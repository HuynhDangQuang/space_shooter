﻿namespace Space_Shooter.AccountManagement
{
    partial class ForgotPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.btn_sentPassword = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pn_border = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.pn_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sentPassword
            // 
            this.btn_sentPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sentPassword.BackColor = System.Drawing.Color.DimGray;
            this.btn_sentPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sentPassword.BackgroundImage")));
            this.btn_sentPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sentPassword.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sentPassword.ForeColor = System.Drawing.Color.Khaki;
            this.btn_sentPassword.Location = new System.Drawing.Point(160, 416);
            this.btn_sentPassword.Name = "btn_sentPassword";
            this.btn_sentPassword.Size = new System.Drawing.Size(313, 71);
            this.btn_sentPassword.TabIndex = 13;
            this.btn_sentPassword.Text = "SENT PASSWORD";
            this.btn_sentPassword.UseVisualStyleBackColor = false;
            this.btn_sentPassword.Click += new System.EventHandler(this.btn_sentPassword_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Lime;
            this.lb_Email.Location = new System.Drawing.Point(26, 83);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(406, 27);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Enter Your Email";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.DarkBlue;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(31, 155);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(560, 35);
            this.tb_email.TabIndex = 11;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(0, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(55, 50);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 14;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pn_border
            // 
            this.pn_border.BackColor = System.Drawing.Color.Transparent;
            this.pn_border.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_border.BackgroundImage")));
            this.pn_border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_border.Controls.Add(this.lb_Email);
            this.pn_border.Controls.Add(this.tb_email);
            this.pn_border.Controls.Add(this.btn_sentPassword);
            this.pn_border.Location = new System.Drawing.Point(123, 203);
            this.pn_border.Name = "pn_border";
            this.pn_border.Size = new System.Drawing.Size(617, 581);
            this.pn_border.TabIndex = 15;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_border);
            this.Controls.Add(this.pb_exit);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(1582, 1053);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.pn_border.ResumeLayout(false);
            this.pn_border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sentPassword;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Panel pn_border;
    }
}
