using FinalProject.BL;
using FinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class form_searchVahicle : Form
    {
        VehicleDL BST = new VehicleDL();
        public form_searchVahicle()
        {
            InitializeComponent();
        }

        private void form_searchVahicle_Load(object sender, EventArgs e)
        {
            BST.read("Vehicle.csv");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtBox_Id.Text != "")
            {

                VehcleBL emp = BST.search(int.Parse(txtBox_Id.Text));
                if (emp != null)
                {
                    lbl_details.Text = ("Number : " + emp.Number + "\n" + "Status : " + emp.Status + "\n" + "Fuel : " + emp.Fuel + "\n"  + "ID : " + emp.Id).ToString();
                }
                else if (emp == null)
                {
                    lbl_details.Text = "User Not Found!!!";
                }
            }
            else
            {
                MessageBox.Show("Enter th Id!!", "Error");
            }
        }

        private void txtBox_Id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Id.Text))
            {
                e.Cancel = true;
                txtBox_Id.Focus();
                errorID.SetError(txtBox_Id, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorID.SetError(txtBox_Id, "");
                if (int.Parse(txtBox_Id.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_Id.Focus();
                    errorID.SetError(txtBox_Id, "Invalid!!! ");
                }

                else
                {
                    e.Cancel = false;
                    errorID.SetError(txtBox_Id, "");
                }
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
