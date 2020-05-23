using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataStructures;

namespace AccessToDB
{
    public class Connector
    {
        SqlConnection connection;
        

        /// <summary>
        /// Создает подключение к БД.
        /// По умолчанию вход в БД через текущего пользователя windows
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public Connector(string connectionString = "Server=LAPTOP-HJHG4ROO\\HM;Database=DB_CP;Integrated Security=true;")
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }


        /// <summary>
        /// Выполняет запрос возвращающий список результатов
        /// </summary>
        /// <param name="cmdTxt">Текст команды</param>
        /// <returns>Список результатов(массив значений строк)</returns>
        public List<object[]> ExecuteSelect(string cmdTxt)
        {
            List<object[]> res = new List<object[]>();

            using (var comand = new SqlCommand(cmdTxt, connection))
            {
                var reader = comand.ExecuteReader();
                int nCol = reader.VisibleFieldCount; // количество столбцов
                
                while (reader.Read()) // получаем очередную строку результата
                {
                    object[] tmp = new object[nCol];
                    reader.GetValues(tmp); // считать в tmp значения строк
                    res.Add(tmp);
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
