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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private CustomerBL cusbl = new CustomerBL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string phone = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            if(hoten != null && phone != null && diachi != null)
            {
                Customer cus = new Customer(hoten, phone, diachi);

                cusbl.AddCustomer(cus);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }

        }
    }
}
