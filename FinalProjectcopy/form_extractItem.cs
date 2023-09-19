using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.BL;
using FinalProject.DL;

namespace FinalProject
{
    public partial class form_extractItem : Form
    {
        public form_extractItem()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            int a = StockDL.Total(cmb_type.Text, int.Parse(cmb_size.Text));
            int add=StockDL.search(cmb_type.Text, int.Parse(cmb_size.Text));
            MessageBox.Show((add).ToString());
            MessageBox.Show((a).ToString());
            if (add > 0 && int.Parse(txtBox_quantity.Text) < add)
            {
                Stock d = new Stock(cmb_type.Text, int.Parse(cmb_size.Text),a,add, int.Parse(txtBox_quantity.Text));
                if (StockDL.extract(d))
                {
                    //  StockDL.storeInFile("Stock.csv");
                    StockDL.update(d);
                    MessageBox.Show("Extracted!!");
                }
                else
                {
                    MessageBox.Show("Error FOund!!");
                }
            }
            else
            {
                MessageBox.Show("Not available this time!!");

            }
        }

        private void cmb_type_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_type.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_type.Focus();
                errorType.SetError(cmb_type, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorType.SetError(cmb_type, "");
            }
        }

        private void cmb_size_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_size.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_size.Focus();
                errorSize.SetError(cmb_size, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorSize.SetError(cmb_size, "");
            }
        }

        private void txtBox_quantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_quantity.Text))
            {
                e.Cancel = true;
                txtBox_quantity.Focus();
                errorQuantity.SetError(txtBox_quantity, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorQuantity.SetError(txtBox_quantity, "");
                if (int.Parse(txtBox_quantity.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_quantity.Focus();
                    errorQuantity.SetError(txtBox_quantity, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorQuantity.SetError(txtBox_quantity, "");
                }
            }
        }

        private void form_extractItem_Load(object sender, EventArgs e)
        {
            //StockDL.stocklist.Clear();
            if(DrinkDL.read("Stock.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!");
            }
        }
    }
}
