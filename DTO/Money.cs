using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class Money
    {
        private float total;

        public float Total { get => total; set => total = value; }
        public string Id { get => id; set => id = value; }
        public string Note { get => note; set => note = value; }
        public DateTime? Dates { get => dates; set => dates = value; }

        private string id;

        private string note;

        private DateTime? dates;

        public Money(string note)
        {
            this.id = RandomIdDAO.Instance.randomID("MONEYS");
            this.dates = DateTime.Now;
            this.note = note;
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.MONEYS");
            this.total = float.Parse(table.Rows[table.Rows.Count - 1]["total"].ToString());
        }
    }
}
