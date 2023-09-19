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
    public partial class form_viewRider : Form
    {
        RiderDL BST=new RiderDL();
        VehicleDL bst = new VehicleDL();
        public form_viewRider()
        {
            InitializeComponent();
        }

        private void GV_viewRider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            RiderBL rider = (RiderBL)GV_viewRider.CurrentRow.DataBoundItem;
            VehcleBL vh = bst.search(rider.VehicleID);
            if (1== e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    BST.Remove(rider);
                   
                }
                if (MessageBox.Show("Do you save in file?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<RiderBL> list = BST.TreetoList();
                    BST.storeInFile("Rider.csv", list);
                    MessageBox.Show("Store in File!!");
                    VehcleBL v = new VehcleBL(vh.Number, false, vh.Fuel, vh.Id);
                    if (bst.Update(v))
                    {
                        List<VehcleBL> listv = bst.TreetoList();
                        bst.storeInFile("Vehicle.csv", listv);
                    }

                }
                databind();
            }
            if (0 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to update?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_updRider m = new form_updRider(rider, new form_viewRider());
                    m.Show();
                    this.Close();

                }
                databind();
            }
        }

        private void form_viewRider_Load(object sender, EventArgs e)
        {
            bst.read("Vehicle.csv");
            BST.read("Rider.csv");
            List<RiderBL> list = BST.TreetoList();
            GV_viewRider.DataSource = list;
        }
        public void databind()
        {
            GV_viewRider.DataSource = null;
            List<RiderBL> list = BST.TreetoList();
            GV_viewRider.DataSource = list;
            GV_viewRider.Update();
            GV_viewRider.Refresh();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_manager m = new form_manager();
            m.Show();
            this.Close();
        }
    }
}
