﻿using System.Windows.Forms;

namespace cocosubbetaversion
{
    partial class signup
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
            this.signupbutton = new Guna.UI2.WinForms.Guna2Button();
            this.nametext = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passwordtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.back_button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // signupbutton
            // 
            this.signupbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signupbutton.AutoRoundedCorners = true;
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.signupbutton.BorderRadius = 15;
            this.signupbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.signupbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(957, 713);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(160, 33);
            this.signupbutton.TabIndex = 0;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseTransparentBackground = true;
            this.signupbutton.Click += new System.EventHandler(this.signup_Click);
            // 
            // nametext
            // 
            this.nametext.AutoRoundedCorners = true;
            this.nametext.BackColor = System.Drawing.Color.Transparent;
            this.nametext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nametext.BorderRadius = 21;
            this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametext.DefaultText = "";
            this.nametext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nametext.ForeColor = System.Drawing.Color.Black;
            this.nametext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametext.Location = new System.Drawing.Point(724, 386);
            this.nametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametext.Name = "nametext";
            this.nametext.PasswordChar = '\0';
            this.nametext.PlaceholderText = "";
            this.nametext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nametext.SelectedText = "";
            this.nametext.Size = new System.Drawing.Size(373, 44);
            this.nametext.TabIndex = 1;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // emailtext
            // 
            this.emailtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtext.AutoRoundedCorners = true;
            this.emailtext.BackColor = System.Drawing.Color.Transparent;
            this.emailtext.BorderRadius = 19;
            this.emailtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtext.DefaultText = "";
            this.emailtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtext.ForeColor = System.Drawing.Color.Black;
            this.emailtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtext.Location = new System.Drawing.Point(724, 483);
            this.emailtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtext.Name = "emailtext";
            this.emailtext.PasswordChar = '\0';
            this.emailtext.PlaceholderText = "";
            this.emailtext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailtext.SelectedText = "";
            this.emailtext.Size = new System.Drawing.Size(373, 41);
            this.emailtext.TabIndex = 3;
            this.emailtext.TextChanged += new System.EventHandler(this.emailtext_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(764, 670);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtext.AutoRoundedCorners = true;
            this.passwordtext.BackColor = System.Drawing.Color.Transparent;
            this.passwordtext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordtext.BorderRadius = 17;
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.DefaultText = "";
            this.passwordtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtext.ForeColor = System.Drawing.Color.Black;
            this.passwordtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtext.Location = new System.Drawing.Point(724, 586);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '\0';
            this.passwordtext.PlaceholderText = "";
            this.passwordtext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordtext.SelectedText = "";
            this.passwordtext.Size = new System.Drawing.Size(373, 37);
            this.passwordtext.TabIndex = 5;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // back_button
            // 
            this.back_button.AutoRoundedCorners = true;
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BorderRadius = 15;
            this.back_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(744, 713);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(160, 33);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseTransparentBackground = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__18_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.signupbutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "signup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button signupbutton;
        private Guna.UI2.WinForms.Guna2TextBox nametext;
        private Guna.UI2.WinForms.Guna2TextBox emailtext;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2TextBox passwordtext;
        private Guna.UI2.WinForms.Guna2Button back_button;
    }
}
