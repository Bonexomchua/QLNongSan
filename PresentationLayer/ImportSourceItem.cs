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
    public partial class ImportSourceItem : UserControl
    {
        public ImportSource ips {  get; set; }
        private ImportSourceBL ipsBL = new ImportSourceBL();
        public ImportSourceItem(ImportSource ips)
        {
            this.ips = ips;
            InitializeComponent();
        }

        public string tenNguon
        {
            get { return lblTen.Text; }
            set { lblTen.Text = value; }
        }

        public string tenCongTy
        {
            get { return lblCongTy.Text; }
            set { lblCongTy.Text = value; }
        }

        public string soDienThoai
        {
            get { return lblSoDienThoai.Text; }
            set { lblSoDienThoai.Text = value; }
        }

        public string diaChi
        {
            get
            {
                return lblDiaChi.Text;
            }

            set { lblDiaChi.Text = value; }
        }
        private void ImportSourceItem_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ipsBL.DeleteImportSourceByPhone(ips.SoDienThoai);
            MessageBox.Show("Xóa thành công");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateImportSource update= new UpdateImportSource(this.ips);
            update.Show();
        }
    }
}
