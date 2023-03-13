namespace GSTEducationalCRMSoftware
{
    partial class Form1
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
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblBatchStatus = new System.Windows.Forms.Label();
            this.cmbbxCourse = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchName = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchStatus = new System.Windows.Forms.ComboBox();
            this.btnNewBatch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSms = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grdvwBatchDetails = new System.Windows.Forms.DataGridView();
            this.lblBatchDetails = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwBatchDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Location = new System.Drawing.Point(68, 123);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(46, 13);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course :";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Location = new System.Drawing.Point(298, 123);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(72, 13);
            this.lblBatchName.TabIndex = 1;
            this.lblBatchName.Text = "Batch Name :";
            this.lblBatchName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBatchStatus
            // 
            this.lblBatchStatus.AutoSize = true;
            this.lblBatchStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchStatus.Location = new System.Drawing.Point(565, 123);
            this.lblBatchStatus.Name = "lblBatchStatus";
            this.lblBatchStatus.Size = new System.Drawing.Size(74, 13);
            this.lblBatchStatus.TabIndex = 2;
            this.lblBatchStatus.Text = "Batch Status :";
            // 
            // cmbbxCourse
            // 
            this.cmbbxCourse.FormattingEnabled = true;
            this.cmbbxCourse.Location = new System.Drawing.Point(130, 120);
            this.cmbbxCourse.Name = "cmbbxCourse";
            this.cmbbxCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCourse.TabIndex = 3;
            this.cmbbxCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourse_SelectedIndexChanged);
            this.cmbbxCourse.Enter += new System.EventHandler(this.cmbbxCourse_Enter);
            // 
            // cmbbxBatchName
            // 
            this.cmbbxBatchName.FormattingEnabled = true;
            this.cmbbxBatchName.Location = new System.Drawing.Point(376, 120);
            this.cmbbxBatchName.Name = "cmbbxBatchName";
            this.cmbbxBatchName.Size = new System.Drawing.Size(121, 21);
            this.cmbbxBatchName.TabIndex = 4;
            // 
            // cmbbxBatchStatus
            // 
            this.cmbbxBatchStatus.FormattingEnabled = true;
            this.cmbbxBatchStatus.Items.AddRange(new object[] {
            "Active",
            "Release"});
            this.cmbbxBatchStatus.Location = new System.Drawing.Point(667, 120);
            this.cmbbxBatchStatus.Name = "cmbbxBatchStatus";
            this.cmbbxBatchStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbbxBatchStatus.TabIndex = 5;
            // 
            // btnNewBatch
            // 
            this.btnNewBatch.BackColor = System.Drawing.Color.Transparent;
            this.btnNewBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewBatch.Location = new System.Drawing.Point(130, 42);
            this.btnNewBatch.Name = "btnNewBatch";
            this.btnNewBatch.Size = new System.Drawing.Size(99, 22);
            this.btnNewBatch.TabIndex = 8;
            this.btnNewBatch.Text = "New Batch";
            this.btnNewBatch.UseVisualStyleBackColor = false;
            this.btnNewBatch.Click += new System.EventHandler(this.btnNewBatch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(274, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMail.Location = new System.Drawing.Point(540, 39);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(50, 23);
            this.btnMail.TabIndex = 14;
            this.btnMail.Text = "Mail";
            this.btnMail.UseVisualStyleBackColor = false;
            // 
            // btnSms
            // 
            this.btnSms.BackColor = System.Drawing.Color.Transparent;
            this.btnSms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSms.Location = new System.Drawing.Point(639, 40);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(42, 23);
            this.btnSms.TabIndex = 15;
            this.btnSms.Text = "SMS";
            this.btnSms.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Location = new System.Drawing.Point(713, 41);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // grdvwBatchDetails
            // 
            this.grdvwBatchDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvwBatchDetails.Location = new System.Drawing.Point(12, 165);
            this.grdvwBatchDetails.Name = "grdvwBatchDetails";
            this.grdvwBatchDetails.Size = new System.Drawing.Size(776, 257);
            this.grdvwBatchDetails.TabIndex = 17;
            this.grdvwBatchDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvwBatchDetails_CellContentClick);
            // 
            // lblBatchDetails
            // 
            this.lblBatchDetails.AutoSize = true;
            this.lblBatchDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchDetails.Location = new System.Drawing.Point(55, 13);
            this.lblBatchDetails.Name = "lblBatchDetails";
            this.lblBatchDetails.Size = new System.Drawing.Size(70, 13);
            this.lblBatchDetails.TabIndex = 18;
            this.lblBatchDetails.Text = "Batch Details";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::GSTEducationalCRMSoftware.Properties.Resources.pdf;
            this.pictureBox8.Location = new System.Drawing.Point(352, 40);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(44, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GSTEducationalCRMSoftware.Properties.Resources.refresh_button;
            this.pictureBox7.Location = new System.Drawing.Point(246, 42);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GSTEducationalCRMSoftware.Properties.Resources.gmail1;
            this.pictureBox6.Location = new System.Drawing.Point(498, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GSTEducationalCRMSoftware.Properties.Resources.plus;
            this.pictureBox5.Location = new System.Drawing.Point(131, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GSTEducationalCRMSoftware.Properties.Resources.IMG_20221102_WA0001;
            this.pictureBox4.Location = new System.Drawing.Point(697, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GSTEducationalCRMSoftware.Properties.Resources.sms;
            this.pictureBox3.Location = new System.Drawing.Point(610, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GSTEducationalCRMSoftware.Properties.Resources.excel1;
            this.pictureBox2.Location = new System.Drawing.Point(435, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSTEducationalCRMSoftware.Properties.Resources.Search_11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(38, 45);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(76, 20);
            this.txtbxSearch.TabIndex = 27;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoftware.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBatchDetails);
            this.Controls.Add(this.grdvwBatchDetails);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSms);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewBatch);
            this.Controls.Add(this.cmbbxBatchStatus);
            this.Controls.Add(this.cmbbxBatchName);
            this.Controls.Add(this.cmbbxCourse);
            this.Controls.Add(this.lblBatchStatus);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvwBatchDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblBatchStatus;
        private System.Windows.Forms.ComboBox cmbbxCourse;
        private System.Windows.Forms.ComboBox cmbbxBatchName;
        private System.Windows.Forms.ComboBox cmbbxBatchStatus;
        private System.Windows.Forms.Button btnNewBatch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnSms;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView grdvwBatchDetails;
        private System.Windows.Forms.Label lblBatchDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtbxSearch;
    }
}

