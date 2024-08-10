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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appstudent
{
    public partial class admin : Form
    {
        SqlConnection conn;
        public admin()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt9;Integrated Security = true;");

        }
        public admin(string username)
        {
            InitializeComponent();

            lbluser.Text = "user" + username;
        }


        private void admin_Load(object sender, EventArgs e)
        {
            conn.Open();
            fill_data();

        }
        private void fill_data()
        {
            string query = "select * from attendance";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tableadmin.DataSource = tb;
            conn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btcreateteacher_Click(object sender, EventArgs e)
        {
            createstudent createstudent = new createstudent();
            this.Hide();
            createstudent.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want delete", "result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "DELETE FROM attendance WHERE attendance_id=@attendanceid AND status_inday=@statusinday AND attendance=@attendance AND student_id = @studentid AND student_name=@studentname  AND class_id=@classid AND class_name=@classname and teacher_id = @teacherid and teacher_name = @teachername and subject_id = @subjectid and subject_name = @subjectname";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@attendanceid", SqlDbType.Int);
                cmd.Parameters["@attendanceid"].Value = tbattendanceid.Text;
                cmd.Parameters.Add("@statusinday", SqlDbType.VarChar);
                cmd.Parameters["@statusinday"].Value = tbsattusinday.Text;
                cmd.Parameters.Add("@attendance", SqlDbType.DateTime);
                cmd.Parameters["@attendance"].Value = tbattendance.Text;
                cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                cmd.Parameters["@studentid"].Value = tbstudentid.Text;
                cmd.Parameters.Add("@studentname", SqlDbType.VarChar);
                cmd.Parameters["@studentname"].Value = tbstudentname.Text;
                cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                cmd.Parameters["@classid"].Value = tbclassid.Text;
                cmd.Parameters.Add("@classname", SqlDbType.VarChar);
                cmd.Parameters["@classname"].Value = tbclassname.Text;
                cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                cmd.Parameters["@teacherid"].Value = tbteacherid.Text;
                cmd.Parameters.Add("@teachername", SqlDbType.VarChar);
                cmd.Parameters["@teachername"].Value = tbtachername.Text;
                cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                cmd.Parameters["@subjectid"].Value = tbsubjectid.Text;
                cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                cmd.Parameters["@subjectname"].Value = tbsubjectname.Text;
                cmd.ExecuteNonQuery();

                fill_data();
                MessageBox.Show(this, "delete succesfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataviewadmin(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tableadmin.Rows[e.RowIndex];
                tbattendanceid.Text = row.Cells["attendanceid"].Value.ToString();
                tbsattusinday.Text = row.Cells["statusinday"].Value.ToString();
                tbattendance.Text = row.Cells["attendance1"].Value.ToString();
                tbstudentid.Text = row.Cells["studentid"].Value.ToString();
                tbstudentname.Text = row.Cells["studentname"].Value.ToString();
                tbclassid.Text = row.Cells["classid"].Value.ToString();
                tbclassname.Text = row.Cells["classname"].Value.ToString();
                tbteacherid.Text = row.Cells["teacherid"].Value.ToString();
                tbtachername.Text = row.Cells["teachername"].Value.ToString();
                tbsubjectid.Text = row.Cells["subjectid"].Value.ToString();
                tbsubjectname.Text = row.Cells["subjectname"].Value.ToString();

            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            string attendanceid = tbattendanceid.Text;
            if (attendanceid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "ID can't be blank ";
            }
            else lberror.Text = "";
            string statusinday = tbsattusinday.Text;
            if (statusinday.Equals(""))
            {
                error = error + 1;
                lberror.Text = "startus can't be blank ";
            }
            else lberror.Text = "";
            string attendance = tbattendance.Text;
            if (attendance.Equals(""))
            {
                error = error + 1;
                lberror.Text = "attendance can't be blank ";
            }
            else lberror.Text = "";
            string studentid = tbsubjectid.Text;
            if (studentid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "id student can't be blank ";
            }
            else lberror.Text = "";
            string studentname = tbstudentname.Text;
            if (studentname.Equals(""))
            {
                error = error + 1;
                lberror.Text = "name student can't be blank ";
            }
            else lberror.Text = "";
            string classid = tbclassid.Text;
            if (classid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "class id can't be blank ";
            }
            else lberror.Text = "";
            string classname = tbclassname.Text;
            if (classname.Equals(""))
            {
                error = error + 1;
                lberror.Text = "class name can't be blank ";
            }
            else lberror.Text = "";
            string teacherid = tbteacherid.Text;
            if (teacherid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "teacher can't be blank";
            }
            string teachername = tbtachername.Text;
            if (teacherid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "teacher name can't be blank";
            }
            string subjectid = tbsubjectid.Text;
            if (subjectid.Equals(""))
            {
                error = error + 1;
                lberror.Text = "subjectid can't be blank";

            }
            string subjectname = tbsubjectname.Text;
            if (subjectname.Equals(""))
            {
                error = error + 1;
                lberror.Text = "subjectid can't be blank";

            }
            else
            {
                string query = "select * from attendance where attendance_id = @attendanceid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@attendanceid", SqlDbType.Int);
                cmdcheck.Parameters["@attendanceid"].Value = attendanceid;
                SqlDataReader r = cmdcheck.ExecuteReader();
                if (r.Read())
                {
                    error++;
                    lberror.Text = "this attenddance id exiting,please choose another";

                }
                else
                {
                    lberror.Text = "";

                }
                conn.Close();
                if (error == 0)
                {

                    conn.Open();
                    string insert = "insert into  attendance values (@attendanceid,@statusinday,@attendance,@studentid,@studentname,@classid,@classname,@teacherid,@teachername,@subjectid,@subjectname)";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.Add("@attendanceid", SqlDbType.Int);
                    cmd.Parameters["@attendanceid"].Value = tbattendanceid.Text;
                    cmd.Parameters.Add("@statusinday", SqlDbType.VarChar);
                    cmd.Parameters["@statusinday"].Value = tbsattusinday.Text;
                    cmd.Parameters.Add("@attendance", SqlDbType.DateTime);
                    cmd.Parameters["@attendance"].Value = tbattendance.Text;
                    cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                    cmd.Parameters["@studentid"].Value = tbstudentid.Text;
                    cmd.Parameters.Add("@studentname", SqlDbType.VarChar);
                    cmd.Parameters["@studentname"].Value = tbstudentname.Text;
                    cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                    cmd.Parameters["@classid"].Value = tbclassid.Text;
                    cmd.Parameters.Add("@classname", SqlDbType.VarChar);
                    cmd.Parameters["@classname"].Value = tbclassname.Text;
                    cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                    cmd.Parameters["@teacherid"].Value = tbteacherid.Text;
                    cmd.Parameters.Add("@teachername", SqlDbType.VarChar);
                    cmd.Parameters["@teachername"].Value = tbtachername.Text;
                    cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                    cmd.Parameters["@subjectid"].Value = tbsubjectid.Text;
                    cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                    cmd.Parameters["@subjectname"].Value = tbsubjectname.Text;
                    cmd.ExecuteNonQuery();
                    fill_data();
                    MessageBox.Show(this, "add succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want edit", "result", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string update = "update  attendance set status_inday=@statusinday,attendance=@attendance,student_id=@studentid,student_name=@studentname,class_id=@classid,class_name=@classname,teacher_id=@teacherid,teacher_name=@teachername,subject_id=@subjectid,subject_name=@subjectname where attendance_id=@attendanceid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);


                cmd.Parameters.Add("@attendanceid", SqlDbType.Int);
                cmd.Parameters["@attendanceid"].Value = tbattendanceid.Text;
                cmd.Parameters.Add("@statusinday", SqlDbType.VarChar);
                cmd.Parameters["@statusinday"].Value = tbsattusinday.Text;
                cmd.Parameters.Add("@attendance", SqlDbType.DateTime);
                cmd.Parameters["@attendance"].Value = tbattendance.Text;
                cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                cmd.Parameters["@studentid"].Value = tbstudentid.Text;
                cmd.Parameters.Add("@studentname", SqlDbType.VarChar);
                cmd.Parameters["@studentname"].Value = tbstudentname.Text;
                cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                cmd.Parameters["@classid"].Value = tbclassid.Text;
                cmd.Parameters.Add("@classname", SqlDbType.VarChar);
                cmd.Parameters["@classname"].Value = tbclassname.Text;
                cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                cmd.Parameters["@teacherid"].Value = tbteacherid.Text;
                cmd.Parameters.Add("@teachername", SqlDbType.VarChar);
                cmd.Parameters["@teachername"].Value = tbtachername.Text;
                cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                cmd.Parameters["@subjectid"].Value = tbsubjectid.Text;
                cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                cmd.Parameters["@subjectname"].Value = tbsubjectname.Text;



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    fill_data();
                    MessageBox.Show(this, "update succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbattendanceid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btclass_Click(object sender, EventArgs e)
        {
            createclass createclass = new createclass();
            createclass.ShowDialog();
            this.Dispose();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            createteacher createteacher = new createteacher();
            createteacher.ShowDialog();
            this.Dispose(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createsubject createsubject = new createsubject();
            createsubject.ShowDialog();
            this.Dispose(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btreport_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.ShowDialog();
            this.Dispose(); this.Hide();
        }
    }
}
