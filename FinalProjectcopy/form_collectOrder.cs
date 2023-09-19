using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.DL;

namespace FinalProject
{
    public partial class form_collectOrder : Form
    {
        public form_collectOrder()
        {
            InitializeComponent();
        }

        private void form_collectOrder_Load(object sender, EventArgs e)
        {
            OrderDL.read("Order.txt");
            dataGridView1.DataSource = OrderDL.OrderList;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          //  txtBox_quantity.Text=
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
