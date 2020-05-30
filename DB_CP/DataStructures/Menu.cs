namespace DataStructures
{
    public class Menu
    {
        public string eateryName { set; get; }
        public string mealName { set; get; }
        public int day { set; get; }
        public int amount { get; set; }
        public string state { get; set; }

        public Menu(string eateryname, string mealname, int day,
            string state = "", int amount = 0)
        {
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
        }
    }
}
