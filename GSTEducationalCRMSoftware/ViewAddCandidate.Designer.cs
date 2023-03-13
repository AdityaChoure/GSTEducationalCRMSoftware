namespace GSTEducationalCRMSoftware
{
    partial class ViewAddCandidate
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.txtbxCourseName = new System.Windows.Forms.TextBox();
            this.txtbxAddStudent = new System.Windows.Forms.TextBox();
            this.txtbxTrainer = new System.Windows.Forms.TextBox();
            this.txtbxBatchName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(147, 72);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(91, 15);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name :";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(147, 107);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(86, 15);
            this.lblBatchName.TabIndex = 1;
            this.lblBatchName.Text = "Batch Name :";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainer.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainer.Location = new System.Drawing.Point(147, 140);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(59, 15);
            this.lblTrainer.TabIndex = 2;
            this.lblTrainer.Text = "Trainer :";
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddStudent.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.Location = new System.Drawing.Point(147, 183);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(86, 15);
            this.lblAddStudent.TabIndex = 3;
            this.lblAddStudent.Text = "Add Student :";
            // 
            // txtbxCourseName
            // 
            this.txtbxCourseName.Location = new System.Drawing.Point(322, 69);
            this.txtbxCourseName.Name = "txtbxCourseName";
            this.txtbxCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtbxCourseName.TabIndex = 5;
            // 
            // txtbxAddStudent
            // 
            this.txtbxAddStudent.Location = new System.Drawing.Point(322, 176);
            this.txtbxAddStudent.Name = "txtbxAddStudent";
            this.txtbxAddStudent.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddStudent.TabIndex = 6;
            // 
            // txtbxTrainer
            // 
            this.txtbxTrainer.Location = new System.Drawing.Point(322, 133);
            this.txtbxTrainer.Name = "txtbxTrainer";
            this.txtbxTrainer.Size = new System.Drawing.Size(100, 20);
            this.txtbxTrainer.TabIndex = 7;
            // 
            // txtbxBatchName
            // 
            this.txtbxBatchName.Location = new System.Drawing.Point(322, 100);
            this.txtbxBatchName.Name = "txtbxBatchName";
            this.txtbxBatchName.Size = new System.Drawing.Size(100, 20);
            this.txtbxBatchName.TabIndex = 8;
            this.txtbxBatchName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(94, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Merge";
            this.Column2.Name = "Column2";
            // 
            // ViewAddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxBatchName);
            this.Controls.Add(this.txtbxTrainer);
            this.Controls.Add(this.txtbxAddStudent);
            this.Controls.Add(this.txtbxCourseName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAddStudent);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblCourseName);
            this.Name = "ViewAddCandidate";
            this.Text = "ViewAddCandidate";
            this.Load += new System.EventHandler(this.ViewAddCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.TextBox txtbxCourseName;
        private System.Windows.Forms.TextBox txtbxAddStudent;
        private System.Windows.Forms.TextBox txtbxTrainer;
        private System.Windows.Forms.TextBox txtbxBatchName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}