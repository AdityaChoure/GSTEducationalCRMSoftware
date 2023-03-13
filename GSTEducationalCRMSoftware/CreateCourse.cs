using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsLibrary.Admin;

namespace GSTEducationalCRMSoftware
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void lblSyllabus_Click(object sender, EventArgs e)
        {

        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            clsAdmin objcourse = new clsAdmin();
            DataTable dt = new DataTable();
            dt = objcourse.GetCourseType();
            cmbbxCourseType.DisplayMember = "CourseTypeName";
            cmbbxCourseType.ValueMember = "CourseTypeId";

            cmbbxCourseType.DataSource = dt;

            clsAdmin objcenter = new clsAdmin();
            DataTable dtcenter = new DataTable();
            dtcenter = objcenter.GetCenter();
            cmbbxCenter.DisplayMember = "CentreName";
            cmbbxCenter.ValueMember = "CentreId";

            cmbbxCenter.DataSource = dtcenter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int centreid = Convert.ToInt32(cmbbxCenter.SelectedValue.ToString());
            string CourseName = txtbxCourseName.Text;
            DateTime date = dtpStDt.Value;
            string CourseFee = txtbxCourseFee.Text;
            string Description = txtbxDescription.Text;
            int CourseTypeid = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
            clsAdmin obj = new clsAdmin(centreid, CourseName,  date, CourseFee, Description, CourseTypeid);
            obj.Course();
            MessageBox.Show("Add Successfully");
        }
    }
}
