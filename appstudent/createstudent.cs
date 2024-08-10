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
    public partial class createstudent : Form
    {
        SqlConnection conn;
        public createstudent()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");
        }
        private void filldata()
        {
            string query = "select * from dbo.student";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tablestudent.DataSource = tb;
            conn.Close();
        }
        private void tablestudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablestudent.Rows[e.RowIndex];
                tbstudentid.Text = row.Cells["student_id"].Value.ToString();
                tbstudentname.Text = row.Cells["student_name"].Value.ToString();
                tbregistrationdate.Text = row.Cells["registration_date"].Value.ToString();
                tbdateofbirth.Text = row.Cells["date_of_birth"].Value.ToString();
                tbemail.Text = row.Cells["email"].Value.ToString();
                tbaddres.Text = row.Cells["addres"].Value.ToString();
                tbage.Text = row.Cells["age"].Value.ToString();
                tbgender.Text = row.Cells["gender"].Value.ToString();
            }

        }


        private void createstudent_Load(object sender, EventArgs e)
        {
            conn.Open();
            filldata();
            getdatastudent();



        }
        private void getdatastudent()
        {
            string query = "Select student_id,student_name,registration_date,date_of_birth,addres,email,age,gender from dbo.student";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            string studentid = tbstudentid.Text;
            if (studentid.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "ID can't be blank ";
            }
            else lblerror.Text = "";
            string studentname = tbstudentname.Text;
            if (studentname.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "name can't be blank";
            }
            else lblerror.Text = "";
            string registrationdate = tbregistrationdate.Text;
            if (registrationdate.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "registrationdate can't be blank";

            }
            else lblerror.Text = "";
            string dateofbirth = tbdateofbirth.Text;
            if (dateofbirth.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "date of birth can't be blank";

            }
            else lblerror.Text = "";
            string email = tbemail.Text;
            if (email.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "email can't be blank";
            }
            else lblerror.Text = "";
            string addres = tbaddres.Text;
            if (addres.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "addres can't be blank";
            }
            else lblerror.Text = "";
            string age = tbage.Text;
            if (age.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "ege can't be blank";
            }
            else lblerror.Text = "";
            string gender = tbgender.Text;
            if (gender.Equals(""))
            {
                error = error + 1;
                lblerror.Text = "gender can't be blank";
            }
            else
            {
                string query = "select * from dbo.student where student_id = @studentid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@studentid", SqlDbType.VarChar);
                cmdcheck.Parameters["@studentid"].Value = studentid;
                SqlDataReader r = cmdcheck.ExecuteReader();
                if (r.Read())
                {
                    error++;
                    lblerror.Text = "this student id exiting,please choose another";

                }
                else
                {
                    lblerror.Text = "";

                }
                conn.Close();
                if (error == 0)
                {
                    string insert = "insert into dbo.student values (@studentid,@studentname,@registrationdate,@dateofbirth,@addres,@email,@age,@gender)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                    cmd.Parameters["@studentid"].Value = studentid;
                    cmd.Parameters.Add("@studentname", SqlDbType.VarChar);
                    cmd.Parameters["@studentname"].Value = studentname;
                    cmd.Parameters.Add("@registrationdate", SqlDbType.Date);
                    cmd.Parameters["@registrationdate"].Value = registrationdate;
                    cmd.Parameters.Add("@dateofbirth", SqlDbType.Date);
                    cmd.Parameters["@dateofbirth"].Value = dateofbirth;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar);
                    cmd.Parameters["@email"].Value = email;
                    cmd.Parameters.Add("@addres", SqlDbType.VarChar);
                    cmd.Parameters["@addres"].Value = addres;
                    cmd.Parameters.Add("@age", SqlDbType.Int);
                    cmd.Parameters["@age"].Value = age;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                    cmd.Parameters["@gender"].Value = gender;
                    cmd.ExecuteNonQuery();
                    filldata();
                    MessageBox.Show(this, "add succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want edit", "result", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string update = "update dbo.student set registration_date=@registrationdate,date_of_birth=@dateofbirth,email=@email,addres=@addres,age=@age,gender=@gender where student_id=@studentid"
                    ;
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                cmd.Parameters["@studentid"].Value = tbstudentid.Text;
                cmd.Parameters.Add("@registrationdate", SqlDbType.Date);
                cmd.Parameters["@registrationdate"].Value = tbregistrationdate.Text;
                cmd.Parameters.Add("@dateofbirth", SqlDbType.Date);
                cmd.Parameters["@dateofbirth"].Value = tbdateofbirth.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbemail.Text;
                cmd.Parameters.Add("@addres", SqlDbType.VarChar);
                cmd.Parameters["@addres"].Value = tbaddres.Text;
                cmd.Parameters.Add("@age", SqlDbType.Int);
                cmd.Parameters["@age"].Value = tbage.Text;
                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = tbgender.Text;


                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    filldata();
                    MessageBox.Show(this, "update succesfuly ", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want delete", "result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "DELETE FROM dbo.student WHERE student_name=@studentname AND registration_date=@registrationdate AND date_of_birth=@dateofbirth AND email=@email AND addres=@addres AND age=@age AND gender=@gender AND student_id=@studentid";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@studentname", SqlDbType.VarChar);
                cmd.Parameters["@studentname"].Value = tbstudentname.Text;
                cmd.Parameters.Add("@registrationdate", SqlDbType.Date);
                cmd.Parameters["@registrationdate"].Value = tbregistrationdate.Text;
                cmd.Parameters.Add("@dateofbirth", SqlDbType.Date);
                cmd.Parameters["@dateofbirth"].Value = tbdateofbirth.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbemail.Text;
                cmd.Parameters.Add("@addres", SqlDbType.VarChar);
                cmd.Parameters["@addres"].Value = tbaddres.Text;
                cmd.Parameters.Add("@age", SqlDbType.Int);
                cmd.Parameters["@age"].Value = tbage.Text;
                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = tbgender.Text;
                cmd.Parameters.Add("@studentid", SqlDbType.VarChar);
                cmd.Parameters["@studentid"].Value = tbstudentid.Text;
                cmd.ExecuteNonQuery();

                filldata();
                MessageBox.Show(this, "delete succesfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tbstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.ShowDialog();
            this.Hide();
            this.Dispose();
        }
    }
}
