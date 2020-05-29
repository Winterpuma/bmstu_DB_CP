using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDB
{
    public static class DeleteInfo
    {
        public static int DeleteMealChoosen(Connector conn, string userID, string mealID)
        {
            return conn.ExecuteNonQuery(
                "delete from ChoosenMeals " +
                "where userID = '" + userID + "' and mealID = '" + mealID + "'");
        }

        public static int DeleteUserByID(Connector conn, string userID)
        {
            return conn.ExecuteNonQuery(
                "delete from MyUser " +
                "where userID = '" + userID + "'");
        }
    }
}
