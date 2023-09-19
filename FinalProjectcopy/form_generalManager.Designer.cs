
namespace FinalProject
{
    partial class form_generalManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_generalManager));
            this.tlp_manager = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_general = new System.Windows.Forms.Panel();
            this.lbl_general = new System.Windows.Forms.Label();
            this.btn_issuepayment = new System.Windows.Forms.Button();
            this.btn_acceptpayment = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tlp_manager.SuspendLayout();
            this.pnl_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_manager
            // 
            this.tlp_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_manager.ColumnCount = 3;
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.112699F));
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.59066F));
            this.tlp_manager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.29664F));
            this.tlp_manager.Controls.Add(this.pnl_general, 0, 0);
            this.tlp_manager.Controls.Add(this.btn_issuepayment, 1, 1);
            this.tlp_manager.Controls.Add(this.btn_acceptpayment, 1, 2);
            this.tlp_manager.Controls.Add(this.btn_report, 1, 3);
            this.tlp_manager.Controls.Add(this.btn_logout, 1, 4);
            this.tlp_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_manager.Location = new System.Drawing.Point(0, 0);
            this.tlp_manager.Name = "tlp_manager";
            this.tlp_manager.RowCount = 6;
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.57F));
            this.tlp_manager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_manager.Size = new System.Drawing.Size(659, 452);
            this.tlp_manager.TabIndex = 2;
            // 
            // pnl_general
            // 
            this.pnl_general.BackColor = System.Drawing.Color.Silver;
            this.pnl_general.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_manager.SetColumnSpan(this.pnl_general, 3);
            this.pnl_general.Controls.Add(this.lbl_general);
            this.pnl_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_general.Location = new System.Drawing.Point(3, 3);
            this.pnl_general.Name = "pnl_general";
            this.pnl_general.Size = new System.Drawing.Size(653, 41);
            this.pnl_general.TabIndex = 1;
            // 
            // lbl_general
            // 
            this.lbl_general.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_general.AutoSize = true;
            this.lbl_general.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_general.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_general.Location = new System.Drawing.Point(160, -1);
            this.lbl_general.Name = "lbl_general";
            this.lbl_general.Size = new System.Drawing.Size(330, 36);
            this.lbl_general.TabIndex = 2;
            this.lbl_general.Text = "GENERAL MANAGER";
            // 
            // btn_issuepayment
            // 
            this.btn_issuepayment.BackColor = System.Drawing.Color.Silver;
            this.btn_issuepayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_issuepayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issuepayment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_issuepayment.Location = new System.Drawing.Point(36, 50);
            this.btn_issuepayment.Name = "btn_issuepayment";
            this.btn_issuepayment.Size = new System.Drawing.Size(123, 31);
            this.btn_issuepayment.TabIndex = 6;
            this.btn_issuepayment.Text = "Issue Payment";
            this.btn_issuepayment.UseVisualStyleBackColor = false;
            // 
            // btn_acceptpayment
            // 
            this.btn_acceptpayment.BackColor = System.Drawing.Color.Silver;
            this.btn_acceptpayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_acceptpayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceptpayment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_acceptpayment.Location = new System.Drawing.Point(36, 87);
            this.btn_acceptpayment.Name = "btn_acceptpayment";
            this.btn_acceptpayment.Size = new System.Drawing.Size(123, 31);
            this.btn_acceptpayment.TabIndex = 7;
            this.btn_acceptpayment.Text = "Accept Payment";
            this.btn_acceptpayment.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Silver;
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_report.Location = new System.Drawing.Point(36, 124);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(123, 31);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(36, 385);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(123, 39);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "    LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // form_generalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_manager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_generalManager";
            this.Text = "Soft Drink Management System";
            this.tlp_manager.ResumeLayout(false);
            this.pnl_general.ResumeLayout(false);
            this.pnl_general.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_manager;
        private System.Windows.Forms.Panel pnl_general;
        private System.Windows.Forms.Label lbl_general;
        private System.Windows.Forms.Button btn_issuepayment;
        private System.Windows.Forms.Button btn_acceptpayment;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_logout;
    }
}