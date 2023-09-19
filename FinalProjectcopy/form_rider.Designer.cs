namespace FinalProject
{
    partial class form_rider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rider));
            this.tlp_rider = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_rider = new System.Windows.Forms.Panel();
            this.lbl_rider = new System.Windows.Forms.Label();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_collectOrder = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tlp_rider.SuspendLayout();
            this.pnl_rider.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_rider
            // 
            this.tlp_rider.ColumnCount = 3;
            this.tlp_rider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.112699F));
            this.tlp_rider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.59066F));
            this.tlp_rider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.29664F));
            this.tlp_rider.Controls.Add(this.pnl_rider, 0, 0);
            this.tlp_rider.Controls.Add(this.btn_placeOrder, 1, 2);
            this.tlp_rider.Controls.Add(this.btn_collectOrder, 1, 1);
            this.tlp_rider.Controls.Add(this.btn_logout, 1, 8);
            this.tlp_rider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_rider.Location = new System.Drawing.Point(0, 0);
            this.tlp_rider.Name = "tlp_rider";
            this.tlp_rider.RowCount = 10;
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.29F));
            this.tlp_rider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_rider.Size = new System.Drawing.Size(659, 452);
            this.tlp_rider.TabIndex = 2;
            // 
            // pnl_rider
            // 
            this.pnl_rider.BackColor = System.Drawing.Color.Silver;
            this.pnl_rider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_rider.SetColumnSpan(this.pnl_rider, 3);
            this.pnl_rider.Controls.Add(this.lbl_rider);
            this.pnl_rider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_rider.Location = new System.Drawing.Point(3, 3);
            this.pnl_rider.Name = "pnl_rider";
            this.pnl_rider.Size = new System.Drawing.Size(653, 41);
            this.pnl_rider.TabIndex = 1;
            // 
            // lbl_rider
            // 
            this.lbl_rider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_rider.AutoSize = true;
            this.lbl_rider.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rider.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_rider.Location = new System.Drawing.Point(233, -5);
            this.lbl_rider.Name = "lbl_rider";
            this.lbl_rider.Size = new System.Drawing.Size(113, 36);
            this.lbl_rider.TabIndex = 2;
            this.lbl_rider.Text = "RIDER";
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_placeOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_placeOrder.Location = new System.Drawing.Point(36, 87);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(123, 31);
            this.btn_placeOrder.TabIndex = 9;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // btn_collectOrder
            // 
            this.btn_collectOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_collectOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_collectOrder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_collectOrder.Location = new System.Drawing.Point(36, 50);
            this.btn_collectOrder.Name = "btn_collectOrder";
            this.btn_collectOrder.Size = new System.Drawing.Size(123, 31);
            this.btn_collectOrder.TabIndex = 11;
            this.btn_collectOrder.Text = "Collect Order";
            this.btn_collectOrder.UseVisualStyleBackColor = true;
            this.btn_collectOrder.Click += new System.EventHandler(this.btn_collectOrder_Click);
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
            // form_rider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_rider);
            this.Name = "form_rider";
            this.Text = "form_rider";
            this.tlp_rider.ResumeLayout(false);
            this.pnl_rider.ResumeLayout(false);
            this.pnl_rider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_rider;
        private System.Windows.Forms.Panel pnl_rider;
        private System.Windows.Forms.Label lbl_rider;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_collectOrder;
        private System.Windows.Forms.Button btn_logout;
    }
}