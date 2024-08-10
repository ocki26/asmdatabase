using System.Data;
using System.Data.SqlClient;

namespace appstudent
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = tbusers.Text;
            string password = tbpassword.Text;
            string query = "Select * from  account2 where username=@username and u_password =@password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["username"].ToString();
                if (role.Equals("student"))
                {
                    MessageBox.Show(this, "log in successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    student st = new student();
                    st.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "log in successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    admin ad = new admin();
                    ad.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("teacher"))
                {
                    MessageBox.Show(this, "log in successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    teacher te = new teacher();
                    te.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    lblerror.Text = "error 999";
                }

            }
            lblerror.Text = "wrong account or password";
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
