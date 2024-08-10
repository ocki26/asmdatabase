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
    public partial class report : Form
    {
        SqlConnection conn;
        public report()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt10;Integrated Security = true;");
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.ShowDialog();
            this.Hide();

        }
        private void fill_data()
        {
            string query = "select * from dbo.ClassAttendanceReport";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tablereportclass.DataSource = tb;
            conn.Close();


        }

        private void btstudentreport_Click(object sender, EventArgs e)
        {
            report2 report2 = new report2();
            report2.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void report_Load(object sender, EventArgs e)
        {
            conn.Open();
            fill_data();
        }
    }
}
