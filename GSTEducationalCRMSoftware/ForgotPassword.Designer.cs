namespace GSTEducationalCRMSoftware
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblEnterEmailAddress = new System.Windows.Forms.Label();
            this.txtbxEnterYourEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.Image = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.lblForgotPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgotPassword.Location = new System.Drawing.Point(298, 25);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(130, 17);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "Forgot Password";
            // 
            // lblEnterEmailAddress
            // 
            this.lblEnterEmailAddress.AutoSize = true;
            this.lblEnterEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterEmailAddress.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmailAddress.Location = new System.Drawing.Point(307, 141);
            this.lblEnterEmailAddress.Name = "lblEnterEmailAddress";
            this.lblEnterEmailAddress.Size = new System.Drawing.Size(157, 15);
            this.lblEnterEmailAddress.TabIndex = 1;
            this.lblEnterEmailAddress.Text = "Enter Your Email Address";
            // 
            // txtbxEnterYourEmail
            // 
            this.txtbxEnterYourEmail.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEnterYourEmail.Location = new System.Drawing.Point(287, 180);
            this.txtbxEnterYourEmail.Name = "txtbxEnterYourEmail";
            this.txtbxEnterYourEmail.Size = new System.Drawing.Size(208, 21);
            this.txtbxEnterYourEmail.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(287, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send ";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(420, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtbxEnterYourEmail);
            this.Controls.Add(this.lblEnterEmailAddress);
            this.Controls.Add(this.lblForgotPassword);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblEnterEmailAddress;
        private System.Windows.Forms.TextBox txtbxEnterYourEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBack;
    }
}