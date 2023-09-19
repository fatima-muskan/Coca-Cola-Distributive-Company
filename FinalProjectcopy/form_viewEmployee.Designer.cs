namespace FinalProject
{
    partial class form_viewEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlp_viewEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_viewRider = new System.Windows.Forms.Panel();
            this.lbl_viewEmployee = new System.Windows.Forms.Label();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlp_viewEmployee.SuspendLayout();
            this.pnl_viewRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_viewEmployee
            // 
            this.tlp_viewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_viewEmployee.ColumnCount = 3;
            this.tlp_viewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8786F));
            this.tlp_viewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40668F));
            this.tlp_viewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56297F));
            this.tlp_viewEmployee.Controls.Add(this.pnl_viewRider, 0, 0);
            this.tlp_viewEmployee.Controls.Add(this.btn_cancle, 2, 3);
            this.tlp_viewEmployee.Controls.Add(this.dataGridView1, 0, 2);
            this.tlp_viewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_viewEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlp_viewEmployee.Name = "tlp_viewEmployee";
            this.tlp_viewEmployee.RowCount = 4;
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27558F));
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.654867F));
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.56637F));
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38053F));
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewEmployee.Size = new System.Drawing.Size(659, 452);
            this.tlp_viewEmployee.TabIndex = 2;
            // 
            // pnl_viewRider
            // 
            this.pnl_viewRider.BackColor = System.Drawing.Color.Silver;
            this.tlp_viewEmployee.SetColumnSpan(this.pnl_viewRider, 3);
            this.pnl_viewRider.Controls.Add(this.lbl_viewEmployee);
            this.pnl_viewRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_viewRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_viewRider.Name = "pnl_viewRider";
            this.pnl_viewRider.Size = new System.Drawing.Size(653, 40);
            this.pnl_viewRider.TabIndex = 0;
            // 
            // lbl_viewEmployee
            // 
            this.lbl_viewEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_viewEmployee.AutoSize = true;
            this.lbl_viewEmployee.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewEmployee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_viewEmployee.Location = new System.Drawing.Point(232, 2);
            this.lbl_viewEmployee.Name = "lbl_viewEmployee";
            this.lbl_viewEmployee.Size = new System.Drawing.Size(277, 36);
            this.lbl_viewEmployee.TabIndex = 3;
            this.lbl_viewEmployee.Text = "VIEW EMPLOYEE";
            // 
            // btn_cancle
            // 
            this.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancle.Location = new System.Drawing.Point(489, 404);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(130, 45);
            this.btn_cancle.TabIndex = 15;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateColumn,
            this.DeleteColumn});
            this.tlp_viewEmployee.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 322);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpdateColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            this.UpdateColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "Edit";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // form_viewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_viewEmployee);
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_viewEmployee";
            this.Text = "Soft Drink Distribution System";
            this.Load += new System.EventHandler(this.form_viewEmployee_Load);
            this.tlp_viewEmployee.ResumeLayout(false);
            this.pnl_viewRider.ResumeLayout(false);
            this.pnl_viewRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_viewEmployee;
        private System.Windows.Forms.Panel pnl_viewRider;
        private System.Windows.Forms.Label lbl_viewEmployee;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}