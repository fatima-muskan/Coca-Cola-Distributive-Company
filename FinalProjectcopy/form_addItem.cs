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
    public partial class form_addItem : Form
    {
        SupplierDL BST = new SupplierDL();
        public form_addItem()
        {
            InitializeComponent();
        }

        private void form_addItem_Load(object sender, EventArgs e)
        {
            DrinkDL.read("Stock.csv");
            BST.read("Supplier.csv");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtBox_supplierId.Text != "" && txtBox_quantity.Text != "" && cmb_size.Text != "" && cmb_payment.Text != "" && cmb_type.Text != "")
            {
                SupplierBL sup = BST.search(int.Parse(txtBox_supplierId.Text));
                if (sup != null)
                {

                    List<Drink> list = new List<Drink>();
                   
                        string typ = cmb_type.Text;
                        int siz = int.Parse(cmb_size.Text);
                        int quantit = int.Parse(txtBox_quantity.Text);
                        Drink de = new Drink(typ, siz, quantit);
                        list.Add(de);
                        if(DrinkDL.ADDItem(de))
                        {
                            MessageBox.Show("Updated!!");
                        }
                        else
                        {
                            MessageBox.Show("Addedd!1");
                        }
                        
                    
                        Orders or = new Orders(list, bool.Parse(cmb_payment.Text), 0, int.Parse(txtBox_supplierId.Text));
                        OrderDL.addOrdertolist(or);
                        MessageBox.Show("Data Added!!");
                        if (MessageBox.Show("are yous ure to save in file???", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            OrderDL.storeInFile("Order.csv");
                            MessageBox.Show("Store in File!!");

                        }
                    
                }
                else
                {
                    MessageBox.Show("Supplier must be addes!");
                }
            }
            else
            {
                MessageBox.Show("Data Not enter!!");
            }

         }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void cmb_type_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_type.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_type.Focus();
                errortype.SetError(cmb_type, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errortype.SetError(cmb_type, "");
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

        private void cmb_payment_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_payment.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_payment.Focus();
                errorPayment.SetError(cmb_payment, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorPayment.SetError(cmb_payment, "");
            }
        }

        private void txtBox_supplierId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_supplierId.Text))
            {
                e.Cancel = true;
                txtBox_supplierId.Focus();
                errorSupplier.SetError(txtBox_supplierId, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorSupplier.SetError(txtBox_supplierId, "");
                if (int.Parse(txtBox_supplierId.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_supplierId.Focus();
                    errorSupplier.SetError(txtBox_supplierId, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorSupplier.SetError(txtBox_supplierId, "");
                }
            }
        }
    }
}
