namespace appstudent
{
    partial class createstudent
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
            btadd = new Button();
            btedit = new Button();
            btdelete = new Button();
            tbstudentid = new TextBox();
            label1 = new Label();
            tbstudentname = new TextBox();
            tbgender = new TextBox();
            tbage = new TextBox();
            tbemail = new TextBox();
            tbaddres = new TextBox();
            tbdateofbirth = new TextBox();
            tbregistrationdate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblerror = new Label();
            tablestudent = new DataGridView();
            student_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            registration_date = new DataGridViewTextBoxColumn();
            date_of_birth = new DataGridViewTextBoxColumn();
            addres = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            btexit = new Button();
            ((System.ComponentModel.ISupportInitialize)tablestudent).BeginInit();
            SuspendLayout();
            // 
            // btadd
            // 
            btadd.Location = new Point(500, 520);
            btadd.Name = "btadd";
            btadd.Size = new Size(188, 58);
            btadd.TabIndex = 0;
            btadd.Text = "add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(763, 520);
            btedit.Name = "btedit";
            btedit.Size = new Size(188, 58);
            btedit.TabIndex = 1;
            btedit.Text = "edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(1025, 520);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(188, 58);
            btdelete.TabIndex = 2;
            btdelete.Text = "delete";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // tbstudentid
            // 
            tbstudentid.Location = new Point(245, 57);
            tbstudentid.Name = "tbstudentid";
            tbstudentid.Size = new Size(578, 47);
            tbstudentid.TabIndex = 3;
            tbstudentid.TextChanged += tbstudentid_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 4;
            label1.Text = "studentid";
            // 
            // tbstudentname
            // 
            tbstudentname.Location = new Point(245, 159);
            tbstudentname.Name = "tbstudentname";
            tbstudentname.Size = new Size(578, 47);
            tbstudentname.TabIndex = 6;
            // 
            // tbgender
            // 
            tbgender.Location = new Point(1210, 401);
            tbgender.Name = "tbgender";
            tbgender.Size = new Size(578, 47);
            tbgender.TabIndex = 7;
            // 
            // tbage
            // 
            tbage.Location = new Point(1210, 266);
            tbage.Name = "tbage";
            tbage.Size = new Size(578, 47);
            tbage.TabIndex = 8;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(1210, 159);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(578, 47);
            tbemail.TabIndex = 9;
            // 
            // tbaddres
            // 
            tbaddres.Location = new Point(1210, 54);
            tbaddres.Name = "tbaddres";
            tbaddres.Size = new Size(578, 47);
            tbaddres.TabIndex = 10;
            // 
            // tbdateofbirth
            // 
            tbdateofbirth.Location = new Point(245, 401);
            tbdateofbirth.Name = "tbdateofbirth";
            tbdateofbirth.Size = new Size(578, 47);
            tbdateofbirth.TabIndex = 11;
            // 
            // tbregistrationdate
            // 
            tbregistrationdate.Location = new Point(245, 266);
            tbregistrationdate.Name = "tbregistrationdate";
            tbregistrationdate.Size = new Size(578, 47);
            tbregistrationdate.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 165);
            label2.Name = "label2";
            label2.Size = new Size(205, 41);
            label2.TabIndex = 13;
            label2.Text = "student_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 272);
            label3.Name = "label3";
            label3.Size = new Size(240, 41);
            label3.TabIndex = 14;
            label3.Text = "registration_date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 404);
            label4.Name = "label4";
            label4.Size = new Size(190, 41);
            label4.TabIndex = 15;
            label4.Text = "date_of_birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1072, 57);
            label5.Name = "label5";
            label5.Size = new Size(108, 41);
            label5.TabIndex = 16;
            label5.Text = "addres";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1072, 159);
            label6.Name = "label6";
            label6.Size = new Size(89, 41);
            label6.TabIndex = 17;
            label6.Text = "email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1072, 266);
            label7.Name = "label7";
            label7.Size = new Size(67, 41);
            label7.TabIndex = 18;
            label7.Text = "age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1048, 407);
            label8.Name = "label8";
            label8.Size = new Size(113, 41);
            label8.TabIndex = 19;
            label8.Text = "gender";
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(1831, 57);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 41);
            lblerror.TabIndex = 20;
            // 
            // tablestudent
            // 
            tablestudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablestudent.Columns.AddRange(new DataGridViewColumn[] { student_id, student_name, registration_date, date_of_birth, addres, email, age, gender });
            tablestudent.Location = new Point(186, 584);
            tablestudent.Name = "tablestudent";
            tablestudent.RowHeadersWidth = 102;
            tablestudent.Size = new Size(1898, 375);
            tablestudent.TabIndex = 21;
            tablestudent.CellClick += tablestudent_CellClick;
            // 
            // student_id
            // 
            student_id.DataPropertyName = "student_id";
            student_id.HeaderText = "student_id";
            student_id.MinimumWidth = 12;
            student_id.Name = "student_id";
            student_id.Width = 250;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "student_name";
            student_name.MinimumWidth = 12;
            student_name.Name = "student_name";
            student_name.Width = 250;
            // 
            // registration_date
            // 
            registration_date.DataPropertyName = "registration_date";
            registration_date.HeaderText = "registration_date";
            registration_date.MinimumWidth = 12;
            registration_date.Name = "registration_date";
            registration_date.Width = 250;
            // 
            // date_of_birth
            // 
            date_of_birth.DataPropertyName = "date_of_birth";
            date_of_birth.HeaderText = "date_of_birth ";
            date_of_birth.MinimumWidth = 12;
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Width = 250;
            // 
            // addres
            // 
            addres.DataPropertyName = "addres";
            addres.HeaderText = "addres";
            addres.MinimumWidth = 12;
            addres.Name = "addres";
            addres.Width = 250;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "email";
            email.MinimumWidth = 12;
            email.Name = "email";
            email.Width = 250;
            // 
            // age
            // 
            age.DataPropertyName = "age";
            age.HeaderText = "age";
            age.MinimumWidth = 12;
            age.Name = "age";
            age.Width = 250;
            // 
            // gender
            // 
            gender.DataPropertyName = "gender";
            gender.HeaderText = "gender";
            gender.MinimumWidth = 12;
            gender.Name = "gender";
            gender.Width = 250;
            // 
            // btexit
            // 
            btexit.Location = new Point(1277, 526);
            btexit.Name = "btexit";
            btexit.Size = new Size(188, 58);
            btexit.TabIndex = 22;
            btexit.Text = "exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // createstudent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2309, 984);
            Controls.Add(btexit);
            Controls.Add(tablestudent);
            Controls.Add(lblerror);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbregistrationdate);
            Controls.Add(tbdateofbirth);
            Controls.Add(tbaddres);
            Controls.Add(tbemail);
            Controls.Add(tbage);
            Controls.Add(tbgender);
            Controls.Add(tbstudentname);
            Controls.Add(label1);
            Controls.Add(tbstudentid);
            Controls.Add(btdelete);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Name = "createstudent";
            Text = "createstudent";
            Load += createstudent_Load;
            ((System.ComponentModel.ISupportInitialize)tablestudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btadd;
        private Button btedit;
        private Button btdelete;
        private TextBox tbstudentid;
        private Label label1;
        private TextBox tbstudentname;
        private TextBox tbgender;
        private TextBox tbage;
        private TextBox tbemail;
        private TextBox tbaddres;
        private TextBox tbdateofbirth;
        private TextBox tbregistrationdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblerror;
        private DataGridView tablestudent;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn registration_date;
        private DataGridViewTextBoxColumn date_of_birth;
        private DataGridViewTextBoxColumn addres;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn gender;
        private Button btexit;
    }
}