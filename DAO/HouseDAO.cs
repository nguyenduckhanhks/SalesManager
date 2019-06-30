using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class HouseDAO
    {
        private static HouseDAO instance;
        public static HouseDAO Instance
        {
            get { if (instance == null) instance = new HouseDAO(); return HouseDAO.instance; }
            private set { HouseDAO.instance = value; }
        }

        private HouseDAO() { }

        public List<House> GetListItemInHouse()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.HOUSE");
            List<House> houses = new List<House>();
            foreach(DataRow item in table.Rows)
            {
                House house = new House(item);
                houses.Add(house);
            }
            return houses;
        }

        public void AddData(House house)
        {
            string query = @"insert into dbo.HOUSE
            (
	            id,
	            idItem,
	            name,
	            price,
	            countItem,
	            note,
	            idCatalogy,
	            dateAddItem
            )
            values
            (
	            '"+house.Id+@"',
	            '"+house.IdItem+@"',
	            '"+house.Name+@"',
	            "+house.Price.ToString()+@",
	            "+house.CountItem.ToString()+@",
	            '"+house.Note+@"',
	            '"+house.IdCatalogy+@"',
	            '"+house.DateAddItem+@"'
            )";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
