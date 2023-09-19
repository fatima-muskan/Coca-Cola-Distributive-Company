namespace FinalProject
{
    partial class form_collectOrder
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
            this.tlp_collect = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_collect = new System.Windows.Forms.Panel();
            this.lbl_collect = new System.Windows.Forms.Label();
            this.lbl_shopkeeperID = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txtBox_quantity = new System.Windows.Forms.TextBox();
            this.txtBox_shopkeeperID = new System.Windows.Forms.TextBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tlp_collect.SuspendLayout();
            this.pnl_collect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_collect
            // 
            this.tlp_collect.ColumnCount = 7;
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.657006F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65383F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20048F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.977372F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65383F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20048F));
            this.tlp_collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.657006F));
            this.tlp_collect.Controls.Add(this.pnl_collect, 0, 0);
            this.tlp_collect.Controls.Add(this.lbl_shopkeeperID, 1, 1);
            this.tlp_collect.Controls.Add(this.lbl_type, 1, 2);
            this.tlp_collect.Controls.Add(this.lbl_size, 4, 1);
            this.tlp_collect.Controls.Add(this.lbl_quantity, 4, 2);
            this.tlp_collect.Controls.Add(this.txtBox_quantity, 5, 2);
            this.tlp_collect.Controls.Add(this.txtBox_shopkeeperID, 2, 1);
            this.tlp_collect.Controls.Add(this.cmb_size, 5, 1);
            this.tlp_collect.Controls.Add(this.cmb_type, 2, 2);
            this.tlp_collect.Controls.Add(this.dataGridView1, 0, 4);
            this.tlp_collect.Controls.Add(this.btn_send, 1, 5);
            this.tlp_collect.Controls.Add(this.btn_save, 5, 5);
            this.tlp_collect.Controls.Add(this.btn_add, 5, 3);
            this.tlp_collect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_collect.Location = new System.Drawing.Point(0, 0);
            this.tlp_collect.Name = "tlp_collect";
            this.tlp_collect.RowCount = 7;
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.75F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this.tlp_collect.Size = new System.Drawing.Size(659, 452);
            this.tlp_collect.TabIndex = 1;
            // 
            // pnl_collect
            // 
            this.pnl_collect.BackColor = System.Drawing.Color.Silver;
            this.tlp_collect.SetColumnSpan(this.pnl_collect, 7);
            this.pnl_collect.Controls.Add(this.lbl_collect);
            this.pnl_collect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_collect.Location = new System.Drawing.Point(3, 3);
            this.pnl_collect.Name = "pnl_collect";
            this.pnl_collect.Size = new System.Drawing.Size(653, 41);
            this.pnl_collect.TabIndex = 0;
            // 
            // lbl_collect
            // 
            this.lbl_collect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_collect.AutoSize = true;
            this.lbl_collect.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_collect.Location = new System.Drawing.Point(165, 4);
            this.lbl_collect.Name = "lbl_collect";
            this.lbl_collect.Size = new System.Drawing.Size(278, 36);
            this.lbl_collect.TabIndex = 3;
            this.lbl_collect.Text = "COLLECT ORDER";
            // 
            // lbl_shopkeeperID
            // 
            this.lbl_shopkeeperID.AutoSize = true;
            this.lbl_shopkeeperID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_shopkeeperID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shopkeeperID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_shopkeeperID.Location = new System.Drawing.Point(40, 47);
            this.lbl_shopkeeperID.Name = "lbl_shopkeeperID";
            this.lbl_shopkeeperID.Size = new System.Drawing.Size(77, 37);
            this.lbl_shopkeeperID.TabIndex = 3;
            this.lbl_shopkeeperID.Text = "Shopkeeper ID";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_type.Location = new System.Drawing.Point(40, 84);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(77, 37);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Type";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_size.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_size.Location = new System.Drawing.Point(341, 47);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(77, 37);
            this.lbl_size.TabIndex = 5;
            this.lbl_size.Text = "Size";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_quantity.Location = new System.Drawing.Point(341, 84);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(77, 37);
            this.lbl_quantity.TabIndex = 6;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txtBox_quantity
            // 
            this.txtBox_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_quantity.Location = new System.Drawing.Point(424, 87);
            this.txtBox_quantity.Name = "txtBox_quantity";
            this.txtBox_quantity.Size = new System.Drawing.Size(193, 20);
            this.txtBox_quantity.TabIndex = 4;
            // 
            // txtBox_shopkeeperID
            // 
            this.txtBox_shopkeeperID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_shopkeeperID.Location = new System.Drawing.Point(123, 50);
            this.txtBox_shopkeeperID.Name = "txtBox_shopkeeperID";
            this.txtBox_shopkeeperID.Size = new System.Drawing.Size(193, 20);
            this.txtBox_shopkeeperID.TabIndex = 0;
            // 
            // cmb_size
            // 
            this.cmb_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Items.AddRange(new object[] {
            "300",
            "750",
            "1000",
            "1500",
            "2500"});
            this.cmb_size.Location = new System.Drawing.Point(424, 50);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(193, 21);
            this.cmb_size.TabIndex = 2;
            // 
            // cmb_type
            // 
            this.cmb_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Fanta",
            "Coke",
            "Marinda",
            "Sprite",
            "7 up",
            "Pepsi",
            "Coca Cola"});
            this.cmb_type.Location = new System.Drawing.Point(123, 87);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(193, 21);
            this.cmb_type.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_collect.SetColumnSpan(this.dataGridView1, 7);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 245);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_send.BackColor = System.Drawing.Color.Silver;
            this.btn_send.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(40, 412);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(77, 31);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send Email";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.Silver;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(485, 412);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(71, 31);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(485, 124);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 31);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // form_collectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_collect);
            this.Name = "form_collectOrder";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_collectOrder_Load);
            this.tlp_collect.ResumeLayout(false);
            this.tlp_collect.PerformLayout();
            this.pnl_collect.ResumeLayout(false);
            this.pnl_collect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_collect;
        private System.Windows.Forms.Panel pnl_collect;
        private System.Windows.Forms.Label lbl_collect;
        private System.Windows.Forms.Label lbl_shopkeeperID;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txtBox_quantity;
        private System.Windows.Forms.TextBox txtBox_shopkeeperID;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
    }
}