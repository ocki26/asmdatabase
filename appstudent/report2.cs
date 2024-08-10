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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace appstudent
{

    public partial class report2 : Form

    {
        SqlConnection conn;
        public report2()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");
        }

        private void button1_Click(object sender, EventArgs e, string username)
        {
            if (username == "student")
            {
                student student = new student();
                student.ShowDialog();
                this.Close();

            }
            else if (username == "teacher")
            {
                teacher teacher = new teacher();
                teacher.ShowDialog();
                this.Close();
            }
            else
            {
                admin admin = new admin();
                admin.ShowDialog();
                this.Hide();

            }

        }

        private void btexit_Click(object sender, EventArgs e, string username)
        {
            InitializeComponent();
            if (username == "student")
            {
                student student = new student();
                student.ShowDialog();
                this.Close();
            }
            else if (username == "teacher")
            {
                teacher student = new teacher();
                student.ShowDialog();
                this.Close();
            }
            else
            {
                admin admin = new admin();
                admin.ShowDialog();
                this.Hide();
            }
        }

        private void btexitaa_Click(object sender, EventArgs e, string username)
        {
            InitializeComponent();
            if (username == "student")
            {
                student student = new student();
                student.ShowDialog();
                this.Close();
            }
            else if (username == "teacher")
            {
                teacher student = new teacher();
                student.ShowDialog();
                this.Close();
            }
            else
            {
                admin admin = new admin();
                admin.ShowDialog();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btexitaa_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.ShowDialog();
            this.Hide();
        }
        public report2(string username)
        {
            InitializeComponent();

            if (username == "student" || username == "teacher")
            {
                btexitaa.Enabled = false;
            }
        }


        private void fill_data()
        {
            string query = "select * from dbo.StudentAttendanceReport";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tablestudentreport.DataSource = tb;
            conn.Close();


        }




        private void report2_Load(object sender, EventArgs e)
        {
            conn.Open();
            fill_data();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
