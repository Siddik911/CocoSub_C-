using System.Windows.Forms;

namespace cocosubbetaversion
{
    partial class forgot_page
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
            this.forgot_email_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.new_password_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirm_password_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.send_button = new Guna.UI2.WinForms.Guna2Button();
            this.showcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // forgot_email_text
            // 
            this.forgot_email_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forgot_email_text.AutoRoundedCorners = true;
            this.forgot_email_text.BackColor = System.Drawing.Color.Transparent;
            this.forgot_email_text.BorderRadius = 20;
            this.forgot_email_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.forgot_email_text.DefaultText = "";
            this.forgot_email_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgot_email_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgot_email_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_email_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_email_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_email_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgot_email_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_email_text.Location = new System.Drawing.Point(551, 320);
            this.forgot_email_text.Name = "forgot_email_text";
            this.forgot_email_text.PasswordChar = '\0';
            this.forgot_email_text.PlaceholderText = "";
            this.forgot_email_text.SelectedText = "";
            this.forgot_email_text.Size = new System.Drawing.Size(277, 43);
            this.forgot_email_text.TabIndex = 0;
            this.forgot_email_text.TextChanged += new System.EventHandler(this.forgot_email_text_TextChanged);
            // 
            // new_password_text
            // 
            this.new_password_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_password_text.AutoRoundedCorners = true;
            this.new_password_text.BackColor = System.Drawing.Color.Transparent;
            this.new_password_text.BorderRadius = 19;
            this.new_password_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_password_text.DefaultText = "";
            this.new_password_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.new_password_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.new_password_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.new_password_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.new_password_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_password_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_password_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_password_text.Location = new System.Drawing.Point(551, 397);
            this.new_password_text.Name = "new_password_text";
            this.new_password_text.PasswordChar = '\0';
            this.new_password_text.PlaceholderText = "";
            this.new_password_text.SelectedText = "";
            this.new_password_text.Size = new System.Drawing.Size(277, 40);
            this.new_password_text.TabIndex = 1;
            // 
            // confirm_password_text
            // 
            this.confirm_password_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_password_text.AutoRoundedCorners = true;
            this.confirm_password_text.BackColor = System.Drawing.Color.Transparent;
            this.confirm_password_text.BorderRadius = 17;
            this.confirm_password_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_password_text.DefaultText = "";
            this.confirm_password_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirm_password_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirm_password_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirm_password_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirm_password_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirm_password_text.Location = new System.Drawing.Point(551, 481);
            this.confirm_password_text.Name = "confirm_password_text";
            this.confirm_password_text.PasswordChar = '\0';
            this.confirm_password_text.PlaceholderText = "";
            this.confirm_password_text.SelectedText = "";
            this.confirm_password_text.Size = new System.Drawing.Size(277, 36);
            this.confirm_password_text.TabIndex = 2;
            this.confirm_password_text.TextChanged += new System.EventHandler(this.confirm_password_TextChanged);
            // 
            // send_button
            // 
            this.send_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_button.AutoRoundedCorners = true;
            this.send_button.BackColor = System.Drawing.Color.Transparent;
            this.send_button.BorderRadius = 15;
            this.send_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.send_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.send_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.send_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.send_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.send_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.ForeColor = System.Drawing.Color.White;
            this.send_button.Location = new System.Drawing.Point(642, 554);
            this.send_button.Margin = new System.Windows.Forms.Padding(2);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(120, 32);
            this.send_button.TabIndex = 3;
            this.send_button.Text = "Send";
            // 
            // showcheck
            // 
            this.showcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showcheck.AutoSize = true;
            this.showcheck.BackColor = System.Drawing.Color.Transparent;
            this.showcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.showcheck.Location = new System.Drawing.Point(729, 522);
            this.showcheck.Margin = new System.Windows.Forms.Padding(2);
            this.showcheck.Name = "showcheck";
            this.showcheck.Size = new System.Drawing.Size(77, 28);
            this.showcheck.TabIndex = 4;
            this.showcheck.Text = "Show";
            this.showcheck.UseVisualStyleBackColor = false;
            this.showcheck.CheckedChanged += new System.EventHandler(this.showcheck_CheckedChanged);
            // 
            // forgot_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__20_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.showcheck);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.confirm_password_text);
            this.Controls.Add(this.new_password_text);
            this.Controls.Add(this.forgot_email_text);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "forgot_page";
            this.Text = "forgot_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox forgot_email_text;
        private Guna.UI2.WinForms.Guna2TextBox new_password_text;
        private Guna.UI2.WinForms.Guna2TextBox confirm_password_text;
        private Guna.UI2.WinForms.Guna2Button send_button;
        private CheckBox showcheck;
    }
}
