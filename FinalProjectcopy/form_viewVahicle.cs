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
    public partial class form_viewVahicle : Form
    {
        VehicleDL BST = new VehicleDL();
        public form_viewVahicle()
        {
            InitializeComponent();
        }

        private void form_viewVahicle_Load(object sender, EventArgs e)
        {
            BST.read("Vehicle.csv");
            List<VehcleBL> list = BST.TreetoList();
            GV_viewVahicle.DataSource = list;
        }
        public void databind()
        {
            GV_viewVahicle.DataSource = null;
            List<VehcleBL> list = BST.TreetoList();
            GV_viewVahicle.DataSource = list;
            GV_viewVahicle.Update();
            GV_viewVahicle.Refresh();

        }
        private void GV_viewVahicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            VehcleBL vh = (VehcleBL)GV_viewVahicle.CurrentRow.DataBoundItem;
            if (1 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BST.Remove(vh);
                }
                if (MessageBox.Show("Do you save in file?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<VehcleBL> list = BST.TreetoList();
                    BST.storeInFile("Vehcile.csv", list);
                    MessageBox.Show("Store in File!!");

                }
                databind();
            }
            if (0 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to update?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_updateVahicle m = new form_updateVahicle(vh, new form_viewVahicle());
                    m.Show();
                    this.Close();

                }
                databind();
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
