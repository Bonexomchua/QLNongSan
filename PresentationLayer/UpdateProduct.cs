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
    public partial class UpdateProduct : Form
    {
        public Product prod { get; set; }
        private CategoryBL cateBL = new CategoryBL();
        private ProductBL prodBL = new ProductBL();
        public UpdateProduct(Product p)
        {
            this.prod = p;
            InitializeComponent();
        }



        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cbbTenSP.Text = prod.tenSP;
            cbbCate.Text = cateBL.GetCateNameById(prod.loaiSP);
            cbbDonVi.Text = prod.donVi;
            txtGia.Text = prod.giaBan.ToString();
            txtSoLuong.Text = prod.soLuongCon.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Product newProd = new Product(cbbTenSP.Text, Convert.ToInt32(cbbCate.SelectedValue), Convert.ToSingle(txtSoLuong.Text), Convert.ToDecimal(txtGia.Text), cbbDonVi.Text);
            int id = prodBL.GetMaxIdByName(this.prod.tenSP);
            prodBL.UpdateProduct(id, newProd);
            MessageBox.Show("Update thành công");
        }
    }
}
