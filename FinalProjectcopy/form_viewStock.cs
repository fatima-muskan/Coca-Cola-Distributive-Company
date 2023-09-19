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
    public partial class form_viewStock : Form
    {
        public form_viewStock()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void form_viewStock_Load(object sender, EventArgs e)
        {
            StockDL.stocklist.Clear();
            StockDL.read("Stock.csv");
            GV_viewRider.DataSource=StockDL.stocklist;
        }
    }
}
