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
    public partial class UpdateImportSource : Form
    {
        public ImportSource ips {  get; set; }
        public UpdateImportSource(ImportSource ips)
        {
            this.ips = ips;
            InitializeComponent();
        }
        private ImportSourceBL ipBL = new ImportSourceBL();



        private void button1_Click(object sender, EventArgs e)
        {
            int id = ipBL.GetImportSourceIdByPhone(ips.SoDienThoai);
            try
            {
                ipBL.UpdateImportSource(txtTen.Text, txtTenCongTy.Text, txtPhone.Text, txtDiaChi.Text, id);
            }
            catch (SqlException)
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
        }

        private void UpdateImportSource_Load(object sender, EventArgs e)
        {
            txtTen.Text = this.ips.HoVaTen.ToString();
            txtPhone.Text = this.ips.SoDienThoai.ToString();
            txtDiaChi.Text = this.ips.DiaChi.ToString();
            if(this.ips.TenCongTy == "")
            {
                txtTenCongTy.Text = "Không khả dụng";
                txtTenCongTy.Enabled = false;
            }
            else
            {
               txtTenCongTy.Text = this.ips.TenCongTy.ToString();
            }

        }
    }
}
