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
    public partial class QuanLyNguonNhapControl : UserControl
    {
        public QuanLyNguonNhapControl()
        {
            InitializeComponent();
        }

        ImportSourceBL ipBL = new ImportSourceBL(); 
        private void QuanLyNguonNhapControl_Load(object sender, EventArgs e)
        {
            List<ImportSource> list = new List<ImportSource>();
            list = ipBL.GetAllImportSource();
            foreach (ImportSource source in list)
            {
                ImportSourceItem item = new ImportSourceItem(source);
                item.tenNguon = source.HoVaTen;
                item.tenCongTy = source.TenCongTy;
                item.soDienThoai = source.SoDienThoai;
                item.diaChi = source.DiaChi;
                item.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddImportSource aips = new AddImportSource();
            aips.ShowDialog();
        }
    }
}
