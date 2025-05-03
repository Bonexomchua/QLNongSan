using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
   public class ProductDL:DataProvider
    {
        public void addProduct(Product prod)
        {
            this.Connection();
            string query = "INSERT INTO Products (TenSanPham, CategoryId, SoLuongCon, GiaBan, DonVi, HinhAnh) VALUES (@TenSanPham, @CategoryId, @SoLuongCon, @GiaBan, @DonVi, @HinhAnh)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = this.GetConn();
            cmd.Parameters.AddWithValue("@TenSanPham", prod.tenSP);
            cmd.Parameters.AddWithValue("@CategoryId", prod.loaiSP);
            cmd.Parameters.AddWithValue("@SoLuongCon", prod.soLuongCon);
            cmd.Parameters.AddWithValue("@GiaBan", prod.giaBan);
            cmd.Parameters.AddWithValue("@DonVi", prod.donVi);
            cmd.Parameters.AddWithValue("@HinhAnh", prod.imageBytes);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetAllProduct()
        {
            this.Connection();
            List<Product> products = new List<Product>();
            String sql = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = this.GetConn();
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product p = new Product(dr["TenSanPham"].ToString(),
                        Convert.ToInt32(dr["CategoryId"]),
                        Convert.ToSingle(dr["SoLuongCon"]),
                        Convert.ToDecimal(dr["GiaBan"]),
                        dr["DonVi"].ToString(),
                        (byte[])dr["HinhAnh"]);
                products.Add(p);
            }
            return products;

        }

        public int GetProductIdByName(String name)
        {
            this.Connection();
            String sql = $"SELECT Id FROM Products WHERE TenSanPham LIKE '%{name}%'";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            int value = (int)cmd.ExecuteScalar();
            this.CloseConn();
            return value;

        }

        public void DeleteProductByName(String name)
        {
            this.Connection();
            String sql = $"DELETE FROM Products WHERE TenSanPham LIKE '{name}'";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection=this.GetConn();
            cmd.ExecuteNonQuery();
        }

        public Product GetProductByName(String name)
        {
            this.Connection();
            String sql = $"SELECT * FROM Products WHERE TenSanPham LIKE '%{name}%'";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = this.GetConn();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Product d = new Product(
                    dr["TenSanPham"].ToString(),
                    Convert.ToInt32(dr["CategoryId"]),
                    Convert.ToSingle(dr["SoLuongCon"]),
                    Convert.ToDecimal(dr["GiaBan"]),
                    dr["DonVi"].ToString()
                );
                dr.Close();
                return d;
            }
            dr.Close();
            this.CloseConn();
            return null;
        }

        public void UpdateProductById(int id, Product prod)
        {
            Connection();
            string sql = "UPDATE Products SET TenSanPham = @TenSanPham, CategoryId = @CateId, SoLuongCon = @SoLuongCon, GiaBan = @GiaBan, DonVi = @DonVi  WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            cmd.Parameters.AddWithValue("@TenSanPham", prod.tenSP);
            cmd.Parameters.AddWithValue("@CateId", 2);
            cmd.Parameters.AddWithValue("@SoLuongCon", prod.soLuongCon);
            cmd.Parameters.AddWithValue("@GiaBan", prod.giaBan);
            cmd.Parameters.AddWithValue("@DonVi", prod.donVi);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public int GetMaxIdByName(string name)
        {
            String sql = $"SELECT MAX(Id) FROM Products WHERE TenSanPham = '{name}'";
            Connection();
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            int value = (int)cmd.ExecuteScalar();
            return value;
        }

        public List<Product> GetProductByKW(String kw)
        {
            List<Product> products = new List<Product> ();
            this.Connection();
            String sql = $"SELECT * FROM Products WHERE TenSanPham LIKE '%{kw}%'";
            SqlCommand cmd  = new SqlCommand(sql , this.GetConn());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product p = new Product(dr["TenSanPham"].ToString(),
                        Convert.ToInt32(dr["CategoryId"]),
                        Convert.ToSingle(dr["SoLuongCon"]),
                        Convert.ToDecimal(dr["GiaBan"]),
                        dr["DonVi"].ToString(),
                        (byte[])dr["HinhAnh"]);
                products.Add(p);
            }
            return products;
        }

        public void UpdateAmount(float newSL, int id)
        {
            this.Connection();
            String sql = "UPDATE Products SET SoLuongCon = SoLuongCon - @newSL WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            cmd.Parameters.AddWithValue("@newSL", newSL);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            this.CloseConn();
        }

        public void AddAdmout(float newSL, int id)
        {
            this.Connection();
            String sql = "UPDATE Products SET SoLuongCon = SoLuongCon + @newSL WHERE Id = @id";
            SqlCommand cmd = new SqlCommand (sql, this.GetConn());
            cmd.Parameters.AddWithValue("@newSL", newSL);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            this.CloseConn();
        }

        public string GetProductNameById(int id) 
        {
            Connection();
            string sql = $"SELECT TenSanPham FROM Products WHERE Id = {id}";
            SqlCommand cmd = new SqlCommand(sql, GetConn());
            return cmd.ExecuteScalar().ToString();
        }

    }
}
