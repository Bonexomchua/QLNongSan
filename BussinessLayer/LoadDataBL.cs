using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTransferObject;

namespace BussinessLayer
{

    // ALO ALO mấy hàm trong này đừng làm theo nhe, đợt này làm test chưa có sửa
    public class LoadDataBL
    {

        LoadDataDL loadDataDL = new LoadDataDL();


        //Hàm lấy dữ liệu của cột trong bảng truyền vào
/*        public List<string> GetColumnValues(string tableName, string columnName)
        {
            List<string> values = new List<string>();

            if (MyDataSet.myDTSet.Tables.Contains(tableName))
            {
                DataTable table = MyDataSet.myDTSet.Tables[tableName];

                if (table.Columns.Contains(columnName))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        values.Add(row[columnName].ToString());
                    }
                }
            }
            return values;
        }*/
        public List<Product> LoadProduct()
        {
            //loadDataDL.LoadProduct()
            List<Product> products = loadDataDL.LoadProduct();

                // Có thể áp dụng thêm logic ở đây nếu cần (ví dụ: lọc sản phẩm hết hàng)
                return products;
        }

        public List<User> GetUsers()
        {
            List<User> u = loadDataDL.GetUser();
            return u;
        }

        public List<String> LoadProductName()
        {
            List<Product> products = loadDataDL.LoadProduct();
            List<String> values = new List<String>();
            foreach (Product product in products)
            {
                values.Add(product.tenSP);
            }
            return values;
        }

        public List<string> LoadCategory()
        {
            List<Category> categories = loadDataDL.LoadCategory();
            List<string> values = new List<string>();
            foreach (Category category in categories)
            {
                values.Add(category.TenMuc);
            }
            return values;
        }

        public List<string> LoadDonVi() 
        {

            List<string> values = new List<string>();
            values = loadDataDL.GetDonVi();

            //Gộp các phần tử bằng nhau
            List<string> uniqueValues = values.Distinct().ToList();
            return uniqueValues;

        }


        public List<ImportSource> GetImportSource()
        {
            List<ImportSource> impss = loadDataDL.LoadImportSource();
            return impss;
        }

        public List<String> LoadIPName()
        {
            List<ImportSource> impss = loadDataDL.LoadImportSource();
            List<String> values = new List<string>();
            foreach (ImportSource imps in impss)
            {
                values.Add(imps.HoVaTen);
            }
            return values;
        }

        public List<String> GetPhoneByName(string name)
        {
            List<ImportSource> imp = this.GetImportSource();
            List<String> values = new List<string>();
            foreach( ImportSource imps in imp)
            {
                if (imps.HoVaTen == name)
                    values.Add(imps.SoDienThoai);
            }
            return values;
        }

        public List<String> GetAddressByName(string name)
        {
            List<ImportSource> imp = this.GetImportSource();
            List<String> values = new List<string>();
            foreach (ImportSource imps in imp)
            {
                if (imps.HoVaTen == name)
                    values.Add(imps.DiaChi);
            }
            return values;
        }

        public int GetCateIdByName(String name)
        {
            return loadDataDL.GetCateIdByName(name);
        }

        public int GetUserIdByPhone(String std)
        {
            return loadDataDL.GetUserIdByPhone(std);
        }





    }
}
