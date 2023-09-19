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
using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FinalProject
{
    public partial class form_AddEmployee : Form
    {
        EmployeeDL BST = new EmployeeDL();
        public form_AddEmployee()
        {
            InitializeComponent();
        }

        private void txtBox_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_email.Text)||(txtBox_email.Text)=="xyz@gmail.com")
            {
                e.Cancel = true;
                txtBox_email.Focus();
                errorSalary.SetError(txtBox_email, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorSalary.SetError(txtBox_email, "");
                try
                {
                    new MailAddress(txtBox_email.Text);
                    e.Cancel = false;
                    errorSalary.SetError(txtBox_email, "");
                }

                catch
                {
                    e.Cancel = true;
                    txtBox_salary.Focus();
                    errorSalary.SetError(txtBox_email, "Invalid email! ");

                }
            }
        }

        private void txtBox_cnic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_cnic.Text) || (txtBox_cnic.Text)=="XXXXXXXXXXXXX")
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

        private void txtBox_salary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_salary.Text))
            {
                e.Cancel = true;
                txtBox_salary.Focus();
                errorSalary.SetError(txtBox_salary, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorSalary.SetError(txtBox_salary, "");
                if (int.Parse(txtBox_salary.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_salary.Focus();
                    errorSalary.SetError(txtBox_salary, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorSalary.SetError(txtBox_salary, "");
                }
            }
        }
        public int RandomId()
        {
            Random random = new Random();
            int num = random.Next(1, 1000);
            EmployeeBL emp = BST.search(num);
            while (emp != null)
            {
                num = random.Next(1, 1000);
                emp = BST.search(num);
            }
            return num;

        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txtBox_name1.Text != "" && txtBox_name1.Text != "First Name" && txtBox_name2.Text != "" && txtBox_name2.Text != "Last Name" && txtBox_cnic.Text != "" && txtBox_cnic.Text != "XXXXXXXXXXXXX" && txtBox_email.Text != "" && txtBox_email.Text != "xyz@gmail.com" && txtBox_salary.Text != "" && txtBox_pass.Text != "" && txtBox_pass.Text != "******** (number + alphabet)" && txtBox_year.Text != "" && txtBox_year.Text != "XXXX" && txtBox_digits.Text != "" && txtBox_digits.Text != "Digits" && cmb_date.Text != "Date" && cmb_month.Text != "Month" && cmb_role.Text != "Role")
            {
                int Id = RandomId();
                EmployeeBL emp = new EmployeeBL(txtBox_name1.Text + txtBox_name2.Text, txtBox_cnic.Text, txtBox_email.Text, int.Parse(txtBox_salary.Text), cmb_date.Text + cmb_month.Text + txtBox_year.Text, txtBox_code.Text + txtBox_digits.Text, txtBox_pass.Text, cmb_role.Text, Id);
                if (!BST.CheckData(emp))
                {
                    BST.insert(emp);
                    MessageBox.Show("Data Added!!");
                    btn_add.Enabled = false;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<EmployeeBL> list = BST.TreetoList();
                        BST.storeInFile("Employee.csv", list);
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

        private void txtBox_year_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_year.Text) || (txtBox_year.Text)=="XXXX")
            {
                e.Cancel = true;
                txtBox_year.Focus();
                errorYear.SetError(txtBox_year, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorYear.SetError(txtBox_year, "");
                if ((txtBox_year.Text).Length == 4)
                {
                    e.Cancel = false;
                    errorYear.SetError(txtBox_year, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_year.Focus();
                    errorYear.SetError(txtBox_year, "Invalid");
                }
            }
        }

        private void txtBox_pass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_pass.Text) ||(txtBox_pass.Text)=="******** (number + alphabets)")
            {
                e.Cancel = true;
                txtBox_pass.Focus();
                errorPassword.SetError(txtBox_pass, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorPassword.SetError(txtBox_pass, "");
                if ((txtBox_pass.Text).Length == 8 && Regex.IsMatch(txtBox_pass.Text, @"\d+\S"))
                {
                    e.Cancel = false;
                    errorPassword.SetError(txtBox_pass, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_pass.Focus();
                    errorPassword.SetError(txtBox_pass, "Invalid");
                }

            }
        }
        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text) || (txtBox_digits.Text)=="Digits")
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigit.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigit.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 10 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorDigit.SetError(txtBox_digits, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_digits.Focus();
                    errorDigit.SetError(txtBox_digits, "Invalid");
                }

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

        private void cmb_month_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_month.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_month.Focus();
                errorMonth.SetError(cmb_month, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorMonth.SetError(cmb_month, "");
            }

        }

        private void cmb_date_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_date.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_date.Focus();
                errorDate.SetError(cmb_date, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorDate.SetError(cmb_date, "");
            }

        }

        private void cmb_role_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_role.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_role.Focus();
                errorRole.SetError(cmb_role, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorRole.SetError(cmb_role, "");
            }
        }

        private void txtBox_name2_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBox_name2.Text) || (txtBox_name2.Text) == "Last Name")
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

        private void form_AddEmployee_Load(object sender, EventArgs e)
        {
            if (BST.read("Employee.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!!");

            }
        }
        private void txtBox_name1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_manager m = new form_manager();
            m.Show();
            this.Hide();
        }
        private void txtBox_name2_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtBox_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void EmailValidating(object sender, CancelEventArgs e)
        {

        }

        private void txtBox_email_Enter(object sender, EventArgs e)
        {

        }

        private void CheckCnic(object sender, CancelEventArgs e)
        {

        }

        private void cmb_area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tlp_addEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_area_Click(object sender, EventArgs e)
        {

        }
        private void txtBox_name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_name2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_add_Click(object sender, EventArgs e)
        {


        }

        private void tlp_name_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CheckSalary(object sender, CancelEventArgs e)
        {

        }

        
    }
}
