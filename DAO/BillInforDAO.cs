using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance; }
            private set { BillInforDAO.instance = value; }
        }

        private BillInforDAO() { } 

        public List<BillInfor> getListBillInfor(string idBill)
        {
            List<BillInfor> billInfors = new List<BillInfor>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.BILLINFOR where idBill = '"+idBill+@"'");
            foreach(DataRow item in table.Rows)
            {
                BillInfor bi = new BillInfor(item);
                billInfors.Add(bi);
            }
            return billInfors;
        }


        public void AddData(BillInfor billInfor)
        {
            string query = @"insert into dbo.BILLINFOR
            (
                id,
                idItem,
                idBill,
                countItems
            )
            values
            (
                '" + billInfor.Id + @"',
                '" + billInfor.IdItem + @"',
                '" + billInfor.IdBill + @"',
                " + billInfor.CountItems.ToString() + @"
            )";

            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
