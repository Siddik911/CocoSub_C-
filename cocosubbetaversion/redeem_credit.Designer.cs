namespace cocosubbetaversion
{
    partial class redeem_credit
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
            this.drink_list = new Guna.UI2.WinForms.Guna2ComboBox();
            this.special_instraction = new Guna.UI2.WinForms.Guna2TextBox();
            this.submit_order = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // drink_list
            // 
            this.drink_list.BackColor = System.Drawing.Color.Transparent;
            this.drink_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drink_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drink_list.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.drink_list.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.drink_list.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.drink_list.ForeColor = System.Drawing.Color.Black;
            this.drink_list.ItemHeight = 30;
            this.drink_list.Location = new System.Drawing.Point(75, 298);
            this.drink_list.Name = "drink_list";
            this.drink_list.Size = new System.Drawing.Size(396, 36);
            this.drink_list.TabIndex = 0;
            // 
            // special_instraction
            // 
            this.special_instraction.BackColor = System.Drawing.Color.Transparent;
            this.special_instraction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.special_instraction.DefaultText = "";
            this.special_instraction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.special_instraction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.special_instraction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.special_instraction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.special_instraction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.special_instraction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.special_instraction.ForeColor = System.Drawing.Color.Black;
            this.special_instraction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.special_instraction.Location = new System.Drawing.Point(75, 390);
            this.special_instraction.Name = "special_instraction";
            this.special_instraction.PasswordChar = '\0';
            this.special_instraction.PlaceholderText = "";
            this.special_instraction.SelectedText = "";
            this.special_instraction.Size = new System.Drawing.Size(396, 112);
            this.special_instraction.TabIndex = 1;
            // 
            // submit_order
            // 
            this.submit_order.AutoRoundedCorners = true;
            this.submit_order.BackColor = System.Drawing.Color.Transparent;
            this.submit_order.BorderRadius = 21;
            this.submit_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit_order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.submit_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_order.ForeColor = System.Drawing.Color.White;
            this.submit_order.Location = new System.Drawing.Point(506, 342);
            this.submit_order.Name = "submit_order";
            this.submit_order.Size = new System.Drawing.Size(180, 45);
            this.submit_order.TabIndex = 2;
            this.submit_order.Text = "Submit order";
            // 
            // redeem_credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__32_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.submit_order);
            this.Controls.Add(this.special_instraction);
            this.Controls.Add(this.drink_list);
            this.DoubleBuffered = true;
            this.Name = "redeem_credit";
            this.Text = "redeem_credit";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox drink_list;
        private Guna.UI2.WinForms.Guna2TextBox special_instraction;
        private Guna.UI2.WinForms.Guna2Button submit_order;
    }
}