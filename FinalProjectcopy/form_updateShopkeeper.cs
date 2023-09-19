using FinalProject.BL;
using FinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class form_updateShopkeeper : Form
    {
        form_viewShopkeeper view;
        private ShopkeeperBL NewShop;
        ShopkeeperDL BST = new ShopkeeperDL();
        public form_updateShopkeeper(ShopkeeperBL NewShop, form_viewShopkeeper view)
        {
            this.NewShop = NewShop;
            this.view = view;
            InitializeComponent();
        }

        private void form_updateShopkeeper_Load(object sender, EventArgs e)
        {
            BST.read("Shopkeeper.csv");
            txtBox_name1.Text = NewShop.Name;
            txtBox_stAddress.Text = NewShop.Area;
            txtBox_cnic.Text = NewShop.Cnic;
            txtBox_digits.Text = NewShop.Phone;
            txtBox_location.Text= NewShop.Location;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtBox_name1.Text != "" && txtBox_location.Text != "" && txtBox_digits.Text != ""&& txtBox_cnic.Text!=""&&txtBox_stAddress.Text!="")
            {
                ShopkeeperBL shop = new ShopkeeperBL(txtBox_name1.Text,txtBox_cnic.Text,txtBox_stAddress.Text,txtBox_digits.Text,txtBox_location.Text,NewShop.Id);

                if (BST.Update(shop))
                {
                    MessageBox.Show("Data Updated!!");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<ShopkeeperBL> list = BST.TreetoList();
                        BST.storeInFile("Shopkeeper.csv", list);
                        MessageBox.Show("Store in File!!");
                    }

                    view.databind();
                }
            }
            else
            {
                MessageBox.Show("Data enter!!");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Hide();
        }

        private void txtBox_name1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_name1.Text))
            {
                e.Cancel = true;
                txtBox_name1.Focus();
                errorName.SetError(txtBox_name1, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(txtBox_name1, "");
            }
        }

        private void txtBox_cnic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_cnic.Text))
            {
                e.Cancel = true;
                txtBox_cnic.Focus();
                errorCnic.SetError(txtBox_cnic, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorCnic.SetError(txtBox_cnic, "");
                if ((txtBox_cnic.Text).Length == 13 && Regex.IsMatch(txtBox_cnic.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorCnic.SetError(txtBox_cnic, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_cnic.Focus();
                    errorCnic.SetError(txtBox_cnic, "Invalid");
                }

            }
        }

        private void txtBox_location_Validating(object sender, CancelEventArgs e)
        {

            if (txtBox_location.SelectedIndex == -1)
            {
                e.Cancel = true;
                txtBox_location.Focus();
                errorLocation.SetError(txtBox_location, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorLocation.SetError(txtBox_location, "");
            }
        }

        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text))
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigits.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigits.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 11 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorDigits.SetError(txtBox_digits, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_digits.Focus();
                    errorDigits.SetError(txtBox_digits, "Invalid");
                }

            }
        }
    }
}
