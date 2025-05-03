using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BillDL:DataProvider
    {
        public List<Bill> GetAllBill()
        {
            Connection();
            List<Bill> list = new List<Bill>();
            List<int> intlist = new List<int>();
            String sql = "SELECT * FROM Bills";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Bill(Convert.ToInt32(dr["Id"]),
                                  Convert.ToInt32(dr["LoaiHoaDon"]),
                                  Convert.ToDecimal(dr["TongTien"]),
                                  Convert.ToDateTime(dr["NgayThanhToan"]),
                                  Convert.ToInt32(dr["CustomerId"]),
                                  Convert.ToInt32(dr["UserId"]),
                                  intlist
                    ));
            }
            return list;
        }

        public void AddBillSell(Bill bill)
        {
            Connection();
            String sql = "INSERT INTO Bills (CustomerId, UserId, LoaiHoaDon, TongTien, NgayThanhToan, ImportId) VALUES (@CustomerId, @UserId, @loaiHoaDon, @TongTien, @NgayThanhToan, @ImportId)";
            SqlCommand cmd = new SqlCommand(sql, GetConn());
            cmd.Parameters.AddWithValue("@CustomerId", bill.customerId);
            cmd.Parameters.AddWithValue("@UserId", bill.userId);
            cmd.Parameters.AddWithValue("LoaiHoaDon", 1);
            cmd.Parameters.AddWithValue("TongTien", bill.tongTien);
            cmd.Parameters.AddWithValue("@NgayThanhToan", bill.ngayThanhToan);
            cmd.Parameters.AddWithValue("@ImportId", 10);
            cmd.ExecuteNonQuery();
            this.CloseConn();
        }

        public int GetLastBillId()
        {
            Connection();
            String sql = "SELECT MAX(Id) FROM Bills";
            return Convert.ToInt32(MyExecuteScalar(sql, System.Data.CommandType.Text));

        }

        public void AddBillSellDetail(Bill bill, Product prod, float soLuong)
        {
            ProductDL productDL = new ProductDL();
            Connection();
            String sql = "INSERT INTO BillDetails (BillId, ProductId, SoLuong) VALUES (@BillId, @ProductId, @SoLuong)";
            SqlCommand cmd = new SqlCommand(sql, GetConn());
            cmd.Parameters.AddWithValue("@BillId", this.GetLastBillId());
            cmd.Parameters.AddWithValue("@ProductId", productDL.GetProductIdByName(prod.tenSP));
            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
            cmd.ExecuteNonQuery();
            this.CloseConn( );
        }

        public DataTable GetBillDetail(int id)
        {
            Connection();
            String sql = $"SELECT * FROM BillDetails WHERE BillId = {id}";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, GetConn());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
