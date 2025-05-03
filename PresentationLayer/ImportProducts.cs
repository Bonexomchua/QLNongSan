using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataTransferObject;

namespace PresentationLayer
{
    public partial class ImportProducts : Form
    {
        private byte[] imagesbyte;
        public ImportProducts()
        {
            InitializeComponent();
        }

        LoadDataBL loadData = new LoadDataBL();
        private void ImportProducts_Load(object sender, EventArgs e)
        {
            List<String> values = loadData.LoadProductName();
            List<String> cate = loadData.LoadCategory();
            List<String> ipsname = loadData.LoadIPName();
            LoadDataToComboBox(values,cbbTenSP);
            LoadDataToComboBox(cate, cbbLoaiSP);
            LoadDataToComboBox(loadData.LoadDonVi(), cbbDonVi);
            //LoadDataToComboBox(ipsname, cbbTen);
        }
        private void LoadDataToComboBox(List<string> values, ComboBox comboBox)
        {
            LoadDataBL loadData = new LoadDataBL();

            if (values.Count > 0)
            {
                comboBox.Items.AddRange(values.ToArray());
            }
            else
            {
                MessageBox.Show($"Không có dữ liệu trong bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

/*        private void cbbTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhone.Items.Clear();
            cbbAddress.Items.Clear();
            List<String> phone = loadData.GetPhoneByName(cbbTen.SelectedItem.ToString());
            LoadDataToComboBox(phone, cbbPhone);

            List<String> address = loadData.GetAddressByName(cbbTen.SelectedItem.ToString());
            LoadDataToComboBox(address, cbbAddress);
        }*/

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductBL addprod = new ProductBL();
            addprod.AddProduct(cbbTenSP.Text, cbbLoaiSP.Text, Convert.ToSingle(txtSoLuong.Text), cbbDonVi.Text, Convert.ToDecimal(txtDonGia.Text), Convert.ToDecimal(txtGiaLai.Text), imagesbyte);
            
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đọc tệp hình ảnh
                string filePath = openFileDialog.FileName;
                imagesbyte = File.ReadAllBytes(filePath);

                // Hiển thị ảnh trong PictureBox (nếu có)
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }
    }
}
