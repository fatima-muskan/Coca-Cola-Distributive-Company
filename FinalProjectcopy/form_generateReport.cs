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
using FinalProject.BL;

namespace FinalProject
{
    public partial class form_generateReport : Form
    {
        public form_generateReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void form_generateReport_Load(object sender, EventArgs e)
        {
          
            if(StockDL.read("Stock.csv"))
            {
                MessageBox.Show("Data loaded!!");
            }
            else
            {
                MessageBox.Show("Data not loaded!!");
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            foreach (Stock s in StockDL.stocklist)
            {
                chart1.Series["Drink"].Points.AddXY(s.Type, s.QuantityRemove);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
