
namespace FinalProject
{
    partial class form_viewShopkeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_viewShopkeeper));
            this.tlp_viewshopkeeper = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_viewshopkeeper = new System.Windows.Forms.Panel();
            this.lbl_viewshopkeeper = new System.Windows.Forms.Label();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.GV_viewshopkeeper = new System.Windows.Forms.DataGridView();
            this.updateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlp_viewshopkeeper.SuspendLayout();
            this.pnl_viewshopkeeper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_viewshopkeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_viewshopkeeper
            // 
            this.tlp_viewshopkeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlp_viewshopkeeper.ColumnCount = 3;
            this.tlp_viewshopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8786F));
            this.tlp_viewshopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40668F));
            this.tlp_viewshopkeeper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56297F));
            this.tlp_viewshopkeeper.Controls.Add(this.pnl_viewshopkeeper, 0, 0);
            this.tlp_viewshopkeeper.Controls.Add(this.btn_cancle, 2, 3);
            this.tlp_viewshopkeeper.Controls.Add(this.GV_viewshopkeeper, 0, 2);
            this.tlp_viewshopkeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_viewshopkeeper.Location = new System.Drawing.Point(0, 0);
            this.tlp_viewshopkeeper.Name = "tlp_viewshopkeeper";
            this.tlp_viewshopkeeper.RowCount = 4;
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27558F));
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.654867F));
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.56637F));
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38053F));
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewshopkeeper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_viewshopkeeper.Size = new System.Drawing.Size(659, 452);
            this.tlp_viewshopkeeper.TabIndex = 2;
            // 
            // pnl_viewshopkeeper
            // 
            this.pnl_viewshopkeeper.BackColor = System.Drawing.Color.Silver;
            this.tlp_viewshopkeeper.SetColumnSpan(this.pnl_viewshopkeeper, 3);
            this.pnl_viewshopkeeper.Controls.Add(this.lbl_viewshopkeeper);
            this.pnl_viewshopkeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_viewshopkeeper.Location = new System.Drawing.Point(3, 3);
            this.pnl_viewshopkeeper.Name = "pnl_viewshopkeeper";
            this.pnl_viewshopkeeper.Size = new System.Drawing.Size(653, 40);
            this.pnl_viewshopkeeper.TabIndex = 0;
            // 
            // lbl_viewshopkeeper
            // 
            this.lbl_viewshopkeeper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_viewshopkeeper.AutoSize = true;
            this.lbl_viewshopkeeper.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewshopkeeper.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_viewshopkeeper.Location = new System.Drawing.Point(158, 0);
            this.lbl_viewshopkeeper.Name = "lbl_viewshopkeeper";
            this.lbl_viewshopkeeper.Size = new System.Drawing.Size(314, 36);
            this.lbl_viewshopkeeper.TabIndex = 3;
            this.lbl_viewshopkeeper.Text = "VIEW SHOPKEEPER";
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
            // GV_viewshopkeeper
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV_viewshopkeeper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_viewshopkeeper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_viewshopkeeper.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_viewshopkeeper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_viewshopkeeper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_viewshopkeeper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.updateColumn,
            this.deleteColumn});
            this.tlp_viewshopkeeper.SetColumnSpan(this.GV_viewshopkeeper, 3);
            this.GV_viewshopkeeper.Location = new System.Drawing.Point(3, 61);
            this.GV_viewshopkeeper.MinimumSize = new System.Drawing.Size(653, 322);
            this.GV_viewshopkeeper.Name = "GV_viewshopkeeper";
            this.GV_viewshopkeeper.Size = new System.Drawing.Size(653, 322);
            this.GV_viewshopkeeper.TabIndex = 16;
            this.GV_viewshopkeeper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_viewshopkeeper_CellContentClick);
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
            // form_viewShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.tlp_viewshopkeeper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "form_viewShopkeeper";
            this.Text = "Soft Drink Management System";
            this.Load += new System.EventHandler(this.form_viewShopkeeper_Load);
            this.tlp_viewshopkeeper.ResumeLayout(false);
            this.pnl_viewshopkeeper.ResumeLayout(false);
            this.pnl_viewshopkeeper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_viewshopkeeper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_viewshopkeeper;
        private System.Windows.Forms.Panel pnl_viewshopkeeper;
        private System.Windows.Forms.Label lbl_viewshopkeeper;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.DataGridView GV_viewshopkeeper;
        private System.Windows.Forms.DataGridViewButtonColumn updateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}