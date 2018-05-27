using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobertsDatabase.Model
{
    public class DatabaseData
    {
        public long Id { get; set; }
        public string Trade { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string Ref { get; set; }
        public int Rate { get; set; }
        public string UoM { get; set; }



        private static List<DatabaseData> Select(string query, object param = null)
        {
            using (var db = Database.GetConnection())
            {
                return db.Query<DatabaseData>(query, param).ToList();
            }
        }
        public static List<DatabaseData> SelectAll()
        {
            using (var db = Database.GetConnection().OpenAndReturn())
            {
                var order = db.Query<DatabaseData>("SELECT Trade, Class, Description, Project, Ref, Rate, UoM  FROM RL");
                return order.ToList();
            }
        }
 

        public static List<DatabaseData> Filter(string Trade)
        {
            //WHERE(col1 LIKE '%keyword%' OR col2 LIKE '%keyword%' OR col3 LIKE '%keyword%' OR col4 LIKE '%keyword%')
            var query = "SELECT * FROM RL WHERE Trade LIKE '%' || @auth || '%' OR Class LIKE '%' || @auth || '%' OR Description LIKE '%' || @auth || '%' OR Project LIKE '%' || @auth || '%' OR Ref LIKE '%' || @auth || '%' OR Rate LIKE '%' || @auth || '%' OR UoM LIKE '%' || @auth || '%'";
            var param = new { auth = Trade };
            return Select(query, param);
        }

       
    }
}