using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    public class DBConnection
    {
        public const String _DOMAIN_SERVER = "127.0.0.1";
        public const String _USER_ID = "root";
        public const String _PASSWORD = "1234";
        public const String _DATABASE = "member";

        public static String connectionStr;

        public static MySqlConnection ConDB;

        public DBConnection()
        {
        }

        public static void DBconect()
        {
            connectionStr = "Server=stories2.iptime.org;Uid=daekun1;Pwd=daekun1;Database=project_test;Charset=utf8; ";

            ConDB = new MySqlConnection(connectionStr);
        }
    }
}
