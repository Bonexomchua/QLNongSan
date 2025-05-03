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
using BussinessLayer;
using DataTransferObject;

namespace PresentationLayer
{
    public partial class ThanhToanControl : UserControl
    {

        public ThanhToanControl()
        {
            InitializeComponent();
            lblTongTien.Text = "0";
        }

        LoadDataBL ldBL = new LoadDataBL();
        ProductBL productBL = new ProductBL();
        BillBL billBL = new BillBL();
        private CustomerBL cusBL = new CustomerBL();
        private UserBL userBL = new UserBL();

        public Panel MyPanel => panelSide;
        public FlowLayoutPanel FlowPanel => flowLayoutPanelProds;


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThanhToanControl_Load(object sender, EventArgs e)
        {

            List<Product> prod = productBL.GetAllProduct();
            LoadProductToScreen(prod);
        }

        private void LoadProductToScreen(List<Product> list)
        {
            foreach (Product p in list)
            {
                ProductItem productItem = new ProductItem(this, p);
                productItem.TenSanPham = p.tenSP.ToString();
                productItem.GiaTien = p.giaBan.ToString();
                productItem.SoLuongCon = p.soLuongCon.ToString();
                using (MemoryStream ms = new MemoryStream(p.imageBytes))
                {
                    productItem.myPicture.Image = Image.FromStream(ms);
                }
                productItem.Margin = new Padding(5);
                flowLayoutPanelProds.Controls.Add(productItem);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginForm.logedin.username);
            int userId = userBL.GetUserIdByUsername(LoginForm.logedin.username.Trim());
            MessageBox.Show(userId.ToString());
            int cusId = 1;
            string cusPhone = txtSoDienThoai.Text;
            if (cusPhone != "")
            {
                int check = cusBL.CheckCustomerByPhone(cusPhone);
                if (check != 0)
                {
                    cusId = check;
                }
                else
                {
                    CustomerForm customer = new CustomerForm();
                    customer.ShowDialog();
                    cusId = cusBL.GetMaxId();
                }
            }

            List<int> list = new List<int>();
            
            //Lấy id các sản phẩm
            foreach(CartProductItem c in this.panelSide.Controls)
            {
                    int value = productBL.GetProductIdByName(c.name);
                    list.Add(value);
            }


            Bill bill = new Bill(1, calculate(), DateTime.Now,cusId , userId, list);

            billBL.AddBillSell(bill);

            foreach (CartProductItem c in this.panelSide.Controls)
            {
                    billBL.AddBillSellDetail(bill,productBL.GetProductByName(c.name), Convert.ToSingle(c.soluong));

            }
            foreach (CartProductItem c in this.panelSide.Controls)
            {
                int id = productBL.GetProductIdByName(c.name);
                productBL.UpdateAmount(Convert.ToSingle(c.soluong), id);
            }

        }

        public decimal calculate()
        {
            decimal result = 0;
            foreach(CartProductItem cartProduct in this.panelSide.Controls)
            {
                result +=  Convert.ToDecimal(cartProduct.soluong) * cartProduct.prod.giaBan;
            }
            return result;
        }
        

        public void setTongTien()
        {
            string tongtien = this.calculate().ToString();
            this.lblTongTien.Text = tongtien;
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelProds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String kw = txtSearch.Text;
            if(kw != "")
            {
                flowLayoutPanelProds.Controls.Clear();
                List<Product> pr  = productBL.GetProductByKW(kw);
                LoadProductToScreen(pr);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProds.Controls.Clear();
            this.ThanhToanControl_Load(sender, e);
        }
    }
}
