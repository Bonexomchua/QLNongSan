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
    public partial class ProductManagementItem : UserControl
    {
        public ProductManagementItem(Product prod)
        {
            this.pr = prod;
            InitializeComponent();
        }

        public Product pr { get; set; }

        public string soLuongCon
        {
            get { return lblSoLuongCon.Text; }
            set { lblSoLuongCon.Text = value; }
        }

/*        public string tenSP
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }*/

        ProductBL prodBL = new ProductBL();
        private void button2_Click(object sender, EventArgs e)
        {
            string tensp = pr.tenSP;
            prodBL.DeleteProductByName(tensp);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product p = prodBL.GetProductByName(pr.tenSP);
            UpdateProduct update = new UpdateProduct(p);
            update.ShowDialog();
        }

        private void ProductManagementItem_Load(object sender, EventArgs e)
        {
            lblProductName.Text = pr.tenSP;
            lblSoLuongCon.Text = "Hàng còn: " + pr.soLuongCon.ToString();
        }
    }
}
