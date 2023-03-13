namespace GSTEducationalCRMSoftware
{
    partial class ChangePassword
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtbxConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txtbxEnterNewPass = new System.Windows.Forms.TextBox();
            this.lblEnternewpass = new System.Windows.Forms.Label();
            this.lblConfirmnewpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(283, 293);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(178, 23);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtbxConfirmNewPass
            // 
            this.txtbxConfirmNewPass.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmNewPass.Location = new System.Drawing.Point(362, 210);
            this.txtbxConfirmNewPass.Name = "txtbxConfirmNewPass";
            this.txtbxConfirmNewPass.Size = new System.Drawing.Size(208, 21);
            this.txtbxConfirmNewPass.TabIndex = 11;
            // 
            // txtbxEnterNewPass
            // 
            this.txtbxEnterNewPass.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEnterNewPass.Location = new System.Drawing.Point(362, 116);
            this.txtbxEnterNewPass.Name = "txtbxEnterNewPass";
            this.txtbxEnterNewPass.Size = new System.Drawing.Size(208, 21);
            this.txtbxEnterNewPass.TabIndex = 8;
            // 
            // lblEnternewpass
            // 
            this.lblEnternewpass.AutoSize = true;
            this.lblEnternewpass.BackColor = System.Drawing.Color.Transparent;
            this.lblEnternewpass.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnternewpass.Location = new System.Drawing.Point(153, 119);
            this.lblEnternewpass.Name = "lblEnternewpass";
            this.lblEnternewpass.Size = new System.Drawing.Size(125, 15);
            this.lblEnternewpass.TabIndex = 7;
            this.lblEnternewpass.Text = "Enter New Password";
            // 
            // lblConfirmnewpass
            // 
            this.lblConfirmnewpass.AutoSize = true;
            this.lblConfirmnewpass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmnewpass.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmnewpass.Location = new System.Drawing.Point(153, 213);
            this.lblConfirmnewpass.Name = "lblConfirmnewpass";
            this.lblConfirmnewpass.Size = new System.Drawing.Size(140, 15);
            this.lblConfirmnewpass.TabIndex = 13;
            this.lblConfirmnewpass.Text = "Confirm New Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConfirmnewpass);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtbxConfirmNewPass);
            this.Controls.Add(this.txtbxEnterNewPass);
            this.Controls.Add(this.lblEnternewpass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtbxConfirmNewPass;
        private System.Windows.Forms.TextBox txtbxEnterNewPass;
        private System.Windows.Forms.Label lblEnternewpass;
        private System.Windows.Forms.Label lblConfirmnewpass;
    }
}