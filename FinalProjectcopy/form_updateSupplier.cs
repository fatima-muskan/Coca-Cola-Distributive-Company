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

namespace FinalProject
{
    public partial class form_updateSupplier : Form
    {
        form_viewSupplier view;
        private SupplierBL NewSup;
        SupplierDL BST = new SupplierDL();
        public form_updateSupplier(SupplierBL NewSup, form_viewSupplier view)
        {
            this.NewSup = NewSup;
            this.view = view;
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txtBox_name.Text != "" && txtBox_phone.Text != "" && txtBox_cnic.Text != "")
            {
                SupplierBL sup = new SupplierBL(txtBox_name.Text, txtBox_cnic.Text, txtBox_phone.Text, NewSup.Id);

                if (BST.Update(sup))
                {
                    MessageBox.Show("Data Updated!!");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<SupplierBL> list = BST.TreetoList();
                        BST.storeInFile("Supplier.csv", list);
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

        private void form_updateSupplier_Load(object sender, EventArgs e)
        {
            BST.read("Supplier.csv");
            txtBox_name.Text = NewSup.Name;
            txtBox_cnic.Text = NewSup.Cnic;
            txtBox_phone.Text = NewSup.Phone;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Hide();
        }

        private void txtBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_name.Text))
            {
                e.Cancel = true;
                txtBox_name.Focus();
                errorName.SetError(txtBox_name, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(txtBox_name, "");
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

        private void txtBox_phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_phone.Text))
            {
                e.Cancel = true;
                txtBox_phone.Focus();
                errorDigitd.SetError(txtBox_phone, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigitd.SetError(txtBox_phone, "");
                if ((txtBox_phone.Text).Length == 11 && Regex.IsMatch(txtBox_phone.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorDigitd.SetError(txtBox_phone, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_phone.Focus();
                    errorDigitd.SetError(txtBox_phone, "Invalid");
                }

            }
        }
    }
}
