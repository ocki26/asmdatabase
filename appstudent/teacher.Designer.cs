namespace appstudent
{
    partial class teacher
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
            btexit = new Button();
            tbtacher = new DataGridView();
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
            btreport = new Button();
            ((System.ComponentModel.ISupportInitialize)tbtacher).BeginInit();
            SuspendLayout();
            // 
            // btexit
            // 
            btexit.Location = new Point(1946, 63);
            btexit.Name = "btexit";
            btexit.Size = new Size(188, 58);
            btexit.TabIndex = 1;
            btexit.Text = "exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // tbtacher
            // 
            tbtacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbtacher.Columns.AddRange(new DataGridViewColumn[] { attendance_id, status_inday, attendance, student_id, student_name, class_id, class_name, teacher_id, teacher_name, subject_id, subject_name });
            tbtacher.Location = new Point(242, 289);
            tbtacher.Name = "tbtacher";
            tbtacher.RowHeadersWidth = 102;
            tbtacher.Size = new Size(1815, 375);
            tbtacher.TabIndex = 2;
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
            // btreport
            // 
            btreport.Location = new Point(1706, 63);
            btreport.Name = "btreport";
            btreport.Size = new Size(188, 58);
            btreport.TabIndex = 3;
            btreport.Text = "report";
            btreport.UseVisualStyleBackColor = true;
            btreport.Click += btreport_Click;
            // 
            // teacher
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2137, 814);
            Controls.Add(btreport);
            Controls.Add(tbtacher);
            Controls.Add(btexit);
            Name = "teacher";
            Text = "teacher";
            Load += teacher_Load;
            ((System.ComponentModel.ISupportInitialize)tbtacher).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btexit;
        private DataGridView tbtacher;
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
        private Button btreport;
    }
}