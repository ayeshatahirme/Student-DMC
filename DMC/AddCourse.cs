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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudents s1 = new ManageStudents();
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");
            con.Open();

            string query = "INSERT INTO COURSE_DETAILS(COURSE_ID, COURSE_NAME, CRDHRS, SEMESTER, MARKS, FK_REG_NUM)" +
                "VALUES(@course_id, @course_name, @crdh, @sem, @marks, @regnum)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@course_id", idtxt.Text);
            cmd.Parameters.AddWithValue("@course_name", coursenametxt.Text);
            cmd.Parameters.AddWithValue("@crdh", crdhrstxt.Text);
            cmd.Parameters.AddWithValue("@sem", semestertxt.Text);
            cmd.Parameters.AddWithValue("@marks", markstxt.Text);
            cmd.Parameters.AddWithValue("@regnum", regnumtxt.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Record added!");

            idtxt.Text = "";
            coursenametxt.Text = "";
            crdhrstxt.Text = "";
            semestertxt.Text = "";
            regnumtxt.Text = "";

            con.Close();

            this.Hide();
            AddStudent s1 = new AddStudent();
            s1.Show();
        }
        
    }
}
