using System.Windows.Forms;

namespace cocosubbetaversion
{
    partial class admin_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_button = new Guna.UI2.WinForms.Guna2Button();
            this.order_button = new Guna.UI2.WinForms.Guna2Button();
            this.payment_button = new Guna.UI2.WinForms.Guna2Button();
            this.gridview_order_admin = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_order_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // user_button
            // 
            this.user_button.AutoRoundedCorners = true;
            this.user_button.BackColor = System.Drawing.Color.Transparent;
            this.user_button.BorderRadius = 21;
            this.user_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user_button.FillColor = System.Drawing.Color.White;
            this.user_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.user_button.ForeColor = System.Drawing.Color.Black;
            this.user_button.Location = new System.Drawing.Point(33, 212);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(180, 45);
            this.user_button.TabIndex = 0;
            this.user_button.Text = "USERS";
            this.user_button.UseTransparentBackground = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // order_button
            // 
            this.order_button.AutoRoundedCorners = true;
            this.order_button.BackColor = System.Drawing.Color.Transparent;
            this.order_button.BorderRadius = 21;
            this.order_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.order_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.order_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.order_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.order_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.order_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.order_button.ForeColor = System.Drawing.Color.White;
            this.order_button.Location = new System.Drawing.Point(33, 366);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(180, 45);
            this.order_button.TabIndex = 1;
            this.order_button.Text = "ORDERS";
            this.order_button.UseTransparentBackground = true;
            // 
            // payment_button
            // 
            this.payment_button.AutoRoundedCorners = true;
            this.payment_button.BackColor = System.Drawing.Color.Transparent;
            this.payment_button.BorderRadius = 21;
            this.payment_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payment_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payment_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payment_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payment_button.FillColor = System.Drawing.Color.White;
            this.payment_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_button.ForeColor = System.Drawing.Color.Black;
            this.payment_button.Location = new System.Drawing.Point(33, 518);
            this.payment_button.Name = "payment_button";
            this.payment_button.Size = new System.Drawing.Size(180, 45);
            this.payment_button.TabIndex = 3;
            this.payment_button.Text = "PAYMENTS";
            this.payment_button.UseTransparentBackground = true;
            this.payment_button.Click += new System.EventHandler(this.payment_button_Click);
            // 
            // gridview_order_admin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_order_admin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_order_admin.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_order_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_order_admin.ColumnHeadersHeight = 4;
            this.gridview_order_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_order_admin.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_order_admin.GridColor = System.Drawing.Color.Wheat;
            this.gridview_order_admin.Location = new System.Drawing.Point(312, 212);
            this.gridview_order_admin.Name = "gridview_order_admin";
            this.gridview_order_admin.RowHeadersVisible = false;
            this.gridview_order_admin.Size = new System.Drawing.Size(571, 293);
            this.gridview_order_admin.TabIndex = 4;
            this.gridview_order_admin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_order_admin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_order_admin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_order_admin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_order_admin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_order_admin.ThemeStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gridview_order_admin.ThemeStyle.GridColor = System.Drawing.Color.Wheat;
            this.gridview_order_admin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_order_admin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_order_admin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_order_admin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_order_admin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_order_admin.ThemeStyle.HeaderStyle.Height = 4;
            this.gridview_order_admin.ThemeStyle.ReadOnly = false;
            this.gridview_order_admin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_order_admin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_order_admin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_order_admin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_order_admin.ThemeStyle.RowsStyle.Height = 22;
            this.gridview_order_admin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_order_admin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_order_admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_order_admin_CellContentClick);
            // 
            // admin_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__34_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gridview_order_admin);
            this.Controls.Add(this.payment_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.user_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "admin_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_order";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_order_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button user_button;
        private Guna.UI2.WinForms.Guna2Button order_button;
        private Guna.UI2.WinForms.Guna2Button payment_button;
        private Guna.UI2.WinForms.Guna2DataGridView gridview_order_admin;
    }
}