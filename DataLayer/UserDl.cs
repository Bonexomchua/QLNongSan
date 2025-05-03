using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer
{
    public class UserDl:DataProvider
    {
        public List<User> GetAllUser()
        {
            this.Connection();
            List<User> users = new List<User>();
            String sql = "SELECT * FROM Users";
            SqlDataReader dr = (SqlDataReader)MyExecuteReader(sql, CommandType.Text); 
            while (dr.Read())
            {
                User user = new User(dr["HoVaTen"].ToString(),
                                     dr["SoDienThoai"].ToString(),
                                     dr["ViTri"].ToString(),
                                     dr["Username"].ToString(),
                                     dr["Password"].ToString(),
                                     Convert.ToDateTime(dr["NgaySinh"])
                    );
                users.Add(user);
            }
            return users;
        }

        public void AddUser(User user)
        {
            this.Connection();
            string query = "INSERT INTO Users (HoVaTen, NgaySinh, SoDienThoai, ViTri, Username, Password) VALUES (@HoVaTen, @NgaySinh, @SoDienThoai, @ViTri, @Username, @Password)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = this.GetConn();
            cmd.Parameters.AddWithValue("@HoVaTen", user.hoVaTen);
            cmd.Parameters.AddWithValue("@NgaySinh", user.dOB);
            cmd.Parameters.AddWithValue("@SoDienThoai", user.phone);
            cmd.Parameters.AddWithValue("@ViTri", user.chucVu);
            cmd.Parameters.AddWithValue("@Username", user.userName);
            cmd.Parameters.AddWithValue("@Password", user.password);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUser(string sdt)
        {
            Connection();
            string query = $"DELETE FROM Users WHERE SoDienThoai LIKE '{sdt}'";
            SqlCommand cmd = new SqlCommand(query); cmd.Connection = this.GetConn();
            cmd.ExecuteNonQuery();
        }

        public User GetUserById (int id)
        {
            User user;
            Connection();
            string sql = $"SELECT * FROM Users WHERE Id LIKE {id}";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                 user = new User(dataReader["HoVaTen"].ToString(),
                                  dataReader["SoDienThoai"].ToString(),
                                  dataReader["ViTri"].ToString(),
                                  dataReader["Username"].ToString(),
                                  dataReader["Password"].ToString(),
                                  Convert.ToDateTime(dataReader["NgaySinh"]));
                return user;
            } else
            {
                return null;
            }
        }

        public int GetUserIdByUsername(string username)
        {
            Connection();
            string sql = $"SELECT Id FROM Users WHERE Username LIKE '{username}'";
            SqlCommand cmd = new SqlCommand(sql, this.GetConn());
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            return value;
        }

        public void UpdateUser(User user,int id)
        {
            Connection();
            string sql = "UPDATE Users SET HoVaten = @HoVaTen, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, ViTri = @ViTri, Username = @Username, Password = @Password WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand (sql, this.GetConn());
            cmd.Parameters.AddWithValue("@HoVaTen", user.hoVaTen);
            cmd.Parameters.AddWithValue("@NgaySinh", user.dOB);
            cmd.Parameters.AddWithValue("@SoDienThoai", user.phone);
            cmd.Parameters.AddWithValue("@ViTri", user.chucVu);
            cmd.Parameters.AddWithValue("@Username", user.userName);
            cmd.Parameters.AddWithValue("@Password", user.password);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
