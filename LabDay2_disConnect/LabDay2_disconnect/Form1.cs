using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace LabDay2_connect
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;


        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=DbADOLab;Integrated Security=True";

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            btn_searsh.Enabled = false;
            btn_display.Enabled = false;
        }

        private void btn_disconnect_Click(object sender, System.EventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            btn_searsh.Enabled = false;
            btn_display.Enabled = false;
            dataGridView1.DataSource = null;    
        }

        private void btn_connect_Click(object sender, System.EventArgs e)
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            btn_searsh.Enabled = true;
            btn_display.Enabled = true;
        }

        private void btn_add_Click(object sender, System.EventArgs e)
        {
            if (text_Fname.Text == "")
            {
                MessageBox.Show("Student First Name Can't be null");
                return;
            }
            cmd.CommandText = "Insert into Student( St_Fname,St_Lname , St_Address , St_Age) " +
                                "values ( @Fname , @Lname , @Address , @Age)";    // Query Text

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Fname", text_Fname.Text);
            cmd.Parameters.AddWithValue("@Lname", text_Lname.Text);
            cmd.Parameters.AddWithValue("@Address", text_Address.Text);
            int.TryParse(text_Age.Text, out int ageValue);
            cmd.Parameters.AddWithValue("@Age", ageValue);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            btn_display_Click(sender, e);

            text_Address.Text = text_Lname.Text = text_Fname.Text = text_Age.Text = "";
        }

        private void btn_display_Click(object sender, System.EventArgs e)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("St_Id", typeof(int));
            dt.Columns.Add("St_Fname", typeof(string));
            dt.Columns.Add("St_Lname", typeof(string));
            dt.Columns.Add("St_Age", typeof(int));
            dt.Columns.Add("St_Address", typeof(string));

            cmd.CommandText = "SELECT * FROM Student";
            cmd.Connection = con;

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string fname = reader.GetString(1);
                    string lname = reader.GetString(2);
                    int age = reader.GetInt32(3);
                    string address = reader.GetString(4);

                    dt.Rows.Add(id, fname, lname, age, address);
                }

                reader.Close();
            }
            finally
            {
                con.Close();
            }

            dataGridView1.DataSource = dt;

        }

        private void btn_searsh_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(text_IdSearch.Text, out int id))
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("St_Id", typeof(int));
            dt.Columns.Add("St_Fname", typeof(string));
            dt.Columns.Add("St_Lname", typeof(string));
            dt.Columns.Add("St_Age", typeof(int));
            dt.Columns.Add("St_Address", typeof(string));

            cmd.CommandText = "SELECT * FROM Student WHERE St_Id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetString(4)
                    );
                }

                reader.Close();
            }
            finally
            {
                con.Close();
            }

            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(text_IdDelete.Text, out int id))
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            cmd.CommandText = "DELETE FROM Student WHERE St_Id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }

            btn_display_Click(sender, e);
        }

    }
}
