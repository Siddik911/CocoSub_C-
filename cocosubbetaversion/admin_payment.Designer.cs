﻿namespace cocosubbetaversion
{
    partial class admin_payment
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

        private System.Windows.Forms.DataGridView gridview_payment_admin;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_button = new Guna.UI2.WinForms.Guna2Button();
            this.order_button = new Guna.UI2.WinForms.Guna2Button();
            this.payment_button = new Guna.UI2.WinForms.Guna2Button();
            this.gridview_payment_admin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_payment_admin)).BeginInit();
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
            this.user_button.Location = new System.Drawing.Point(37, 200);
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
            this.order_button.FillColor = System.Drawing.Color.White;
            this.order_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.order_button.ForeColor = System.Drawing.Color.Black;
            this.order_button.Location = new System.Drawing.Point(37, 363);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(180, 45);
            this.order_button.TabIndex = 1;
            this.order_button.Text = "ORDERS";
            this.order_button.UseTransparentBackground = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
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
            this.payment_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.payment_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.payment_button.ForeColor = System.Drawing.Color.White;
            this.payment_button.Location = new System.Drawing.Point(37, 520);
            this.payment_button.Name = "payment_button";
            this.payment_button.Size = new System.Drawing.Size(180, 45);
            this.payment_button.TabIndex = 3;
            this.payment_button.Text = "PAYMENTS";
            this.payment_button.UseTransparentBackground = true;
            this.payment_button.Click += new System.EventHandler(this.payment_button_Click);
            // 
            // gridview_payment_admin
            // 
            this.gridview_payment_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_payment_admin.Location = new System.Drawing.Point(266, 180);
            this.gridview_payment_admin.Name = "gridview_payment_admin";
            this.gridview_payment_admin.Size = new System.Drawing.Size(718, 425);
            this.gridview_payment_admin.TabIndex = 0;
            // 
            // admin_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__34_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gridview_payment_admin);
            this.Controls.Add(this.payment_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.user_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "admin_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_payment";
            this.Load += new System.EventHandler(this.admin_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_payment_admin)).EndInit();
            this.ResumeLayout(false);

        }








        #endregion

        private Guna.UI2.WinForms.Guna2Button user_button;
        private Guna.UI2.WinForms.Guna2Button order_button;
        private Guna.UI2.WinForms.Guna2Button payment_button;
    }
}