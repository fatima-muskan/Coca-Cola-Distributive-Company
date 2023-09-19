namespace FinalProject
{
    partial class form_placeOrder
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
            this.tlp_placeOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_shopkeeperID = new System.Windows.Forms.Label();
            this.pnl_placeOrder = new System.Windows.Forms.Panel();
            this.lbl_placeOrder = new System.Windows.Forms.Label();
            this.txtBox_shopkeeperID = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.btn_place = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.tlp_placeOrder.SuspendLayout();
            this.pnl_placeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_placeOrder
            // 
            this.tlp_placeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_placeOrder.ColumnCount = 3;
            this.tlp_placeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8786F));
            this.tlp_placeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40668F));
            this.tlp_placeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56297F));
            this.tlp_placeOrder.Controls.Add(this.lbl_shopkeeperID, 0, 1);
            this.tlp_placeOrder.Controls.Add(this.pnl_placeOrder, 0, 0);
            this.tlp_placeOrder.Controls.Add(this.txtBox_shopkeeperID, 1, 1);
            this.tlp_placeOrder.Controls.Add(this.lbl_details, 0, 2);
            this.tlp_placeOrder.Controls.Add(this.btn_place, 0, 3);
            this.tlp_placeOrder.Controls.Add(this.btn_cancle, 2, 3);
            this.tlp_placeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_placeOrder.Location = new System.Drawing.Point(0, 0);
            this.tlp_placeOrder.Name = "tlp_placeOrder";
            this.tlp_placeOrder.RowCount = 4;
            this.tlp_placeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27558F));
            this.tlp_placeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.9292F));
            this.tlp_placeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.44248F));
            this.tlp_placeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.67257F));
            this.tlp_placeOrder.Size = new System.Drawing.Size(659, 452);
            this.tlp_placeOrder.TabIndex = 2;
            // 
            // lbl_shopkeeperID
            // 
            this.lbl_shopkeeperID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_shopkeeperID.AutoSize = true;
            this.lbl_shopkeeperID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shopkeeperID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_shopkeeperID.Location = new System.Drawing.Point(5, 71);
            this.lbl_shopkeeperID.Name = "lbl_shopkeeperID";
            this.lbl_shopkeeperID.Size = new System.Drawing.Size(123, 21);
            this.lbl_shopkeeperID.TabIndex = 2;
            this.lbl_shopkeeperID.Text = "Shopkeeper ID";
            // 
            // pnl_placeOrder
            // 
            this.pnl_placeOrder.BackColor = System.Drawing.Color.Silver;
            this.tlp_placeOrder.SetColumnSpan(this.pnl_placeOrder, 3);
            this.pnl_placeOrder.Controls.Add(this.lbl_placeOrder);
            this.pnl_placeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_placeOrder.Location = new System.Drawing.Point(3, 3);
            this.pnl_placeOrder.Name = "pnl_placeOrder";
            this.pnl_placeOrder.Size = new System.Drawing.Size(653, 40);
            this.pnl_placeOrder.TabIndex = 0;
            // 
            // lbl_placeOrder
            // 
            this.lbl_placeOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_placeOrder.AutoSize = true;
            this.lbl_placeOrder.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeOrder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_placeOrder.Location = new System.Drawing.Point(209, 0);
            this.lbl_placeOrder.Name = "lbl_placeOrder";
            this.lbl_placeOrder.Size = new System.Drawing.Size(235, 36);
            this.lbl_placeOrder.TabIndex = 3;
            this.lbl_placeOrder.Text = "PLACE ORDER";
            // 
            // txtBox_shopkeeperID
            // 
            this.txtBox_shopkeeperID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_shopkeeperID.Location = new System.Drawing.Point(134, 71);
            this.txtBox_shopkeeperID.Name = "txtBox_shopkeeperID";
            this.txtBox_shopkeeperID.Size = new System.Drawing.Size(313, 20);
            this.txtBox_shopkeeperID.TabIndex = 0;
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.BackColor = System.Drawing.Color.Silver;
            this.tlp_placeOrder.SetColumnSpan(this.lbl_details, 3);
            this.lbl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_details.Location = new System.Drawing.Point(3, 117);
            this.lbl_details.MinimumSize = new System.Drawing.Size(200, 200);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(653, 227);
            this.lbl_details.TabIndex = 1;
            // 
            // btn_place
            // 
            this.btn_place.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_place.BackColor = System.Drawing.Color.Silver;
            this.btn_place.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_place.Location = new System.Drawing.Point(28, 404);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(75, 45);
            this.btn_place.TabIndex = 2;
            this.btn_place.Text = "PLACE";
            this.btn_place.UseVisualStyleBackColor = false;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(517, 404);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 45);
            this.btn_cancle.TabIndex = 3;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            // 
            // form_placeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_placeOrder);
            this.Name = "form_placeOrder";
            this.Text = "Soft Drink Distribution System";
            this.tlp_placeOrder.ResumeLayout(false);
            this.tlp_placeOrder.PerformLayout();
            this.pnl_placeOrder.ResumeLayout(false);
            this.pnl_placeOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_placeOrder;
        private System.Windows.Forms.Label lbl_shopkeeperID;
        private System.Windows.Forms.Panel pnl_placeOrder;
        private System.Windows.Forms.Label lbl_placeOrder;
        private System.Windows.Forms.TextBox txtBox_shopkeeperID;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Button btn_place;
        private System.Windows.Forms.Button btn_cancle;
    }
}