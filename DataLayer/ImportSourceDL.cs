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
    public class ImportSourceDL:DataProvider
    {
        public List<ImportSource> GetAllImportSource()
        {
            this.Connection();
            List<ImportSource> list = new List<ImportSource>();
            String sql = "SELECT * FROM ImportSources";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = this.GetConn();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["TenCongTy"]  == DBNull.Value)
                {
                    ImportSource ip = new ImportSource(
                                                       dr["HoVaTen"].ToString(),
                                                       dr["DiaChi"].ToString(),
                                                       dr["SoDienThoai"].ToString());
                    list.Add(ip);
                } else
                {
                    ImportSource ip = new ImportSource(
                                   dr["HoVaTen"].ToString(),
                                   dr["TenCongTy"].ToString(),
                                   dr["DiaChi"].ToString(),
                                   dr["SoDienThoai"].ToString(),
                                   Convert.ToInt32(dr["ProductId"]));
                                   
                    list.Add(ip);
                }
            }
            return list;
        }

        public void AddImportSource(ImportSource ip)
        {
            this.Connection();
            string query = "INSERT INTO ImportSources (HoVaTen, TenCongTy, DiaChi, SoDienThoai, ProductId) VALUES (@HoVaTen, @TenCongTy, @DiaChi, @SoDienThoai, @ProductId)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = this.GetConn();
            if (ip.TenCongTy == "")
            {
                cmd.Parameters.AddWithValue("@TenCongTy", null);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TenCongTy", ip.TenCongTy);
            }
            cmd.Parameters.AddWithValue("@HoVaTen", ip.HoVaTen);
            cmd.Parameters.AddWithValue("@SoDienThoai", ip.SoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", ip.DiaChi);
            cmd.Parameters.AddWithValue("@ProductId", ip.ProductId);
            cmd.ExecuteNonQuery();
        }

        public int CheckImportSourceExistByPhone(String sdt)
        {
            String sql = $"SELECT COUNT(Id) FROM ImportSources WHERE SoDienThoai LIKE {sdt}";
            return (int)MyExecuteScalar(sql, CommandType.Text);
        }


        public void DeleteImportSourceByPhone(String sdt)
        {
            Connection();
            string query = $"DELETE FROM ImportSources WHERE SoDienThoai LIKE '{sdt}'";
            SqlCommand cmd = new SqlCommand(query); cmd.Connection = this.GetConn();
            cmd.ExecuteNonQuery();
        }

        public void UpdateImportSource(string hovaten, string tencongty, string sdt, string diachi, int id)
        {
            Connection();
            string sql = $"UPDATE ImportSources SET HoVaTen = '{hovaten}', TenCongTy = '{tencongty}', SoDienThoai = '{sdt}', DiaChi = '{diachi}' WHERE Id = {id}";
            SqlCommand cmd = new SqlCommand(sql,GetConn());
            cmd.ExecuteNonQuery();
        }

        public int GetIPIdByPhone(String phone)
        {
            Connection();
            String sql = $"SELECT Id FROM ImportSources WHERE SoDienThoai = '{phone}'";
            SqlCommand cmd = new SqlCommand(sql,GetConn());
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
