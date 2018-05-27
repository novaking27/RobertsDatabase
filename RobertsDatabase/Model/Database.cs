using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using Dapper;

namespace RobertsDatabase.Model
{
    public static class Database
    {
        const string DB_FILE = "roberts.db";
        const string CREATE_SCRIPT = "create.sql";

        static string MAPPED_DATA;
        static string CONNECTION_STRING;

        static Database()
        {
            MAPPED_DATA = HttpContext.Current.Server.MapPath("~/App_Data/");
            CONNECTION_STRING = $"Data Source={MAPPED_DATA + DB_FILE}";
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(CONNECTION_STRING);
        }

        public static void CreateDatabase()
        {
            using (var db = GetConnection())
            {
                var query = System.IO.File.ReadAllText(MAPPED_DATA + CREATE_SCRIPT);
                var results = db.Execute(query);
            }
        }
    }
}