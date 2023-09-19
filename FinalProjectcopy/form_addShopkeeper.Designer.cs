
namespace FinalProject
{
    partial class form_addShopkeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_addShopkeeper));
            this.txtBox_province = new System.Windows.Forms.TextBox();
            this.txtBox_city = new System.Windows.Forms.TextBox();
            this.txtBox_name2 = new System.Windows.Forms.TextBox();
            this.txtBox_digits = new System.Windows.Forms.TextBox();
            this.txtBox_areacode = new System.Windows.Forms.TextBox();
            this.txtBox_stAddress = new System.Windows.Forms.TextBox();
            this.txtBox_cnic = new System.Windows.Forms.TextBox();
            this.txtBox_name1 = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_cnic = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_addshopkeeper = new System.Windows.Forms.Panel();
            this.lbl_addshopkeeper = new System.Windows.Forms.Label();
            this.tlp_addShopkeeper = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_hyphon = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.txtBox_country = new System.Windows.Forms.TextBox();
            this.cmb_code = new System.Windows.Forms.ComboBox();
            this.cmb_Location = new System.Windows.Forms.ComboBox();
            this.errorName1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCnic = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDigitd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_addshopkeeper.SuspendLayout();
            this.tlp_addShopkeeper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigitd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_province
            // 
            this.txtBox_province.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_province.Location = new System.Drawing.Point(359, 189);
            this.txtBox_province.Name = "txtBox_province";
            this.txtBox_province.ReadOnly = true;
            this.txtBox_province.Size = new System.Drawing.Size(216, 20);
            this.txtBox_province.TabIndex = 5;
            this.txtBox_province.Text = "Punjab";
            // 
            // txtBox_city
            // 
            this.txtBox_city.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_city.Location = new System.Drawing.Point(174, 189);
            this.txtBox_city.Name = "txtBox_city";
            this.txtBox_city.ReadOnly = true;
            this.txtBox_city.Size = new System.Drawing.Size(162, 20);
            this.txtBox_city.TabIndex = 4;
            this.txtBox_city.Text = "Lahore";
            // 
            // txtBox_name2
            // 
            this.txtBox_name2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_name2.Location = new System.Drawing.Point(359, 59);
            this.txtBox_name2.Name = "txtBox_name2";
            this.txtBox_name2.Size = new System.Drawing.Size(216, 20);
            this.txtBox_name2.TabIndex = 1;
            this.txtBox_name2.Text = "Second Name";
            this.txtBox_name2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name2_Validating);
            // 
            // txtBox_digits
            // 
            this.txtBox_digits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_digits.Location = new System.Drawing.Point(359, 268);
            this.txtBox_digits.Name = "txtBox_digits";
            this.txtBox_digits.Size = new System.Drawing.Size(216, 20);
            this.txtBox_digits.TabIndex = 9;
            this.txtBox_digits.Text = "Digits";
            this.txtBox_digits.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_digits_Validating);
            // 
            // txtBox_areacode
            // 
            this.txtBox_areacode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_areacode.Location = new System.Drawing.Point(174, 268);
            this.txtBox_areacode.Name = "txtBox_areacode";
            this.txtBox_areacode.ReadOnly = true;
            this.txtBox_areacode.Size = new System.Drawing.Size(162, 20);
            this.txtBox_areacode.TabIndex = 8;
            this.txtBox_areacode.Text = "+92";
            // 
            // txtBox_stAddress
            // 
            this.tlp_addShopkeeper.SetColumnSpan(this.txtBox_stAddress, 3);
            this.txtBox_stAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_stAddress.Location = new System.Drawing.Point(174, 147);
            this.txtBox_stAddress.Name = "txtBox_stAddress";
            this.txtBox_stAddress.Size = new System.Drawing.Size(401, 20);
            this.txtBox_stAddress.TabIndex = 3;
            this.txtBox_stAddress.Text = "Street Address";
            this.txtBox_stAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_stAddress_Validating);
            // 
            // txtBox_cnic
            // 
            this.tlp_addShopkeeper.SetColumnSpan(this.txtBox_cnic, 3);
            this.txtBox_cnic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_cnic.Location = new System.Drawing.Point(174, 102);
            this.txtBox_cnic.Name = "txtBox_cnic";
            this.txtBox_cnic.Size = new System.Drawing.Size(401, 20);
            this.txtBox_cnic.TabIndex = 2;
            this.txtBox_cnic.Text = "XXXXXXXXXXXXX";
            this.txtBox_cnic.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_cnic_Validating);
            // 
            // txtBox_name1
            // 
            this.txtBox_name1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_name1.Location = new System.Drawing.Point(174, 59);
            this.txtBox_name1.Name = "txtBox_name1";
            this.txtBox_name1.Size = new System.Drawing.Size(162, 20);
            this.txtBox_name1.TabIndex = 0;
            this.txtBox_name1.Text = "First Name";
            this.txtBox_name1.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name1_Validating);
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Location.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Location.Location = new System.Drawing.Point(63, 303);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(105, 50);
            this.lbl_Location.TabIndex = 7;
            this.lbl_Location.Text = "Location";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_phone.Location = new System.Drawing.Point(63, 265);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(105, 38);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone No.";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_area.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_area.Location = new System.Drawing.Point(63, 144);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(105, 42);
            this.lbl_area.TabIndex = 5;
            this.lbl_area.Text = "Area";
            // 
            // lbl_cnic
            // 
            this.lbl_cnic.AutoSize = true;
            this.lbl_cnic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cnic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_cnic.Location = new System.Drawing.Point(63, 99);
            this.lbl_cnic.Name = "lbl_cnic";
            this.lbl_cnic.Size = new System.Drawing.Size(105, 45);
            this.lbl_cnic.TabIndex = 4;
            this.lbl_cnic.Text = "CNIC";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(63, 56);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(105, 43);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Full Name";
            // 
            // pnl_addshopkeeper
            // 
            this.pnl_addshopkeeper.BackColor = System.Drawing.Color.Silver;
            this.tlp_addShopkeeper.SetColumnSpan(this.pnl_addshopkeeper, 6);
            this.pnl_addshopkeeper.Controls.Add(this.lbl_addshopkeeper);
            this.pnl_addshopkeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addshopkeeper.Location = new System.Drawing.Point(3, 3);
            this.pnl_addshopkeeper.Name = "pnl_addshopkeeper";
            this.pnl_addshopkeeper.Size = new System.Drawing.Size(653, 50);
            this.pnl_addshopkeeper.TabIndex = 2;
            // 
            // lbl_addshopkeeper
            // 
            this.lbl_addshopkeeper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addshopkeeper.AutoSize = true;
            this.lbl_addshopkeeper.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addshopkeeper.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_addshopkeeper.Location = new System.Drawing.Point(168, 6);
            this.lbl_addshopkeeper.Name = "lbl_addshopkeeper";
            this.lbl_addshopkeeper.Size = new System.Drawing.Size(301, 36);
            this.lbl_addshopkeeper.TabIndex = 3;
            this.lbl_addshopkeeper.Text = "ADD SHOPKEEPER";
            // 
            // tlp_addShopkeeper
            // 
            this.tlp_addShopkeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_addShopkeeper.ColumnCount = 6;
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.104704F));
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8437F));
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.49317F));
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.579666F));
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.6874F));
            this.tlp_addShopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.13961F));
            this.tlp_addShopkeeper.Controls.Add(this.pnl_addshopkeeper, 0, 0);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_name, 1, 1);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_cnic, 1, 2);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_area, 1, 3);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_phone, 1, 6);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_Location, 1, 7);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_name1, 2, 1);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_cnic, 2, 2);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_stAddress, 2, 3);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_areacode, 2, 6);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_digits, 4, 6);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_name2, 4, 1);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_city, 2, 4);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_province, 4, 4);
            this.tlp_addShopkeeper.Controls.Add(this.lbl_hyphon, 3, 6);
            this.tlp_addShopkeeper.Controls.Add(this.btn_add, 1, 8);
            this.tlp_addShopkeeper.Controls.Add(this.btn_cancle, 4, 8);
            this.tlp_addShopkeeper.Controls.Add(this.txtBox_country, 4, 5);
            this.tlp_addShopkeeper.Controls.Add(this.cmb_code, 2, 5);
            this.tlp_addShopkeeper.Controls.Add(this.cmb_Location, 2, 7);
            this.tlp_addShopkeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_addShopkeeper.Location = new System.Drawing.Point(0, 0);
            this.tlp_addShopkeeper.Name = "tlp_addShopkeeper";
            this.tlp_addShopkeeper.RowCount = 10;
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.58044F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.543781F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.97759F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.326877F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.893068F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.676165F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.459261F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06211F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.4022F));
            this.tlp_addShopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.078506F));
            this.tlp_addShopkeeper.Size = new System.Drawing.Size(659, 452);
            this.tlp_addShopkeeper.TabIndex = 0;
            // 
            // lbl_hyphon
            // 
            this.lbl_hyphon.AutoSize = true;
            this.lbl_hyphon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_hyphon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hyphon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_hyphon.Location = new System.Drawing.Point(342, 265);
            this.lbl_hyphon.Name = "lbl_hyphon";
            this.lbl_hyphon.Size = new System.Drawing.Size(11, 38);
            this.lbl_hyphon.TabIndex = 31;
            this.lbl_hyphon.Text = "-";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(63, 379);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 45);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(500, 379);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 45);
            this.btn_cancle.TabIndex = 12;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // txtBox_country
            // 
            this.txtBox_country.Location = new System.Drawing.Point(359, 229);
            this.txtBox_country.Name = "txtBox_country";
            this.txtBox_country.ReadOnly = true;
            this.txtBox_country.Size = new System.Drawing.Size(216, 20);
            this.txtBox_country.TabIndex = 32;
            this.txtBox_country.Text = "Pakistan";
            // 
            // cmb_code
            // 
            this.cmb_code.FormattingEnabled = true;
            this.cmb_code.Items.AddRange(new object[] {
            "54000",
            "52254",
            "54782",
            "87340"});
            this.cmb_code.Location = new System.Drawing.Point(174, 229);
            this.cmb_code.Name = "cmb_code";
            this.cmb_code.Size = new System.Drawing.Size(162, 21);
            this.cmb_code.TabIndex = 33;
            this.cmb_code.Text = "Zip code";
            this.cmb_code.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_code_Validating);
            // 
            // cmb_Location
            // 
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Items.AddRange(new object[] {
            "Shalimar",
            "Anarkali",
            "GPO",
            "Wahdat Road",
            "Railway Station",
            "Johar Town",
            "Ali Town"});
            this.cmb_Location.Location = new System.Drawing.Point(174, 306);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(162, 21);
            this.cmb_Location.TabIndex = 34;
            this.cmb_Location.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Location_Validating);
            // 
            // errorName1
            // 
            this.errorName1.ContainerControl = this;
            // 
            // errorName2
            // 
            this.errorName2.ContainerControl = this;
            // 
            // errorCnic
            // 
            this.errorCnic.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorcode
            // 
            this.errorcode.ContainerControl = this;
            // 
            // errorDigitd
            // 
            this.errorDigitd.ContainerControl = this;
            // 
            // errorLocation
            // 
            this.errorLocation.ContainerControl = this;
            // 
            // form_addShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_addShopkeeper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_addShopkeeper";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_addShopkeeper_Load);
            this.pnl_addshopkeeper.ResumeLayout(false);
            this.pnl_addshopkeeper.PerformLayout();
            this.tlp_addShopkeeper.ResumeLayout(false);
            this.tlp_addShopkeeper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigitd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_province;
        private System.Windows.Forms.TextBox txtBox_city;
        private System.Windows.Forms.TextBox txtBox_name2;
        private System.Windows.Forms.TextBox txtBox_digits;
        private System.Windows.Forms.TextBox txtBox_areacode;
        private System.Windows.Forms.TextBox txtBox_stAddress;
        private System.Windows.Forms.TableLayoutPanel tlp_addShopkeeper;
        private System.Windows.Forms.Panel pnl_addshopkeeper;
        private System.Windows.Forms.Label lbl_addshopkeeper;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_cnic;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txtBox_name1;
        private System.Windows.Forms.TextBox txtBox_cnic;
        private System.Windows.Forms.Label lbl_hyphon;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.TextBox txtBox_country;
        private System.Windows.Forms.ComboBox cmb_code;
        private System.Windows.Forms.ErrorProvider errorName1;
        private System.Windows.Forms.ErrorProvider errorName2;
        private System.Windows.Forms.ErrorProvider errorCnic;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorcode;
        private System.Windows.Forms.ErrorProvider errorDigitd;
        private System.Windows.Forms.ErrorProvider errorLocation;
        private System.Windows.Forms.ComboBox cmb_Location;
    }
}