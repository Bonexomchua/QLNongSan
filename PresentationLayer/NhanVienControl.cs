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
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }


        LoadDataBL loadData = new LoadDataBL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhanVienControl_Load(object sender, EventArgs e)
        {
            List<User> users = loadData.GetUsers();
            LoadUserToScreen(users);
        }

        private void LoadUserToScreen(List<User> list)
        {
            foreach (User p in list)
            {
                StaffItem item = new StaffItem(p);
                item.HoVaTen = p.hoVaTen.ToString();
                item.SoDienThoai = p.phone.ToString();
                item.ChucVu = p.chucVu.ToString();
                item.NgaySinh = p.dOB.ToString();
                item.Margin = new Padding(5);
                item.ItemDeleted += (s, ev) =>
                {
                    this.flpanelMain.Controls.Clear();
                    List<User> users = loadData.GetUsers();
                    LoadUserToScreen(users);
                };
                item.UserUpdates += (s, ev) =>
                {
                    this.flpanelMain.Controls.Clear();
                    List<User> users = loadData.GetUsers();
                    LoadUserToScreen(users);
                };
                flpanelMain.Controls.Add(item);
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            if(addstaff.ShowDialog() == DialogResult.OK)
            {
                this.flpanelMain.Controls.Clear();
                List<User> users = loadData.GetUsers();
                LoadUserToScreen(users);
            }
        }
    }
}
