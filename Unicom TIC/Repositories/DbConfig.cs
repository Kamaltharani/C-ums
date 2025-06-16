using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Repositories
{
    internal static class DbConfig
    {
        private static string Connectionstring = "Data Sourse =unicomticDB.db; Version = 3;";
        public static SQLiteConnection GetConnection() 
        {
            var conn = new SQLiteConnection(Connectionstring);
            conn.Open();
            return conn;
        }
    }
}
