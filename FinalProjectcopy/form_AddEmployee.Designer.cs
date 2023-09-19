namespace FinalProject
{
    partial class form_AddEmployee
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
            this.errorSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCnic = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_addEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_addRider = new System.Windows.Forms.Panel();
            this.lbl_addEmployee = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_cnic = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txtBox_name1 = new System.Windows.Forms.TextBox();
            this.txtBox_cnic = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.txtBox_code = new System.Windows.Forms.TextBox();
            this.txtBox_name2 = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txtBox_salary = new System.Windows.Forms.TextBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.cmb_date = new System.Windows.Forms.ComboBox();
            this.lbl_hyphon = new System.Windows.Forms.Label();
            this.txtBox_digits = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtBox_year = new System.Windows.Forms.TextBox();
            this.errorYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDigit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).BeginInit();
            this.tlp_addEmployee.SuspendLayout();
            this.pnl_addRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // errorSalary
            // 
            this.errorSalary.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorCnic
            // 
            this.errorCnic.ContainerControl = this;
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
            this.tlp_addEmployee.Controls.Add(this.txtBox_name1, 1, 1);
            this.tlp_addEmployee.Controls.Add(this.txtBox_cnic, 1, 2);
            this.tlp_addEmployee.Controls.Add(this.txtBox_email, 1, 3);
            this.tlp_addEmployee.Controls.Add(this.txtBox_pass, 1, 4);
            this.tlp_addEmployee.Controls.Add(this.txtBox_code, 1, 6);
            this.tlp_addEmployee.Controls.Add(this.txtBox_name2, 3, 1);
            this.tlp_addEmployee.Controls.Add(this.lbl_salary, 2, 4);
            this.tlp_addEmployee.Controls.Add(this.txtBox_salary, 3, 4);
            this.tlp_addEmployee.Controls.Add(this.cmb_month, 1, 5);
            this.tlp_addEmployee.Controls.Add(this.cmb_date, 2, 5);
            this.tlp_addEmployee.Controls.Add(this.lbl_hyphon, 2, 6);
            this.tlp_addEmployee.Controls.Add(this.txtBox_digits, 3, 6);
            this.tlp_addEmployee.Controls.Add(this.btn_add, 0, 9);
            this.tlp_addEmployee.Controls.Add(this.btn_cancle, 3, 9);
            this.tlp_addEmployee.Controls.Add(this.cmb_role, 1, 7);
            this.tlp_addEmployee.Controls.Add(this.lbl_role, 0, 7);
            this.tlp_addEmployee.Controls.Add(this.txtBox_year, 3, 5);
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
            this.tlp_addEmployee.TabIndex = 1;
            this.tlp_addEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.tlp_addEmployee_Paint);
            // 
            // pnl_addRider
            // 
            this.pnl_addRider.BackColor = System.Drawing.Color.Silver;
            this.pnl_addRider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_addEmployee.SetColumnSpan(this.pnl_addRider, 4);
            this.pnl_addRider.Controls.Add(this.lbl_addEmployee);
            this.pnl_addRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_addRider.Name = "pnl_addRider";
            this.pnl_addRider.Size = new System.Drawing.Size(653, 41);
            this.pnl_addRider.TabIndex = 0;
            // 
            // lbl_addEmployee
            // 
            this.lbl_addEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addEmployee.AutoSize = true;
            this.lbl_addEmployee.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addEmployee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_addEmployee.Location = new System.Drawing.Point(239, 1);
            this.lbl_addEmployee.Name = "lbl_addEmployee";
            this.lbl_addEmployee.Size = new System.Drawing.Size(264, 36);
            this.lbl_addEmployee.TabIndex = 2;
            this.lbl_addEmployee.Text = "ADD EMPLOYEE";
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
            // txtBox_name1
            // 
            this.txtBox_name1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_name1.Location = new System.Drawing.Point(127, 50);
            this.txtBox_name1.Name = "txtBox_name1";
            this.txtBox_name1.Size = new System.Drawing.Size(172, 20);
            this.txtBox_name1.TabIndex = 0;
            this.txtBox_name1.Text = "First Name";
            this.txtBox_name1.TextChanged += new System.EventHandler(this.txtBox_name1_TextChanged);
            this.txtBox_name1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_name1_KeyPress);
            this.txtBox_name1.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name1_Validating);
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
            // txtBox_code
            // 
            this.txtBox_code.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_code.Location = new System.Drawing.Point(127, 235);
            this.txtBox_code.Name = "txtBox_code";
            this.txtBox_code.ReadOnly = true;
            this.txtBox_code.Size = new System.Drawing.Size(150, 20);
            this.txtBox_code.TabIndex = 9;
            this.txtBox_code.Text = "+92";
            // 
            // txtBox_name2
            // 
            this.txtBox_name2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_name2.Location = new System.Drawing.Point(429, 50);
            this.txtBox_name2.Name = "txtBox_name2";
            this.txtBox_name2.Size = new System.Drawing.Size(200, 20);
            this.txtBox_name2.TabIndex = 1;
            this.txtBox_name2.Text = "Last Name";
            this.txtBox_name2.TextChanged += new System.EventHandler(this.txtBox_name2_TextChanged);
            this.txtBox_name2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_name2_KeyPress);
            this.txtBox_name2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name2_Validating);
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
            this.txtBox_salary.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_salary_Validating);
            // 
            // cmb_month
            // 
            this.cmb_month.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "January",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_month.Location = new System.Drawing.Point(127, 198);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(150, 21);
            this.cmb_month.TabIndex = 6;
            this.cmb_month.Text = "Month";
            this.cmb_month.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_month_Validating);
            // 
            // cmb_date
            // 
            this.cmb_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_date.FormattingEnabled = true;
            this.cmb_date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_date.Location = new System.Drawing.Point(305, 198);
            this.cmb_date.Name = "cmb_date";
            this.cmb_date.Size = new System.Drawing.Size(100, 21);
            this.cmb_date.TabIndex = 7;
            this.cmb_date.Text = "Date";
            this.cmb_date.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_date_Validating);
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
            // txtBox_digits
            // 
            this.txtBox_digits.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_digits.Location = new System.Drawing.Point(429, 235);
            this.txtBox_digits.Name = "txtBox_digits";
            this.txtBox_digits.Size = new System.Drawing.Size(200, 20);
            this.txtBox_digits.TabIndex = 10;
            this.txtBox_digits.Text = "Digits";
            this.txtBox_digits.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_digits_Validating);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(24, 404);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 45);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
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
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_area_SelectedIndexChanged);
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
            this.lbl_role.Click += new System.EventHandler(this.lbl_area_Click);
            // 
            // txtBox_year
            // 
            this.txtBox_year.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_year.Location = new System.Drawing.Point(429, 198);
            this.txtBox_year.Name = "txtBox_year";
            this.txtBox_year.Size = new System.Drawing.Size(200, 20);
            this.txtBox_year.TabIndex = 23;
            this.txtBox_year.Text = "XXXX";
            this.txtBox_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_year_KeyPress);
            this.txtBox_year.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_year_Validating);
            // 
            // errorYear
            // 
            this.errorYear.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorName1
            // 
            this.errorName1.ContainerControl = this;
            // 
            // errorName2
            // 
            this.errorName2.ContainerControl = this;
            // 
            // errorMonth
            // 
            this.errorMonth.ContainerControl = this;
            // 
            // errorDate
            // 
            this.errorDate.ContainerControl = this;
            // 
            // errorRole
            // 
            this.errorRole.ContainerControl = this;
            // 
            // errorDigit
            // 
            this.errorDigit.ContainerControl = this;
            // 
            // form_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_addEmployee);
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_AddEmployee";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCnic)).EndInit();
            this.tlp_addEmployee.ResumeLayout(false);
            this.tlp_addEmployee.PerformLayout();
            this.pnl_addRider.ResumeLayout(false);
            this.pnl_addRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDigit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorSalary;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorCnic;
        private System.Windows.Forms.TableLayoutPanel tlp_addEmployee;
        private System.Windows.Forms.Panel pnl_addRider;
        private System.Windows.Forms.Label lbl_addEmployee;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_cnic;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txtBox_name1;
        private System.Windows.Forms.TextBox txtBox_cnic;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.TextBox txtBox_code;
        private System.Windows.Forms.TextBox txtBox_name2;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txtBox_salary;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.ComboBox cmb_date;
        private System.Windows.Forms.Label lbl_hyphon;
        private System.Windows.Forms.TextBox txtBox_digits;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.TextBox txtBox_year;
        private System.Windows.Forms.ErrorProvider errorYear;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorName1;
        private System.Windows.Forms.ErrorProvider errorName2;
        private System.Windows.Forms.ErrorProvider errorMonth;
        private System.Windows.Forms.ErrorProvider errorDate;
        private System.Windows.Forms.ErrorProvider errorRole;
        private System.Windows.Forms.ErrorProvider errorDigit;
    }
}