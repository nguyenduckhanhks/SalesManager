using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class billDAO
    {
        private static billDAO instance;
        
        public static billDAO Instance
        {
            get { if (instance == null) instance = new billDAO(); return billDAO.instance; }
            set { billDAO.instance = value; }
        }

        private billDAO() { }

        public List<Bill> GetBills()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.BILL");

            List<Bill> bills = new List<Bill> { };
            foreach(DataRow item in table.Rows)
            {
                Bill bill = new Bill(item);
                bills.Add(bill);
            }

            return bills;
        }

        public void addData(Bill bill)
        {
            string query = @"insert into dbo.BILL
            (
                id,
                idAcount,
                dateCheckIn,
                moneyBill
            )
            values
            (
                '"+bill.Id+ @"',
                '" + bill.IdAcount + @"',
                '" + bill.TimeCheckIn.Value.ToString("yyyyMMdd") + @"',
                " + bill.MoneyBill.ToString() + @"
            )";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
