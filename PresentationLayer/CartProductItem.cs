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
    public partial class CartProductItem : UserControl
    {
        private ThanhToanControl tcc;
        public CartProductItem(Product prod, ThanhToanControl tcc)
        {
            this.prod = prod;
            this.tcc = tcc;
            InitializeComponent();
        }

        public Product prod {  get; set; }
        public string name
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string soluong
        {
            get { return lblSoLuong.Text; }
            set { lblSoLuong.Text = value; }
        }

    public Label labela => label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void CartProductItem_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(this.soluong);
            soLuong++;
            this.soluong = soLuong.ToString();
            lblSoLuong.Text = this.soluong;
            tcc.setTongTien();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(this.soluong);
            if(soluong > 1)
            {
                soluong--;
                this.soluong = soluong.ToString();
                lblSoLuong.Text = this.soluong;
                tcc.setTongTien();
            }
            else
            {
                tcc.MyPanel.Controls.Remove(this);
                tcc.setTongTien();
                foreach (ProductItem p in tcc.FlowPanel.Controls)
                {
                    if (p.TenSanPham == this.name)
                    {
                        p.soLuongTrongGio = 0;
                    }
                }
            }
        }
    }
}
