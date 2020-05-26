using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDB
{
    public static class CheckInfo
    {
        /// <summary>
        /// Проверяет занят ли такой login
        /// </summary>
        /// <param name="conn">Подключение к БД</param>
        /// <param name="login">Логин</param>
        /// <returns>true если занят, false - свободен</returns>
        public static bool IsLoginTaken(Connector conn, string login)
        {
            var tmp = conn.ExecuteSelect(
                "select * from MyUser " +
                "where login = '" + login + "'");

            return tmp.Count == 0 ? false : true;
        }
    }
}
