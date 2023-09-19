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
    public partial class form_updateVahicle : Form
    {
        form_viewVahicle view;
        private VehcleBL NewVehicle;
        VehicleDL BST = new VehicleDL();
        public form_updateVahicle(VehcleBL NewVehicle, form_viewVahicle view)
        {
            this.NewVehicle = NewVehicle;
            this.view = view;
            InitializeComponent();
        }

        private void tlp_updatevehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_fuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void form_updateVahicle_Load(object sender, EventArgs e)
        {
            BST.read("Vehicle.csv");
            txtBox_vhID.Text = NewVehicle.Number;
            cmb_status.Text = (NewVehicle.Status).ToString();
            textBox1.Text = (NewVehicle.Fuel).ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtBox_vhID.Text != "" && cmb_status.Text != "" && textBox1.Text != "")
            {
                VehcleBL emp = new VehcleBL(txtBox_vhID.Text, bool.Parse(cmb_status.Text), int.Parse(textBox1.Text), NewVehicle.Id);

                if (BST.Update(emp))
                {
                    MessageBox.Show("Data Updated!!");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<VehcleBL> list = BST.TreetoList();
                        BST.storeInFile("Vehicle.csv", list);
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

        private void txtBox_vhID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_vhID.Text))
            {
                e.Cancel = true;
                txtBox_vhID.Focus();
                errorNumber.SetError(txtBox_vhID, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorNumber.SetError(txtBox_vhID, "");
                if ((txtBox_vhID.Text).Length == 6 && Regex.IsMatch(txtBox_vhID.Text, @"\d+\S"))
                {
                    e.Cancel = false;
                    errorNumber.SetError(txtBox_vhID, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_vhID.Focus();
                    errorNumber.SetError(txtBox_vhID, "Invalid");
                }

            }
        }

        private void cmb_status_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_status.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_status.Focus();
                errorStatus.SetError(cmb_status, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorStatus.SetError(cmb_status, "");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorFuel.SetError(textBox1, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorFuel.SetError(textBox1, "");
                if (int.Parse(textBox1.Text) < 0)
                {
                    e.Cancel = true;
                    textBox1.Focus();
                    errorFuel.SetError(textBox1, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorFuel.SetError(textBox1, "");
                }
            }
        }
    }
}
