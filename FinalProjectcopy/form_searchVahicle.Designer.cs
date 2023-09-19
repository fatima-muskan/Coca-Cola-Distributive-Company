
namespace FinalProject
{
    partial class form_searchVahicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_searchVahicle));
            this.tlp_searchEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.pnl_searchVahicle = new System.Windows.Forms.Panel();
            this.lbl_searchVahicle = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_searchEmployee.SuspendLayout();
            this.pnl_searchVahicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
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
            this.tlp_searchEmployee.Controls.Add(this.pnl_searchVahicle, 0, 0);
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
            this.tlp_searchEmployee.TabIndex = 2;
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
            // pnl_searchVahicle
            // 
            this.pnl_searchVahicle.BackColor = System.Drawing.Color.Silver;
            this.tlp_searchEmployee.SetColumnSpan(this.pnl_searchVahicle, 3);
            this.pnl_searchVahicle.Controls.Add(this.lbl_searchVahicle);
            this.pnl_searchVahicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_searchVahicle.Location = new System.Drawing.Point(3, 3);
            this.pnl_searchVahicle.Name = "pnl_searchVahicle";
            this.pnl_searchVahicle.Size = new System.Drawing.Size(653, 40);
            this.pnl_searchVahicle.TabIndex = 0;
            // 
            // lbl_searchVahicle
            // 
            this.lbl_searchVahicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_searchVahicle.AutoSize = true;
            this.lbl_searchVahicle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchVahicle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_searchVahicle.Location = new System.Drawing.Point(156, 4);
            this.lbl_searchVahicle.Name = "lbl_searchVahicle";
            this.lbl_searchVahicle.Size = new System.Drawing.Size(290, 36);
            this.lbl_searchVahicle.TabIndex = 3;
            this.lbl_searchVahicle.Text = "SEARCH VEHICLE";
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
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // form_searchVahicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_searchEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_searchVahicle";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_searchVahicle_Load);
            this.tlp_searchEmployee.ResumeLayout(false);
            this.tlp_searchEmployee.PerformLayout();
            this.pnl_searchVahicle.ResumeLayout(false);
            this.pnl_searchVahicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_searchEmployee;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Panel pnl_searchVahicle;
        private System.Windows.Forms.Label lbl_searchVahicle;
        private System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.ErrorProvider errorID;
    }
}