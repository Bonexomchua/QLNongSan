using BussinessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class BillDetail : Form
    {
        public Bill bill {  get; set; }
        private BillBL billBL = new BillBL();
        private ProductBL productBL = new ProductBL();
        public BillDetail(Bill bill)
        {
            this.bill = bill;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSize = true;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;

            DataTable dt = billBL.GetBillDetail(this.bill.id);
            // Thêm cột mới
            dt.Columns.Add("TenSanPham", typeof(string));

            // Lặp qua từng hàng, thay thế ProductId bằng tên sản phẩm
            foreach (DataRow row in dt.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                row["TenSanPham"] = productBL.GetProductNameById(productId);
            }

            // Ẩn cột ProductId, gán DataSource
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
        }
    }
}
