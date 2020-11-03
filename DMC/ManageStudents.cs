using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DMC
{
    public partial class ManageStudents : Form
    {
        string con = @"Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True;";

        public ManageStudents()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent s1 = new AddStudent();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent s1 = new AddStudent();
            s1.Show();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");

            string searchQuery = "SELECT STUDENT_DETAILS.REG_NUMBER, STUDENT_DETAILS.NAME, STUDENT_DETAILS.DEGREE, COURSE_DETAILS.COURSE_NAME FROM [dbo].[STUDENT_DETAILS] inner join [dbo].[COURSE_DETAILS]";
            searchQuery += "on STUDENT_DETAILS.REG_NUMBER = COURSE_DETAILS.FK_REG_NUM";
            SqlCommand cmd = new SqlCommand(searchQuery, con);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
