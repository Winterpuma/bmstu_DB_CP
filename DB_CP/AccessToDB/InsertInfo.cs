using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDB
{
    public static class InsertInfo
    {
        public static int InsertUser(Connector conn, string login, string password, string permission = "NULL")
        {
            return conn.ExecuteNonQuery(
                "insert into MyUser " +
                "(userID, login, password, permission) " +
                "values (NEWID(), '" + login + "', '" + password + "'," + permission + ")");
        }


        public static int InsertMeal(Connector conn, string name, string type = "NULL", string kkal = "NULL", string cost = "NULL")
        {
            return conn.ExecuteNonQuery(
                "insert into Meal" +
                "(mealID, mealName, mealType, kkal, cost) " +
                "values(NEWID(), '" + name + "', '" + type + "', " + kkal + ", " + cost + ")");
        }
        

        public static int InsertMenu(Connector conn, string eateryID, string mealID, string day = "NULL", string amount = "NULL")
        {
            return conn.ExecuteNonQuery(
                "insert into Menu " +
                "(eateryID, mealID, day, amount, state) " +
                "values('" + eateryID + "', '" + mealID + "', " + day + ", " + amount + "'Нет в наличии')");
        }


        public static int InsertMealChoosen(Connector conn, string userID, string mealID)
        {
            return conn.ExecuteNonQuery(
                "insert into ChoosenMeals " +
                "(userID, mealID) " +
                "values('" + userID + "', '" + mealID + "')");
        }
    }
}
