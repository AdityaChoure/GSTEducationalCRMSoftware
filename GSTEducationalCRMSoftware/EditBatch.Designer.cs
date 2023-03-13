namespace GSTEducationalCRMSoftware
{
    partial class EditBatch
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
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblBatchTime = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpSd = new System.Windows.Forms.DateTimePicker();
            this.txtbxBatchTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(237, 89);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 15);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Course :";
            // 
            // lblBatchTime
            // 
            this.lblBatchTime.AutoSize = true;
            this.lblBatchTime.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchTime.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchTime.Location = new System.Drawing.Point(237, 187);
            this.lblBatchTime.Name = "lblBatchTime";
            this.lblBatchTime.Size = new System.Drawing.Size(81, 15);
            this.lblBatchTime.TabIndex = 15;
            this.lblBatchTime.Text = "Batch Time :";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(237, 145);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(86, 15);
            this.lblBatchName.TabIndex = 14;
            this.lblBatchName.Text = "BatchName : ";
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(384, 266);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbbxStatus.TabIndex = 19;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(237, 269);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(237, 230);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 15);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(223, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(430, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dtpSd
            // 
            this.dtpSd.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSd.Location = new System.Drawing.Point(384, 224);
            this.dtpSd.Name = "dtpSd";
            this.dtpSd.Size = new System.Drawing.Size(200, 21);
            this.dtpSd.TabIndex = 23;
            // 
            // txtbxBatchTime
            // 
            this.txtbxBatchTime.Location = new System.Drawing.Point(384, 187);
            this.txtbxBatchTime.Name = "txtbxBatchTime";
            this.txtbxBatchTime.Size = new System.Drawing.Size(100, 20);
            this.txtbxBatchTime.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(384, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(393, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "label2";
            // 
            // EditBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxBatchTime);
            this.Controls.Add(this.dtpSd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBatchTime);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblCourse);
            this.Name = "EditBatch";
            this.Text = "EditBatch";
            this.Load += new System.EventHandler(this.EditBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblBatchTime;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpSd;
        private System.Windows.Forms.TextBox txtbxBatchTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}