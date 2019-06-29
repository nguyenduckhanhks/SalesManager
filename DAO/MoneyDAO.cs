using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang0._1.DAO
{
    class MoneyDAO
    {
        private static MoneyDAO instance;
        public static MoneyDAO Instance
        {
            get { if (instance == null) instance = new MoneyDAO(); return MoneyDAO.instance; }
            private set { MoneyDAO.instance = value; }
        }
        private MoneyDAO() { }

        public void Add(Money mn)
        {
            string query = @"insert into dbo.MONEYS
            (
                total,
                id,
                note,
                dates
            )
            values
            (
                "+mn.Total.ToString()+@",
                '"+mn.Id+@"',
                '"+mn.Note+@"',
                "+mn.Dates.Value.ToString("yyyyMMdd")+@"
            )";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public void updateMoneyAdd(float money, string note)
        {
            Money mn = new Money(note);
            mn.Total = mn.Total + money;
            Add(mn);
        }

        public void updateMoneyMinues(float money, string note)
        {
            Money mn = new Money(note);
            if (mn.Total > money)
            {
                mn.Total = mn.Total - money;
                Add(mn);
            }
            else MessageBox.Show("Không đủ tiền trong kho để giao dịch");
        }
    }
}
