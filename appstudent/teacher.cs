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
    public partial class teacher : Form
    {
        SqlConnection conn;
        public teacher()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-4FUIOMN\\SQLEXPRESS;Database=bt9;Integrated Security = true;");
        }
        public void filldata()
        {
            string query = "select * from attendance";
            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tb);
            tbtacher.DataSource = tb;
            conn.Close();
        }

        private void btexit_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            conn.Open();
            filldata();
        }

        private void tbtacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btreport_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.ShowDialog();
            this.Close();
        }
    }
}
