using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDB
{
    public static class UpdateInfo
    {
        public static int UpdateMenu(Connector conn, string eateryID, string mealID, 
            string newState = "Нет в наличии", string newAmount = "0")
        {
            return conn.ExecuteNonQuery(
                "update Menu " +
                "set state = '" + newState + "', amount = " + newAmount + " " +
                "where eateryID = '" + eateryID + "' and mealID = '" + mealID + "'");
        }

        public static int UpdateMenuSpecifyDay(Connector conn, string eateryID, string mealID,
            string day, string newState = "Нет в наличии", string newAmount = "0")
        {
            return conn.ExecuteNonQuery(
                "update Menu " +
                "set state = '" + newState + "', amount = " + newAmount + " " +
                "where eateryID = '" + eateryID + "' and mealID = '" + mealID + "' and day = " + day);
        }

        public static int UpdateUserPermissions(Connector conn, string userID, string newPermissions)
        {
            return conn.ExecuteNonQuery(
                "update MyUser " +
                "set permission = " + newPermissions + " " +
                "where userID = '" + userID + "'");
        }
    }
}
