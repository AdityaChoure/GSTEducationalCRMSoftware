namespace GSTEducationalCRMSoftware
{
    partial class frmAddNewBatch
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
            this.dgvAddStudent = new System.Windows.Forms.DataGridView();
            this.dtteprStrDt = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxBatchCapacity = new System.Windows.Forms.TextBox();
            this.txtbxBatchName = new System.Windows.Forms.TextBox();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.cmbbxLab = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchTime = new System.Windows.Forms.ComboBox();
            this.cmbbxTrainer = new System.Windows.Forms.ComboBox();
            this.cmbbxCourse = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblBatchTime = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblBatchCapacity = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddStudent
            // 
            this.dgvAddStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddStudent.Location = new System.Drawing.Point(444, 28);
            this.dgvAddStudent.Name = "dgvAddStudent";
            this.dgvAddStudent.Size = new System.Drawing.Size(302, 315);
            this.dgvAddStudent.TabIndex = 37;
            // 
            // dtteprStrDt
            // 
            this.dtteprStrDt.Location = new System.Drawing.Point(190, 159);
            this.dtteprStrDt.Name = "dtteprStrDt";
            this.dtteprStrDt.Size = new System.Drawing.Size(200, 20);
            this.dtteprStrDt.TabIndex = 36;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(380, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(190, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxBatchCapacity
            // 
            this.txtbxBatchCapacity.Location = new System.Drawing.Point(190, 276);
            this.txtbxBatchCapacity.Name = "txtbxBatchCapacity";
            this.txtbxBatchCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtbxBatchCapacity.TabIndex = 33;
            // 
            // txtbxBatchName
            // 
            this.txtbxBatchName.Location = new System.Drawing.Point(190, 194);
            this.txtbxBatchName.Name = "txtbxBatchName";
            this.txtbxBatchName.Size = new System.Drawing.Size(100, 20);
            this.txtbxBatchName.TabIndex = 32;
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(190, 322);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbbxStatus.TabIndex = 31;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // cmbbxLab
            // 
            this.cmbbxLab.FormattingEnabled = true;
            this.cmbbxLab.Location = new System.Drawing.Point(190, 63);
            this.cmbbxLab.Name = "cmbbxLab";
            this.cmbbxLab.Size = new System.Drawing.Size(121, 21);
            this.cmbbxLab.TabIndex = 30;
            this.cmbbxLab.SelectedIndexChanged += new System.EventHandler(this.cmbbxLab_SelectedIndexChanged);
            // 
            // cmbbxBatchTime
            // 
            this.cmbbxBatchTime.FormattingEnabled = true;
            this.cmbbxBatchTime.Items.AddRange(new object[] {
            "11.00AM TO 1.00PM",
            "1.00PM TO 3.00PM",
            "3.00PM TO 5.00PM"});
            this.cmbbxBatchTime.Location = new System.Drawing.Point(190, 233);
            this.cmbbxBatchTime.Name = "cmbbxBatchTime";
            this.cmbbxBatchTime.Size = new System.Drawing.Size(121, 21);
            this.cmbbxBatchTime.TabIndex = 29;
            // 
            // cmbbxTrainer
            // 
            this.cmbbxTrainer.FormattingEnabled = true;
            this.cmbbxTrainer.Location = new System.Drawing.Point(190, 110);
            this.cmbbxTrainer.Name = "cmbbxTrainer";
            this.cmbbxTrainer.Size = new System.Drawing.Size(121, 21);
            this.cmbbxTrainer.TabIndex = 28;
            // 
            // cmbbxCourse
            // 
            this.cmbbxCourse.FormattingEnabled = true;
            this.cmbbxCourse.Location = new System.Drawing.Point(190, 28);
            this.cmbbxCourse.Name = "cmbbxCourse";
            this.cmbbxCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCourse.TabIndex = 27;
            this.cmbbxCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourse_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(54, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Location = new System.Drawing.Point(54, 164);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.BackColor = System.Drawing.Color.Transparent;
            this.lblLab.Location = new System.Drawing.Point(54, 71);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(31, 13);
            this.lblLab.TabIndex = 24;
            this.lblLab.Text = "Lab :";
            // 
            // lblBatchTime
            // 
            this.lblBatchTime.AutoSize = true;
            this.lblBatchTime.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchTime.Location = new System.Drawing.Point(54, 241);
            this.lblBatchTime.Name = "lblBatchTime";
            this.lblBatchTime.Size = new System.Drawing.Size(67, 13);
            this.lblBatchTime.TabIndex = 23;
            this.lblBatchTime.Text = "Batch Time :";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainer.Location = new System.Drawing.Point(54, 118);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(40, 13);
            this.lblTrainer.TabIndex = 22;
            this.lblTrainer.Text = "Trainer";
            // 
            // lblBatchCapacity
            // 
            this.lblBatchCapacity.AutoSize = true;
            this.lblBatchCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchCapacity.Location = new System.Drawing.Point(54, 284);
            this.lblBatchCapacity.Name = "lblBatchCapacity";
            this.lblBatchCapacity.Size = new System.Drawing.Size(79, 13);
            this.lblBatchCapacity.TabIndex = 21;
            this.lblBatchCapacity.Text = "Batch Capacity";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Location = new System.Drawing.Point(54, 199);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(72, 13);
            this.lblBatchName.TabIndex = 20;
            this.lblBatchName.Text = "BatchName : ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Location = new System.Drawing.Point(54, 36);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(46, 13);
            this.lblCourse.TabIndex = 19;
            this.lblCourse.Text = "Course :";
            // 
            // frmAddNewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAddStudent);
            this.Controls.Add(this.dtteprStrDt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbxBatchCapacity);
            this.Controls.Add(this.txtbxBatchName);
            this.Controls.Add(this.cmbbxStatus);
            this.Controls.Add(this.cmbbxLab);
            this.Controls.Add(this.cmbbxBatchTime);
            this.Controls.Add(this.cmbbxTrainer);
            this.Controls.Add(this.cmbbxCourse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblBatchTime);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.lblBatchCapacity);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblCourse);
            this.Name = "frmAddNewBatch";
            this.Text = "frmAddNewBatch";
            this.Load += new System.EventHandler(this.frmAddNewBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddStudent;
        private System.Windows.Forms.DateTimePicker dtteprStrDt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbxBatchCapacity;
        private System.Windows.Forms.TextBox txtbxBatchName;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.ComboBox cmbbxLab;
        private System.Windows.Forms.ComboBox cmbbxBatchTime;
        private System.Windows.Forms.ComboBox cmbbxTrainer;
        private System.Windows.Forms.ComboBox cmbbxCourse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblBatchTime;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Label lblBatchCapacity;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblCourse;
    }
}