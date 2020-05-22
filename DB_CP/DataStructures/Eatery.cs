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
    }
}
