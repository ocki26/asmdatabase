using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appstudent
{
    public partial class createclass : Form
    {
        SqlConnection conn;
        public createclass()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt9;Integrated Security = true;");
        }

        private void createclass_Load(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Hi");
            FillData();
        }
        private void FillData()
        {
            string query = "select * from dbo.class";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tablecreateclass.DataSource = tb;
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tablecreateclass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablecreateclass.Rows[e.RowIndex];
                tbclassid.Text = row.Cells["class_id"].Value.ToString();
                tbclassname.Text = row.Cells["class_name"].Value.ToString();
                tbclassdatetime.Text = row.Cells["class_dateoftime"].Value.ToString();

            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            string classid = tbclassid.Text;
            if (classid.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "ID can't be blank ";
            }
            else lblerror.Text = "";
            string classname = tbclassname.Text;
            if (classname.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }
            else lblerror.Text = "";
            string classdateoftime = tbclassdatetime.Text;
            if (classname.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }

            else
            {
                string query = "select * from dbo.student where student_id = @classid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@classid", SqlDbType.VarChar);
                cmdcheck.Parameters["@classid"].Value = classid;
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
                    string insert = "insert into dbo.class values (@classid,@classname,@classdateoftime)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                    cmd.Parameters["@classid"].Value = classid;
                    cmd.Parameters.Add("@classname", SqlDbType.VarChar);
                    cmd.Parameters["@classname"].Value = classname;
                    cmd.Parameters.Add("@classdateoftime", SqlDbType.Date);
                    cmd.Parameters["@classdateoftime"].Value = classdateoftime;

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
                string delete = "DELETE FROM dbo.class WHERE class_id=@classid AND class_name=@classname AND class_dateoftime=@classdateoftime ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                cmd.Parameters["@classid"].Value = tbclassid.Text;
                cmd.Parameters.Add("@classname", SqlDbType.VarChar);
                cmd.Parameters["@classname"].Value = tbclassname.Text;
                cmd.Parameters.Add("@classdateoftime", SqlDbType.Date);
                cmd.Parameters["@classdateoftime"].Value = tbclassdatetime.Text;
                cmd.ExecuteNonQuery();

                FillData();
                MessageBox.Show(this, "delete succesfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want edit", "result", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string update = "update dbo.class set class_dateoftime=@classdateoftime where class_id=@classid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@classid", SqlDbType.VarChar);
                cmd.Parameters["@classid"].Value = tbclassid.Text;

                cmd.Parameters.Add("@classdateoftime", SqlDbType.Date);
                cmd.Parameters["@classdateoftime"].Value = tbclassdatetime.Text;
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
            tbclassdatetime.Text = "";
            tbclassid.Text = "";
            tbclassname.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.ShowDialog
                ();
            this.Hide();
            this.Dispose();
        }
    }
}
