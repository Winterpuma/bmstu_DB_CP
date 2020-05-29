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

        public static List<Eatery> GetEateryWhere(Connector conn, string colName, string equalsTo)
        {
            List<Eatery> res = new List<Eatery>();

            var tmp = conn.ExecuteSelect("select * from Eatery where " + colName + " = '" + equalsTo + "'");
            foreach (object[] i in tmp)
            {
                res.Add(new Eatery(i));
            }

            return res;
        }

        public static List<Eatery> GetEateryWhereMealIsAvailable(Connector conn, string mealID)
        {
            List<Eatery> res = new List<Eatery>();

            var tmp = conn.ExecuteSelect(
                "select Eatery.eateryID, eateryName, eateryType, location, description " +
                "from(Eatery join Menu on Menu.EateryID = Eatery.EateryID) " +
                "where mealID = '" + mealID + "' and state = 'В наличии'");
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

        public static List<Meal> GetAllMealsOfEatery(Connector conn, string eateryID)
        {
            List<Meal> res = new List<Meal>();
            
            var tmp = conn.ExecuteSelect("select Meal.mealID, mealName, mealType, kkal, cost " +
                "from(Menu join Meal on Menu.MealID = Meal.mealID) " +
                "where eateryID = '" + eateryID + "'");
            foreach (object[] i in tmp)
            {
                res.Add(new Meal(i));
            }

            return res;
        }

        public static List<Meal> GetAllMealsEateryByDay(Connector conn, string eateryID, string day)
        {
            List<Meal> res = new List<Meal>();

            var tmp = conn.ExecuteSelect("select Meal.mealID, mealName, mealType, kkal, cost " +
                "from(Menu join Meal on Menu.MealID = Meal.mealID) " +
                "where eateryID = '" + eateryID + "' and day = " + day);
            foreach (object[] i in tmp)
            {
                res.Add(new Meal(i));
            }

            return res;
        }

        public static List<Meal> GetChoosenMeals(Connector conn, string userID)
        {
            List<Meal> res = new List<Meal>();

            var tmp = conn.ExecuteSelect("select Meal.mealID, mealName, mealType, kkal, cost " +
                "from(ChoosenMeals join Meal on ChoosenMeals.MealID = Meal.mealID) " +
                "where userID = '" + userID + "'");
            foreach (object[] i in tmp)
            {
                res.Add(new Meal(i));
            }

            return res;
        }

        public static List<User> GetAllUsers(Connector conn)
        {
            List<User> res = new List<User>();

            var tmp = conn.ExecuteSelect("select * from MyUser");
            foreach (object[] i in tmp)
            {
                res.Add(new User(i));
            }

            return res;
        }

        public static User GetUserByLogin(Connector conn, string login, string pass)
        {
            var tmp = conn.ExecuteSelect(
                "select * from MyUser " +
                "where login = '" + login + "' and password = '" + pass + "'");
            if (tmp.Count != 0)
                return new User(tmp[0]);
            else
                return null;
        }


    }
}
