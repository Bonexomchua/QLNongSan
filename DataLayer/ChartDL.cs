using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class ChartDL: DataProvider
    {
        private ProductDL prodDL = new ProductDL();
        public List<Chart> BillChartByMonth()
        {
            Connection();
            string sql = "SELECT MONTH(NgayThanhToan) AS NgayThanhToan, SUM(TongTien) AS TongTien FROM Bills GROUP BY MONTH(NgayThanhToan) ORDER BY NgayThanhToan";
            SqlCommand cmd = new SqlCommand(sql,GetConn());
            SqlDataReader dr = cmd.ExecuteReader();
            List<Chart> charts = new List<Chart>();
            while (dr.Read())
            {
                Chart c = new Chart((dr["NgayThanhToan"]).ToString(),
                                     Convert.ToDecimal(dr["TongTien"]));
                charts.Add(c);
            }
            return charts;
        }

        public List<Chart> BillChartByProduct() 
        {
            Connection();
            string sql = "SELECT SUM(SoLuong) AS SL ,ProductId FROM BillDetails GROUP BY ProductId";
            SqlCommand cmd = new SqlCommand(sql,GetConn());
            SqlDataReader dr = cmd.ExecuteReader();
            List<Chart> charts = new List<Chart>();
            while (dr.Read())
            {
                string name = prodDL.GetProductNameById(Convert.ToInt32(dr["ProductId"]));
                Chart c = new Chart(name, Convert.ToSingle(dr["SL"]));
                charts.Add(c);
            }
            return charts;
        }

    }
}
