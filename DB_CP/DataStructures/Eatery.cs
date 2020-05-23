namespace DataStructures
{
    public class Eatery
    {
        string eateryID;
        string eateryName;
        string eateryType = "";
        string location = "";
        string description = "";

        public Eatery(string id, string name, string type = "", string loc = "", string descr = "")
        {
            eateryID = id;
            eateryName = name;
            eateryType = type;
            location = loc;
            description = descr;
        }

        /// <summary>
        /// Создет Eatery из массива данных
        /// </summary>
        /// <param name="data">Массив значений</param>
        public Eatery(object[] data)
        {
            eateryID = data[0].ToString();
            eateryName = data[1].ToString().TrimEnd();
            if (data[2] != System.DBNull.Value)
                eateryType = data[2].ToString().TrimEnd();
            if (data[3] != System.DBNull.Value)
               location = data[3].ToString().TrimEnd();
            if (data[4] != System.DBNull.Value)
                description = data[4].ToString().TrimEnd();
        }
    }
}
