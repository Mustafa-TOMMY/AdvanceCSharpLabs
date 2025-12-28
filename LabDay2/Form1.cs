using System;
using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LabDay2
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn;
        SqlCommand SqlCmd;

        SqlDataAdapter sqlAdp;
        DataSet dSet;


        public Form1()
        {
            InitializeComponent();

            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = "Data Source=.;Initial Catalog=DbADOLab;Integrated Security=True;TrustServerCertificate=True;";

            SqlCmd = sqlConn.CreateCommand();
            SqlCmd.Connection = sqlConn;                        //Connection to
            SqlCmd.CommandType = CommandType.Text;              // Query Type

            sqlAdp = new SqlDataAdapter();
            dSet = new DataSet();


            #region Disconnected Button Mode

            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Searsh.Enabled = false;
            btn_Display.Enabled = false;

            #endregion

        }

        private void btn_Display_Click(object sender, EventArgs e) //Disconnected Model
        {
            dSet.Clear();
            SqlCmd.CommandText = "Select * from Student";    // Query Text
            sqlAdp.SelectCommand = SqlCmd;

            sqlConn.Open();
            sqlAdp.Fill(dSet);
            sqlConn.Close();

            dataGridView1.DataSource = dSet.Tables[0];
        }

        private void btn_Add_Click(object sender, EventArgs e)  // Disconnected Model
        {
            dSet.Clear();
            if (text_fname.Text == "")
            {
                MessageBox.Show("Student First Name Can't be null");
                return;
            }

            SqlCmd.CommandText = "Insert into Student( St_Fname,St_Lname , St_Address , St_Age) " +
                        "values ( @Fname , @Lname , @Address , @Age)";    // Query Text

            #region  the Query and its Parameter

            SqlCmd.Parameters.Clear();

            SqlCmd.Parameters.AddWithValue("@Fname", text_fname.Text);
            SqlCmd.Parameters.AddWithValue("@Lname", text_lname.Text);
            SqlCmd.Parameters.AddWithValue("@Address", text_Address.Text);
            int.TryParse(text_age.Text, out int ageValue);
            SqlCmd.Parameters.AddWithValue("@Age", ageValue);
            #endregion

            sqlAdp.InsertCommand = SqlCmd;

            try
            {
                sqlConn.Open();
                sqlAdp.Fill(dSet);
            }
            finally
            {
                sqlConn.Close();
            }
            MessageBox.Show("Student Added Successfully");
            btn_Display_Click(sender, e);

            text_age.Text = text_fname.Text = text_lname.Text = text_Address.Text = "";

        }

        private void btn_Searsh_Click(object sender, EventArgs e)  // Disconnected Model
        {
            dSet.Clear();
            if (string.IsNullOrEmpty(text_IdSearch.Text))
            {
                MessageBox.Show("Please Enter an ID to Start Searsh");
                return;
            }

            SqlCmd.CommandText = "Select * from Student where St_Id = @Id";

            #region the Query and its Parameter

            SqlCmd.Parameters.Clear();
            SqlCmd.Parameters.AddWithValue("@Id", int.Parse(text_IdSearch.Text));

            #endregion

            sqlAdp.SelectCommand = SqlCmd;

            try
            {
                sqlConn.Open();
                sqlAdp.Fill(dSet);
            }
            finally
            {
                sqlConn.Close();
            }

            if (dSet == null)
            {
                MessageBox.Show("No Student With this ID");
                return;
            }

            dataGridView1.DataSource = dSet.Tables[0];
        }

        private void btn_Delete_Click(object sender, EventArgs e)  // Disconnected Model
        {
            if (string.IsNullOrEmpty(text_IdDelete.Text))
            {
                MessageBox.Show("Please Enter an ID");
                return;
            }

            SqlCmd.CommandText = "Delete from Student where St_Id = @Id";

            #region the Query and its Parameter

            SqlCmd.Parameters.Clear();
            SqlCmd.Parameters.AddWithValue("@Id", int.Parse(text_IdDelete.Text));

            #endregion

            try
            {
                sqlConn.Open();
                sqlAdp.Fill(dSet);
            }
            finally
            {
                sqlConn.Close();
            }
            //int rows = sqlAdp.DeleteCommand.ExecuteNonQuery();
            //if (rows == 0)
            //{
            //    MessageBox.Show("No Student With this ID");
            //    return;
            //}
            text_IdDelete.Text = "";
            MessageBox.Show("Student Deleted Successfully");
            btn_Display_Click(sender, e);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Display_Click(sender, e);
            btn_Searsh.Enabled = true;
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Display.Enabled = true;
        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Searsh.Enabled = false;
            btn_Display.Enabled = false;

        }

    }
}
