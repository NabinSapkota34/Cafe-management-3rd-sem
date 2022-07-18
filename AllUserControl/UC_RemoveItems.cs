using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_management.AllUserControl
{
    public partial class UC_RemoveItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_RemoveItems()
        {
            InitializeComponent();
        }

        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            DellLabel.Text = "How to DELETE?";
            DellLabel.ForeColor = Color.Green;
            loadData();
        }

        public void loadData()
        {
            query = "Select * from items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from items where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete from items where iid =" + id + "";
                fn.setData(query);
                loadData();
            }
        }

        private void DellLabel_Click(object sender, EventArgs e)
        {
            DellLabel.ForeColor = Color.Blue;
            DellLabel.Text = "*Click on Row to Delete the Item.";
        }

        private void UC_RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
