using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccessToDB
{
    public class Connector
    {
        SqlConnection connection;
        
        /// <summary>
        /// Создаем подключение к БД.
        /// По умолчанию вход в БД через текущего пользователя windows
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public Connector(string connectionString = "Server=LAPTOP-HJHG4ROO\\HM;Database=DB_CW;Integrated Security=true;")
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// Выполняет запрос возвращающий одно текстовое значение и возвращает результат 
        /// </summary>
        /// <param name="cmdTxt">Текст команды</param>
        /// <returns>Результат выполнения запроса</returns>
        public List<string> Execute(string cmdTxt)
        {
            List<string> res = new List<string>();

            using (var comand = new SqlCommand(cmdTxt, connection))
            {
                var reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    res.Add(reader.GetString(0).ToString());
                }
            }
            return res;
        }

        /// <summary>
        /// Закрывает соединение
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }

        /// <summary>
        /// При удалении коннектора закрывается соединение
        /// </summary>
        ~Connector()
        {
            connection.Close();
        }

    }
}
