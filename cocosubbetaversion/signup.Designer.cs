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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // signupbutton
            // 
            this.signupbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signupbutton.AutoRoundedCorners = true;
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.signupbutton.BorderRadius = 12;
            this.signupbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.signupbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(636, 583);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(120, 27);
            this.signupbutton.TabIndex = 0;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseTransparentBackground = true;
            this.signupbutton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // nametext
            // 
            this.nametext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nametext.AutoRoundedCorners = true;
            this.nametext.BackColor = System.Drawing.Color.Transparent;
            this.nametext.BorderRadius = 12;
            this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametext.DefaultText = "";
            this.nametext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nametext.ForeColor = System.Drawing.Color.Transparent;
            this.nametext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametext.Location = new System.Drawing.Point(558, 322);
            this.nametext.Name = "nametext";
            this.nametext.PasswordChar = '\0';
            this.nametext.PlaceholderText = "";
            this.nametext.SelectedText = "";
            this.nametext.Size = new System.Drawing.Size(280, 27);
            this.nametext.TabIndex = 1;
            // 
            // emailtext
            // 
            this.emailtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailtext.AutoRoundedCorners = true;
            this.emailtext.BackColor = System.Drawing.Color.Transparent;
            this.emailtext.BorderRadius = 10;
            this.emailtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtext.DefaultText = "";
            this.emailtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtext.ForeColor = System.Drawing.Color.Transparent;
            this.emailtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtext.Location = new System.Drawing.Point(558, 404);
            this.emailtext.Name = "emailtext";
            this.emailtext.PasswordChar = '\0';
            this.emailtext.PlaceholderText = "";
            this.emailtext.SelectedText = "";
            this.emailtext.Size = new System.Drawing.Size(280, 23);
            this.emailtext.TabIndex = 3;
            this.emailtext.TextChanged += new System.EventHandler(this.emailtext_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(573, 544);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 14;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(558, 478);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(280, 30);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__18_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.signupbutton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "signup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button signupbutton;
        private Guna.UI2.WinForms.Guna2TextBox nametext;
        private Guna.UI2.WinForms.Guna2TextBox emailtext;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
