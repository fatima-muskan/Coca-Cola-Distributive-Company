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
    public partial class form_addVahicle : Form
    {
        VehicleDL BST=new VehicleDL();
        public form_addVahicle()
        {
            InitializeComponent();
        }

        private void form_addVahicle_Load(object sender, EventArgs e)
        {
            if (BST.read("Vehicle.csv"))
            {
                MessageBox.Show("Data Loaded!!");

            }
            else
            {
                MessageBox.Show("Data not Loaded!!");

            }
        }

        private void txtBox_vhID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_vhID.Text) || (txtBox_vhID.Text) == "xyz123")
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

        private void txtBox_fuel_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBox_fuel.Text) || (txtBox_fuel.Text)== "In litre")
            {
                e.Cancel = true;
                txtBox_fuel.Focus();
                errorFuel.SetError(txtBox_fuel, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorFuel.SetError(txtBox_fuel, "");
                if (int.Parse(txtBox_fuel.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_fuel.Focus();
                    errorFuel.SetError(txtBox_fuel, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorFuel.SetError(txtBox_fuel, "");
                }
            }
        }

        public int RandomId()
        {
            Random random = new Random();
            int num = random.Next(1, 1000);
            VehcleBL emp = BST.search(num);
            while (emp != null)
            {
                num = random.Next(1, 1000);
                emp = BST.search(num);
            }
            return num;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtBox_vhID.Text != "xyz123" && txtBox_fuel.Text != "In litre" && cmb_status.Text != "Select")
            {
                int Id = RandomId();
                VehcleBL vh = new VehcleBL(txtBox_vhID.Text, bool.Parse(cmb_status.Text), int.Parse(txtBox_fuel.Text),Id);
                if (!BST.CheckData(vh))
                {
                    BST.insert(vh);
                    MessageBox.Show("Data Added!!");
                    btn_add.Enabled = false;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                    if (result == DialogResult.Yes)
                    {
                        List<VehcleBL> list = BST.TreetoList();
                        BST.storeInFile("Vehicle.csv", list);
                        MessageBox.Show("Store in File!!");
                    }
                }
                else
                {
                    MessageBox.Show("That number is already added!!");
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
