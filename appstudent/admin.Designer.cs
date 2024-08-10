namespace appstudent
{
    partial class admin
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
            lbluser = new Label();
            btcreateteacher = new Button();
            btclass = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button1 = new Button();
            attendance_id = new DataGridViewTextBoxColumn();
            status_inday = new DataGridViewTextBoxColumn();
            attendance = new DataGridViewTextBoxColumn();
            student_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            class_id = new DataGridViewTextBoxColumn();
            class_name = new DataGridViewTextBoxColumn();
            teacher_id = new DataGridViewTextBoxColumn();
            teacher_name = new DataGridViewTextBoxColumn();
            subject_id = new DataGridViewTextBoxColumn();
            subject_name = new DataGridViewTextBoxColumn();
            tbattendanceid = new TextBox();
            tbsubjectname = new TextBox();
            tbsubjectid = new TextBox();
            tbclassname = new TextBox();
            tbteacherid = new TextBox();
            tbstudentname = new TextBox();
            tbstudentid = new TextBox();
            tbsattusinday = new TextBox();
            tbattendance = new TextBox();
            tbclassid = new TextBox();
            tbtachername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tableadmin = new DataGridView();
            attendanceid = new DataGridViewTextBoxColumn();
            statusinday = new DataGridViewTextBoxColumn();
            attendance1 = new DataGridViewTextBoxColumn();
            studentid = new DataGridViewTextBoxColumn();
            studentname = new DataGridViewTextBoxColumn();
            classid = new DataGridViewTextBoxColumn();
            classname = new DataGridViewTextBoxColumn();
            teacherid = new DataGridViewTextBoxColumn();
            teachername = new DataGridViewTextBoxColumn();
            subjectid = new DataGridViewTextBoxColumn();
            subjectname = new DataGridViewTextBoxColumn();
            btadd = new Button();
            lberror = new Label();
            btedit = new Button();
            btreport = new Button();
            ((System.ComponentModel.ISupportInitialize)tableadmin).BeginInit();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(135, 37);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(0, 41);
            lbluser.TabIndex = 0;
            // 
            // btcreateteacher
            // 
            btcreateteacher.Location = new Point(4, 97);
            btcreateteacher.Name = "btcreateteacher";
            btcreateteacher.Size = new Size(253, 58);
            btcreateteacher.TabIndex = 2;
            btcreateteacher.Text = "create student";
            btcreateteacher.UseVisualStyleBackColor = true;
            btcreateteacher.Click += btcreateteacher_Click;
            // 
            // btclass
            // 
            btclass.Location = new Point(4, 188);
            btclass.Name = "btclass";
            btclass.Size = new Size(253, 58);
            btclass.TabIndex = 3;
            btclass.Text = "createclass";
            btclass.UseVisualStyleBackColor = true;
            btclass.Click += btclass_Click;
            // 
            // button3
            // 
            button3.Location = new Point(2, 348);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(255, 58);
            button3.TabIndex = 4;
            button3.Text = "create subject";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 412);
            button4.Name = "button4";
            button4.Size = new Size(253, 58);
            button4.TabIndex = 5;
            button4.Text = "exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(2, 263);
            button5.Name = "button5";
            button5.Size = new Size(255, 58);
            button5.TabIndex = 6;
            button5.Text = "create teacher";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 7;
            label1.Text = "create data ";
            // 
            // button1
            // 
            button1.Location = new Point(1919, 322);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 8;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // attendance_id
            // 
            attendance_id.DataPropertyName = "attendance_id";
            attendance_id.HeaderText = "attendance_id";
            attendance_id.MinimumWidth = 12;
            attendance_id.Name = "attendance_id";
            attendance_id.Width = 250;
            // 
            // status_inday
            // 
            status_inday.DataPropertyName = "status_inday";
            status_inday.HeaderText = "status_inday";
            status_inday.MinimumWidth = 12;
            status_inday.Name = "status_inday";
            status_inday.Width = 250;
            // 
            // attendance
            // 
            attendance.DataPropertyName = "attendance";
            attendance.HeaderText = "attendance";
            attendance.MinimumWidth = 12;
            attendance.Name = "attendance";
            attendance.Width = 250;
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
            // class_id
            // 
            class_id.DataPropertyName = "class_id";
            class_id.HeaderText = "class_id";
            class_id.MinimumWidth = 12;
            class_id.Name = "class_id";
            class_id.Width = 250;
            // 
            // class_name
            // 
            class_name.DataPropertyName = "class_name";
            class_name.HeaderText = "class_name";
            class_name.MinimumWidth = 12;
            class_name.Name = "class_name";
            class_name.Width = 250;
            // 
            // teacher_id
            // 
            teacher_id.DataPropertyName = "teacher_id";
            teacher_id.HeaderText = "teacher_id";
            teacher_id.MinimumWidth = 12;
            teacher_id.Name = "teacher_id";
            teacher_id.Width = 250;
            // 
            // teacher_name
            // 
            teacher_name.DataPropertyName = "teacher_name";
            teacher_name.HeaderText = "teacher_name";
            teacher_name.MinimumWidth = 12;
            teacher_name.Name = "teacher_name";
            teacher_name.Width = 250;
            // 
            // subject_id
            // 
            subject_id.DataPropertyName = "subject_id";
            subject_id.HeaderText = "subject_id";
            subject_id.MinimumWidth = 12;
            subject_id.Name = "subject_id";
            subject_id.Width = 250;
            // 
            // subject_name
            // 
            subject_name.DataPropertyName = "subject_name";
            subject_name.HeaderText = "subject_name";
            subject_name.MinimumWidth = 12;
            subject_name.Name = "subject_name";
            subject_name.Width = 250;
            // 
            // tbattendanceid
            // 
            tbattendanceid.Location = new Point(489, 103);
            tbattendanceid.Name = "tbattendanceid";
            tbattendanceid.Size = new Size(250, 47);
            tbattendanceid.TabIndex = 10;
            tbattendanceid.TextChanged += tbattendanceid_TextChanged;
            // 
            // tbsubjectname
            // 
            tbsubjectname.Location = new Point(1857, 232);
            tbsubjectname.Name = "tbsubjectname";
            tbsubjectname.Size = new Size(250, 47);
            tbsubjectname.TabIndex = 11;
            // 
            // tbsubjectid
            // 
            tbsubjectid.Location = new Point(1857, 94);
            tbsubjectid.Name = "tbsubjectid";
            tbsubjectid.Size = new Size(250, 47);
            tbsubjectid.TabIndex = 12;
            // 
            // tbclassname
            // 
            tbclassname.Location = new Point(1392, 94);
            tbclassname.Name = "tbclassname";
            tbclassname.Size = new Size(250, 47);
            tbclassname.TabIndex = 13;
            // 
            // tbteacherid
            // 
            tbteacherid.Location = new Point(1392, 210);
            tbteacherid.Name = "tbteacherid";
            tbteacherid.Size = new Size(250, 47);
            tbteacherid.TabIndex = 14;
            // 
            // tbstudentname
            // 
            tbstudentname.Location = new Point(955, 219);
            tbstudentname.Name = "tbstudentname";
            tbstudentname.Size = new Size(250, 47);
            tbstudentname.TabIndex = 15;
            // 
            // tbstudentid
            // 
            tbstudentid.Location = new Point(955, 97);
            tbstudentid.Name = "tbstudentid";
            tbstudentid.Size = new Size(250, 47);
            tbstudentid.TabIndex = 16;
            // 
            // tbsattusinday
            // 
            tbsattusinday.Location = new Point(489, 199);
            tbsattusinday.Name = "tbsattusinday";
            tbsattusinday.Size = new Size(250, 47);
            tbsattusinday.TabIndex = 17;
            // 
            // tbattendance
            // 
            tbattendance.Location = new Point(489, 325);
            tbattendance.Name = "tbattendance";
            tbattendance.Size = new Size(250, 47);
            tbattendance.TabIndex = 18;
            // 
            // tbclassid
            // 
            tbclassid.Location = new Point(955, 325);
            tbclassid.Name = "tbclassid";
            tbclassid.Size = new Size(250, 47);
            tbclassid.TabIndex = 19;
            // 
            // tbtachername
            // 
            tbtachername.Location = new Point(1414, 328);
            tbtachername.Name = "tbtachername";
            tbtachername.Size = new Size(250, 47);
            tbtachername.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 100);
            label2.Name = "label2";
            label2.Size = new Size(203, 41);
            label2.TabIndex = 21;
            label2.Text = "attendance_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 197);
            label3.Name = "label3";
            label3.Size = new Size(170, 41);
            label3.TabIndex = 22;
            label3.Text = "Statusinday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 325);
            label4.Name = "label4";
            label4.Size = new Size(166, 41);
            label4.TabIndex = 23;
            label4.Text = "attendance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(771, 103);
            label5.Name = "label5";
            label5.Size = new Size(158, 41);
            label5.TabIndex = 24;
            label5.Text = "Student_id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(744, 222);
            label6.Name = "label6";
            label6.Size = new Size(205, 41);
            label6.TabIndex = 25;
            label6.Text = "student_name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(802, 328);
            label7.Name = "label7";
            label7.Size = new Size(117, 41);
            label7.TabIndex = 26;
            label7.Text = "class_id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1220, 100);
            label8.Name = "label8";
            label8.Size = new Size(154, 41);
            label8.TabIndex = 27;
            label8.Text = "classname";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1220, 225);
            label9.Name = "label9";
            label9.Size = new Size(149, 41);
            label9.TabIndex = 28;
            label9.Text = "teacher id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1211, 331);
            label10.Name = "label10";
            label10.Size = new Size(202, 41);
            label10.TabIndex = 29;
            label10.Text = "teacher_name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1681, 103);
            label11.Name = "label11";
            label11.Size = new Size(150, 41);
            label11.TabIndex = 30;
            label11.Text = "subject_id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1664, 232);
            label12.Name = "label12";
            label12.Size = new Size(187, 41);
            label12.TabIndex = 31;
            label12.Text = "subjectname";
            // 
            // tableadmin
            // 
            tableadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableadmin.Columns.AddRange(new DataGridViewColumn[] { attendanceid, statusinday, attendance1, studentid, studentname, classid, classname, teacherid, teachername, subjectid, subjectname });
            tableadmin.Location = new Point(12, 483);
            tableadmin.Name = "tableadmin";
            tableadmin.RowHeadersWidth = 102;
            tableadmin.Size = new Size(2162, 307);
            tableadmin.TabIndex = 32;
            tableadmin.CellClick += dataviewadmin;
            // 
            // attendanceid
            // 
            attendanceid.DataPropertyName = "attendance_id";
            attendanceid.HeaderText = "attendance_id";
            attendanceid.MinimumWidth = 12;
            attendanceid.Name = "attendanceid";
            attendanceid.Width = 250;
            // 
            // statusinday
            // 
            statusinday.DataPropertyName = "status_inday";
            statusinday.HeaderText = "status_inday";
            statusinday.MinimumWidth = 12;
            statusinday.Name = "statusinday";
            statusinday.Width = 250;
            // 
            // attendance1
            // 
            attendance1.DataPropertyName = "attendance";
            attendance1.HeaderText = "attendance";
            attendance1.MinimumWidth = 12;
            attendance1.Name = "attendance1";
            attendance1.Width = 250;
            // 
            // studentid
            // 
            studentid.DataPropertyName = "student_id";
            studentid.HeaderText = "student_id";
            studentid.MinimumWidth = 12;
            studentid.Name = "studentid";
            studentid.Width = 250;
            // 
            // studentname
            // 
            studentname.DataPropertyName = "student_name";
            studentname.HeaderText = "student_name";
            studentname.MinimumWidth = 12;
            studentname.Name = "studentname";
            studentname.Width = 250;
            // 
            // classid
            // 
            classid.DataPropertyName = "class_id";
            classid.HeaderText = "class_id";
            classid.MinimumWidth = 12;
            classid.Name = "classid";
            classid.Width = 250;
            // 
            // classname
            // 
            classname.DataPropertyName = "class_name";
            classname.HeaderText = "class_name";
            classname.MinimumWidth = 12;
            classname.Name = "classname";
            classname.Width = 250;
            // 
            // teacherid
            // 
            teacherid.DataPropertyName = "teacher_id";
            teacherid.HeaderText = "teacher_id ";
            teacherid.MinimumWidth = 12;
            teacherid.Name = "teacherid";
            teacherid.Width = 250;
            // 
            // teachername
            // 
            teachername.DataPropertyName = "teacher_name";
            teachername.HeaderText = "teacher_name";
            teachername.MinimumWidth = 12;
            teachername.Name = "teachername";
            teachername.Width = 250;
            // 
            // subjectid
            // 
            subjectid.DataPropertyName = "subject_id";
            subjectid.HeaderText = "subject_id";
            subjectid.MinimumWidth = 12;
            subjectid.Name = "subjectid";
            subjectid.Width = 250;
            // 
            // subjectname
            // 
            subjectname.DataPropertyName = "subject_name";
            subjectname.HeaderText = "subject_name";
            subjectname.MinimumWidth = 12;
            subjectname.Name = "subjectname";
            subjectname.Width = 250;
            // 
            // btadd
            // 
            btadd.Location = new Point(1714, 319);
            btadd.Name = "btadd";
            btadd.Size = new Size(188, 58);
            btadd.TabIndex = 33;
            btadd.Text = "add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // lberror
            // 
            lberror.AutoSize = true;
            lberror.Location = new Point(946, 29);
            lberror.Name = "lberror";
            lberror.Size = new Size(0, 41);
            lberror.TabIndex = 34;
            // 
            // btedit
            // 
            btedit.Location = new Point(1714, 400);
            btedit.Name = "btedit";
            btedit.Size = new Size(188, 58);
            btedit.TabIndex = 35;
            btedit.Text = "edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btreport
            // 
            btreport.Location = new Point(1915, 403);
            btreport.Name = "btreport";
            btreport.Size = new Size(188, 58);
            btreport.TabIndex = 36;
            btreport.Text = "report";
            btreport.UseVisualStyleBackColor = true;
            btreport.Click += btreport_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2161, 802);
            Controls.Add(btreport);
            Controls.Add(btedit);
            Controls.Add(lberror);
            Controls.Add(btadd);
            Controls.Add(tableadmin);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbtachername);
            Controls.Add(tbclassid);
            Controls.Add(tbattendance);
            Controls.Add(tbsattusinday);
            Controls.Add(tbstudentid);
            Controls.Add(tbstudentname);
            Controls.Add(tbteacherid);
            Controls.Add(tbclassname);
            Controls.Add(tbsubjectid);
            Controls.Add(tbsubjectname);
            Controls.Add(tbattendanceid);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btclass);
            Controls.Add(btcreateteacher);
            Controls.Add(lbluser);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)tableadmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluser;
        private Button btcreateteacher;
        private Button btclass;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button1;
  
        private DataGridViewTextBoxColumn attendance_id;
        private DataGridViewTextBoxColumn status_inday;
        private DataGridViewTextBoxColumn attendance;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn class_id;
        private DataGridViewTextBoxColumn class_name;
        private DataGridViewTextBoxColumn teacher_id;
        private DataGridViewTextBoxColumn teacher_name;
        private DataGridViewTextBoxColumn subject_id;
        private DataGridViewTextBoxColumn subject_name;
        private TextBox tbattendanceid;
        private TextBox tbsubjectname;
        private TextBox tbsubjectid;
        private TextBox tbclassname;
        private TextBox tbteacherid;
        private TextBox tbstudentname;
        private TextBox tbstudentid;
        private TextBox tbsattusinday;
        private TextBox tbattendance;
        private TextBox tbclassid;
        private TextBox tbtachername;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView tableadmin;
        private DataGridViewTextBoxColumn attendanceid;
        private DataGridViewTextBoxColumn statusinday;
        private DataGridViewTextBoxColumn attendance1;
        private DataGridViewTextBoxColumn studentid;
        private DataGridViewTextBoxColumn studentname;
        private DataGridViewTextBoxColumn classid;
        private DataGridViewTextBoxColumn classname;
        private DataGridViewTextBoxColumn teacherid;
        private DataGridViewTextBoxColumn teachername;
        private DataGridViewTextBoxColumn subjectid;
        private DataGridViewTextBoxColumn subjectname;
        private Button btadd;
        private Label lberror;
        private Button btedit;
        private Button btreport;
    }
}