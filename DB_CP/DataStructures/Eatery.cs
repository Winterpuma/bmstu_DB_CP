namespace DataStructures
{
    public class Eatery
    {
        int eateryID;
        string eateryName;
        string eateryType = "";
        string location = "";
        string description = "";

        public Eatery(int id, string name, string type = "", string loc = "", string descr = "")
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
            eateryID = (int)data[0];
            eateryName = (string)data[1];
            if (data[2] != System.DBNull.Value)
                eateryType = (string)data[2];
            if (data[3] != System.DBNull.Value)
               location = (string)data[3];
            if (data[4] != System.DBNull.Value)
                description = (string)data[4];
        }
    }
}
