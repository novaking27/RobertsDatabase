using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using Dapper;

namespace RobertsDatabase.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }

        public static bool HasUsers()
        {
            using (var db = Database.GetConnection())
            {
                var query = "SELECT COUNT(*) FROM users";
                var results = db.ExecuteScalar(query);
                return (long)results > 0;
            }
        }

        public static string Encrypt(string data)
        {

            const string ENCRYPTION_KEY = "alskdjjkdflasoiwjm";


            string saltedPassword = ENCRYPTION_KEY + data + ENCRYPTION_KEY;

            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(saltedPassword);
            bytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytes);
            string hashed = System.Text.Encoding.ASCII.GetString(bytes);
            return hashed;
        }

        public static void CreateUser(string username, string pass)
        {
            using (var db = Database.GetConnection().OpenAndReturn())
            using (var transaction = db.BeginTransaction())
            {
                try
                {
                    var query = "INSERT INTO users (username, pass, roles) VALUES (@un, @up);";
                    var param = new { un = username, up = Encrypt(pass) };
                    var results = db.Execute(query, param, transaction);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                }
        }

        public static bool login (string username, string pass)
        {
            using (var db = Database.GetConnection())
            {
                var query = "SELECT COUNT (*) FROM users WHERE username = @un AND pass = @up;";
                var param = new { un = username, up = Encrypt(pass) };
                var results = (long)db.ExecuteScalar(query, param);
                return results > 0;
            }
        }


        public static void CheckIfUserLoggedIn()
        {
            try
            {
                string userName = HttpContext.Current.Session["user"].ToString();

            }
            catch
            {
                HttpContext.Current.Response.Redirect("~/Default.aspx");
            }
        }
    }
}