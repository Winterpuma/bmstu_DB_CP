using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using AccessToDB;

namespace DB_CP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var m = new Connector();

            //var test1 = GetInfo.GetAllEatery(m);
            //var test2 = GetInfo.GetEateryWhere(m, "location", "ULK");

            //var test3 = InsertInfo.InsertUser(m, "test3", "12345");
            //var test4 = GetInfo.GetAllUsers(m);

            //var test5 = InsertInfo.InsertMeal(m, "РусскиеВперед", "studio", "123", "300");
            //var test6 = InsertInfo.InsertMealChoosen(m, "2DAC6B57-37B3-4341-B06A-90D1460DE38D", "CDD6E1D8-FE31-4C87-9446-578E637EABEF");

            //var test7 = DeleteInfo.DeleteMealChoosen(m, "2DAC6B57-37B3-4341-B06A-90D1460DE38D", "CDD6E1D8-FE31-4C87-9446-578E637EABEF");
            //var test8 = DeleteInfo.DeleteUserByID(m, "FAA21E51-2750-40F6-954F-BD36E81D82AB");
            m.CloseConnection();

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }

        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
