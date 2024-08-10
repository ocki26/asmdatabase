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
    public partial class createsubject : Form
    {
        SqlConnection conn;
        public createsubject()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");
        }

        private void teablesubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.teablesubject.Rows[e.RowIndex];
                tbsubjectid.Text = row.Cells["subject_id"].Value.ToString();
                tbsubjectname.Text = row.Cells["subject_name"].Value.ToString();
                tbsubjectcredit.Text = row.Cells["credit"].Value.ToString();

            }
        }
        private void FillData()
        {
            string query = "select * from dbo.subjectclass";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            teablesubject.DataSource = tb;
            conn.Close();
        }
        private void createsubject_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillData();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            string subjectid = tbsubjectid.Text;
            if (subjectid.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "ID can't be blank ";
            }
            else lblerror.Text = "";
            string subjectname = tbsubjectname.Text;
            if (subjectname.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }
            else lblerror.Text = "";
            string subjectcredit = tbsubjectcredit.Text;
            if (subjectid.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }

            else
            {
                string query = "select * from dbo.subjectclass where subject_id = @subjectid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@subjectid", SqlDbType.VarChar);
                cmdcheck.Parameters["@subjectid"].Value = subjectid;
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
                    string insert = "insert into dbo.subjectclass values (@subjectid,@subjectname,@subjectcredit)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                    cmd.Parameters["@subjectid"].Value = subjectid;
                    cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                    cmd.Parameters["@subjectname"].Value = subjectname;
                    cmd.Parameters.Add("@subjectcredit", SqlDbType.Int);
                    cmd.Parameters["@subjectcredit"].Value = subjectcredit;

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
                string delete = "DELETE FROM dbo.subjectclass WHERE subject_id=@subjectid AND subject_name=@subjectname AND credit=@credit ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                cmd.Parameters["@subjectid"].Value = tbsubjectid.Text;
                cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                cmd.Parameters["@subjectname"].Value = tbsubjectname.Text;
                cmd.Parameters.Add("@credit", SqlDbType.Int);
                cmd.Parameters["@credit"].Value = tbsubjectcredit.Text;
                cmd.ExecuteNonQuery();

                FillData();
                MessageBox.Show(this, "delete succesfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "do you want edit", "result", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string update = "update dbo.subjectclass set subject_id = @subjectid,subject_name=@subjectname ,credit=@credit where subject_id = @subjectid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.Add("@credit", SqlDbType.Int);
                cmd.Parameters["@credit"].Value = tbsubjectcredit.Text;
                cmd.Parameters.Add("@subjectid", SqlDbType.VarChar);
                cmd.Parameters["@subjectid"].Value = tbsubjectid.Text;
                cmd.Parameters.Add("@subjectname", SqlDbType.VarChar);
                cmd.Parameters["@subjectname"].Value = tbsubjectname.Text;
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
            tbsubjectname.Text = "";
            tbsubjectid.Text = "";
            tbsubjectcredit.Text = "";
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
