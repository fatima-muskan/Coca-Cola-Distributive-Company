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
    public partial class form_addShopkeeper : Form
    {
        ShopkeeperDL BST=new ShopkeeperDL();
        public form_addShopkeeper()
        {
            InitializeComponent();
        }
        public int RandomId()
        {
            Random random = new Random();
            int num = random.Next(1, 1000);
            ShopkeeperBL sup = BST.search(num);
            while (sup != null)
            {
                num = random.Next(1, 1000);
                sup = BST.search(num);
            }
            return num;

        }
        private void form_addShopkeeper_Load(object sender, EventArgs e)
        {
            if (BST.read("Shopkeeper.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!!");

            }
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

        private void txtBox_stAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_stAddress.Text) || (txtBox_stAddress.Text) == "Street Address")
            {
                e.Cancel = true;
                txtBox_stAddress.Focus();
                errorAddress.SetError(txtBox_stAddress, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorAddress.SetError(txtBox_stAddress, "");
            }
        }

        private void cmb_code_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_code.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_code.Focus();
                errorcode.SetError(cmb_code, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorcode.SetError(cmb_code, "");
            }
        }

        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBox_digits.Text) || (txtBox_digits.Text) == "Digits")
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigitd.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigitd.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 10 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorDigitd.SetError(txtBox_digits, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_digits.Focus();
                    errorDigitd.SetError(txtBox_digits, "Invalid");
                }

            }
        }

        private void cmb_Location_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_Location.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_Location.Focus();
                errorLocation.SetError(cmb_Location, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorLocation.SetError(cmb_Location, "");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtBox_name1.Text!="" && txtBox_name2.Text!="" && txtBox_cnic.Text!="" && txtBox_stAddress.Text!="" && txtBox_city.Text!="" && cmb_code.Text!="" && txtBox_province.Text!="" && txtBox_country.Text!=""&& txtBox_areacode.Text!="" && txtBox_digits.Text!="" && txtBox_digits.Text != "Digits" && cmb_Location.Text!="")
            {
                int Id = RandomId();
                ShopkeeperBL shop = new ShopkeeperBL(txtBox_name1.Text + txtBox_name2.Text, txtBox_cnic.Text, txtBox_stAddress.Text + txtBox_city.Text + cmb_code.Text + txtBox_province.Text + txtBox_country.Text, txtBox_areacode.Text + txtBox_digits.Text, cmb_Location.Text, Id);
                if (BST.CheckData(shop))
                {
                    if (MessageBox.Show("Cinic is already added. Want to enter new shop?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BST.insert(shop);
                        MessageBox.Show("Data Added!!");
                        btn_add.Enabled = false;
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                        if (result == DialogResult.Yes)
                        {
                            List<ShopkeeperBL> list = BST.TreetoList();
                            BST.storeInFile("Shopkeeper.csv", list);
                            MessageBox.Show("Store in File!!");
                        }
                    }
                }
                else
                {
                    BST.insert(shop);
                    MessageBox.Show("Data Added!!");
                    btn_add.Enabled = false;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<ShopkeeperBL> list = BST.TreetoList();
                        BST.storeInFile("Shopkeeper.csv", list);
                        MessageBox.Show("Store in File!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data not enter!!", "Error");
            }
        }



        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_salesManager m = new form_salesManager();
            m.Show();
            this.Hide();
        }
    }
}
