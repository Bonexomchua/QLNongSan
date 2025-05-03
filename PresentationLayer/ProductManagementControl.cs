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
    public partial class ProductManagementControl : UserControl
    {
        public ProductManagementControl()
        {
            InitializeComponent();
        }

        private void ProductManagementControl_Load(object sender, EventArgs e)
        {
            ProductBL productBL = new ProductBL();
            List<Product> products = productBL.GetAllProduct();
            foreach (Product p in products)
            {
                ProductManagementItem productManagementItem = new ProductManagementItem(p);
                //productManagementItem.tenSP = p.tenSP.ToString();
                productManagementItem.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(productManagementItem);
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ImportProducts importProducts = new ImportProducts();
            importProducts.ShowDialog();
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.ShowDialog();
        }
    }
}
