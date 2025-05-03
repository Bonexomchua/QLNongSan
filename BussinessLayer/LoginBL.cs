using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTransferObject;

namespace BussinessLayer
{
    public class LoginBL
    {

        public int Login(Account acc)
        {
            int a = new LoginDL().isLogin(acc);
            return a;
        }




        

    }
}
