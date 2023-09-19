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
    public partial class form_viewSupplier : Form
    {
        SupplierDL BST = new SupplierDL();
        public form_viewSupplier()
        {
            InitializeComponent();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_inventoryManager m = new form_inventoryManager();
            m.Show();
            this.Hide();
        }

        private void form_viewSupplier_Load(object sender, EventArgs e)
        {

            BST.read("Supplier.csv");
            List<SupplierBL> list = BST.TreetoList();
            GV_viewSupplier.DataSource = list;
        }
        public void databind()
        {
            GV_viewSupplier.DataSource = null;
            List<SupplierBL> list = BST.TreetoList();
            GV_viewSupplier.DataSource = list;
            GV_viewSupplier.Update();
            GV_viewSupplier.Refresh();

        }
        private void GV_viewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SupplierBL sup = (SupplierBL)GV_viewSupplier.CurrentRow.DataBoundItem;
            if (1 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BST.Remove(sup);
                }
                if (MessageBox.Show("Do you save in file?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<SupplierBL> list = BST.TreetoList();
                    BST.storeInFile("Supplier.csv", list);
                    MessageBox.Show("Store in File!!");

                }
                databind();
            }
            if (0 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to update?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_updateSupplier m = new form_updateSupplier(sup, new form_viewSupplier());
                    m.Show();
                    this.Close();

                }
                databind();
            }
        }
    }
}
