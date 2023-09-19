namespace FinalProject
{
    partial class form_extractItem
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
            this.tlp_extract = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_extract = new System.Windows.Forms.Panel();
            this.lbl_extract = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txtBox_quantity = new System.Windows.Forms.TextBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.errorType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_extract = new System.Windows.Forms.Button();
            this.tlp_extract.SuspendLayout();
            this.pnl_extract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_extract
            // 
            this.tlp_extract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_extract.ColumnCount = 5;
            this.tlp_extract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.56266F));
            this.tlp_extract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90628F));
            this.tlp_extract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4437972F));
            this.tlp_extract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.53431F));
            this.tlp_extract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.55295F));
            this.tlp_extract.Controls.Add(this.pnl_extract, 0, 0);
            this.tlp_extract.Controls.Add(this.lbl_type, 1, 1);
            this.tlp_extract.Controls.Add(this.lbl_size, 1, 2);
            this.tlp_extract.Controls.Add(this.lbl_quantity, 1, 3);
            this.tlp_extract.Controls.Add(this.btn_extract, 1, 4);
            this.tlp_extract.Controls.Add(this.btn_cancel, 3, 4);
            this.tlp_extract.Controls.Add(this.cmb_type, 3, 1);
            this.tlp_extract.Controls.Add(this.txtBox_quantity, 3, 3);
            this.tlp_extract.Controls.Add(this.cmb_size, 3, 2);
            this.tlp_extract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_extract.Location = new System.Drawing.Point(0, 0);
            this.tlp_extract.Name = "tlp_extract";
            this.tlp_extract.RowCount = 6;
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.57F));
            this.tlp_extract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_extract.Size = new System.Drawing.Size(659, 452);
            this.tlp_extract.TabIndex = 1;
            // 
            // pnl_extract
            // 
            this.pnl_extract.BackColor = System.Drawing.Color.Silver;
            this.tlp_extract.SetColumnSpan(this.pnl_extract, 5);
            this.pnl_extract.Controls.Add(this.lbl_extract);
            this.pnl_extract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_extract.Location = new System.Drawing.Point(3, 3);
            this.pnl_extract.Name = "pnl_extract";
            this.pnl_extract.Size = new System.Drawing.Size(653, 41);
            this.pnl_extract.TabIndex = 0;
            // 
            // lbl_extract
            // 
            this.lbl_extract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_extract.AutoSize = true;
            this.lbl_extract.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extract.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_extract.Location = new System.Drawing.Point(174, -1);
            this.lbl_extract.Name = "lbl_extract";
            this.lbl_extract.Size = new System.Drawing.Size(249, 36);
            this.lbl_extract.TabIndex = 4;
            this.lbl_extract.Text = "EXTRACT ITEM";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_type.Location = new System.Drawing.Point(131, 47);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(131, 37);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_size.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_size.Location = new System.Drawing.Point(131, 84);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(131, 37);
            this.lbl_size.TabIndex = 4;
            this.lbl_size.Text = "Size";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_quantity.Location = new System.Drawing.Point(131, 121);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(131, 37);
            this.lbl_quantity.TabIndex = 5;
            this.lbl_quantity.Text = "Quantity";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(447, 393);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 31);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.cmb_type.Location = new System.Drawing.Point(270, 50);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(254, 21);
            this.cmb_type.TabIndex = 10;
            this.cmb_type.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_type_Validating);
            // 
            // txtBox_quantity
            // 
            this.txtBox_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_quantity.Location = new System.Drawing.Point(270, 124);
            this.txtBox_quantity.Name = "txtBox_quantity";
            this.txtBox_quantity.Size = new System.Drawing.Size(254, 20);
            this.txtBox_quantity.TabIndex = 11;
            this.txtBox_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_quantity_Validating);
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
            this.cmb_size.Location = new System.Drawing.Point(270, 87);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(254, 21);
            this.cmb_size.TabIndex = 12;
            this.cmb_size.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_size_Validating);
            // 
            // errorType
            // 
            this.errorType.ContainerControl = this;
            // 
            // errorSize
            // 
            this.errorSize.ContainerControl = this;
            // 
            // errorQuantity
            // 
            this.errorQuantity.ContainerControl = this;
            // 
            // btn_extract
            // 
            this.btn_extract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_extract.BackColor = System.Drawing.Color.Silver;
            this.btn_extract.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extract.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_extract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_extract.Location = new System.Drawing.Point(131, 393);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(77, 31);
            this.btn_extract.TabIndex = 8;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = false;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // form_extractItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_extract);
            this.Name = "form_extractItem";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_extractItem_Load);
            this.tlp_extract.ResumeLayout(false);
            this.tlp_extract.PerformLayout();
            this.pnl_extract.ResumeLayout(false);
            this.pnl_extract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_extract;
        private System.Windows.Forms.Panel pnl_extract;
        private System.Windows.Forms.Label lbl_extract;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox txtBox_quantity;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ErrorProvider errorType;
        private System.Windows.Forms.ErrorProvider errorSize;
        private System.Windows.Forms.ErrorProvider errorQuantity;
        private System.Windows.Forms.Button btn_extract;
    }
}