namespace cocosubbetaversion
{
    partial class succesful_subscriber
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
            this.redeem_button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // redeem_button
            // 
            this.redeem_button.AutoRoundedCorners = true;
            this.redeem_button.BackColor = System.Drawing.Color.Transparent;
            this.redeem_button.BorderRadius = 21;
            this.redeem_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.redeem_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.redeem_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.redeem_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.redeem_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.redeem_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeem_button.ForeColor = System.Drawing.Color.White;
            this.redeem_button.Location = new System.Drawing.Point(427, 599);
            this.redeem_button.Name = "redeem_button";
            this.redeem_button.Size = new System.Drawing.Size(180, 45);
            this.redeem_button.TabIndex = 0;
            this.redeem_button.Text = "Redeem Now";
            // 
            // succesful_subscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__29_;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.redeem_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "succesful_subscriber";
            this.Text = "succesful_subscriber";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button redeem_button;
    }
}