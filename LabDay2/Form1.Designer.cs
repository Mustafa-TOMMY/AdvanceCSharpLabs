namespace LabDay2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbADOLabDataSet = new LabDay2.DbADOLabDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTI_MainDataSet = new LabDay2.ITI_MainDataSet();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.btn_Searsh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_IdSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_IdDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentTableAdapter = new LabDay2.ITI_MainDataSetTableAdapters.StudentTableAdapter();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.studentTableAdapter1 = new LabDay2.DbADOLabDataSetTableAdapters.StudentTableAdapter();
            this.dbADOLabDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADOLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTI_MainDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbADOLabDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIdDataGridViewTextBoxColumn,
            this.stFnameDataGridViewTextBoxColumn,
            this.stLnameDataGridViewTextBoxColumn,
            this.stAgeDataGridViewTextBoxColumn,
            this.stAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // stIdDataGridViewTextBoxColumn
            // 
            this.stIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stIdDataGridViewTextBoxColumn.DataPropertyName = "St_Id";
            this.stIdDataGridViewTextBoxColumn.HeaderText = "St_Id";
            this.stIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stIdDataGridViewTextBoxColumn.Name = "stIdDataGridViewTextBoxColumn";
            this.stIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stFnameDataGridViewTextBoxColumn
            // 
            this.stFnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stFnameDataGridViewTextBoxColumn.DataPropertyName = "St_Fname";
            this.stFnameDataGridViewTextBoxColumn.HeaderText = "St_Fname";
            this.stFnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stFnameDataGridViewTextBoxColumn.Name = "stFnameDataGridViewTextBoxColumn";
            this.stFnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stLnameDataGridViewTextBoxColumn
            // 
            this.stLnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stLnameDataGridViewTextBoxColumn.DataPropertyName = "St_Lname";
            this.stLnameDataGridViewTextBoxColumn.HeaderText = "St_Lname";
            this.stLnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stLnameDataGridViewTextBoxColumn.Name = "stLnameDataGridViewTextBoxColumn";
            this.stLnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stAgeDataGridViewTextBoxColumn
            // 
            this.stAgeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stAgeDataGridViewTextBoxColumn.DataPropertyName = "St_Age";
            this.stAgeDataGridViewTextBoxColumn.HeaderText = "St_Age";
            this.stAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stAgeDataGridViewTextBoxColumn.Name = "stAgeDataGridViewTextBoxColumn";
            this.stAgeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stAddressDataGridViewTextBoxColumn
            // 
            this.stAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stAddressDataGridViewTextBoxColumn.DataPropertyName = "St_Address";
            this.stAddressDataGridViewTextBoxColumn.HeaderText = "St_Address";
            this.stAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stAddressDataGridViewTextBoxColumn.Name = "stAddressDataGridViewTextBoxColumn";
            this.stAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.dbADOLabDataSet;
            // 
            // dbADOLabDataSet
            // 
            this.dbADOLabDataSet.DataSetName = "DbADOLabDataSet";
            this.dbADOLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.iTI_MainDataSet;
            // 
            // iTI_MainDataSet
            // 
            this.iTI_MainDataSet.DataSetName = "ITI_MainDataSet";
            this.iTI_MainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(859, 29);
            this.btn_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(131, 36);
            this.btn_Display.TabIndex = 1;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(707, 32);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 36);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(184, 16);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(131, 36);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student FName";
            // 
            // text_fname
            // 
            this.text_fname.Location = new System.Drawing.Point(13, 43);
            this.text_fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(140, 22);
            this.text_fname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student LName";
            // 
            // text_lname
            // 
            this.text_lname.Location = new System.Drawing.Point(187, 43);
            this.text_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_lname.Name = "text_lname";
            this.text_lname.Size = new System.Drawing.Size(140, 22);
            this.text_lname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Age";
            // 
            // text_age
            // 
            this.text_age.Location = new System.Drawing.Point(360, 43);
            this.text_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(140, 22);
            this.text_age.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Student City";
            // 
            // text_Address
            // 
            this.text_Address.Location = new System.Drawing.Point(537, 43);
            this.text_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(140, 22);
            this.text_Address.TabIndex = 13;
            // 
            // btn_Searsh
            // 
            this.btn_Searsh.Location = new System.Drawing.Point(185, 16);
            this.btn_Searsh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Searsh.Name = "btn_Searsh";
            this.btn_Searsh.Size = new System.Drawing.Size(131, 36);
            this.btn_Searsh.TabIndex = 15;
            this.btn_Searsh.Text = "Search";
            this.btn_Searsh.UseVisualStyleBackColor = true;
            this.btn_Searsh.Click += new System.EventHandler(this.btn_Searsh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student Id";
            // 
            // text_IdSearch
            // 
            this.text_IdSearch.Location = new System.Drawing.Point(13, 20);
            this.text_IdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_IdSearch.Name = "text_IdSearch";
            this.text_IdSearch.Size = new System.Drawing.Size(140, 22);
            this.text_IdSearch.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.text_Address);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.text_age);
            this.groupBox2.Controls.Add(this.btn_Display);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.text_lname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_fname);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Location = new System.Drawing.Point(13, 489);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1005, 76);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Searsh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_IdSearch);
            this.groupBox1.Location = new System.Drawing.Point(13, 582);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(327, 66);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student Id";
            // 
            // text_IdDelete
            // 
            this.text_IdDelete.Location = new System.Drawing.Point(8, 20);
            this.text_IdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_IdDelete.Name = "text_IdDelete";
            this.text_IdDelete.Size = new System.Drawing.Size(140, 22);
            this.text_IdDelete.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.text_IdDelete);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Location = new System.Drawing.Point(359, 582);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(325, 63);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(720, 602);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(131, 36);
            this.btn_Connect.TabIndex = 24;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(872, 602);
            this.btn_DisConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(131, 36);
            this.btn_DisConnect.TabIndex = 25;
            this.btn_DisConnect.Text = "DisConnect";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // dbADOLabDataSetBindingSource
            // 
            this.dbADOLabDataSetBindingSource.DataSource = this.dbADOLabDataSet;
            this.dbADOLabDataSetBindingSource.Position = 0;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.dbADOLabDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 662);
            this.Controls.Add(this.btn_DisConnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DisConnected Case";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADOLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTI_MainDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbADOLabDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.Button btn_Searsh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_IdSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_IdDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private ITI_MainDataSet iTI_MainDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ITI_MainDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_DisConnect;
        private DbADOLabDataSet dbADOLabDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private DbADOLabDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource dbADOLabDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAddressDataGridViewTextBoxColumn;
    }
}

