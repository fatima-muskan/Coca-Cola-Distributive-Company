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
using System.Windows.Forms.VisualStyles;
using FinalProject.BL;
using FinalProject.DL;

namespace FinalProject
{
    public partial class form_addSupplier : Form
    {
        SupplierDL BST = new SupplierDL();
        public form_addSupplier()
        {
            InitializeComponent();
        }
        public int RandomId()
        {
            Random random = new Random();
            int num = random.Next(1, 1000);
            SupplierBL sup = BST.search(num);
            while (sup != null)
            {
                num = random.Next(1, 1000);
                sup = BST.search(num);
            }
            return num;

        }

        private void form_addSupplier_Load(object sender, EventArgs e)
        {
            if (BST.read("Supplier.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!!");

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtBox_name1.Text != "First Name" && txtBox_name2.Text != "Second Name" && txtBox_cnic.Text != "XXXXXXXXXXXXX"  && txtBox_digits.Text != "Digits"&& txtBox_name1.Text != "" && txtBox_name2.Text != "" && txtBox_cnic.Text != "" && txtBox_digits.Text != "")
            {
                int Id = RandomId();
                SupplierBL sup = new SupplierBL(txtBox_name1.Text + txtBox_name2.Text, txtBox_cnic.Text, txtBox_areacode.Text + txtBox_digits.Text, Id);
                if (!BST.CheckData(sup))
                {
                    BST.insert(sup);
                    MessageBox.Show("Data Added!!");
                    btn_add.Enabled = false;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<SupplierBL> list = BST.TreetoList();
                        BST.storeInFile("Supplier.csv", list);
                        MessageBox.Show("Store in File!!");
                    }
                }
                else
                {
                    MessageBox.Show("This Cnic is already added!!");
                }
            }
            else
            {
                MessageBox.Show("Data not enter!!", "Error");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_inventoryManager m=new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void txtBox_name1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_name1.Text) || (txtBox_name1.Text) == "First Name")
            {
                e.Cancel = true;
                txtBox_name1.Focus();
                errorName1.SetError(txtBox_name1, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorName1.SetError(txtBox_name1, "");
            }
        }

        private void txtBox_name2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_name2.Text) || (txtBox_name2.Text) == "Second Name")
            {
                e.Cancel = true;
                txtBox_name2.Focus();
                errorName2.SetError(txtBox_name2, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorName2.SetError(txtBox_name2, "");
            }
        }

        private void txtBox_cnic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_cnic.Text) || (txtBox_cnic.Text) == "XXXXXXXXXXXXX")
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

        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text) || (txtBox_digits.Text) == "Digits")
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigits.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigits.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 10 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
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
