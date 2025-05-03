using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            label1.Text = "Xin chào " + LoginForm.logedin.username;
            ThanhToanControl thanhToan = new ThanhToanControl();
            thanhToan.Dock = DockStyle.Fill;
            panel1.Controls.Add(thanhToan);
        }

        private void btnQLHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnQLHang.BackColor = Color.FromArgb(33, 89, 52);
            ProductManagementControl pmc = new ProductManagementControl();
            panel1.Controls.Add((ProductManagementControl) pmc);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnThanhToan.BackColor = Color.FromArgb(33, 89, 52);
            ThanhToanControl thanhtoan = new ThanhToanControl();
            thanhtoan.Dock = DockStyle.Fill;
            panel1.Controls.Add(thanhtoan);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnNhanVien.BackColor = Color.FromArgb(33, 89, 52);
            NhanVienControl n = new NhanVienControl();
            panel1.Controls.Add(n);
        }

        private void btnQLNguonNhap_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnQLNguonNhap.BackColor = Color.FromArgb(33, 89, 52);
            QuanLyNguonNhapControl n = new QuanLyNguonNhapControl();
            panel1.Controls.Add(n);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnHoaDon.BackColor = Color.FromArgb(33, 89, 52);
            BillControl b = new BillControl();
            b.Dock = DockStyle.Fill;
            panel1.Controls.Add(b);
        }

        private void SetAllButtonColor()
        {
            btnHoaDon.BackColor = Color.FromArgb(75,140,98);
            btnNhanVien.BackColor = Color.FromArgb(75, 140, 98);
            btnQLHang.BackColor = Color.FromArgb(75, 140, 98);
            btnQLNguonNhap.BackColor = Color.FromArgb(75, 140, 98);
            btnThanhToan.BackColor = Color.FromArgb(75, 140, 98);
            btnStatic.BackColor = Color.FromArgb(75, 140, 98);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm.logedin = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetAllButtonColor();
            btnStatic.BackColor = Color.FromArgb(33, 89, 52);
            ChartControl c = new ChartControl();
            //c.Dock = DockStyle.Fill;
            panel1.Controls.Add(c);
        }
    }
}
