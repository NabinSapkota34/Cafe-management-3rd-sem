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
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "Select name from items where category ='" + category + "'";
            DataSet ds = fn.GetData(query);

            int i;
            for(i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
