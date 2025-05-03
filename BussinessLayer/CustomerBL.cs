using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CustomerBL
    {
        private CustomerDL cusDL = new CustomerDL();
        public void AddCustomer(Customer cus)
        {
            cusDL.AddCustomer(cus);
        }

        public Customer GetCustomerById(int id)
        {
            return cusDL.GetCustomerById(id);
        }

        public int CheckCustomerByPhone(string phone)
        {
            return cusDL.CheckCustomerByPhone(phone);
        }

        public int GetMaxId()
        {
            return cusDL.GetMaxId();
        }
    }
}
