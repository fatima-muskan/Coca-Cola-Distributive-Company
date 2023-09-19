namespace FinalProject
{
    partial class form_updEmployee
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
            this.tlp_addEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_addRider = new System.Windows.Forms.Panel();
            this.lbl_updEmployee = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_cnic = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_cnic = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txtBox_salary = new System.Windows.Forms.TextBox();
            this.lbl_hyphon = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtBox_dob = new System.Windows.Forms.TextBox();
            this.txtBox_digits = new System.Windows.Forms.TextBox();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCnic = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDigit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_addEmployee.SuspendLayout();
            this.pnl_addRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_addEmployee
            // 
            this.tlp_addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_addEmployee.ColumnCount = 4;
            this.tlp_addEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.93432F));
            this.tlp_addEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0119F));
            this.tlp_addEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.93432F));
            this.tlp_addEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.11946F));
            this.tlp_addEmployee.Controls.Add(this.pnl_addRider, 0, 0);
            this.tlp_addEmployee.Controls.Add(this.lbl_name, 0, 1);
            this.tlp_addEmployee.Controls.Add(this.lbl_cnic, 0, 2);
            this.tlp_addEmployee.Controls.Add(this.lbl_email, 0, 3);
            this.tlp_addEmployee.Controls.Add(this.lbl_password, 0, 4);
            this.tlp_addEmployee.Controls.Add(this.lbl_dob, 0, 5);
            this.tlp_addEmployee.Controls.Add(this.lbl_num, 0, 6);
            this.tlp_addEmployee.Controls.Add(this.txtBox_name, 1, 1);
            this.tlp_addEmployee.Controls.Add(this.txtBox_cnic, 1, 2);
            this.tlp_addEmployee.Controls.Add(this.txtBox_email, 1, 3);
            this.tlp_addEmployee.Controls.Add(this.txtBox_pass, 1, 4);
            this.tlp_addEmployee.Controls.Add(this.lbl_salary, 2, 4);
            this.tlp_addEmployee.Controls.Add(this.txtBox_salary, 3, 4);
            this.tlp_addEmployee.Controls.Add(this.lbl_hyphon, 2, 6);
            this.tlp_addEmployee.Controls.Add(this.btn_save, 0, 9);
            this.tlp_addEmployee.Controls.Add(this.btn_cancle, 3, 9);
            this.tlp_addEmployee.Controls.Add(this.cmb_role, 1, 7);
            this.tlp_addEmployee.Controls.Add(this.lbl_role, 0, 7);
            this.tlp_addEmployee.Controls.Add(this.txtBox_dob, 1, 5);
            this.tlp_addEmployee.Controls.Add(this.txtBox_digits, 1, 6);
            this.tlp_addEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_addEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlp_addEmployee.Name = "tlp_addEmployee";
            this.tlp_addEmployee.RowCount = 10;
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.32F));
            this.tlp_addEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.97F));
            this.tlp_addEmployee.Size = new System.Drawing.Size(659, 452);
            this.tlp_addEmployee.TabIndex = 2;
            // 
            // pnl_addRider
            // 
            this.pnl_addRider.BackColor = System.Drawing.Color.Silver;
            this.pnl_addRider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_addEmployee.SetColumnSpan(this.pnl_addRider, 4);
            this.pnl_addRider.Controls.Add(this.lbl_updEmployee);
            this.pnl_addRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_addRider.Name = "pnl_addRider";
            this.pnl_addRider.Size = new System.Drawing.Size(653, 41);
            this.pnl_addRider.TabIndex = 0;
            // 
            // lbl_updEmployee
            // 
            this.lbl_updEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_updEmployee.AutoSize = true;
            this.lbl_updEmployee.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updEmployee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_updEmployee.Location = new System.Drawing.Point(239, 1);
            this.lbl_updEmployee.Name = "lbl_updEmployee";
            this.lbl_updEmployee.Size = new System.Drawing.Size(273, 36);
            this.lbl_updEmployee.TabIndex = 2;
            this.lbl_updEmployee.Text = "EDIT EMPLOYEE";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(3, 47);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(118, 37);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_cnic
            // 
            this.lbl_cnic.AutoSize = true;
            this.lbl_cnic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cnic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_cnic.Location = new System.Drawing.Point(3, 84);
            this.lbl_cnic.Name = "lbl_cnic";
            this.lbl_cnic.Size = new System.Drawing.Size(118, 37);
            this.lbl_cnic.TabIndex = 2;
            this.lbl_cnic.Text = "CNIC";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_email.Location = new System.Drawing.Point(3, 121);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(118, 37);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email Address";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_password.Location = new System.Drawing.Point(3, 158);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(118, 37);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_dob.Location = new System.Drawing.Point(3, 195);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(118, 37);
            this.lbl_dob.TabIndex = 5;
            this.lbl_dob.Text = "DOB";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_num.Location = new System.Drawing.Point(3, 232);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(118, 37);
            this.lbl_num.TabIndex = 6;
            this.lbl_num.Text = "Phone no.";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_name.Location = new System.Drawing.Point(127, 50);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(172, 20);
            this.txtBox_name.TabIndex = 0;
            this.txtBox_name.Text = "First Name";
            this.txtBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name_Validating);
            // 
            // txtBox_cnic
            // 
            this.tlp_addEmployee.SetColumnSpan(this.txtBox_cnic, 3);
            this.txtBox_cnic.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_cnic.Location = new System.Drawing.Point(127, 87);
            this.txtBox_cnic.Name = "txtBox_cnic";
            this.txtBox_cnic.Size = new System.Drawing.Size(400, 20);
            this.txtBox_cnic.TabIndex = 2;
            this.txtBox_cnic.Text = "XXXXXXXXXXXXX";
            this.txtBox_cnic.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_cnic_Validating);
            // 
            // txtBox_email
            // 
            this.tlp_addEmployee.SetColumnSpan(this.txtBox_email, 3);
            this.txtBox_email.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_email.Location = new System.Drawing.Point(127, 124);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(400, 20);
            this.txtBox_email.TabIndex = 3;
            this.txtBox_email.Text = "xyz@gmail.com";
            this.txtBox_email.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_email_Validating);
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_pass.Location = new System.Drawing.Point(127, 161);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(150, 20);
            this.txtBox_pass.TabIndex = 4;
            this.txtBox_pass.Text = "******** (number + alphabet)";
            this.txtBox_pass.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_pass_Validating);
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_salary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_salary.Location = new System.Drawing.Point(305, 158);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(118, 37);
            this.lbl_salary.TabIndex = 18;
            this.lbl_salary.Text = "Salary";
            // 
            // txtBox_salary
            // 
            this.txtBox_salary.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_salary.Location = new System.Drawing.Point(429, 161);
            this.txtBox_salary.Name = "txtBox_salary";
            this.txtBox_salary.Size = new System.Drawing.Size(200, 20);
            this.txtBox_salary.TabIndex = 5;
            this.txtBox_salary.TextChanged += new System.EventHandler(this.txtBox_salary_TextChanged);
            this.txtBox_salary.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_salary_Validating);
            // 
            // lbl_hyphon
            // 
            this.lbl_hyphon.AutoSize = true;
            this.lbl_hyphon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_hyphon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hyphon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_hyphon.Location = new System.Drawing.Point(305, 232);
            this.lbl_hyphon.Name = "lbl_hyphon";
            this.lbl_hyphon.Size = new System.Drawing.Size(118, 37);
            this.lbl_hyphon.TabIndex = 22;
            this.lbl_hyphon.Text = "          -";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.Silver;
            this.btn_save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Location = new System.Drawing.Point(24, 404);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 45);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(505, 404);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 45);
            this.btn_cancle.TabIndex = 14;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // cmb_role
            // 
            this.cmb_role.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            "Inventory Manager",
            "Sales Manager",
            "General Manager"});
            this.cmb_role.Location = new System.Drawing.Point(127, 272);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(150, 21);
            this.cmb_role.TabIndex = 12;
            this.cmb_role.Text = "Role";
            this.cmb_role.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_role_Validating);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_role.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_role.Location = new System.Drawing.Point(3, 269);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(118, 37);
            this.lbl_role.TabIndex = 8;
            this.lbl_role.Text = "Role";
            // 
            // txtBox_dob
            // 
            this.txtBox_dob.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_dob.Location = new System.Drawing.Point(127, 198);
            this.txtBox_dob.Name = "txtBox_dob";
            this.txtBox_dob.Size = new System.Drawing.Size(150, 20);
            this.txtBox_dob.TabIndex = 23;
            this.txtBox_dob.Text = "XXXX";
            this.txtBox_dob.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_dob_Validating);
            // 
            // txtBox_digits
            // 
            this.txtBox_digits.Location = new System.Drawing.Point(127, 235);
            this.txtBox_digits.Name = "txtBox_digits";
            this.txtBox_digits.Size = new System.Drawing.Size(150, 20);
            this.txtBox_digits.TabIndex = 10;
            this.txtBox_digits.Text = "Digits";
            this.txtBox_digits.TextChanged += new System.EventHandler(this.txtBox_digits_TextChanged);
            this.txtBox_digits.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_number_Validating);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorCnic
            // 
            this.errorCnic.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorSalary
            // 
            this.errorSalary.ContainerControl = this;
            // 
            // errorDOB
            // 
            this.errorDOB.ContainerControl = this;
            // 
            // errorDigit
            // 
            this.errorDigit.ContainerControl = this;
            // 
            // errorRole
            // 
            this.errorRole.ContainerControl = this;
            // 
            // form_updEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_addEmployee);
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_updEmployee";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_updEmployee_Load);
            this.tlp_addEmployee.ResumeLayout(false);
            this.tlp_addEmployee.PerformLayout();
            this.pnl_addRider.ResumeLayout(false);
            this.pnl_addRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_addEmployee;
        private System.Windows.Forms.Panel pnl_addRider;
        private System.Windows.Forms.Label lbl_updEmployee;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_cnic;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_cnic;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txtBox_salary;
        private System.Windows.Forms.Label lbl_hyphon;
        private System.Windows.Forms.TextBox txtBox_digits;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txtBox_dob;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorCnic;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorSalary;
        private System.Windows.Forms.ErrorProvider errorDOB;
        private System.Windows.Forms.ErrorProvider errorDigit;
        private System.Windows.Forms.ErrorProvider errorRole;
    }
}