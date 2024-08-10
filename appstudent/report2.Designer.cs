namespace appstudent
{
    partial class report2
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
            tablestudentreport = new DataGridView();
            studentID = new DataGridViewTextBoxColumn();
            studentname = new DataGridViewTextBoxColumn();
            classid = new DataGridViewTextBoxColumn();
            classname = new DataGridViewTextBoxColumn();
            TotalSessions = new DataGridViewTextBoxColumn();
            PresentCount = new DataGridViewTextBoxColumn();
            AbsentCount = new DataGridViewTextBoxColumn();
            AttendanceRate = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button2 = new Button();
            btexitaa = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tablestudentreport).BeginInit();
            SuspendLayout();
            // 
            // tablestudentreport
            // 
            tablestudentreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablestudentreport.Columns.AddRange(new DataGridViewColumn[] { studentID, studentname, classid, classname, TotalSessions, PresentCount, AbsentCount, AttendanceRate });
            tablestudentreport.Location = new Point(2, 295);
            tablestudentreport.Name = "tablestudentreport";
            tablestudentreport.RowHeadersWidth = 102;
            tablestudentreport.Size = new Size(2131, 559);
            tablestudentreport.TabIndex = 0;
            // 
            // studentID
            // 
            studentID.DataPropertyName = "student_id";
            studentID.HeaderText = "studentID";
            studentID.MinimumWidth = 12;
            studentID.Name = "studentID";
            studentID.Width = 250;
            // 
            // studentname
            // 
            studentname.DataPropertyName = "student_name";
            studentname.HeaderText = "studentname";
            studentname.MinimumWidth = 12;
            studentname.Name = "studentname";
            studentname.Width = 250;
            // 
            // classid
            // 
            classid.DataPropertyName = "class_id";
            classid.HeaderText = "classid";
            classid.MinimumWidth = 12;
            classid.Name = "classid";
            classid.Width = 250;
            // 
            // classname
            // 
            classname.DataPropertyName = "class_name";
            classname.HeaderText = "classname";
            classname.MinimumWidth = 12;
            classname.Name = "classname";
            classname.Width = 250;
            // 
            // TotalSessions
            // 
            TotalSessions.DataPropertyName = "TotalSessions";
            TotalSessions.HeaderText = "TotalSessions";
            TotalSessions.MinimumWidth = 12;
            TotalSessions.Name = "TotalSessions";
            TotalSessions.Width = 250;
            // 
            // PresentCount
            // 
            PresentCount.DataPropertyName = "PresentCount";
            PresentCount.HeaderText = "PresentCount";
            PresentCount.MinimumWidth = 12;
            PresentCount.Name = "PresentCount";
            PresentCount.Width = 250;
            // 
            // AbsentCount
            // 
            AbsentCount.DataPropertyName = "AbsentCount";
            AbsentCount.HeaderText = "AbsentCount";
            AbsentCount.MinimumWidth = 12;
            AbsentCount.Name = "AbsentCount";
            AbsentCount.Width = 250;
            // 
            // AttendanceRate
            // 
            AttendanceRate.DataPropertyName = "AttendanceRate";
            AttendanceRate.HeaderText = "AttendanceRate";
            AttendanceRate.MinimumWidth = 12;
            AttendanceRate.Name = "AttendanceRate";
            AttendanceRate.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(879, 103);
            label1.Name = "label1";
            label1.Size = new Size(365, 41);
            label1.TabIndex = 1;
            label1.Text = "student attendance report";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1795, 162);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 3;
            button2.Text = "reportclass";
            button2.UseVisualStyleBackColor = true;
            // 
            // btexitaa
            // 
            btexitaa.Location = new Point(1799, 52);
            btexitaa.Name = "btexitaa";
            btexitaa.Size = new Size(188, 58);
            btexitaa.TabIndex = 4;
            btexitaa.Text = "exit";
            btexitaa.UseVisualStyleBackColor = true;
            btexitaa.Click += btexitaa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1605, 52);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 5;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // report2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2145, 866);
            Controls.Add(button1);
            Controls.Add(btexitaa);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(tablestudentreport);
            Name = "report2";
            Text = "report2";
            Load += report2_Load;
            ((System.ComponentModel.ISupportInitialize)tablestudentreport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablestudentreport;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn studentID;
        private DataGridViewTextBoxColumn studentname;
        private DataGridViewTextBoxColumn classid;
        private DataGridViewTextBoxColumn classname;
        private DataGridViewTextBoxColumn TotalSessions;
        private DataGridViewTextBoxColumn PresentCount;
        private DataGridViewTextBoxColumn AbsentCount;
        private DataGridViewTextBoxColumn AttendanceRate;
        private Button btexitaa;
        private Button button1;
    }
}