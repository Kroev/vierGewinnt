using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace vierGewinnt
{
    class DBConnector
    {
        private static DBConnector instance;
        private string url;
        private string database;
        private string user;
        private string password;
        private SqlConnection conn;

        private DBConnector()
        {
            this.url = "den1.mssql4.gear.host";
            this.database = "viergewinnt";
            this.user = "viergewinnt";
            this.password = "Bernd-Bernd";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = this.url;
            builder["integrated Security"] = "false";
            builder["database"] = this.database;
            builder["user id"] = this.user;
            builder["password"] = this.password;

            this.conn = new SqlConnection();
            this.conn.ConnectionString = builder.ConnectionString;
            this.conn.Open();

        }

        /**
         * <returns>
         * hashtable with data of the player if found, null if none found
         * </returns>
         * */
        public Hashtable getPlayer ( int id )
        {
            String cmd;
            cmd = "SELECT * FROM spieler WHERE spieler_id = ";
            cmd += id.ToString();
            cmd += ";";

            SqlDataReader reader = this.request(cmd);

            if ( reader.HasRows )
            {
                reader.Read();
                String name = (String)reader["name"];
                int elo = (int)reader["elo"];
                reader.Close();

                Hashtable spieler = new Hashtable();
                spieler["name"] = name;
                spieler["elo"] = elo;
                return spieler;
            }
            else
            {
                return null;
            }
        }

        public Hashtable getPlayer( String name )
        {
            String cmd;
            cmd = "SELECT * FROM spieler WHERE name = '";
            cmd += name;
            cmd += "'";
            cmd += ";";

            SqlDataReader reader = this.request(cmd);

            if ( reader.HasRows )
            {
                reader.Read();
                Hashtable player = new Hashtable();
                player["name"] = (String)reader["name"];
                player["elo"] = (int)reader["elo"];
                reader.Close();

                return player;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        /**
         * <returns>
         *  null if no players found
         *  otherwise list containing hashtables representing player data
         * </returns>
         * */
        public List<Hashtable> getAllPlayers ()
        {
            String cmd = "SELECT * FROM spieler;";
            SqlDataReader reader = this.request(cmd);

            if ( !reader.HasRows )
            {
                //no players found
                reader.Close();
                return null;
            }

            //there are players
            List<Hashtable> players = new List<Hashtable>();
            Hashtable player = new Hashtable();
            while ( reader.Read() )
            {
                player["name"] = (String)reader["name"];
                player["elo"] = (int)reader["elo"];
                players.Add( (Hashtable)player.Clone() );
            }

            reader.Close();
            return players;
        }

        /**
         *  <returns>
         *   0: everything went well
         *   -1: spieler1 not found
         *   -2: spieler2 not found
         *   -3: insert did not work
         *  </returns>
         * */
         public int recordGame( String spieler1, String spieler2, int ergebnis )
        {
            String baseCmd = "SELECT spieler_id FROM spieler WHERE name = '";

            String cmd = baseCmd;
            cmd += spieler1;
            cmd += "';";
            SqlDataReader reader = this.request(cmd);
            if ( !reader.HasRows )
            {
                return -1;
            }
            reader.Read();
            long id1 = (long)reader["spieler_id"];
            reader.Close();

            //get id of player2
            cmd = baseCmd;
            cmd += spieler2;
            cmd += "';";
            reader = this.request(cmd);
            if ( !reader.HasRows )
            {
                return -2;
            }
            reader.Read();
            long id2 = (long)reader["spieler_id"];
            reader.Close();

            //insert new game record
            cmd = "INSERT INTO spiele VALUES (";
            cmd += id1.ToString();
            cmd += ",";
            cmd += id2.ToString();
            cmd += ",'";
            cmd += ergebnis.ToString();
            cmd += "');";

            try
            {
                reader = this.request(cmd);
            }
            catch
            {
                reader.Close();
                return -3;
            }

            reader.Close();
            return 0;
        }

        /**
         * <returns>
         *  list of hashtables containing all records
         *  null if no records available
         * </returns>
         * */
        public List<Hashtable> getGameRecords()
        {
            String cmd = "SELECT * FROM spiele;";
            SqlDataReader reader = this.request(cmd);

            if ( !reader.HasRows )
            {
                reader.Close();
                return null;
            }

            List<Hashtable> records = new List<Hashtable>();
            Hashtable record = new Hashtable();
            while (reader.Read() )
            {
                record["spieler1"] = (string)reader["spieler1"];
                record["spieler2"] = (string)reader["spieler2"];
                record["ergebnis"] = (string)reader["ergebnis"];
                records.Add( (Hashtable)record.Clone() );
            }
            reader.Close();
            return records;
        }

        /**
         * <returns>
         *  0: created new player
         *  1: player already exists
         * </returns>
         * */
        public int newPlayer ( String name, int elo )
        {
            //first checkt if there is a player already
            Hashtable spieler = this.getPlayer(name);
            if ( spieler != null )
            {
                //found player, not unique
                return 1;
            }

            //create new player
            String cmd;
            cmd = "";
            cmd = "INSERT INTO spieler VALUES ('";
            cmd += name;
            cmd += "',";
            cmd += elo.ToString();
            cmd += ");";

            SqlDataReader reader = this.request(cmd);
            reader.Close();
            
            //assume everything went well...
            return 0;
        }

        /**
         * <returns>
         *  nothing
         * </returns>
         * */
        public void updatePlayerElo ( String name, int newElo )
        {
            String cmd = "UPDATE spieler SET elo = ";
            cmd += newElo.ToString();
            cmd += " WHERE name = '";
            cmd += name;
            cmd += "';";

            SqlDataReader reader = this.request(cmd);
            reader.Close();

            return;
        }

        public static DBConnector getInstance()
        {
            if ( instance == null )
            {
                instance = new DBConnector();
            }

            return instance;
        }

        private SqlDataReader request(String command)
        {
            SqlCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = command;

            return cmd.ExecuteReader();
        }
    }
}
