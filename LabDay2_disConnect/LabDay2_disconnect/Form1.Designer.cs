namespace LabDay2_connect
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
            this.text_Fname = new System.Windows.Forms.TextBox();
            this.text_Lname = new System.Windows.Forms.TextBox();
            this.text_Age = new System.Windows.Forms.TextBox();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.text_IdDelete = new System.Windows.Forms.TextBox();
            this.text_IdSearch = new System.Windows.Forms.TextBox();
            this.btn_searsh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Fname
            // 
            this.text_Fname.Location = new System.Drawing.Point(11, 313);
            this.text_Fname.Name = "text_Fname";
            this.text_Fname.Size = new System.Drawing.Size(121, 22);
            this.text_Fname.TabIndex = 1;
            // 
            // text_Lname
            // 
            this.text_Lname.Location = new System.Drawing.Point(169, 313);
            this.text_Lname.Name = "text_Lname";
            this.text_Lname.Size = new System.Drawing.Size(121, 22);
            this.text_Lname.TabIndex = 2;
            // 
            // text_Age
            // 
            this.text_Age.Location = new System.Drawing.Point(325, 313);
            this.text_Age.Name = "text_Age";
            this.text_Age.Size = new System.Drawing.Size(121, 22);
            this.text_Age.TabIndex = 3;
            // 
            // text_Address
            // 
            this.text_Address.Location = new System.Drawing.Point(477, 313);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(121, 22);
            this.text_Address.TabIndex = 4;
            // 
            // text_IdDelete
            // 
            this.text_IdDelete.Location = new System.Drawing.Point(11, 370);
            this.text_IdDelete.Name = "text_IdDelete";
            this.text_IdDelete.Size = new System.Drawing.Size(121, 22);
            this.text_IdDelete.TabIndex = 5;
            // 
            // text_IdSearch
            // 
            this.text_IdSearch.Location = new System.Drawing.Point(325, 370);
            this.text_IdSearch.Name = "text_IdSearch";
            this.text_IdSearch.Size = new System.Drawing.Size(121, 22);
            this.text_IdSearch.TabIndex = 6;
            // 
            // btn_searsh
            // 
            this.btn_searsh.Location = new System.Drawing.Point(477, 364);
            this.btn_searsh.Name = "btn_searsh";
            this.btn_searsh.Size = new System.Drawing.Size(82, 34);
            this.btn_searsh.TabIndex = 7;
            this.btn_searsh.Text = "Search";
            this.btn_searsh.UseVisualStyleBackColor = true;
            this.btn_searsh.Click += new System.EventHandler(this.btn_searsh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(169, 364);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 34);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(625, 307);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 34);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(169, 421);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(82, 34);
            this.btn_connect.TabIndex = 10;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.LightCoral;
            this.btn_disconnect.FlatAppearance.BorderSize = 0;
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Location = new System.Drawing.Point(325, 421);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(82, 34);
            this.btn_disconnect.TabIndex = 11;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(477, 421);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(82, 34);
            this.btn_display.TabIndex = 12;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 267);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Student LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Student Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 470);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_searsh);
            this.Controls.Add(this.text_IdSearch);
            this.Controls.Add(this.text_IdDelete);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.text_Age);
            this.Controls.Add(this.text_Lname);
            this.Controls.Add(this.text_Fname);
            this.Name = "Form1";
            this.Text = "ConnectedCase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_Fname;
        private System.Windows.Forms.TextBox text_Lname;
        private System.Windows.Forms.TextBox text_Age;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.TextBox text_IdDelete;
        private System.Windows.Forms.TextBox text_IdSearch;
        private System.Windows.Forms.Button btn_searsh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

