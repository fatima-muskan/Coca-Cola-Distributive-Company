using FinalProject.BL;
using FinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class form_addRider : Form
    {
        RiderDL BST = new RiderDL();
        VehicleDL bst = new VehicleDL();
        public form_addRider()
        {
            InitializeComponent();
        }

        private void form_addRider_Load(object sender, EventArgs e)
        {
            if (BST.read("Rider.csv") && bst.read("Vehicle.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!!");

            }
        }

        public int RandomId()
        {
            Random random = new Random();
            int num = random.Next(1, 1000);
            RiderBL rider = BST.search(num);
            while (rider != null)
            {
                num = random.Next(1, 1000);
                rider = BST.search(num);
            }
            return num;

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

        private void txtBox2_Validating(object sender, CancelEventArgs e)
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

          private void txtBox_email_Validating(object sender, CancelEventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtBox_email.Text) || (txtBox_email.Text) == "xyz@gmail.com")
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

        private void txtBox_vehicleId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_vehicleId.Text))
            {
                e.Cancel = true;
                txtBox_vehicleId.Focus();
                errorVehicleID.SetError(txtBox_vehicleId, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorVehicleID.SetError(txtBox_vehicleId, "");
                if (int.Parse(txtBox_vehicleId.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_vehicleId.Focus();
                    errorVehicleID.SetError(txtBox_vehicleId, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorVehicleID.SetError(txtBox_vehicleId, "");
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

        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text) || (txtBox_digits.Text) == "Digits")
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

        private void txtBox_pass_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBox_pass.Text) || (txtBox_pass.Text) == "******** (number + alphabets)")
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

        private void cmb_area_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_area.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_area.Focus();
                errorArea.SetError(cmb_area, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorArea.SetError(cmb_area, "");
            }
        }
        private void txtBox_year_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_year.Text) || (txtBox_year.Text) == "XXXX")
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
        private void btn_add_Click(object sender, EventArgs e)

        {
            
            if (txtBox_name1.Text != "" && txtBox_name1.Text != "First Name" && txtBox_name2.Text != "" && txtBox_name2.Text != "Last Name" && txtBox_cnic.Text != "" && txtBox_cnic.Text != "XXXXXXXXXXXXX" && txtBox_email.Text != "" && txtBox_email.Text != "xyz@gmail.com" && txtBox_salary.Text != "" && txtBox_pass.Text != "" && txtBox_pass.Text != "******** (number + alphabet)" && txtBox_year.Text != "" && txtBox_year.Text != "XXXX" && txtBox_digits.Text != "" && txtBox_digits.Text != "Digits" && cmb_date.Text != "Date" && cmb_month.Text != "Month" && cmb_area.Text != "Role" && txtBox_vehicleId.Text != "")
            {
                int Id = RandomId();
                VehcleBL vh= bst.search(int.Parse(txtBox_vehicleId.Text));
                if (vh != null && !vh.Status)
                {
                    RiderBL rider = new RiderBL(txtBox_name1.Text + txtBox_name2.Text, txtBox_cnic.Text, txtBox_email.Text, int.Parse(txtBox_salary.Text), cmb_date.Text + cmb_month.Text + txtBox_year.Text, txtBox_code.Text + txtBox_digits.Text, txtBox_pass.Text, "Rider", Id, int.Parse(txtBox_vehicleId.Text), cmb_area.Text);
                    if (!BST.CheckData(rider))
                    {
                        BST.insert(rider);
                        MessageBox.Show("Data Added!!");
                        btn_add.Enabled = false;
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                        if (result == DialogResult.Yes)
                        {
                            List<RiderBL> list = BST.TreetoList();
                            BST.storeInFile("Rider.csv", list);
                            MessageBox.Show("Store in File!!");
                           VehcleBL v = new VehcleBL(vh.Number, true, vh.Fuel, vh.Id);
                           if (bst.Update(v))
                           {
                             List<VehcleBL> listv = bst.TreetoList();
                             bst.storeInFile("Vehicle.csv", listv);
                           }
                        }
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Cnic is already added!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle is not available!!!");
                }
            }
            else
            {
                MessageBox.Show("Data not enter!!", "Error");
            }

        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {

            form_manager m = new form_manager();
            m.Show();
            this.Hide();
        }
        private void cmb_year_Validating(object sender, CancelEventArgs e)
        {
           
        }

        
    }
}
