
namespace FinalProject
{
    partial class form_inventoryManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_inventoryManager));
            this.tlp_inventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_inventory = new System.Windows.Forms.Panel();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.btn_searchsupplier = new System.Windows.Forms.Button();
            this.btn_viewsupplier = new System.Windows.Forms.Button();
            this.btn_addsupplier = new System.Windows.Forms.Button();
            this.btn_addstock = new System.Windows.Forms.Button();
            this.btn_viewStock = new System.Windows.Forms.Button();
            this.btn_searchStock = new System.Windows.Forms.Button();
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tlp_inventory.SuspendLayout();
            this.pnl_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_inventory
            // 
            this.tlp_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_inventory.ColumnCount = 3;
            this.tlp_inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.112699F));
            this.tlp_inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.59066F));
            this.tlp_inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.29664F));
            this.tlp_inventory.Controls.Add(this.pnl_inventory, 0, 0);
            this.tlp_inventory.Controls.Add(this.btn_searchsupplier, 1, 3);
            this.tlp_inventory.Controls.Add(this.btn_viewsupplier, 1, 2);
            this.tlp_inventory.Controls.Add(this.btn_addsupplier, 1, 1);
            this.tlp_inventory.Controls.Add(this.btn_addstock, 1, 4);
            this.tlp_inventory.Controls.Add(this.btn_viewStock, 1, 5);
            this.tlp_inventory.Controls.Add(this.btn_searchStock, 1, 6);
            this.tlp_inventory.Controls.Add(this.btn_viewOrder, 1, 7);
            this.tlp_inventory.Controls.Add(this.btn_report, 1, 8);
            this.tlp_inventory.Controls.Add(this.btn_logout, 1, 9);
            this.tlp_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_inventory.Location = new System.Drawing.Point(0, 0);
            this.tlp_inventory.Name = "tlp_inventory";
            this.tlp_inventory.RowCount = 11;
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97F));
            this.tlp_inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_inventory.Size = new System.Drawing.Size(659, 452);
            this.tlp_inventory.TabIndex = 2;
            // 
            // pnl_inventory
            // 
            this.pnl_inventory.BackColor = System.Drawing.Color.Silver;
            this.pnl_inventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_inventory.SetColumnSpan(this.pnl_inventory, 3);
            this.pnl_inventory.Controls.Add(this.lbl_inventory);
            this.pnl_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_inventory.Location = new System.Drawing.Point(3, 3);
            this.pnl_inventory.Name = "pnl_inventory";
            this.pnl_inventory.Size = new System.Drawing.Size(653, 41);
            this.pnl_inventory.TabIndex = 1;
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventory.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_inventory.Location = new System.Drawing.Point(145, -1);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(361, 36);
            this.lbl_inventory.TabIndex = 2;
            this.lbl_inventory.Text = "INVENTORY MANAGER";
            // 
            // btn_searchsupplier
            // 
            this.btn_searchsupplier.BackColor = System.Drawing.Color.Silver;
            this.btn_searchsupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchsupplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchsupplier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_searchsupplier.Location = new System.Drawing.Point(36, 124);
            this.btn_searchsupplier.Name = "btn_searchsupplier";
            this.btn_searchsupplier.Size = new System.Drawing.Size(123, 31);
            this.btn_searchsupplier.TabIndex = 10;
            this.btn_searchsupplier.Text = "Search Supplier";
            this.btn_searchsupplier.UseVisualStyleBackColor = false;
            this.btn_searchsupplier.Click += new System.EventHandler(this.btn_searchsupplier_Click);
            // 
            // btn_viewsupplier
            // 
            this.btn_viewsupplier.BackColor = System.Drawing.Color.Silver;
            this.btn_viewsupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewsupplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewsupplier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewsupplier.Location = new System.Drawing.Point(36, 87);
            this.btn_viewsupplier.Name = "btn_viewsupplier";
            this.btn_viewsupplier.Size = new System.Drawing.Size(123, 31);
            this.btn_viewsupplier.TabIndex = 9;
            this.btn_viewsupplier.Text = "View Supplier";
            this.btn_viewsupplier.UseVisualStyleBackColor = false;
            this.btn_viewsupplier.Click += new System.EventHandler(this.btn_viewsupplier_Click);
            // 
            // btn_addsupplier
            // 
            this.btn_addsupplier.BackColor = System.Drawing.Color.Silver;
            this.btn_addsupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addsupplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsupplier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addsupplier.Location = new System.Drawing.Point(36, 50);
            this.btn_addsupplier.Name = "btn_addsupplier";
            this.btn_addsupplier.Size = new System.Drawing.Size(123, 31);
            this.btn_addsupplier.TabIndex = 11;
            this.btn_addsupplier.Text = "Add Supplier";
            this.btn_addsupplier.UseVisualStyleBackColor = false;
            this.btn_addsupplier.Click += new System.EventHandler(this.btn_addsupplier_Click);
            // 
            // btn_addstock
            // 
            this.btn_addstock.BackColor = System.Drawing.Color.Silver;
            this.btn_addstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addstock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addstock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addstock.Location = new System.Drawing.Point(36, 161);
            this.btn_addstock.Name = "btn_addstock";
            this.btn_addstock.Size = new System.Drawing.Size(123, 31);
            this.btn_addstock.TabIndex = 12;
            this.btn_addstock.Text = "Add Stock";
            this.btn_addstock.UseVisualStyleBackColor = false;
            this.btn_addstock.Click += new System.EventHandler(this.btn_addstock_Click);
            // 
            // btn_viewStock
            // 
            this.btn_viewStock.BackColor = System.Drawing.Color.Silver;
            this.btn_viewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewStock.Location = new System.Drawing.Point(36, 198);
            this.btn_viewStock.Name = "btn_viewStock";
            this.btn_viewStock.Size = new System.Drawing.Size(123, 31);
            this.btn_viewStock.TabIndex = 13;
            this.btn_viewStock.Text = "Extract Stock";
            this.btn_viewStock.UseVisualStyleBackColor = false;
            this.btn_viewStock.Click += new System.EventHandler(this.btn_viewStock_Click);
            // 
            // btn_searchStock
            // 
            this.btn_searchStock.BackColor = System.Drawing.Color.Silver;
            this.btn_searchStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_searchStock.Location = new System.Drawing.Point(36, 235);
            this.btn_searchStock.Name = "btn_searchStock";
            this.btn_searchStock.Size = new System.Drawing.Size(123, 31);
            this.btn_searchStock.TabIndex = 14;
            this.btn_searchStock.Text = "View Stock";
            this.btn_searchStock.UseVisualStyleBackColor = false;
            this.btn_searchStock.Click += new System.EventHandler(this.btn_searchStock_Click);
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.BackColor = System.Drawing.Color.Silver;
            this.btn_viewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewOrder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewOrder.Location = new System.Drawing.Point(36, 272);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(123, 31);
            this.btn_viewOrder.TabIndex = 15;
            this.btn_viewOrder.Text = "View Order";
            this.btn_viewOrder.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Silver;
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_report.Location = new System.Drawing.Point(36, 309);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(123, 31);
            this.btn_report.TabIndex = 16;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(36, 382);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(123, 39);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "    LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // form_inventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_inventory);
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_inventoryManager";
            this.Text = "form_inventoryManager";
            this.tlp_inventory.ResumeLayout(false);
            this.pnl_inventory.ResumeLayout(false);
            this.pnl_inventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_inventory;
        private System.Windows.Forms.Panel pnl_inventory;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Button btn_searchsupplier;
        private System.Windows.Forms.Button btn_viewsupplier;
        private System.Windows.Forms.Button btn_addsupplier;
        private System.Windows.Forms.Button btn_addstock;
        private System.Windows.Forms.Button btn_viewStock;
        private System.Windows.Forms.Button btn_searchStock;
        private System.Windows.Forms.Button btn_viewOrder;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_logout;
    }
}