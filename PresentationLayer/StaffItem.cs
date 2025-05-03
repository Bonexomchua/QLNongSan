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
    public partial class StaffItem : UserControl
    {
        public User user {  get; set; } 
        public StaffItem()
        {
            InitializeComponent();
        }

        public StaffItem(User u)
        {
            this.user = u;
            InitializeComponent();
        }


        public string HoVaTen
        {
            get { return lblTen.Text; }
            set {lblTen.Text = value; }
        }

        public string SoDienThoai
        {
            get { return lblPhone.Text; }
            set { lblPhone.Text = value; }
        }

        public string ChucVu
        {
            get { return lblChucVu.Text; }
            set { lblChucVu.Text = value; }
        }

        public string NgaySinh
        {
            get { return lblNgaySinh.Text; }
            set { lblNgaySinh.Text = value; }
        }

        private void StaffItem_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler ItemDeleted;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBL addStaffBL = new UserBL();
            addStaffBL.deleteStaff(SoDienThoai);
            MessageBox.Show("Xóa thành công");
            ItemDeleted?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler UserUpdates;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser updateuser = new UpdateUser(this.user);
            updateuser.Show();
            updateuser.UserUpdate += (s, ev) =>
            {
                UserUpdates?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
