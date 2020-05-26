using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDB
{
    public static class InsertInfo
    {
        public static int InsertUser(Connector conn, string login, string password)
        {
            return conn.ExecuteNonQuery("insert into MyUser " +
                "(userID, login, password)" +
                "values (NEWID(), '" + login + "', '" + password + "')");
        }

        public static int InsertUser(Connector conn, string login, string password, int permission)
        {
            return conn.ExecuteNonQuery("insert into MyUser " +
                "(userID, login, password, permission)" +
                "values (NEWID(), '" + login + "', '" + password + "'," + permission.ToString() + ")");
        }
    }
}
