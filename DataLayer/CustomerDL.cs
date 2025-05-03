using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerDL:DataProvider
    {
        public Customer GetCustomerById(int id)
        {
            Customer cus;
            Connection();
            String sql = $"Select * FROM Customers WHERE Id LIKE {id}";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cus = new Customer(Convert.ToInt32(dr["Id"]),
                                   dr["HoVaTen"].ToString(),
                                   dr["DiaChi"].ToString(),
                                   dr["SoDienThoai"].ToString());
                return cus;
            }
            else
            {
                return null;
            }
        }

        public void AddCustomer(Customer cus)
        {
            Connection();
            String sql = "INSERT INTO Customers(HoVaTen, SoDienThoai, DiaChi) VALUES (@HoVaTen, @SoDienThoai, @DiaChi)";
            SqlCommand cmd = new SqlCommand(@sql, this.GetConn());
            cmd.Parameters.AddWithValue("@HoVaTen", cus.Name);
            cmd.Parameters.AddWithValue("@SoDienThoai", cus.Phone);
            cmd.Parameters.AddWithValue("@DiaChi", cus.Address);
            cmd.ExecuteNonQuery();
        }

        public int CheckCustomerByPhone(string phone)
        {
            Connection();
            string sql = $"SELECT Id FROM Customers WHERE SoDienThoai = '{phone}'";
            SqlCommand cmd = new SqlCommand(sql , this.GetConn());
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int GetMaxId()
        {
            Connection();
            string sql = "SELECT MAX(Id) FROM Customers";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
