using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Xml.Linq;

namespace DataLayer
{
    public class CategoryDL:DataProvider
    {
        DataTable ds = new DataTable();
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        public List<Category> GetAllCategory()
        {
            this.Connection();
            List<Category> list = new List<Category>();
            String sql = "SELECT * FROM Categories";
            SqlDataReader dr = (SqlDataReader)MyExecuteReader(sql, CommandType.Text);
            while (dr.Read())
            {
                Category cate = new Category(Convert.ToInt32(dr["Id"]),
                                             dr["TenMuc"].ToString()
                    );
                list.Add(cate);
            }
            return list;
        }

        public int GetCateIdByName(String name)
        {
            this.Connection();
            string sql = $"SELECT Id FROM Categories WHERE TenMuc LIKE '{name}'";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            return value;
        }

        public string GetCateNameById(int id)
        {
            this.Connection();
            string sql = $"SELECT TenMuc FROM Categories WHERE Id LIKE {id}";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
           string value = cmd.ExecuteScalar().ToString();
            return value;
        }

        public DataTable GetCateTable()
        {
            this.Connection();
            String sql = "SELECT * FROM Categories";
            adapter = new SqlDataAdapter(sql,this.GetConn());
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            return ds;
        }

        public void UpdateCateTable(DataTable dt)
        {
            ds = dt;
            adapter.Update(ds);
        }
    }
}
