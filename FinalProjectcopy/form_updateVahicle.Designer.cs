
namespace FinalProject
{
    partial class form_updateVahicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_updateVahicle));
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_fuel = new System.Windows.Forms.Label();
            this.txtBox_vhID = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_vhID = new System.Windows.Forms.Label();
            this.pnl_updatevehicle = new System.Windows.Forms.Panel();
            this.lbl_updatevehicle = new System.Windows.Forms.Label();
            this.tlp_updatevehicle = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_updatevehicle.SuspendLayout();
            this.tlp_updatevehicle.SuspendLayout();
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
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.BackColor = System.Drawing.Color.Silver;
            this.btn_Save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Save.Location = new System.Drawing.Point(83, 360);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 45);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            // lbl_vhID
            // 
            this.lbl_vhID.AutoSize = true;
            this.lbl_vhID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_vhID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vhID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_vhID.Location = new System.Drawing.Point(83, 62);
            this.lbl_vhID.Name = "lbl_vhID";
            this.lbl_vhID.Size = new System.Drawing.Size(137, 45);
            this.lbl_vhID.TabIndex = 3;
            this.lbl_vhID.Text = "Number";
            // 
            // pnl_updatevehicle
            // 
            this.pnl_updatevehicle.BackColor = System.Drawing.Color.Silver;
            this.tlp_updatevehicle.SetColumnSpan(this.pnl_updatevehicle, 4);
            this.pnl_updatevehicle.Controls.Add(this.lbl_updatevehicle);
            this.pnl_updatevehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_updatevehicle.Location = new System.Drawing.Point(3, 3);
            this.pnl_updatevehicle.Name = "pnl_updatevehicle";
            this.pnl_updatevehicle.Size = new System.Drawing.Size(653, 56);
            this.pnl_updatevehicle.TabIndex = 2;
            // 
            // lbl_updatevehicle
            // 
            this.lbl_updatevehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_updatevehicle.AutoSize = true;
            this.lbl_updatevehicle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatevehicle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_updatevehicle.Location = new System.Drawing.Point(150, 6);
            this.lbl_updatevehicle.Name = "lbl_updatevehicle";
            this.lbl_updatevehicle.Size = new System.Drawing.Size(289, 36);
            this.lbl_updatevehicle.TabIndex = 3;
            this.lbl_updatevehicle.Text = "UPDATE VEHICLE";
            // 
            // tlp_updatevehicle
            // 
            this.tlp_updatevehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_updatevehicle.ColumnCount = 4;
            this.tlp_updatevehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.29135F));
            this.tlp_updatevehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85129F));
            this.tlp_updatevehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22762F));
            this.tlp_updatevehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93323F));
            this.tlp_updatevehicle.Controls.Add(this.pnl_updatevehicle, 0, 0);
            this.tlp_updatevehicle.Controls.Add(this.lbl_vhID, 1, 1);
            this.tlp_updatevehicle.Controls.Add(this.lbl_status, 1, 2);
            this.tlp_updatevehicle.Controls.Add(this.txtBox_vhID, 2, 1);
            this.tlp_updatevehicle.Controls.Add(this.lbl_fuel, 1, 3);
            this.tlp_updatevehicle.Controls.Add(this.btn_Save, 1, 4);
            this.tlp_updatevehicle.Controls.Add(this.btn_cancle, 2, 4);
            this.tlp_updatevehicle.Controls.Add(this.cmb_status, 2, 2);
            this.tlp_updatevehicle.Controls.Add(this.textBox1, 2, 3);
            this.tlp_updatevehicle.Location = new System.Drawing.Point(0, 0);
            this.tlp_updatevehicle.Name = "tlp_updatevehicle";
            this.tlp_updatevehicle.RowCount = 6;
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93805F));
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17699F));
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17699F));
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.61947F));
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.68142F));
            this.tlp_updatevehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.292035F));
            this.tlp_updatevehicle.Size = new System.Drawing.Size(659, 452);
            this.tlp_updatevehicle.TabIndex = 3;
            this.tlp_updatevehicle.Paint += new System.Windows.Forms.PaintEventHandler(this.tlp_updatevehicle_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(226, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
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
            // form_updateVahicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_updatevehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_updateVahicle";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_updateVahicle_Load);
            this.pnl_updatevehicle.ResumeLayout(false);
            this.pnl_updatevehicle.PerformLayout();
            this.tlp_updatevehicle.ResumeLayout(false);
            this.tlp_updatevehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_fuel;
        private System.Windows.Forms.TextBox txtBox_vhID;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_vhID;
        private System.Windows.Forms.Panel pnl_updatevehicle;
        private System.Windows.Forms.TableLayoutPanel tlp_updatevehicle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_updatevehicle;
        private System.Windows.Forms.ErrorProvider errorNumber;
        private System.Windows.Forms.ErrorProvider errorStatus;
        private System.Windows.Forms.ErrorProvider errorFuel;
    }
}