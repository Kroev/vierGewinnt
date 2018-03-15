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

            return players;
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
