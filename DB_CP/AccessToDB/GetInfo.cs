using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace AccessToDB
{
    public static class GetInfo
    {
        public static List<Eatery> GetAllEatery(Connector conn)
        {
            List<Eatery> res = new List<Eatery>();

            var tmp = conn.ExecuteSelect("select * from Eatery");
            foreach (object[] i in tmp)
            {
                res.Add(new Eatery(i));
            }

            return res;
        }

        public static List<Meal> GetAllMeals(Connector conn)
        {
            List<Meal> res = new List<Meal>();

            var tmp = conn.ExecuteSelect("select * from Meal");
            foreach (object[] i in tmp)
            {
                res.Add(new Meal(i));
            }

            return res;
        }

        public static List<User> GetAllUsers(Connector conn)
        {
            List<User> res = new List<User>();

            var tmp = conn.ExecuteSelect("select * from User");
            foreach (object[] i in tmp)
            {
                res.Add(new User(i));
            }

            return res;
        }

    }
}
