using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class UserBL
    {
        UserDl userdl = new UserDl();

        public void addUser(User user)
        {
            userdl.AddUser(user);
        }

        public void deleteStaff(string sdt)
        {
            userdl.DeleteUser(sdt);
        }

        public User GetUserById(int id)
        {
            return userdl.GetUserById(id);
        }

        public int GetUserIdByUsername(string username) {
            return userdl.GetUserIdByUsername(username);
        }

        public void UpdateUser(User user, int id)
        {
            userdl.UpdateUser(user, id);
        }

    }
}
