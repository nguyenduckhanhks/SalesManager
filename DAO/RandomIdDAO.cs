using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class RandomIdDAO
    {
        private static RandomIdDAO instance;
        public static RandomIdDAO Instance
        {
            get { if (instance == null) instance = new RandomIdDAO(); return RandomIdDAO.instance; }
            private set { RandomIdDAO.instance = value; }
        }

        private RandomIdDAO() { }

        public string randomID(string nameTable)
        {
            string s = "";
            do
            {
                s = "";
                System.Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    s = s + (char)random.Next(97, 123);
                }
            }
            while (DataProvider.Instance.ExcuteQuery("select * from dbo."+nameTable+@" where id = '" + s +@"'").Rows.Count > 0);
            
            return s;
        }
    }
}
