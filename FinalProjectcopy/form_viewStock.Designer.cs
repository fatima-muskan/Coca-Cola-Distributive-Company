namespace FinalProject
{
    partial class form_viewStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlp_viewRider = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_viewRider = new System.Windows.Forms.Panel();
            this.lbl_viewStock = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.GV_viewRider = new System.Windows.Forms.DataGridView();
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
            this.tlp_viewRider.TabIndex = 2;
            // 
            // pnl_viewRider
            // 
            this.pnl_viewRider.BackColor = System.Drawing.Color.Silver;
            this.tlp_viewRider.SetColumnSpan(this.pnl_viewRider, 3);
            this.pnl_viewRider.Controls.Add(this.lbl_viewStock);
            this.pnl_viewRider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_viewRider.Location = new System.Drawing.Point(3, 3);
            this.pnl_viewRider.Name = "pnl_viewRider";
            this.pnl_viewRider.Size = new System.Drawing.Size(653, 40);
            this.pnl_viewRider.TabIndex = 0;
            // 
            // lbl_viewStock
            // 
            this.lbl_viewStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_viewStock.AutoSize = true;
            this.lbl_viewStock.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_viewStock.Location = new System.Drawing.Point(232, 2);
            this.lbl_viewStock.Name = "lbl_viewStock";
            this.lbl_viewStock.Size = new System.Drawing.Size(201, 36);
            this.lbl_viewStock.TabIndex = 3;
            this.lbl_viewStock.Text = "VIEW RIDER";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_viewRider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GV_viewRider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_viewRider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_viewRider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GV_viewRider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_viewRider.SetColumnSpan(this.GV_viewRider, 3);
            this.GV_viewRider.Location = new System.Drawing.Point(3, 61);
            this.GV_viewRider.MinimumSize = new System.Drawing.Size(653, 322);
            this.GV_viewRider.Name = "GV_viewRider";
            this.GV_viewRider.Size = new System.Drawing.Size(653, 322);
            this.GV_viewRider.TabIndex = 16;
            // 
            // form_viewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_viewRider);
            this.Name = "form_viewStock";
            this.Text = "form_viewStock";
            this.Load += new System.EventHandler(this.form_viewStock_Load);
            this.tlp_viewRider.ResumeLayout(false);
            this.pnl_viewRider.ResumeLayout(false);
            this.pnl_viewRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_viewRider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_viewRider;
        private System.Windows.Forms.Panel pnl_viewRider;
        private System.Windows.Forms.Label lbl_viewStock;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView GV_viewRider;
    }
}