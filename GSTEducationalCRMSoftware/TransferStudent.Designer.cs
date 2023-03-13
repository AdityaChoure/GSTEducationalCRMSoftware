namespace GSTEducationalCRMSoftware
{
    partial class TransferStudent
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
            this.lblRemoveFromBatch = new System.Windows.Forms.Label();
            this.lblAddToBatch = new System.Windows.Forms.Label();
            this.cmbbxRemoveFromBatch = new System.Windows.Forms.ComboBox();
            this.cmbbxAddToBatch = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemoveFromBatch
            // 
            this.lblRemoveFromBatch.AutoSize = true;
            this.lblRemoveFromBatch.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveFromBatch.Location = new System.Drawing.Point(165, 109);
            this.lblRemoveFromBatch.Name = "lblRemoveFromBatch";
            this.lblRemoveFromBatch.Size = new System.Drawing.Size(104, 13);
            this.lblRemoveFromBatch.TabIndex = 0;
            this.lblRemoveFromBatch.Text = "Remove From Batch";
            // 
            // lblAddToBatch
            // 
            this.lblAddToBatch.AutoSize = true;
            this.lblAddToBatch.BackColor = System.Drawing.Color.Transparent;
            this.lblAddToBatch.Location = new System.Drawing.Point(165, 163);
            this.lblAddToBatch.Name = "lblAddToBatch";
            this.lblAddToBatch.Size = new System.Drawing.Size(73, 13);
            this.lblAddToBatch.TabIndex = 1;
            this.lblAddToBatch.Text = "Add To Batch";
            // 
            // cmbbxRemoveFromBatch
            // 
            this.cmbbxRemoveFromBatch.FormattingEnabled = true;
            this.cmbbxRemoveFromBatch.Location = new System.Drawing.Point(409, 100);
            this.cmbbxRemoveFromBatch.Name = "cmbbxRemoveFromBatch";
            this.cmbbxRemoveFromBatch.Size = new System.Drawing.Size(121, 21);
            this.cmbbxRemoveFromBatch.TabIndex = 2;
            // 
            // cmbbxAddToBatch
            // 
            this.cmbbxAddToBatch.FormattingEnabled = true;
            this.cmbbxAddToBatch.Location = new System.Drawing.Point(409, 160);
            this.cmbbxAddToBatch.Name = "cmbbxAddToBatch";
            this.cmbbxAddToBatch.Size = new System.Drawing.Size(121, 21);
            this.cmbbxAddToBatch.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(238, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(395, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // TransferStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbbxAddToBatch);
            this.Controls.Add(this.cmbbxRemoveFromBatch);
            this.Controls.Add(this.lblAddToBatch);
            this.Controls.Add(this.lblRemoveFromBatch);
            this.Name = "TransferStudent";
            this.Text = "TransferStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveFromBatch;
        private System.Windows.Forms.Label lblAddToBatch;
        private System.Windows.Forms.ComboBox cmbbxRemoveFromBatch;
        private System.Windows.Forms.ComboBox cmbbxAddToBatch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}