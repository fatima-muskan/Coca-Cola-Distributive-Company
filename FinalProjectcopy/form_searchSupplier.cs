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
    public partial class form_searchSupplier : Form
    {
        SupplierDL BST = new SupplierDL();
        public form_searchSupplier()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtBox_Id.Text != "")
            {

                SupplierBL emp = BST.search(int.Parse(txtBox_Id.Text));
                if (emp != null)
                {
                    lbl_details.Text = ("Name : " + emp.Name + "\n" + "Cnic : " + emp.Cnic + "\n" + "\n" + "Phone : " + emp.Phone + "\n" + "ID : " + emp.Id + "\n").ToString();
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

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void txtBox_Id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Id.Text))
            {
                e.Cancel = true;
                txtBox_Id.Focus();
                errorId.SetError(txtBox_Id, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorId.SetError(txtBox_Id, "");
                if (int.Parse(txtBox_Id.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_Id.Focus();
                    errorId.SetError(txtBox_Id, "Invalid!!! ");
                }

                else
                {
                    e.Cancel = false;
                    errorId.SetError(txtBox_Id, "");
                }
            }
        }

        private void form_searchSupplier_Load(object sender, EventArgs e)
        {
            BST.read("Supplier.csv");
        }
    }
}
