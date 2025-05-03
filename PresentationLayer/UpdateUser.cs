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
    public partial class UpdateUser : Form
    {

        public User user { get; set; }
        public UpdateUser(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private UserBL uBL = new UserBL();

        public EventHandler UserUpdate;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = uBL.GetUserIdByUsername(user.userName);
            User newU = new User(txtTen.Text,txtPhone.Text,txtViTri.Text,txtUsername.Text,txtPassword.Text,dateTimePicker1.Value);
            try
            {
                uBL.UpdateUser(newU, id);
                MessageBox.Show("Cập nhật thành công");
                UserUpdate?.Invoke(this, EventArgs.Empty);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException)
            {

                MessageBox.Show("Thông tin không hợp lệ");
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            txtTen.Text = user.hoVaTen.ToString();
            txtPhone.Text = user.phone.ToString();
            dateTimePicker1.Value = user.dOB;
            txtViTri.Text = user.chucVu.ToString();
            txtUsername.Text = user.userName.ToString();
            txtPassword.Text = user.password.ToString();
        }
    }
}
