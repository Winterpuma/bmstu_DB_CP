namespace DataStructures
{
    public class Meal
    {
        public string mealID;
        public string mealName { set; get; }
        public string mealType { get; set; }
        public int kkal { get; set; }
        public int cost { get; set; }

        public Meal(string id, string name, string type = "", int kkal = -1, int cost = -1)
        {
            mealID = id;
            mealName = name;
            mealType = type;
            this.kkal = kkal;
            this.cost = cost;
        }

        /// <summary>
        /// Создет Meal из массива данных
        /// </summary>
        /// <param name="data">Массив значений</param>
        public Meal(object[] data)
        {
            mealID = data[0].ToString();
            mealName = (string)data[1];
            if (data[2] != System.DBNull.Value)
                mealType = (string)data[2];
            if (data[3] != System.DBNull.Value)
                kkal = (int)data[3];
            if (data[4] != System.DBNull.Value)
                cost = (int)data[4];
        }
    }
}
