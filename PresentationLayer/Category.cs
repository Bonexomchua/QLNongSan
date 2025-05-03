using BussinessLayer;
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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        
        public DataTable dt = new DataTable();

        private CategoryBL cateBL = new CategoryBL();

        private void Category_Load(object sender, EventArgs e)
        {
            dt = cateBL.GetCateTable();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cateBL.UpdateDataTable(dt);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cateBL.UpdateDataTable(dt);
        }
    }
}
