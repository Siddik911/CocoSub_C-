using System.Windows.Forms;

namespace cocosubbetaversion
{
    partial class loginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.login_name_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_pass_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // login_name_text
            // 
            this.login_name_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.login_name_text.AutoRoundedCorners = true;
            this.login_name_text.BackColor = System.Drawing.Color.Transparent;
            this.login_name_text.BorderColor = System.Drawing.Color.Transparent;
            this.login_name_text.BorderRadius = 22;
            this.login_name_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_name_text.DefaultText = "";
            this.login_name_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_name_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_name_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_name_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_name_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_name_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_name_text.ForeColor = System.Drawing.Color.Black;
            this.login_name_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_name_text.Location = new System.Drawing.Point(553, 331);
            this.login_name_text.Name = "login_name_text";
            this.login_name_text.PasswordChar = '\0';
            this.login_name_text.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.login_name_text.PlaceholderText = "";
            this.login_name_text.SelectedText = "";
            this.login_name_text.Size = new System.Drawing.Size(318, 46);
            this.login_name_text.TabIndex = 0;
            this.login_name_text.TextChanged += new System.EventHandler(this.login_name_text_TextChanged);
            // 
            // login_pass_text
            // 
            this.login_pass_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.login_pass_text.AutoRoundedCorners = true;
            this.login_pass_text.BackColor = System.Drawing.Color.Transparent;
            this.login_pass_text.BorderColor = System.Drawing.Color.Transparent;
            this.login_pass_text.BorderRadius = 23;
            this.login_pass_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_pass_text.DefaultText = "";
            this.login_pass_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_pass_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_pass_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_pass_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_pass_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_pass_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_pass_text.ForeColor = System.Drawing.Color.Black;
            this.login_pass_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_pass_text.Location = new System.Drawing.Point(553, 417);
            this.login_pass_text.Name = "login_pass_text";
            this.login_pass_text.PasswordChar = '●';
            this.login_pass_text.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.login_pass_text.PlaceholderText = "";
            this.login_pass_text.SelectedText = "";
            this.login_pass_text.Size = new System.Drawing.Size(318, 49);
            this.login_pass_text.TabIndex = 1;
            this.login_pass_text.TextChanged += new System.EventHandler(this.login_pass_text_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.checkBox1.Location = new System.Drawing.Point(698, 471);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BorderColor = System.Drawing.Color.Transparent;
            this.login_button.BorderRadius = 17;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(644, 518);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(140, 36);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log In";
            this.login_button.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__35_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.login_pass_text);
            this.Controls.Add(this.login_name_text);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "loginPage";
            this.Text = "loginPage";
            this.Load += new System.EventHandler(this.loginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox login_name_text;
        private Guna.UI2.WinForms.Guna2TextBox login_pass_text;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button login_button;
    }
}
