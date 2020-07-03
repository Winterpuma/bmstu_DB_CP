namespace DataStructures
{
    public class Menu
    {
        public string eateryName { set; get; }
        public string eateryID;
        public string mealName { set; get; }
        public string mealID;
        public int day { set; get; }
        public int amount { get; set; }
        public string state { get; set; }

        public Menu(string eateryID, string mealID, string eateryname, string mealname, int day,
            string state = "", int amount = 0)
        {
            this.eateryID = eateryID;
            this.mealID = mealID;
            mealName = mealname;
            eateryName = eateryname;
            this.day = day;
            this.amount = amount;
            this.state = state;
        }

        /// <summary>
        /// Создет Menu из массива данных
        /// </summary>
        /// <param name="data">Массив значений</param>
        public Menu(object[] data)
        {
            mealName = data[0].ToString();
            eateryName = data[1].ToString();
            if (data[2] != System.DBNull.Value)
                day = (int)data[2];
            if (data[3] != System.DBNull.Value)
                amount = (int)data[3];
            if (data[4] != System.DBNull.Value)
                state = data[4].ToString();
            eateryID = data[5].ToString();
            mealID = data[6].ToString();
        }
    }
}
