using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class ItemDAO
    {
        private static ItemDAO instance;
        public static ItemDAO Instance
        {
            get { if (instance == null) instance = new ItemDAO(); return ItemDAO.instance; }
            private set { ItemDAO.instance = value; }
        }

        private ItemDAO() { }

        public void updateItem(BillInfor billInfor)
        {
            int oldItems = int.Parse(DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where id = '" + billInfor.IdItem + @"'").Rows[0]["countItem"].ToString());
            string query = "update dbo.ITEM set countItem = " + (oldItems - billInfor.CountItems).ToString() + @"where id = '" + billInfor.IdItem + @"'";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public void updateAddItem(Item item)
        {
            int oldItems = int.Parse(DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where id = '" + item.Id + @"'").Rows[0]["countItem"].ToString());
            string query = "update dbo.ITEM set countItem = " + (oldItems + item.CountItem).ToString() + @"where id = '" + item.Id + @"'";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public List<Item> getListItem()
        {
            List<Item> items = new List<Item>();
            string query = "select * from dbo.ITEM";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in table.Rows)
            {
                Item it = new Item(item);
                items.Add(it);
            }
            return items;
        }

        public void AddNewItem(Item it)
        {
            string query = @"insert into dbo.ITEM
            (
	            id,
	            name,
	            price,
	            countItem,
                note,
	            idAcount,
	            idCatalogy
            )
            values
            (
	            '"+it.Id+@"',
	            '"+it.Name+@"',
	            "+it.Price.ToString()+@",
	            "+it.CountItem.ToString()+@",
                '"+it.Note+@"',
	            '"+it.IdAcount+@"',
	            '"+it.IdCatalogy+@"'
            )";

            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
