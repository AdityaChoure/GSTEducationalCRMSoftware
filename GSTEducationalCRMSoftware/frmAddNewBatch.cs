using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsLibrary.Trainer;

namespace GSTEducationalCRMSoftware
{
    public partial class frmAddNewBatch : Form
    {
        public frmAddNewBatch()
        {
            InitializeComponent();
        }
        public frmAddNewBatch(int sid)
        { 
        }

        private void frmAddNewBatch_Load(object sender, EventArgs e)
        {
            clsTrainer obj = new clsTrainer();
            DataTable dt = new DataTable();
            dt = obj.GetCourse();
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DataSource = dt;


            clsTrainer objStatus = new clsTrainer();
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetStatus();
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dtStatus;

            clsTrainer objgdv = new clsTrainer();
            DataTable dtgdv = new DataTable();
            dtgdv = objgdv.AddStudent();
            dgvAddStudent.DataSource = dtgdv;
            dgvAddStudent.Show();
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsTrainer objlab = new clsTrainer();
            DataTable dtlab = new DataTable();
            dtlab = objlab.GetLab();
            cmbbxLab.DisplayMember = "LabName";
            cmbbxLab.ValueMember = "LabId";
            cmbbxLab.DataSource = dtlab;
        }

        private void cmbbxLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxTrainer.SelectedValue.ToString());
            clsTrainer obj = new clsTrainer();
            DataTable dt = new DataTable();
            dt = obj.GetTrainer();
            cmbbxTrainer.DisplayMember = "StaffName";
            cmbbxTrainer.ValueMember = "StaffCode";
            cmbbxTrainer.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int CourseId = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            string BatchName = txtbxBatchName.Text;
            String NoOfStudent = txtbxBatchCapacity.Text;
            string StaffCode = cmbbxTrainer.SelectedValue.ToString();
            string BatchTime = cmbbxBatchTime.Text;
            int LabId = Convert.ToInt32(cmbbxLab.SelectedValue.ToString());
            DateTime date = dtteprStrDt.Value;
            int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());

            clsTrainer obj = new clsTrainer(CourseId, BatchName, NoOfStudent, StaffCode, BatchTime, LabId, date, StatusId);
            obj.BatchSave();
            MessageBox.Show("Save Successfully");
        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
            clsTrainer objgdv = new clsTrainer(sid);
            DataTable dtgdv = new DataTable();
            dtgdv = objgdv.GetStudentByStatus();
            dgvAddStudent.DataSource = dtgdv;
            dgvAddStudent.Show();
        }
    }
}
