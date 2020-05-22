namespace DataStructures
{
    class User
    {
        int userID;
        string login;
        int permission;

        public User(int id, string login, int permission = 0)
        {
            userID = id;
            this.login = login;
            this.permission = permission;
        }
    }
}
