using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Xml.Linq;


namespace DataLayer
{
    // ALO ALO mấy hàm trong này đừng làm theo nhe, đợt này làm test chưa có sửa
    public class LoadDataDL: DataProvider
    {
        public List<Product> LoadProduct()
        {
            List<Product> products = new List<Product>();
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = "SELECT * FROM Products";
            try
            {
                //FillToDataSet(sql,"Products");
                SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(
                        reader["TenSanPham"].ToString(),
                        Convert.ToInt32(reader["CategoryId"]),
                        Convert.ToInt32(reader["SoLuongCon"]),
                        Convert.ToDecimal(reader["GiaBan"]),
                        reader["DonVi"].ToString()
                    ));
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return products;
        }

        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = "SELECT * FROM Users";
            try
            {
                //FillToDataSet(sql,"Products");
                SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User(
                        reader["HoVaTen"].ToString(),
                        reader["SoDienThoai"].ToString(),
                        reader["ViTri"].ToString(),
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        Convert.ToDateTime(reader["NgaySinh"])
                    ));
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return users;
        }

        public List<ImportSource> LoadImportSource()
        {
            List<ImportSource> values = new List<ImportSource>();
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = "SELECT * FROM ImportSources";
            try
            {
                //FillToDataSet(sql,"Products");
                SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(new ImportSource(
                        reader["HoVaTen"].ToString(),
                        reader["TenCongTy"].ToString(),
                        reader["DiaChi"].ToString(),
                        reader["SoDienThoai"].ToString(),
                        Convert.ToInt32(reader["ProductId"])
                    ));
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return values;
        }

        public List<Category> LoadCategory()
        {
            List<Category> products = new List<Category>();
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = "SELECT * FROM Categories";
            try
            {
                //FillToDataSet(sql,"Products");
                SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Category(
                            Convert.ToInt32(reader["id"]),
                            reader["TenMuc"].ToString()
                    ));
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return products;
        }

        public List<String> GetDonVi()
        {
            List<String> values = new List<String>();
            DataProvider dp = new DataProvider();
            dp.Connection();
            List<Product> products = this.LoadProduct();
            foreach (Product product in products)
            {
                values.Add(product.donVi);
            }
            return values;
        }

        public int GetCateIdByName(string name)
        {
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = $"SELECT Id FROM Categories WHERE TenMuc LIKE '{name}'";
            SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            return value;
        }

        public int GetUserIdByPhone(string sdt)
        {
            DataProvider dp = new DataProvider();
            dp.Connection();
            string sql = $"SELECT Id FROM Users WHERE SoDienThoai LIKE '{sdt}'";
            SqlCommand cmd = new SqlCommand(sql, dp.GetConn());
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            return value;
        }
    }
}
