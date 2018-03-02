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
        public Spieler getPlayer ( int id )
        {
            SqlCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM spieler WHERE spieler_id = ";
            cmd.CommandText += id.ToString();
            cmd.CommandText += ";";

            SqlDataReader reader = cmd.ExecuteReader();

            if ( reader.HasRows )
            {
                reader.Read();
                String name = (String)reader["name"];
                int elo = (int)reader["elo"];
                reader.Close();
                
                Hasht             
            }
            else
            {
                return null;
            }
        }

        public static DBConnector getInstance()
        {
            if ( instance == null )
            {
                instance = new DBConnector();
            }

            return instance;
        }
    }
}
