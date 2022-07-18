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
    public partial class UC_InsertItem : UserControl
    {
        function fn = new function();
        private string query;

        public UC_InsertItem()
        {
            InitializeComponent();
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('"+txtItemName.Text+"','"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();

        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();



        }

        private void UC_InsertItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_InsertItem_Load(object sender, EventArgs e)
        {

        }

       private void UC_InsertItem_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(-10, -10);
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
                Border3DStyle.Raised);
        }
    }
}
