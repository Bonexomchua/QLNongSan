using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BillBL
    {
        BillDL billDL = new BillDL();
        public List<Bill> GetAllBill()
        {
            return billDL.GetAllBill();
        }

        public void AddBillSell(Bill bill)
        {
            billDL.AddBillSell(bill);
        }

        public void AddBillSellDetail(Bill bill, Product prod, float soLuong)
        {
            billDL.AddBillSellDetail(bill,prod,soLuong);
        }

        public DataTable GetBillDetail(int id)
        {
            return billDL.GetBillDetail(id);
        }
    }
}
