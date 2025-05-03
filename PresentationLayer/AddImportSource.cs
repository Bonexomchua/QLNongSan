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
    public partial class AddImportSource : Form
    {
        public AddImportSource()
        {
            InitializeComponent();
        }

        ImportSourceBL impBL = new ImportSourceBL();

        private void button1_Click(object sender, EventArgs e)
        {
            ImportSource ip = new ImportSource(txtTen.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            impBL.AddImportSource(txtTen.Text,txtTenCongTy.Text,txtDiaChi.Text, txtSoDienThoai.Text,txtTenSp.Text);
        }
    }
}
