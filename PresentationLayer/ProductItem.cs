using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ProductItem : UserControl
    {
        private ThanhToanControl ttc = new ThanhToanControl();
        public int soLuongTrongGio = 0;
        public PictureBox myPicture => pictureBox1;
        public ProductItem(ThanhToanControl tcc, Product prod)
        {
            InitializeComponent();
            this.ttc = tcc;
            this.prod = prod;
        }

        public Product prod { get; set; }

        public byte[] imageByte { get; set; }
        public string TenSanPham
        {
            get { return lblTenSanPham.Text; }
            set { lblTenSanPham.Text = value; }
        }
        public string GiaTien
        {
            get { return lblGia.Text; }
            set { lblGia.Text = "Giá: " + value + "đ"; }
        }

        public string SoLuongCon
        {
            get { return lblSoLuongCon.Text; } 
            set { lblSoLuongCon.Text ="Số lượng: " +  value; }
        }

        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(prod.soLuongCon == 0)
            {
                MessageBox.Show("Sản phẩm tạm hết hàng");
            }
            else
            {
                CartProductItem product = new CartProductItem(this.prod, this.ttc);
                product.name = this.TenSanPham;
                if (soLuongTrongGio == 0)
                {
                    product.soluong = (++soLuongTrongGio).ToString();
                    ttc.MyPanel.Controls.Add(product);
                    ttc.setTongTien();
                }
                else
                {
                    soLuongTrongGio++;
                    foreach (Control ctrl in ttc.MyPanel.Controls)
                    {
                        if (ctrl is CartProductItem item && item.name == this.TenSanPham)
                        {
                            item.soluong = soLuongTrongGio.ToString();
                            item.Refresh();
                            ttc.setTongTien();
                            break;
                        }
                    }
                }
            }

        }
    }
}
