
namespace FinalProject
{
    partial class form_viewRider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_viewRider));
            this.tlp_viewRider = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_viewRider = new System.Windows.Forms.Panel();
            this.lbl_viewRider = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.GV_viewRider = new System.Windows.Forms.DataGridView();
            this.updateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlp_viewRider.SuspendLayout();
            this.pnl_viewRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_viewRider)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_viewRider
            // 
            this.tlp_viewRider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_viewRider.ColumnCount = 3;
            this.tlp_viewRider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8786F));
            this.tlp_viewRider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40668F));
            this.tlp_viewRider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56297F));
            this.tlp_viewRider.Controls.Add(this.pnl_viewRider, 0, 0);
            this.tlp_viewRider.Controls.Add(this.btn_cancel, 2, 3);
            this.tlp_viewRider.Controls.Add(this.GV_viewRider, 0, 2);
            this.tlp_viewRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_viewRider.Location = new System.Drawing.Point(0, 0);
            this.tlp_viewRider.Name = "tlp_viewRider";
            this.tlp_viewRider.RowCount = 4;
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27558F));
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.654867F));
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.56637F));
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38053F));
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewRider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewRider.Size = new System.Drawing.Size(659, 452);
            this.tlp_viewRider.TabIndex = 1;
            // 
            // pnl_viewRider
            // 
            this.pnl_viewRider.BackColor = System.Drawing.Color.Silver;
            this.tlp_viewRider.SetColumnSpan(this.pnl_viewRider, 3);
            this.pnl_viewRider.Controls.Add(this.lbl_viewRider);
            this.pnl_viewRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_viewRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_viewRider.Name = "pnl_viewRider";
            this.pnl_viewRider.Size = new System.Drawing.Size(653, 40);
            this.pnl_viewRider.TabIndex = 0;
            // 
            // lbl_viewRider
            // 
            this.lbl_viewRider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_viewRider.AutoSize = true;
            this.lbl_viewRider.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewRider.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_viewRider.Location = new System.Drawing.Point(232, 2);
            this.lbl_viewRider.Name = "lbl_viewRider";
            this.lbl_viewRider.Size = new System.Drawing.Size(201, 36);
            this.lbl_viewRider.TabIndex = 3;
            this.lbl_viewRider.Text = "VIEW RIDER";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_cancel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.Location = new System.Drawing.Point(489, 404);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 45);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // GV_viewRider
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_viewRider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_viewRider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_viewRider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_viewRider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_viewRider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_viewRider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.updateColumn,
            this.deleteColumn});
            this.tlp_viewRider.SetColumnSpan(this.GV_viewRider, 3);
            this.GV_viewRider.Location = new System.Drawing.Point(3, 61);
            this.GV_viewRider.MinimumSize = new System.Drawing.Size(653, 322);
            this.GV_viewRider.Name = "GV_viewRider";
            this.GV_viewRider.Size = new System.Drawing.Size(653, 322);
            this.GV_viewRider.TabIndex = 16;
            this.GV_viewRider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_viewRider_CellContentClick);
            // 
            // updateColumn
            // 
            this.updateColumn.HeaderText = "Update";
            this.updateColumn.MinimumWidth = 4;
            this.updateColumn.Name = "updateColumn";
            this.updateColumn.Text = "Update";
            this.updateColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.MinimumWidth = 4;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "Delete";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // form_viewRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_viewRider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_viewRider";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_viewRider_Load);
            this.tlp_viewRider.ResumeLayout(false);
            this.pnl_viewRider.ResumeLayout(false);
            this.pnl_viewRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_viewRider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_viewRider;
        private System.Windows.Forms.Panel pnl_viewRider;
        private System.Windows.Forms.Label lbl_viewRider;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView GV_viewRider;
        private System.Windows.Forms.DataGridViewButtonColumn updateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}