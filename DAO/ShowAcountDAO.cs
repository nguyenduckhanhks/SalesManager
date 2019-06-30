using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class ShowAcountDAO
    {
        private static ShowAcountDAO instance;
        public static ShowAcountDAO Instance
        {
            get { if (instance == null) instance = new ShowAcountDAO(); return ShowAcountDAO.instance; }
            private set { ShowAcountDAO.instance = value; }
        }

        private ShowAcountDAO() { }

        public DataTable GetAcountTable(string NameAcount)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.ACOUNT where typeWord = '"+NameAcount+@"'");
            return table;
        }
    }
}
