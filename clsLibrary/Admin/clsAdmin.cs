using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using clsLibrary.Admin;



namespace clsLibrary.Admin
{
    public class clsAdmin
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5RM1IPJ;Initial Catalog=GSTEducationalCRMSoftware-2;Integrated Security=True");
        public string CourseType { get; set; }
        public int CentreId { get; set; }
        public int CourseTypeId { get; set; }
        public int Centre { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseStartDate { get; set; }
        public string CourseFees { get; set; }
        public string CourseTypeName { get; set; }
        public string CentreName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseId { get; set; }
        public string StaffEmail { get; set; }
        public clsAdmin()
        {

        }

        public clsAdmin(string coursetypename, string centrename)
        {
             CourseTypeName = coursetypename; CentreName = centrename;
        }


        public clsAdmin(string staffemail)
        {
            StaffEmail=staffemail;
        }



        public clsAdmin( int centreId, string coursename, DateTime coursestartdate, string coursefees, string coursedescription, int coursetypeid)
        {
             CentreId = centreId; CourseName = coursename;  CourseStartDate = coursestartdate; CourseFees = coursefees; CourseDescription = coursedescription; CourseTypeId = coursetypeid;
        }


        public void Course()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Course");
            cmd.Parameters.AddWithValue("@centreId", CentreId);
            cmd.Parameters.AddWithValue("@CourseName", CourseName);
            cmd.Parameters.AddWithValue("@CourseStartDate", CourseStartDate);
            cmd.Parameters.AddWithValue("@CourseFees", CourseFees);
            cmd.Parameters.AddWithValue("@CourseDescription", CourseDescription);
            cmd.Parameters.AddWithValue("@CourseTypeId", CourseTypeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetCourseTypegrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseTypegrd");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable GetCenter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCenter");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }
        public DataTable GetCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        

        public DataTable GetCourseType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public SqlDataReader Forgot()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Forgot");
            cmd.Parameters.AddWithValue("@StaffEmail", StaffEmail);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public void AddCourseType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMAdminHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddCourse");
            cmd.Parameters.AddWithValue("@CourseTypeName", CourseTypeName);
            cmd.Parameters.AddWithValue("@CentreName", CentreName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
    
}
