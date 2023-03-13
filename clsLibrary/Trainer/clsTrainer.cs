using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsLibrary.Trainer;
using System.Data.SqlClient;
using System.Data;


namespace clsLibrary.Trainer
{
    public class clsTrainer
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5RM1IPJ;Initial Catalog=GSTEducationalCRMSoftware-2;Integrated Security=True");
        public string CourseType { get; set; }
        public int Centre { get; set; }
        public int CourseTypeId { get; set; }
        public int CentreId { get; set; }
        public string CourseName { get; set; }
        public DateTime Date { get; set; }
        public string BatchName { get; set; }
        public int LabId { get; set; }
        public string BatchTime { get; set; }
        public string StaffCode { get; set; }
        public int StatusId { get; set; }
        public string CourseFees { get; set; }
        public int BatchId { get; set; }
        public int Batch { get; set; }   
        public string CourseDescription { get; set; }
        public int CourseId { get; set; }
        public String NoOfStudent { get; set; }
        public clsTrainer()
        {

        }
        public clsTrainer()
        {
            CourseId=cid
        }
        public clsTrainer( int sid)
        {
            StatusId = sid;
        }
        
        public clsTrainer( String batchtime, DateTime date, int statusid)
        {
            BatchTime = batchtime; Date = date; StatusId = statusid;
        }
        public clsTrainer(int courseid,string batchname,string noofstudent, string staffcode, String batchtime,int labid, DateTime date, int statusid)
        {
            CourseId=courseid; BatchName=batchname; NoOfStudent=noofstudent; StaffCode=staffcode; BatchTime = batchtime; LabId = labid; Date = date;StatusId=statusid; 
        }
        public DataTable GetCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable GetBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatch");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable GetLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLab");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable GetStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStatus");
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtStat = new DataTable();
            adpt.Fill(dtStat);
            return dtStat;

            con.Close();
        }
        public DataTable GetTrainer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTrainer");
            cmd.Parameters.AddWithValue("@CourseId",CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public void BatchSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "BatchSave");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
           // cmd.Parameters.AddWithValue("@StudCode", null);
            cmd.Parameters.AddWithValue("@BatchName", BatchName);
            cmd.Parameters.AddWithValue("@NoOfStudent", NoOfStudent);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.Parameters.AddWithValue("@BatchTime", BatchTime);
            cmd.Parameters.AddWithValue("@LabId", LabId);
           // cmd.Parameters.AddWithValue("@TentativeEndDate", null);
            cmd.Parameters.AddWithValue("@CourseStartDate", Date);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateBatch");
            //cmd.Parameters.AddWithValue("@CourseId", CourseId);
            //cmd.Parameters.AddWithValue("@BatchName", BatchName);
            cmd.Parameters.AddWithValue("@BatchTime", BatchTime);
            cmd.Parameters.AddWithValue("@CourseStartDate", Date);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable BatchDetailgrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "BatchDetailgrd");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtgrd = new DataTable();
            adpt.Fill(dtgrd);
            return dtgrd;

            con.Close();
        }
        public DataTable Studentbatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Studentbatch");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable TransferStudentSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TransferStudentSave");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable AddStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddStudent");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtgrd = new DataTable();
            adpt.Fill(dtgrd);
            return dtgrd;

            con.Close();
        }
        public DataTable GetStudentByStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTCRMTrainerHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentByStatus");
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
            }


        }
}
 