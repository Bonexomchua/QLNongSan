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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User(txtHoVaTen.Text,txtSoDienThoai.Text,cbbChucVu.Text,txtUsername.Text,txtPassword.Text, dateNgaySinh.Value);

            UserBL userbl = new UserBL();
            userbl.addUser(user);
            this.DialogResult = DialogResult.OK;
            this.Close();
/*            try
            {
                userbl.addUser(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException)
            {

                MessageBox.Show("Thông tin không hợp lệ");
            }*/
        }
    }
}
