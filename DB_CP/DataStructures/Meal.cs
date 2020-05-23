namespace DataStructures
{
    public class Meal
    {
        int mealID;
        string mealName;
        string mealType = "";
        int kkal = -1;
        int cost = -1;

        public Meal(int id, string name, string type = "", int kkal = -1, int cost = -1)
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
            mealID = (int)data[0];
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
