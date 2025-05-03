using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class DataProvider
    {
            SqlConnection cnn;


            public SqlConnection GetConn()
            {
                return cnn;
            }

            public void Connection()
            {
                string connString = "Data Source=.;Initial Catalog=QuanLyNongSan;Integrated Security=True";
                cnn = new SqlConnection(connectionString: connString);
                this.OpenConn();
            }

            public void OpenConn()
            {
                if (cnn != null || cnn.State != System.Data.ConnectionState.Open)
                    cnn.Open();
            }

            public void CloseConn()
            {
            if (cnn.State == System.Data.ConnectionState.Closed)
                Console.WriteLine("sai ket noi");
            else
                cnn.Close();
            }

            public object MyExecuteScalar(string sql, CommandType type)
            {

                Connection();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;

                try
                {
                    return cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConn();
                }
            }
            public object MyExecuteReader(string sql, CommandType type)
        {
            Connection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = type;

            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseConn();
            }
        }
            public object MyExecuteNonQuerry(string sql, CommandType type)
        {
            Connection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType= type;

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { CloseConn();}
        }

            public void FillToDataSet (string sql, string tableName)
        {
            Connection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,cnn);
/*            DataSet ds = new DataSet();
            adapter.Fill(ds);*/
            //adapter.Fill(MyDataSet.myDTSet, tableName);
            
        }
    }
}
