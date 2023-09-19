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
    public partial class form_updRider : Form
    {

        form_viewRider view;
        private RiderBL NewRider;
        RiderDL BST = new RiderDL();
        VehicleDL bst = new VehicleDL();
        public form_updRider(RiderBL NewRider, form_viewRider view)
        {
            this.NewRider = NewRider;
            this.view = view;
            InitializeComponent();
        }

        private void form_updRider_Load(object sender, EventArgs e)
        {
            BST.read("Rider.csv");
            bst.read("Vehicle.csv");
            txtBox_name1.Text = NewRider.Name;
            txtBox_cnic.Text = NewRider.Cnic;
            txtBox_email.Text= NewRider.Email;
            txtBox_salary.Text = (NewRider.Salary).ToString();
            txtBox_pass.Text = NewRider.Password;
            txtBox_digits.Text = NewRider.Phone;
            txtBox_vehicleId.Text = NewRider.VehicleID.ToString();
            txtBox_year.Text = NewRider.DOB;
            cmb_area.Text= NewRider.Area;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtBox_name1.Text != "" && txtBox_cnic.Text != "" && txtBox_email.Text != "" && txtBox_salary.Text != "" && txtBox_pass.Text != "" && txtBox_digits.Text != "" && cmb_area.Text != "" && txtBox_year.Text != "" && txtBox_vehicleId.Text!="")
            {
                RiderBL emp = new RiderBL(txtBox_name1.Text, txtBox_cnic.Text, txtBox_email.Text, int.Parse(txtBox_salary.Text), txtBox_year.Text, txtBox_digits.Text, txtBox_pass.Text, "Rider", NewRider.Id, int.Parse(txtBox_vehicleId.Text), cmb_area.Text);
                if (int.Parse(txtBox_vehicleId.Text) == NewRider.VehicleID)
                {
                    BST.Update(emp);
                    MessageBox.Show("Data Updated!!");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<RiderBL> list = BST.TreetoList();
                        BST.storeInFile("Rider.csv", list);
                        MessageBox.Show("Store in File!!");
                    }
                }
                VehcleBL vh = bst.search(int.Parse(txtBox_vehicleId.Text));
                if (vh != null && !vh.Status)
                {
                    BST.Update(emp);
                    MessageBox.Show("Data Updated!!");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<RiderBL> list = BST.TreetoList();
                        BST.storeInFile("Rider.csv", list);
                        MessageBox.Show("Store in File!!");
                    }
                    VehcleBL v = new VehcleBL(vh.Number, true, vh.Fuel, vh.Id);
                    if (bst.Update(v))
                    {
                        List<VehcleBL> listv = bst.TreetoList();
                        bst.storeInFile("Vehicle.csv", listv);
                    }
                    VehcleBL ve = bst.search(NewRider.VehicleID);
                    VehcleBL vhe = new VehcleBL(ve.Number, false, ve.Fuel, ve.Id);
                    if (bst.Update(vhe))
                    {
                        List<VehcleBL> listv = bst.TreetoList();
                        bst.storeInFile("Vehicle.csv", listv);
                    }
                }

                    view.databind();
            }
            else
            {
                MessageBox.Show("Data Enterd!!!");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Close();
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

        private void txtBox_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_email.Text))
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
                errorVId.SetError(txtBox_vehicleId, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorVId.SetError(txtBox_vehicleId, "");
                if (int.Parse(txtBox_vehicleId.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_vehicleId.Focus();
                    errorVId.SetError(txtBox_vehicleId, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorVId.SetError(txtBox_vehicleId, "");
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

        private void txtBox_year_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtBox_digits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text))
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigit.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigit.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 11 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
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
            if (string.IsNullOrWhiteSpace(txtBox_pass.Text))
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

        private void txtBox_vehicleId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
