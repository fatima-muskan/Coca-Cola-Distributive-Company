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
    public partial class form_viewShopkeeper : Form
    {
        ShopkeeperDL BST = new ShopkeeperDL();
        public form_viewShopkeeper()
        {
            InitializeComponent();
        }

        private void form_viewShopkeeper_Load(object sender, EventArgs e)
        {
            BST.read("Shopkeeper.csv");
            List<ShopkeeperBL> list = BST.TreetoList();
            GV_viewshopkeeper.DataSource = list;
        }
        public void databind()
        {
            GV_viewshopkeeper.DataSource = null;
            List<ShopkeeperBL> list = BST.TreetoList();
            GV_viewshopkeeper.DataSource = list;
            GV_viewshopkeeper.Update();
            GV_viewshopkeeper.Refresh();

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_salesManager m = new form_salesManager();
            m.Show();
            this.Hide();
        }

        private void GV_viewshopkeeper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ShopkeeperBL shop = (ShopkeeperBL)GV_viewshopkeeper.CurrentRow.DataBoundItem;
            if (1 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BST.Remove(shop);
                }
                if (MessageBox.Show("Do you save in file?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<ShopkeeperBL> list = BST.TreetoList();
                    BST.storeInFile("Shopkeeper.csv", list);
                    MessageBox.Show("Store in File!!");

                }
                databind();
            }
            if (0 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to update?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_updateShopkeeper m = new form_updateShopkeeper(shop, new form_viewShopkeeper());
                    m.Show();
                    this.Close();

                }
                databind();
            }
        }
    }
}
