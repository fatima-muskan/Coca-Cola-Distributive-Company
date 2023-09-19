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
    public partial class form_searchShopkeeper : Form
    {
        ShopkeeperDL BST = new ShopkeeperDL();
        public form_searchShopkeeper()
        {
            InitializeComponent();
        }

        private void form_searchShopkeeper_Load(object sender, EventArgs e)
        {

            BST.read("Shopkeeper.csv");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtBox_Id.Text != "")
            {

                ShopkeeperBL emp = BST.search(int.Parse(txtBox_Id.Text));
                if (emp != null)
                {
                    lbl_details.Text = ("Name : " + emp.Name + "\n" + "Cnic : " + emp.Cnic + "\n" + "Address : " + emp.Area + "\n" + "Phone : " + emp.Phone + "\n" + "Location : " + emp.Location + "\n" + "ID : " + emp.Id + "\n").ToString();
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
            form_salesManager m = new form_salesManager();
            m.Show();
            this.Close();
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
    }
}
