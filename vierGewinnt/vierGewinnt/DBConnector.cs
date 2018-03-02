using System;
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
            this.url = "den1.mysql5.gear.host";
            this.database = "VierGewinnt";
            this.user = "viergewinnt";
            this.password = "ifs12bAdmin!";

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

        public DBConnector getInstance()
        {
            if ( instance == null )
            {
                instance = new DBConnector();
            }

            return instance;
        }
    }
}
