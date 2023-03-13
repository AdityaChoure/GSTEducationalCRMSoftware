using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clsLibrary.Admin;


namespace GSTEducationalCRMSoftware
{
    public partial class CreateCourseType : Form
    {
        public CreateCourseType()
        {
            InitializeComponent();
        }

        private void CreateCourseType_Load(object sender, EventArgs e)
        {
         ;

            clsAdmin objcenter = new clsAdmin();
            DataTable dtcenter = new DataTable();
            dtcenter = objcenter.GetCenter();
            cmbbxCenter.DisplayMember = "CentreName";
            cmbbxCenter.ValueMember = "CentreName";
            cmbbxCenter.DataSource = dtcenter;

            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.GetCourseTypegrd();
            grdCourseType.DataSource = dt;
            grdCourseType.Show();



        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     
            string coursetypename = txtbxCourseType.Text;
            string centrename = cmbbxCenter.SelectedValue.ToString();
            clsAdmin obj = new clsAdmin(coursetypename, centrename);
            obj.AddCourseType();
            MessageBox.Show("Add Successfully");
        }

        private void cmbbxCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            clsAdmin obj = new clsAdmin();
            DataTable dt = new DataTable();
            dt = obj.GetCourseTypegrd();
            grdCourseType.DataSource = dt;
            grdCourseType.Show();

        }
    }
}
