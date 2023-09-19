
namespace FinalProject
{
    partial class form_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manager));
            this.tlp_manager = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_manager = new System.Windows.Forms.Panel();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.btn_searchemp = new System.Windows.Forms.Button();
            this.btn_viewemp = new System.Windows.Forms.Button();
            this.btn_addemp = new System.Windows.Forms.Button();
            this.btn_addRider = new System.Windows.Forms.Button();
            this.btn_viewRider = new System.Windows.Forms.Button();
            this.btn_searchRider = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tlp_manager.SuspendLayout();
            this.pnl_manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_manager
            // 
            this.tlp_manager.ColumnCount = 3;
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.112699F));
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.59066F));
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.29664F));
            this.tlp_manager.Controls.Add(this.pnl_manager, 0, 0);
            this.tlp_manager.Controls.Add(this.btn_searchemp, 1, 3);
            this.tlp_manager.Controls.Add(this.btn_viewemp, 1, 2);
            this.tlp_manager.Controls.Add(this.btn_addemp, 1, 1);
            this.tlp_manager.Controls.Add(this.btn_addRider, 1, 4);
            this.tlp_manager.Controls.Add(this.btn_viewRider, 1, 5);
            this.tlp_manager.Controls.Add(this.btn_searchRider, 1, 6);
            this.tlp_manager.Controls.Add(this.btn_logout, 1, 8);
            this.tlp_manager.Controls.Add(this.btn_report, 1, 7);
            this.tlp_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_manager.Location = new System.Drawing.Point(0, 0);
            this.tlp_manager.Name = "tlp_manager";
            this.tlp_manager.RowCount = 10;
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.29F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_manager.Size = new System.Drawing.Size(659, 452);
            this.tlp_manager.TabIndex = 1;
            // 
            // pnl_manager
            // 
            this.pnl_manager.BackColor = System.Drawing.Color.Silver;
            this.pnl_manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_manager.SetColumnSpan(this.pnl_manager, 3);
            this.pnl_manager.Controls.Add(this.lbl_manager);
            this.pnl_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_manager.Location = new System.Drawing.Point(3, 3);
            this.pnl_manager.Name = "pnl_manager";
            this.pnl_manager.Size = new System.Drawing.Size(653, 41);
            this.pnl_manager.TabIndex = 1;
            // 
            // lbl_manager
            // 
            this.lbl_manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manager.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_manager.Location = new System.Drawing.Point(233, -5);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(173, 36);
            this.lbl_manager.TabIndex = 2;
            this.lbl_manager.Text = "MANAGER";
            // 
            // btn_searchemp
            // 
            this.btn_searchemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchemp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchemp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_searchemp.Location = new System.Drawing.Point(36, 124);
            this.btn_searchemp.Name = "btn_searchemp";
            this.btn_searchemp.Size = new System.Drawing.Size(123, 31);
            this.btn_searchemp.TabIndex = 10;
            this.btn_searchemp.Text = "Search Employee";
            this.btn_searchemp.UseVisualStyleBackColor = true;
            this.btn_searchemp.Click += new System.EventHandler(this.btn_searchemp_Click);
            // 
            // btn_viewemp
            // 
            this.btn_viewemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewemp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewemp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewemp.Location = new System.Drawing.Point(36, 87);
            this.btn_viewemp.Name = "btn_viewemp";
            this.btn_viewemp.Size = new System.Drawing.Size(123, 31);
            this.btn_viewemp.TabIndex = 9;
            this.btn_viewemp.Text = "View Employee";
            this.btn_viewemp.UseVisualStyleBackColor = true;
            this.btn_viewemp.Click += new System.EventHandler(this.btn_viewemp_Click_1);
            // 
            // btn_addemp
            // 
            this.btn_addemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addemp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addemp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addemp.Location = new System.Drawing.Point(36, 50);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(123, 31);
            this.btn_addemp.TabIndex = 11;
            this.btn_addemp.Text = "Add Employee";
            this.btn_addemp.UseVisualStyleBackColor = true;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click_1);
            // 
            // btn_addRider
            // 
            this.btn_addRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addRider.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRider.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addRider.Location = new System.Drawing.Point(36, 161);
            this.btn_addRider.Name = "btn_addRider";
            this.btn_addRider.Size = new System.Drawing.Size(123, 31);
            this.btn_addRider.TabIndex = 12;
            this.btn_addRider.Text = "Add Rider";
            this.btn_addRider.UseVisualStyleBackColor = true;
            this.btn_addRider.Click += new System.EventHandler(this.btn_addRider_Click);
            // 
            // btn_viewRider
            // 
            this.btn_viewRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewRider.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewRider.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewRider.Location = new System.Drawing.Point(36, 198);
            this.btn_viewRider.Name = "btn_viewRider";
            this.btn_viewRider.Size = new System.Drawing.Size(123, 31);
            this.btn_viewRider.TabIndex = 13;
            this.btn_viewRider.Text = "View Rider";
            this.btn_viewRider.UseVisualStyleBackColor = true;
            this.btn_viewRider.Click += new System.EventHandler(this.btn_viewRider_Click);
            // 
            // btn_searchRider
            // 
            this.btn_searchRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchRider.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchRider.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_searchRider.Location = new System.Drawing.Point(36, 235);
            this.btn_searchRider.Name = "btn_searchRider";
            this.btn_searchRider.Size = new System.Drawing.Size(123, 31);
            this.btn_searchRider.TabIndex = 14;
            this.btn_searchRider.Text = "Search Rider";
            this.btn_searchRider.UseVisualStyleBackColor = true;
            this.btn_searchRider.Click += new System.EventHandler(this.btn_searchRider_Click);
            // 
            // btn_report
            // 
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_report.Location = new System.Drawing.Point(36, 272);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(123, 31);
            this.btn_report.TabIndex = 15;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = true;
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
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "    LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_manager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_manager";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_manager_Load);
            this.tlp_manager.ResumeLayout(false);
            this.pnl_manager.ResumeLayout(false);
            this.pnl_manager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_manager;
        private System.Windows.Forms.Panel pnl_manager;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_viewemp;
        private System.Windows.Forms.Button btn_searchemp;
        private System.Windows.Forms.Button btn_addemp;
        private System.Windows.Forms.Button btn_addRider;
        private System.Windows.Forms.Button btn_viewRider;
        private System.Windows.Forms.Button btn_searchRider;
        private System.Windows.Forms.Button btn_report;
    }
}