using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appstudent
{
    public partial class createteacher : Form
    {
        SqlConnection conn;

        public createteacher()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");

        }

        private void tableteacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tableteacher.Rows[e.RowIndex];
                tbteacherid.Text = row.Cells["teacher_id"].Value.ToString();
                tbteachername.Text = row.Cells["teacher_name"].Value.ToString();
                tbteacheremail.Text = row.Cells["teacher_email"].Value.ToString();

            }
        }
        private void FillData()
        {
            string query = "select * from dbo.teacher";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tableteacher.DataSource = tb;
            conn.Close();
        }

        private void createteacher_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillData();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            string teacherid = tbteacherid.Text;
            if (teacherid.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "ID can't be blank ";
            }
            else lblerror.Text = "";
            string teachername = tbteachername.Text;
            if (teachername.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }
            else lblerror.Text = "";
            string teacheremail = tbteacheremail.Text;
            if (teacheremail.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }

            else
            {
                string query = "select * from dbo.teacher where teacher_id = @teacherid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@teacherid", SqlDbType.VarChar);
                cmdcheck.Parameters["@teacherid"].Value = teacherid;
                SqlDataReader r = cmdcheck.ExecuteReader();
                if (r.Read())
                {
                    error++;
                    lblerror.Text = "this classid id exiting,please choose another";

                }
                else
                {
                    lblerror.Text = "";

                }
                conn.Close();
                if (error == 0)
                {
                    string insert = "insert into dbo.teacher values (@teacherid,@teachername,@teacheremail)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                    cmd.Parameters["@teacherid"].Value = teacherid;
                    cmd.Parameters.Add("@teachername", SqlDbType.VarChar);
                    cmd.Parameters["@teachername"].Value = teachername;
                    cmd.Parameters.Add("@teacheremail", SqlDbType.VarChar);
                    cmd.Parameters["@teacheremail"].Value = teacheremail;

                    cmd.ExecuteNonQuery();
                    FillData();
                    MessageBox.Show(this, "add succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want delete", "result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "DELETE FROM dbo.teacher WHERE teacher_id=@teacherid AND teacher_name=@teachername AND teacher_email=@teacheremail ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                cmd.Parameters["@teacherid"].Value = tbteacherid.Text;
                cmd.Parameters.Add("@teachername", SqlDbType.VarChar);
                cmd.Parameters["@teachername"].Value = tbteachername.Text;
                cmd.Parameters.Add("@teacheremail", SqlDbType.VarChar);
                cmd.Parameters["@teacheremail"].Value = tbteacheremail.Text;
                cmd.ExecuteNonQuery();

                FillData();
                MessageBox.Show(this, "delete succesfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "do you want edit", "result", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string update = "update dbo.teacher set teacher_email=@teacheremail where teacher_id=@teacherid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@teacherid", SqlDbType.VarChar);
                cmd.Parameters["@teacherid"].Value = tbteacherid.Text;
                cmd.Parameters.Add("@teacheremail", SqlDbType.VarChar);
                cmd.Parameters["@teacheremail"].Value = tbteacheremail.Text;
                cmd.ExecuteNonQuery();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    MessageBox.Show(this, "update succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            tbteacherid.Text = "";
            tbteachername.Text = "";
            tbteacheremail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
           admin.ShowDialog();
            this.Hide();
            this.Dispose();
        }
    }
}

