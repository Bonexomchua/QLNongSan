using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;

namespace DataLayer
{
    public class LoginDL:DataProvider
    {


        public int isLogin(Account acc)
        {
            string sql = $"SELECT COUNT(Username) FROM Users WHERE Username = '{acc.username}' AND Password = '{acc.password}'";
            try
            {
                return Convert.ToInt32(MyExecuteScalar(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
