namespace cocosubbetaversion
{
    partial class checkout_page 
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
            this.sub_plan_name = new System.Windows.Forms.Label();
            this.sub_cost = new System.Windows.Forms.Label();
            this.discount_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.sub_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.sub_total_cost = new System.Windows.Forms.Label();
            this.discount_amont = new System.Windows.Forms.Label();
            this.total_amount = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.appply_button = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_buton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // sub_plan_name
            // 
            this.sub_plan_name.AutoSize = true;
            this.sub_plan_name.BackColor = System.Drawing.Color.Transparent;
            this.sub_plan_name.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_plan_name.Location = new System.Drawing.Point(390, 255);
            this.sub_plan_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sub_plan_name.Name = "sub_plan_name";
            this.sub_plan_name.Size = new System.Drawing.Size(130, 60);
            this.sub_plan_name.TabIndex = 4;
            this.sub_plan_name.Text = "Basic";
            // 
            // sub_cost
            // 
            this.sub_cost.AutoSize = true;
            this.sub_cost.BackColor = System.Drawing.Color.Transparent;
            this.sub_cost.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_cost.Location = new System.Drawing.Point(389, 330);
            this.sub_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sub_cost.Name = "sub_cost";
            this.sub_cost.Size = new System.Drawing.Size(92, 54);
            this.sub_cost.TabIndex = 6;
            this.sub_cost.Text = "$35";
            // 
            // discount_text
            // 
            this.discount_text.AutoRoundedCorners = true;
            this.discount_text.BackColor = System.Drawing.Color.Transparent;
            this.discount_text.BorderRadius = 25;
            this.discount_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discount_text.DefaultText = "";
            this.discount_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.discount_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.discount_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discount_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discount_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discount_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discount_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discount_text.Location = new System.Drawing.Point(391, 459);
            this.discount_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discount_text.Name = "discount_text";
            this.discount_text.PasswordChar = '\0';
            this.discount_text.PlaceholderText = "";
            this.discount_text.SelectedText = "";
            this.discount_text.Size = new System.Drawing.Size(329, 53);
            this.discount_text.TabIndex = 7;
            // 
            // sub_label
            // 
            this.sub_label.AutoSize = true;
            this.sub_label.BackColor = System.Drawing.Color.Transparent;
            this.sub_label.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_label.Location = new System.Drawing.Point(390, 540);
            this.sub_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sub_label.Name = "sub_label";
            this.sub_label.Size = new System.Drawing.Size(163, 46);
            this.sub_label.TabIndex = 8;
            this.sub_label.Text = "Sub Total";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.BackColor = System.Drawing.Color.Transparent;
            this.discount_label.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_label.Location = new System.Drawing.Point(390, 600);
            this.discount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(156, 46);
            this.discount_label.TabIndex = 9;
            this.discount_label.Text = "Discount";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.BackColor = System.Drawing.Color.Transparent;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(390, 679);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(99, 46);
            this.total_label.TabIndex = 10;
            this.total_label.Text = "Total";
            // 
            // sub_total_cost
            // 
            this.sub_total_cost.AutoSize = true;
            this.sub_total_cost.BackColor = System.Drawing.Color.Transparent;
            this.sub_total_cost.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total_cost.Location = new System.Drawing.Point(643, 540);
            this.sub_total_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sub_total_cost.Name = "sub_total_cost";
            this.sub_total_cost.Size = new System.Drawing.Size(77, 46);
            this.sub_total_cost.TabIndex = 11;
            this.sub_total_cost.Text = "$35";
            // 
            // discount_amont
            // 
            this.discount_amont.AutoSize = true;
            this.discount_amont.BackColor = System.Drawing.Color.Transparent;
            this.discount_amont.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_amont.Location = new System.Drawing.Point(643, 600);
            this.discount_amont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_amont.Name = "discount_amont";
            this.discount_amont.Size = new System.Drawing.Size(104, 46);
            this.discount_amont.TabIndex = 12;
            this.discount_amont.Text = "$0.00";
            // 
            // total_amount
            // 
            this.total_amount.AutoSize = true;
            this.total_amount.BackColor = System.Drawing.Color.Transparent;
            this.total_amount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount.Location = new System.Drawing.Point(643, 679);
            this.total_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(80, 46);
            this.total_amount.TabIndex = 13;
            this.total_amount.Text = "$30";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(879, 827);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(368, 55);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "SUBSCRIBE NOW";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // appply_button
            // 
            this.appply_button.AutoRoundedCorners = true;
            this.appply_button.BackColor = System.Drawing.Color.Transparent;
            this.appply_button.BorderRadius = 26;
            this.appply_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.appply_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.appply_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.appply_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.appply_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.appply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appply_button.ForeColor = System.Drawing.Color.White;
            this.appply_button.Location = new System.Drawing.Point(728, 459);
            this.appply_button.Margin = new System.Windows.Forms.Padding(4);
            this.appply_button.Name = "appply_button";
            this.appply_button.Size = new System.Drawing.Size(207, 55);
            this.appply_button.TabIndex = 15;
            this.appply_button.Text = "APPLY NOW";
            this.appply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "/ per Month";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_buton
            // 
            this.back_buton.AutoRoundedCorners = true;
            this.back_buton.BackColor = System.Drawing.Color.Transparent;
            this.back_buton.BorderRadius = 26;
            this.back_buton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_buton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_buton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_buton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_buton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.back_buton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.back_buton.ForeColor = System.Drawing.Color.White;
            this.back_buton.Location = new System.Drawing.Point(16, 827);
            this.back_buton.Margin = new System.Windows.Forms.Padding(4);
            this.back_buton.Name = "back_buton";
            this.back_buton.Size = new System.Drawing.Size(176, 55);
            this.back_buton.TabIndex = 17;
            this.back_buton.Text = "Back";
            this.back_buton.UseTransparentBackground = true;
            // 
            // checkout_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cocosubbetaversion.Properties.Resources.C__x_CocoSub__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.back_buton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appply_button);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.total_amount);
            this.Controls.Add(this.discount_amont);
            this.Controls.Add(this.sub_total_cost);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.sub_label);
            this.Controls.Add(this.discount_text);
            this.Controls.Add(this.sub_cost);
            this.Controls.Add(this.sub_plan_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "checkout_page";
            this.Text = "s";
            this.Load += new System.EventHandler(this.checkout_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label sub_plan_name;
        private System.Windows.Forms.Label sub_cost;
        private Guna.UI2.WinForms.Guna2TextBox discount_text;
        private System.Windows.Forms.Label sub_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label sub_total_cost;
        private System.Windows.Forms.Label discount_amont;
        private System.Windows.Forms.Label total_amount;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button appply_button;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button back_buton;
    }
}