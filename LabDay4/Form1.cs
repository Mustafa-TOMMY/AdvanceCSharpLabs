using LabDay4.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabDay4
{
    public partial class Form1 : Form
    {
        MyAppContext db = new MyAppContext();
        public Form1()
        {
            InitializeComponent();
            db.Database.EnsureCreated(); //only one time at start the app. to create DB ant tables
            DisableApp();
            EmptyGrid();

            #region dataGridView1 style
            //dataGridView1.EnableHeadersVisualStyles = false;

            //dataGridView1.BackgroundColor = Color.White;

            //dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;

            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            //dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            ////dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            ////dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.GridColor = Color.LightGray;

            //dataGridView1.ColumnHeadersHeight = 40;
            //dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridView1.RowTemplate.Height = 35;
            #endregion
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
            EmptyGrid();
            var data = db.Students.ToList();
            dataGridView1.DataSource = data;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(text_IdSearch.Text, out int id))
            {
                var student = db.Students.Where(s => s.Id == id).ToList();

                if (student.Any())
                {
                    dataGridView1.DataSource = student;
                    text_IdSearch.Text = "";
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
                
            }
            else
            {
                MessageBox.Show("Enter valid Id");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool flag = int.TryParse(text_Age.Text, out int StudentAge);
            if (!flag)
            {
                MessageBox.Show("Enter valid Age");
                return;
            }
            var s = new Student()
            {
                FName = text_Fname.Text,
                LName = text_Lanem.Text,
                Age = StudentAge,
                Address = text_Address.Text
            };
            db.Students.Add(s);
            db.SaveChanges();
            btn_Display_Click(sender, e);

            text_Age.Text = text_Fname.Text = text_Lanem.Text = text_Address.Text = "";
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(text_IdDelete.Text, out int id))
            {
                using MyAppContext db = new MyAppContext();

                //var student = db.Students.Find(id);
                //var student = db.Students.Where(st => st.Id == id);
                Student? student = db?.Students.Where(st => st.Id == id) as Student;
                //var student = db.Students.Where(st => st.Id == id).FirstOrDefault();

                if (student == null)
                {
                    MessageBox.Show("Student not found");
                    return;
                }

                db.Students.Remove(student);
                db.SaveChanges();
                btn_Display_Click(sender, e);
                text_IdDelete.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid Id");
            }
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            EnableApp();
            btn_Display_Click(sender, e);
        }
        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            DisableApp();
            EmptyGrid();
        }
        private void DisableApp()
        {
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Search.Enabled = false;
            btn_Display.Enabled = false;
        }
        private void EnableApp()
        {
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Search.Enabled = true;
            btn_Display.Enabled = true;

        }
        private void EmptyGrid()
        {
            dataGridView1.DataSource = null;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        // Hi from Here

        // Hello from There
    }
}
