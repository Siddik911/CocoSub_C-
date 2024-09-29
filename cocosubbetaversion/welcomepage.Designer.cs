using System.Windows.Forms;

namespace cocosubbetaversion
{
    partial class welcomepage
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
            this.alreadyuser = new Guna.UI2.WinForms.Guna2Button();
            this.newuser = new Guna.UI2.WinForms.Guna2Button();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // alreadyuser
            // 
            this.alreadyuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.alreadyuser.AutoRoundedCorners = true;
            this.alreadyuser.BackColor = System.Drawing.Color.Transparent;
            this.alreadyuser.BorderRadius = 23;
            this.alreadyuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.alreadyuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.alreadyuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.alreadyuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.alreadyuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.alreadyuser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.alreadyuser.ForeColor = System.Drawing.Color.White;
            this.alreadyuser.Location = new System.Drawing.Point(395, 775);
            this.alreadyuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alreadyuser.Name = "alreadyuser";
            this.alreadyuser.Size = new System.Drawing.Size(285, 48);
            this.alreadyuser.TabIndex = 0;
            this.alreadyuser.Text = "Already an user ";
            this.alreadyuser.UseTransparentBackground = true;
            this.alreadyuser.Click += new System.EventHandler(this.alreadyuser_Click);
            // 
            // newuser
            // 
            this.newuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newuser.AutoRoundedCorners = true;
            this.newuser.BackColor = System.Drawing.Color.Transparent;
            this.newuser.BorderRadius = 23;
            this.newuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.newuser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.newuser.ForeColor = System.Drawing.Color.White;
            this.newuser.Location = new System.Drawing.Point(733, 775);
            this.newuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newuser.Name = "newuser";
            this.newuser.Size = new System.Drawing.Size(285, 48);
            this.newuser.TabIndex = 1;
            this.newuser.Text = "New User";
            this.newuser.UseTransparentBackground = true;
            this.newuser.Click += new System.EventHandler(this.newuser_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoRoundedCorners = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BorderRadius = 21;
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1144, 55);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(137, 44);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1287, 55);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(43, 44);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "?";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // welcomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__17_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.newuser);
            this.Controls.Add(this.alreadyuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "welcomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcomepage";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button alreadyuser;
        private Guna.UI2.WinForms.Guna2Button newuser;
        private Guna.UI2.WinForms.Guna2Button exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
