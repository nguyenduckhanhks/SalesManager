using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class CatalogyDAO
    {
        private static CatalogyDAO instance;
        public static CatalogyDAO Instance
        {
            get { if (instance == null) instance = new CatalogyDAO(); return CatalogyDAO.instance; }
            private set { CatalogyDAO.instance = value; }
        }

        public void AddCatalogy(Catalogy catalogy)
        {
            string query = @"insert into dbo.ITEMCATALOGY
            (
                id,
                name
            )
            values
            (
                '"+catalogy.Id+@"',
                '"+catalogy.Name+@"'
            )";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
