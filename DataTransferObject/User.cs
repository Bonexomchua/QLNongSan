using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class User
    {
        public String hoVaTen { get; set; }
        public String phone { get; set; }
        public String chucVu { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public DateTime dOB { get; set; }

        public User(String hoVaTen, String phone, String chucVu, String userName, String password, DateTime dob)
        {
            this.hoVaTen = hoVaTen;
            this.phone = phone;
            this.chucVu = chucVu;
            this.userName = userName;
            this.password = password;
            this.dOB = dob;
        }
    }
}
