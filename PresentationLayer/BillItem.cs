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
    public partial class BillItem : UserControl
    {
        public Bill bill {  get; set; } 

        public BillItem(Bill b)
        {
            this.bill = b;
            InitializeComponent();
        }

        CustomerBL cusbl = new CustomerBL();

        public string Ten
        {
            get { return lblTen.Text; }
            set { lblTen.Text = value; }
        }

        public string NhanVien
        {
            get { return lblNhanVien.Text; }
            set { lblNhanVien.Text = value; }
        }

        public string NgayThanh
        {
            get { return lblNgayThang.Text; }
            set { lblNgayThang.Text = value; }
        }

        public string TongTien
        {
            get { return lblTongTien.Text; }
            set { lblTongTien.Text = value; }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            BillDetail billdetail = new BillDetail(this.bill);
            billdetail.Show();

        }

        private void BillItem_Load(object sender, EventArgs e)
        {
        }
    }
}
