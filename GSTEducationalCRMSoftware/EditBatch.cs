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
    public partial class EditBatch : Form
    {
        public EditBatch(/*string CourseName,string BatchName,String BatchTime, DateTime StarDate*/)
        {
            InitializeComponent();
            //   label1.Text = CourseName;
            //    label2.Text = BatchName;
            //    lblBatchTime.Text = BatchTime.ToString();
            //    lblStartDate.Text = StarDate.ToString();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditBatch_Load(object sender, EventArgs e)
        {
            

            clsTrainer objstatus = new clsTrainer();
            DataTable dtstatus = new DataTable();
            dtstatus = objstatus.GetStatus();
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dtstatus;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           
           
            string batchTime = txtbxBatchTime.Text;
            DateTime date = dtpSd.Value;
            int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());

            clsTrainer obj = new clsTrainer(batchTime, date, StatusId);
            obj.UpdateBatch();
            MessageBox.Show("Update Successfully");
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
