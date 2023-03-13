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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(grdvwBatchDetails.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < grdvwBatchDetails.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdvwBatchDetails.Columns[i -1].HeaderText;
                }
                for (int k=0; k < grdvwBatchDetails.Rows.Count -1; k++)
                {
                    for (int j = 1; j < grdvwBatchDetails.Columns.Count; j++)
                    {
                        xcelApp.Cells[k + 2,j] = grdvwBatchDetails.Rows[k].Cells[j].ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBatch_Click(object sender, EventArgs e)
        {
            //Create_New_Batch obj = new Create_New_Batch();
            //obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsTrainer obj = new clsTrainer();
            DataTable dt = new DataTable();
            dt = obj.GetCourse();
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DataSource = dt;

            clsTrainer objgrd = new clsTrainer();
            DataTable dtgrd = new DataTable();
            dtgrd = objgrd.BatchDetailgrd();
            grdvwBatchDetails.DataSource = dtgrd;
            grdvwBatchDetails.Show();

            DataGridViewButtonColumn objbtn = new DataGridViewButtonColumn();
            grdvwBatchDetails.Columns.Add(objbtn);
            objbtn.HeaderText = "View/Add Candidate";
            objbtn.Text = "View/Add Candidate";
            objbtn.UseColumnTextForButtonValue = true;
            objbtn.Name = "btnAddCandidate";

            DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();
            grdvwBatchDetails.Columns.Add(objBtn);
            objBtn.HeaderText = "Edit";
            objBtn.Text = "Edit";
            objBtn.UseColumnTextForButtonValue = true;
            objBtn.Name = "BtnEdit";

            DataGridViewButtonColumn objbtnn = new DataGridViewButtonColumn();
            grdvwBatchDetails.Columns.Add(objbtnn);
            objbtnn.HeaderText = "Transfer Student";
            objbtnn.Text = "Transfer student";
            objbtnn.UseColumnTextForButtonValue = true;
            objbtnn.Name = "btnTransferStudent";

            clsTrainer objgba = new clsTrainer();
            DataTable dtgba = new DataTable();
            dtgba = objgba.GetBatch();
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DataSource = dtgba;
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           

          
        }

        private void cmbbxCourse_Enter(object sender, EventArgs e)
        {

        }

        private void grdvwBatchDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdvwBatchDetails.Columns[e.ColumnIndex].HeaderText == "View/Add Candidate")
            {
                ViewAddCandidate obj = new ViewAddCandidate();
                obj.Show();
            }
            if (grdvwBatchDetails.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                EditBatch obj = new EditBatch(/*BatchTime, StarDate*/);
                obj.Show();

                //BatchTime = grdvwBatchDetails.CurrentRow.Cells[3].Value.ToString();
                // StarDate = ((DateTime)grdvwBatchDetails.CurrentRow.Cells[4].Value);

            }
            if (grdvwBatchDetails.Columns[e.ColumnIndex].HeaderText == "Transfer student")
            {
             TransferStudent obj = new TransferStudent();
                obj.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsTrainer objgrd = new clsTrainer();
            DataTable dtgrd = new DataTable();
            dtgrd = objgrd.BatchDetailgrd();
            grdvwBatchDetails.DataSource = dtgrd;
            grdvwBatchDetails.Show();
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
