namespace DataStructures
{
    public class User
    {
        public string userID;
        public string login { get; set; }
        public string perms { get; set; }
        public int permission = 2;

        public User(string id, string login, int permission = -1)
        {
            userID = id;
            this.login = login;
            this.permission = permission;
            perms = ((permsEnum)permission).ToString();
        }

        /// <summary>
        /// Создет User из массива данных
        /// </summary>
        /// <param name="data">Массив значений</param>
        public User(object[] data)
        {
            userID = data[0].ToString();
            login = (string)data[1];
            // data[2] по идее password
            if (data[3] != System.DBNull.Value)
                permission = (int)data[3];
            perms = ((permsEnum)permission).ToString();
        }
    }

    enum permsEnum
    {
        admin = 0,
        ruler = 1,
        standard = -1,
        user = 2
    }
}
