namespace DataStructures
{
    class Meal
    {
        int mealID;
        string mealName;
        string mealType;
        int kkal;
        int cost;

        public Meal(int id, string name, string type = "", int kkal = -1, int cost = -1)
        {
            mealID = id;
            mealName = name;
            mealType = type;
            this.kkal = kkal;
            this.cost = cost;
        }
    }
}
