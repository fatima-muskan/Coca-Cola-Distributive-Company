
namespace FinalProject
{
    partial class form_addVahicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_addVahicle));
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_fuel = new System.Windows.Forms.Label();
            this.txtBox_vhID = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_vhclNumber = new System.Windows.Forms.Label();
            this.pnl_addvehicle = new System.Windows.Forms.Panel();
            this.lbl_addvehicle = new System.Windows.Forms.Label();
            this.tlp_addvehicle = new System.Windows.Forms.TableLayoutPanel();
            this.txtBox_fuel = new System.Windows.Forms.TextBox();
            this.errorNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_addvehicle.SuspendLayout();
            this.tlp_addvehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFuel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_status
            // 
            this.cmb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmb_status.Location = new System.Drawing.Point(226, 110);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(323, 21);
            this.cmb_status.TabIndex = 13;
            this.cmb_status.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_status_Validating);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(474, 360);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 45);
            this.btn_cancle.TabIndex = 12;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(83, 360);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 45);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_fuel
            // 
            this.lbl_fuel.AutoSize = true;
            this.lbl_fuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_fuel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_fuel.Location = new System.Drawing.Point(83, 152);
            this.lbl_fuel.Name = "lbl_fuel";
            this.lbl_fuel.Size = new System.Drawing.Size(137, 47);
            this.lbl_fuel.TabIndex = 6;
            this.lbl_fuel.Text = "Fuel";
            // 
            // txtBox_vhID
            // 
            this.txtBox_vhID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_vhID.Location = new System.Drawing.Point(226, 65);
            this.txtBox_vhID.Name = "txtBox_vhID";
            this.txtBox_vhID.Size = new System.Drawing.Size(323, 20);
            this.txtBox_vhID.TabIndex = 0;
            this.txtBox_vhID.Text = "xyz123";
            this.txtBox_vhID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_vhID_Validating);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_status.Location = new System.Drawing.Point(83, 107);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(137, 45);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            // 
            // lbl_vhclNumber
            // 
            this.lbl_vhclNumber.AutoSize = true;
            this.lbl_vhclNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_vhclNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vhclNumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_vhclNumber.Location = new System.Drawing.Point(83, 62);
            this.lbl_vhclNumber.Name = "lbl_vhclNumber";
            this.lbl_vhclNumber.Size = new System.Drawing.Size(137, 45);
            this.lbl_vhclNumber.TabIndex = 3;
            this.lbl_vhclNumber.Text = "Vehicle Number";
            // 
            // pnl_addvehicle
            // 
            this.pnl_addvehicle.BackColor = System.Drawing.Color.Silver;
            this.tlp_addvehicle.SetColumnSpan(this.pnl_addvehicle, 4);
            this.pnl_addvehicle.Controls.Add(this.lbl_addvehicle);
            this.pnl_addvehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addvehicle.Location = new System.Drawing.Point(3, 3);
            this.pnl_addvehicle.Name = "pnl_addvehicle";
            this.pnl_addvehicle.Size = new System.Drawing.Size(653, 56);
            this.pnl_addvehicle.TabIndex = 2;
            // 
            // lbl_addvehicle
            // 
            this.lbl_addvehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addvehicle.AutoSize = true;
            this.lbl_addvehicle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addvehicle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_addvehicle.Location = new System.Drawing.Point(210, 6);
            this.lbl_addvehicle.Name = "lbl_addvehicle";
            this.lbl_addvehicle.Size = new System.Drawing.Size(230, 36);
            this.lbl_addvehicle.TabIndex = 3;
            this.lbl_addvehicle.Text = "ADD VEHICLE";
            // 
            // tlp_addvehicle
            // 
            this.tlp_addvehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_addvehicle.ColumnCount = 4;
            this.tlp_addvehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.29135F));
            this.tlp_addvehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85129F));
            this.tlp_addvehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22762F));
            this.tlp_addvehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93323F));
            this.tlp_addvehicle.Controls.Add(this.pnl_addvehicle, 0, 0);
            this.tlp_addvehicle.Controls.Add(this.lbl_vhclNumber, 1, 1);
            this.tlp_addvehicle.Controls.Add(this.lbl_status, 1, 2);
            this.tlp_addvehicle.Controls.Add(this.txtBox_vhID, 2, 1);
            this.tlp_addvehicle.Controls.Add(this.lbl_fuel, 1, 3);
            this.tlp_addvehicle.Controls.Add(this.btn_add, 1, 4);
            this.tlp_addvehicle.Controls.Add(this.btn_cancle, 2, 4);
            this.tlp_addvehicle.Controls.Add(this.cmb_status, 2, 2);
            this.tlp_addvehicle.Controls.Add(this.txtBox_fuel, 2, 3);
            this.tlp_addvehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_addvehicle.Location = new System.Drawing.Point(0, 0);
            this.tlp_addvehicle.Name = "tlp_addvehicle";
            this.tlp_addvehicle.RowCount = 6;
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93805F));
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17699F));
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17699F));
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.61947F));
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.68142F));
            this.tlp_addvehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.292035F));
            this.tlp_addvehicle.Size = new System.Drawing.Size(659, 452);
            this.tlp_addvehicle.TabIndex = 2;
            // 
            // txtBox_fuel
            // 
            this.txtBox_fuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_fuel.Location = new System.Drawing.Point(226, 155);
            this.txtBox_fuel.Name = "txtBox_fuel";
            this.txtBox_fuel.Size = new System.Drawing.Size(323, 20);
            this.txtBox_fuel.TabIndex = 14;
            this.txtBox_fuel.Text = "In litre";
            this.txtBox_fuel.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_fuel_Validating);
            // 
            // errorNumber
            // 
            this.errorNumber.ContainerControl = this;
            // 
            // errorStatus
            // 
            this.errorStatus.ContainerControl = this;
            // 
            // errorFuel
            // 
            this.errorFuel.ContainerControl = this;
            // 
            // form_addVahicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_addvehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_addVahicle";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_addVahicle_Load);
            this.pnl_addvehicle.ResumeLayout(false);
            this.pnl_addvehicle.PerformLayout();
            this.tlp_addvehicle.ResumeLayout(false);
            this.tlp_addvehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_fuel;
        private System.Windows.Forms.TextBox txtBox_vhID;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_vhclNumber;
        private System.Windows.Forms.Panel pnl_addvehicle;
        private System.Windows.Forms.TableLayoutPanel tlp_addvehicle;
        private System.Windows.Forms.TextBox txtBox_fuel;
        private System.Windows.Forms.Label lbl_addvehicle;
        private System.Windows.Forms.ErrorProvider errorNumber;
        private System.Windows.Forms.ErrorProvider errorStatus;
        private System.Windows.Forms.ErrorProvider errorFuel;
    }
}