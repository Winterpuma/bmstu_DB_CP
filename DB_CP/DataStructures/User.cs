namespace DataStructures
{
    class User
    {
        int userID;
        string login;
        int permission = -1;

        public User(int id, string login, int permission = -1)
        {
            userID = id;
            this.login = login;
            this.permission = permission;
        }

        /// <summary>
        /// Создет User из массива данных
        /// </summary>
        /// <param name="data">Массив значений</param>
        public User(object[] data)
        {
            userID = (int)data[0];
            login = (string)data[1];
            if (data[2] != System.DBNull.Value)
                permission = (int)data[2];
        }
    }
}
