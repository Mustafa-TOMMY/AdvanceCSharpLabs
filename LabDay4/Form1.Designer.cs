namespace LabDay4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            label5 = new Label();
            text_IdDelete = new TextBox();
            btn_Delete = new Button();
            btn_Add = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            text_Fname = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label7 = new Label();
            textBox5 = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label8 = new Label();
            text_Lanem = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            text_Address = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label9 = new Label();
            text_Age = new TextBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Connect = new Button();
            btn_DisConnect = new Button();
            btn_Display = new Button();
            btn_Search = new Button();
            label2 = new Label();
            text_IdSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1095, 621);
            splitContainer1.SplitterDistance = 74;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1095, 74);
            label1.TabIndex = 0;
            label1.Text = "Student Managment System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Panel2.Padding = new Padding(5, 0, 5, 20);
            splitContainer2.Size = new Size(1095, 541);
            splitContainer2.SplitterDistance = 430;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(4);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = SystemColors.ButtonFace;
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(text_IdDelete);
            splitContainer3.Panel1.Controls.Add(btn_Delete);
            splitContainer3.Panel1.Controls.Add(btn_Add);
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel4);
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel6);
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel3);
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel7);
            splitContainer3.Panel1.Padding = new Padding(5, 0, 0, 0);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.BackColor = SystemColors.ButtonFace;
            splitContainer3.Panel2.Controls.Add(dataGridView1);
            splitContainer3.Panel2.Padding = new Padding(5, 20, 5, 20);
            splitContainer3.Size = new Size(1095, 430);
            splitContainer3.SplitterDistance = 402;
            splitContainer3.SplitterWidth = 6;
            splitContainer3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 340);
            label5.Margin = new Padding(20, 20, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 14;
            label5.Text = "SrudentId: ";
            // 
            // text_IdDelete
            // 
            text_IdDelete.Location = new Point(167, 376);
            text_IdDelete.Margin = new Padding(20, 20, 3, 3);
            text_IdDelete.Name = "text_IdDelete";
            text_IdDelete.Size = new Size(218, 34);
            text_IdDelete.TabIndex = 13;
            // 
            // btn_Delete
            // 
            btn_Delete.AutoSize = true;
            btn_Delete.BackColor = Color.Firebrick;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_Delete.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(18, 340);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Padding = new Padding(10, 5, 10, 5);
            btn_Delete.Size = new Size(141, 70);
            btn_Delete.TabIndex = 12;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.BackColor = Color.SeaGreen;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_Add.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(18, 272);
            btn_Add.Name = "btn_Add";
            btn_Add.Padding = new Padding(10, 5, 10, 5);
            btn_Add.Size = new Size(365, 51);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(text_Fname);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.Location = new Point(13, 15);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel4.Size = new Size(372, 45);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 5);
            label3.Margin = new Padding(3, 0, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 0;
            label3.Text = "First Name:";
            // 
            // text_Fname
            // 
            text_Fname.Location = new Point(136, 5);
            text_Fname.Margin = new Padding(3, 0, 3, 0);
            text_Fname.Name = "text_Fname";
            text_Fname.Size = new Size(229, 34);
            text_Fname.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Controls.Add(textBox5);
            flowLayoutPanel5.Location = new Point(3, 42);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel5.Size = new Size(372, 45);
            flowLayoutPanel5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 5);
            label7.Margin = new Padding(3, 0, 20, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 0;
            label7.Text = "First Name:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 5);
            textBox5.Margin = new Padding(3, 0, 3, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 34);
            textBox5.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label8);
            flowLayoutPanel6.Controls.Add(text_Lanem);
            flowLayoutPanel6.Location = new Point(13, 82);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel6.Size = new Size(372, 45);
            flowLayoutPanel6.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 5);
            label8.Margin = new Padding(3, 0, 20, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 0;
            label8.Text = "Last Name: ";
            // 
            // text_Lanem
            // 
            text_Lanem.Location = new Point(138, 5);
            text_Lanem.Margin = new Padding(3, 0, 3, 0);
            text_Lanem.Name = "text_Lanem";
            text_Lanem.Size = new Size(229, 34);
            text_Lanem.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(text_Address);
            flowLayoutPanel3.Location = new Point(13, 207);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel3.Size = new Size(372, 45);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Margin = new Padding(3, 0, 20, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 0;
            label4.Text = "Address:     ";
            // 
            // text_Address
            // 
            text_Address.Location = new Point(137, 5);
            text_Address.Margin = new Padding(3, 0, 3, 0);
            text_Address.Name = "text_Address";
            text_Address.Size = new Size(229, 34);
            text_Address.TabIndex = 5;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label9);
            flowLayoutPanel7.Controls.Add(text_Age);
            flowLayoutPanel7.Location = new Point(13, 145);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel7.Size = new Size(372, 45);
            flowLayoutPanel7.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 5);
            label9.Margin = new Padding(3, 0, 20, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 28);
            label9.TabIndex = 0;
            label9.Text = "Age:            ";
            // 
            // text_Age
            // 
            text_Age.Location = new Point(137, 5);
            text_Age.Margin = new Padding(3, 0, 3, 0);
            text_Age.Name = "text_Age";
            text_Age.Size = new Size(229, 34);
            text_Age.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 20);
            dataGridView1.Margin = new Padding(5, 20, 5, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 390);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.Controls.Add(btn_Connect);
            flowLayoutPanel1.Controls.Add(btn_DisConnect);
            flowLayoutPanel1.Controls.Add(btn_Display);
            flowLayoutPanel1.Controls.Add(btn_Search);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(text_IdSearch);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(5, 0);
            flowLayoutPanel1.Margin = new Padding(5, 5, 5, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(1085, 85);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_Connect
            // 
            btn_Connect.AutoSize = true;
            btn_Connect.BackColor = Color.SeaGreen;
            btn_Connect.Dock = DockStyle.Fill;
            btn_Connect.FlatAppearance.BorderSize = 0;
            btn_Connect.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_Connect.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btn_Connect.FlatStyle = FlatStyle.Flat;
            btn_Connect.ForeColor = Color.White;
            btn_Connect.Location = new Point(13, 8);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Padding = new Padding(10, 5, 10, 5);
            btn_Connect.Size = new Size(141, 64);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "ConnectDB";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_DisConnect
            // 
            btn_DisConnect.AutoSize = true;
            btn_DisConnect.BackColor = Color.Firebrick;
            btn_DisConnect.Dock = DockStyle.Fill;
            btn_DisConnect.FlatAppearance.BorderSize = 0;
            btn_DisConnect.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_DisConnect.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btn_DisConnect.FlatStyle = FlatStyle.Flat;
            btn_DisConnect.ForeColor = Color.White;
            btn_DisConnect.Location = new Point(177, 8);
            btn_DisConnect.Margin = new Padding(20, 3, 3, 3);
            btn_DisConnect.Name = "btn_DisConnect";
            btn_DisConnect.Padding = new Padding(10, 5, 10, 5);
            btn_DisConnect.Size = new Size(166, 64);
            btn_DisConnect.TabIndex = 1;
            btn_DisConnect.Text = "DisConnectDB";
            btn_DisConnect.UseVisualStyleBackColor = false;
            btn_DisConnect.Click += btn_DisConnect_Click;
            // 
            // btn_Display
            // 
            btn_Display.AutoSize = true;
            btn_Display.Dock = DockStyle.Fill;
            btn_Display.FlatStyle = FlatStyle.Flat;
            btn_Display.Location = new Point(366, 8);
            btn_Display.Margin = new Padding(20, 3, 3, 3);
            btn_Display.Name = "btn_Display";
            btn_Display.Padding = new Padding(10, 5, 10, 5);
            btn_Display.Size = new Size(166, 64);
            btn_Display.TabIndex = 2;
            btn_Display.Text = "Display";
            btn_Display.UseVisualStyleBackColor = false;
            btn_Display.Click += btn_Display_Click;
            // 
            // btn_Search
            // 
            btn_Search.AutoSize = true;
            btn_Search.Dock = DockStyle.Fill;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Location = new Point(555, 8);
            btn_Search.Margin = new Padding(20, 3, 3, 3);
            btn_Search.Name = "btn_Search";
            btn_Search.Padding = new Padding(10, 5, 10, 5);
            btn_Search.Size = new Size(166, 64);
            btn_Search.TabIndex = 3;
            btn_Search.Text = "SearchById";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(744, 25);
            label2.Margin = new Padding(20, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 5;
            label2.Text = "SrudentId: ";
            // 
            // text_IdSearch
            // 
            text_IdSearch.Location = new Point(874, 25);
            text_IdSearch.Margin = new Padding(20, 20, 3, 3);
            text_IdSearch.Name = "text_IdSearch";
            text_IdSearch.Size = new Size(207, 34);
            text_IdSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1115, 621);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Padding = new Padding(10, 0, 10, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Connect;
        private Button btn_DisConnect;
        private Button btn_Display;
        private Button btn_Search;
        private Label label2;
        private TextBox text_IdSearch;
        private Label label3;
        private TextBox text_Fname;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label7;
        private TextBox textBox5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label8;
        private TextBox text_Lanem;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label9;
        private TextBox text_Age;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private TextBox text_Address;
        private DataGridView dataGridView1;
        private Button btn_Add;
        private Label label5;
        private TextBox text_IdDelete;
        private Button btn_Delete;
    }
}
