using BussinessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class BillControl : UserControl
    {
        private BillBL billBL = new BillBL();
        private UserBL userBL = new UserBL();
        private CustomerBL cusBL = new CustomerBL();
        public BillControl()
        {
            InitializeComponent();
        }


        private void BillControl_Load(object sender, EventArgs e)
        {
            List < Bill > list = billBL.GetAllBill();
            foreach (Bill bill in list) {
                BillItem item = new BillItem(bill);
                item.NhanVien = userBL.GetUserById(bill.userId).hoVaTen;
                item.Ten = cusBL.GetCustomerById(bill.customerId).Name;
                item.NgayThanh = bill.ngayThanhToan.ToString();
                item.TongTien = bill.tongTien.ToString();
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
