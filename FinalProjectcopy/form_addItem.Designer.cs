namespace FinalProject
{
    partial class form_addItem
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
            this.components = new System.ComponentModel.Container();
            this.tlp_addItem = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_addItem = new System.Windows.Forms.Panel();
            this.lbl_addItem = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.lbl_supplierId = new System.Windows.Forms.Label();
            this.txtBox_supplierId = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtBox_quantity = new System.Windows.Forms.TextBox();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.errortype = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPayment = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSupplier = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_addItem.SuspendLayout();
            this.pnl_addItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_addItem
            // 
            this.tlp_addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_addItem.ColumnCount = 7;
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51996F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.24923F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97091F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.215965F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.61493F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.61493F));
            this.tlp_addItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.814059F));
            this.tlp_addItem.Controls.Add(this.pnl_addItem, 0, 0);
            this.tlp_addItem.Controls.Add(this.lbl_type, 1, 1);
            this.tlp_addItem.Controls.Add(this.lbl_quantity, 1, 2);
            this.tlp_addItem.Controls.Add(this.cmb_type, 2, 1);
            this.tlp_addItem.Controls.Add(this.cmb_size, 5, 1);
            this.tlp_addItem.Controls.Add(this.lbl_size, 4, 1);
            this.tlp_addItem.Controls.Add(this.lbl_payment, 4, 2);
            this.tlp_addItem.Controls.Add(this.btn_cancle, 5, 5);
            this.tlp_addItem.Controls.Add(this.lbl_supplierId, 1, 3);
            this.tlp_addItem.Controls.Add(this.txtBox_supplierId, 2, 3);
            this.tlp_addItem.Controls.Add(this.btn_add, 1, 5);
            this.tlp_addItem.Controls.Add(this.txtBox_quantity, 2, 2);
            this.tlp_addItem.Controls.Add(this.cmb_payment, 5, 2);
            this.tlp_addItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_addItem.Location = new System.Drawing.Point(0, 0);
            this.tlp_addItem.Name = "tlp_addItem";
            this.tlp_addItem.RowCount = 7;
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.77F));
            this.tlp_addItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_addItem.Size = new System.Drawing.Size(659, 452);
            this.tlp_addItem.TabIndex = 1;
            // 
            // pnl_addItem
            // 
            this.pnl_addItem.BackColor = System.Drawing.Color.Silver;
            this.tlp_addItem.SetColumnSpan(this.pnl_addItem, 7);
            this.pnl_addItem.Controls.Add(this.lbl_addItem);
            this.pnl_addItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addItem.Location = new System.Drawing.Point(3, 3);
            this.pnl_addItem.Name = "pnl_addItem";
            this.pnl_addItem.Size = new System.Drawing.Size(653, 41);
            this.pnl_addItem.TabIndex = 1;
            // 
            // lbl_addItem
            // 
            this.lbl_addItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addItem.AutoSize = true;
            this.lbl_addItem.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_addItem.Location = new System.Drawing.Point(232, -1);
            this.lbl_addItem.Name = "lbl_addItem";
            this.lbl_addItem.Size = new System.Drawing.Size(171, 36);
            this.lbl_addItem.TabIndex = 3;
            this.lbl_addItem.Text = "ADD ITEM";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_type.Location = new System.Drawing.Point(72, 47);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(94, 35);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_quantity.Location = new System.Drawing.Point(72, 82);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(94, 35);
            this.lbl_quantity.TabIndex = 7;
            this.lbl_quantity.Text = "Quantity";
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
            this.cmb_type.Location = new System.Drawing.Point(172, 50);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(105, 21);
            this.cmb_type.TabIndex = 0;
            this.cmb_type.Text = "Type";
            this.cmb_type.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_type_Validating);
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
            this.cmb_size.Location = new System.Drawing.Point(466, 50);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(123, 21);
            this.cmb_size.TabIndex = 1;
            this.cmb_size.Text = "Size";
            this.cmb_size.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_size_Validating);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_size.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_size.Location = new System.Drawing.Point(337, 47);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(123, 35);
            this.lbl_size.TabIndex = 5;
            this.lbl_size.Text = "Size";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_payment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_payment.Location = new System.Drawing.Point(337, 82);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(123, 35);
            this.lbl_payment.TabIndex = 6;
            this.lbl_payment.Text = "Payment";
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(484, 379);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(87, 45);
            this.btn_cancle.TabIndex = 8;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // lbl_supplierId
            // 
            this.lbl_supplierId.AutoSize = true;
            this.lbl_supplierId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_supplierId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplierId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_supplierId.Location = new System.Drawing.Point(72, 117);
            this.lbl_supplierId.Name = "lbl_supplierId";
            this.lbl_supplierId.Size = new System.Drawing.Size(94, 35);
            this.lbl_supplierId.TabIndex = 4;
            this.lbl_supplierId.Text = "Supplier ID";
            // 
            // txtBox_supplierId
            // 
            this.txtBox_supplierId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_supplierId.Location = new System.Drawing.Point(172, 120);
            this.txtBox_supplierId.Name = "txtBox_supplierId";
            this.txtBox_supplierId.Size = new System.Drawing.Size(105, 20);
            this.txtBox_supplierId.TabIndex = 6;
            this.txtBox_supplierId.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_supplierId_Validating);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(76, 379);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 45);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtBox_quantity
            // 
            this.txtBox_quantity.Location = new System.Drawing.Point(172, 85);
            this.txtBox_quantity.Name = "txtBox_quantity";
            this.txtBox_quantity.Size = new System.Drawing.Size(105, 20);
            this.txtBox_quantity.TabIndex = 3;
            this.txtBox_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_quantity_Validating);
            // 
            // cmb_payment
            // 
            this.cmb_payment.FormattingEnabled = true;
            this.cmb_payment.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmb_payment.Location = new System.Drawing.Point(466, 85);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(123, 21);
            this.cmb_payment.TabIndex = 2;
            this.cmb_payment.Text = "Payment";
            this.cmb_payment.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_payment_Validating);
            // 
            // errortype
            // 
            this.errortype.ContainerControl = this;
            // 
            // errorSize
            // 
            this.errorSize.ContainerControl = this;
            // 
            // errorQuantity
            // 
            this.errorQuantity.ContainerControl = this;
            // 
            // errorPayment
            // 
            this.errorPayment.ContainerControl = this;
            // 
            // errorSupplier
            // 
            this.errorSupplier.ContainerControl = this;
            // 
            // form_addItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_addItem);
            this.Name = "form_addItem";
            this.Text = "Soft Drink distribution System";
            this.Load += new System.EventHandler(this.form_addItem_Load);
            this.tlp_addItem.ResumeLayout(false);
            this.tlp_addItem.PerformLayout();
            this.pnl_addItem.ResumeLayout(false);
            this.pnl_addItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_addItem;
        private System.Windows.Forms.Panel pnl_addItem;
        private System.Windows.Forms.Label lbl_addItem;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Label lbl_supplierId;
        private System.Windows.Forms.TextBox txtBox_supplierId;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtBox_quantity;
        private System.Windows.Forms.ComboBox cmb_payment;
        private System.Windows.Forms.ErrorProvider errortype;
        private System.Windows.Forms.ErrorProvider errorSize;
        private System.Windows.Forms.ErrorProvider errorQuantity;
        private System.Windows.Forms.ErrorProvider errorPayment;
        private System.Windows.Forms.ErrorProvider errorSupplier;
    }
}