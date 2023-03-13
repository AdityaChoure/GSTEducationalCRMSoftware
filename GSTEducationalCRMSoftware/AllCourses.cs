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
    public partial class AllCourses : Form
    {
        public AllCourses()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            CreateCourse obj = new CreateCourse();
            obj.Show();
        }

        private void AllCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
