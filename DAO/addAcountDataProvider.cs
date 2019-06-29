using BanHang0._1.DAO;
using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.SigUpDAO
{
    class addAcountDataProvider
    {
        private static addAcountDataProvider instance;
        public static addAcountDataProvider Instance
        {
            get { if (instance == null) instance = new addAcountDataProvider(); return addAcountDataProvider.instance; }
            private set { addAcountDataProvider.instance = value; }
        }

        private addAcountDataProvider() { }

        public void testAcountData(Acount acount)
        {
            string query = @"INSERT INTO dbo.ACOUNT
                (
                    id,
                    name,
                    dateOfBirt,
                    sex, --1 la nam; 0 la nu.

                    --typeWord gom admin; thu kho; thu quy; nhan vien ban hang.

                    telephone ,
	                email,
	                typeWord ,
	                userName,
	                passwords,
	                pay
                )
                VALUES
                (
                    '"+acount.Id+@"',
                    N'"+acount.Name+@"',
                    '"+acount.DateOfBirt+@"',
                    "+acount.Sex.ToString()+@",
                    '"+acount.Telephone+@"',
                    '"+acount.Email+@"',
                    '"+acount.TypeWord+@"',
                    '"+acount.UserName+@"',
                    '"+acount.PassWord+@"',
                    "+acount.Pay.ToString()+@"
                )";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
