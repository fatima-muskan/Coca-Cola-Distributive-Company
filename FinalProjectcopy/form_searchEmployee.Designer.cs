namespace FinalProject
{
    partial class form_searchEmployee
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
            this.tlp_searchEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.pnl_searchRider = new System.Windows.Forms.Panel();
            this.lbl_searchEmployee = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_searchEmployee.SuspendLayout();
            this.pnl_searchRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_searchEmployee
            // 
            this.tlp_searchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_searchEmployee.ColumnCount = 3;
            this.tlp_searchEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8786F));
            this.tlp_searchEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40668F));
            this.tlp_searchEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56297F));
            this.tlp_searchEmployee.Controls.Add(this.lbl_Id, 0, 1);
            this.tlp_searchEmployee.Controls.Add(this.pnl_searchRider, 0, 0);
            this.tlp_searchEmployee.Controls.Add(this.txtBox_Id, 1, 1);
            this.tlp_searchEmployee.Controls.Add(this.lbl_details, 0, 2);
            this.tlp_searchEmployee.Controls.Add(this.btn_search, 0, 3);
            this.tlp_searchEmployee.Controls.Add(this.btn_cancle, 2, 3);
            this.tlp_searchEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_searchEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlp_searchEmployee.Name = "tlp_searchEmployee";
            this.tlp_searchEmployee.RowCount = 4;
            this.tlp_searchEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27558F));
            this.tlp_searchEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.9292F));
            this.tlp_searchEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.44248F));
            this.tlp_searchEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.67257F));
            this.tlp_searchEmployee.Size = new System.Drawing.Size(659, 452);
            this.tlp_searchEmployee.TabIndex = 1;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Id.Location = new System.Drawing.Point(49, 71);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(79, 21);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "          ID";
            // 
            // pnl_searchRider
            // 
            this.pnl_searchRider.BackColor = System.Drawing.Color.Silver;
            this.tlp_searchEmployee.SetColumnSpan(this.pnl_searchRider, 3);
            this.pnl_searchRider.Controls.Add(this.lbl_searchEmployee);
            this.pnl_searchRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_searchRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_searchRider.Name = "pnl_searchRider";
            this.pnl_searchRider.Size = new System.Drawing.Size(653, 40);
            this.pnl_searchRider.TabIndex = 0;
            // 
            // lbl_searchEmployee
            // 
            this.lbl_searchEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_searchEmployee.AutoSize = true;
            this.lbl_searchEmployee.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchEmployee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_searchEmployee.Location = new System.Drawing.Point(232, 2);
            this.lbl_searchEmployee.Name = "lbl_searchEmployee";
            this.lbl_searchEmployee.Size = new System.Drawing.Size(324, 36);
            this.lbl_searchEmployee.TabIndex = 3;
            this.lbl_searchEmployee.Text = "SEARCH EMPLOYEE";
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Id.Location = new System.Drawing.Point(134, 71);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.Size = new System.Drawing.Size(313, 20);
            this.txtBox_Id.TabIndex = 3;
            this.txtBox_Id.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Id_Validating);
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_searchEmployee.SetColumnSpan(this.lbl_details, 3);
            this.lbl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_details.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(3, 117);
            this.lbl_details.MinimumSize = new System.Drawing.Size(200, 200);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(653, 227);
            this.lbl_details.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_search.BackColor = System.Drawing.Color.Silver;
            this.btn_search.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.Location = new System.Drawing.Point(28, 404);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 45);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(517, 404);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 45);
            this.btn_cancle.TabIndex = 15;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // form_searchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_searchEmployee);
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_searchEmployee";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_searchEmployee_Load);
            this.tlp_searchEmployee.ResumeLayout(false);
            this.tlp_searchEmployee.PerformLayout();
            this.pnl_searchRider.ResumeLayout(false);
            this.pnl_searchRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_searchEmployee;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Panel pnl_searchRider;
        private System.Windows.Forms.Label lbl_searchEmployee;
        private System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.ErrorProvider errorId;
    }
}