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
    public partial class AddStudent : Form
    {
        string con = @"Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True;";
        SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");

        public AddStudent()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudents s1 = new ManageStudents();
            s1.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");
            con.Open();

            string query = "INSERT INTO STUDENT_DETAILS(REG_NUMBER, NAME, DEGREE)" +
                "VALUES(@reg_num, @name, @degree)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@reg_num", regno.Text);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.Parameters.AddWithValue("@degree", degreetxt.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Record added!");

            regno.Text = "";
            nametxt.Text = "";
            degreetxt.Text = "";

            con.Close();

            this.Hide();
            Form1 s1 = new Form1();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchData(regno.Text);
            
        }

        public void displayData()
        {
            SqlCommand cmd;
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM COURSE_DETAILS", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string reg_num = regno.Text;
            string degree = degreetxt.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");
            con.Open();

            string query = "insert into STUDENT_DETAILS(REG_NUMBER, NAME, DEGREE) " +
                "values(@reg_num1, @name1, @degree1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@reg_num1", name);
            cmd.Parameters.AddWithValue("@name1", reg_num);
            cmd.Parameters.AddWithValue("@degree1", degree);

            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Student added!");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=StudentDMC;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM COURSE_DETAILS WHERE FK_REG_NUM='" + regno.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            displayData();

            MessageBox.Show("Record deleted successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourse s1 = new AddCourse();
            s1.Show();
        }

        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM COURSE_DETAILS WHERE FK_REG_NUM LIKE '%" + valueToFind + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

    }
}
