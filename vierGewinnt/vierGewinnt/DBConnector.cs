using System;
using System.Collections;
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
            cmd = "SELECT * FROM spieler WHERE name = ";
            cmd += name;
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
                return null;
            }
        }

        public int newPlayer ( String name, int elo )
        {
            //first checkt if there is a player already

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
