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

namespace appstudent
{
    public partial class student : Form
    {
        SqlConnection conn;
        public student()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt9;Integrated Security = true;");

        }
        public student(string username)
        {
            lblstudent.Text = "hello" + username;
        }
        private void filldata()
        {
            string query = "select * from dbo.student";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(dt);
            tablestudent.DataSource = dt;
            conn.Close();

        }
        private void student_Load(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show(this, "connection succesful ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            filldata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void btreport_Click(object sender, EventArgs e)
        {
            report2 report2 = new report2();
            report2.ShowDialog();
            this.Close();
        }
    }
}
