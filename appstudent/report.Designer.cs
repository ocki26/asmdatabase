namespace appstudent
{
    partial class report
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
            tablereportclass = new DataGridView();
            classid = new DataGridViewTextBoxColumn();
            classname = new DataGridViewTextBoxColumn();
            TotalSessions = new DataGridViewTextBoxColumn();
            PresentCount = new DataGridViewTextBoxColumn();
            AbsentCount = new DataGridViewTextBoxColumn();
            AttendanceRate = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btexit = new Button();
            btstudentreport = new Button();
            ((System.ComponentModel.ISupportInitialize)tablereportclass).BeginInit();
            SuspendLayout();
            // 
            // tablereportclass
            // 
            tablereportclass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablereportclass.Columns.AddRange(new DataGridViewColumn[] { classid, classname, TotalSessions, PresentCount, AbsentCount, AttendanceRate });
            tablereportclass.Location = new Point(48, 266);
            tablereportclass.Name = "tablereportclass";
            tablereportclass.RowHeadersWidth = 102;
            tablereportclass.Size = new Size(1621, 572);
            tablereportclass.TabIndex = 0;
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
            label1.Location = new Point(1091, 123);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
            label1.TabIndex = 1;
            label1.Text = "class attendance rate";
            // 
            // btexit
            // 
            btexit.Location = new Point(1675, 278);
            btexit.Name = "btexit";
            btexit.Size = new Size(188, 58);
            btexit.TabIndex = 2;
            btexit.Text = "exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // btstudentreport
            // 
            btstudentreport.Location = new Point(1681, 357);
            btstudentreport.Name = "btstudentreport";
            btstudentreport.Size = new Size(188, 58);
            btstudentreport.TabIndex = 3;
            btstudentreport.Text = "student report";
            btstudentreport.UseVisualStyleBackColor = true;
            btstudentreport.Click += btstudentreport_Click;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2121, 850);
            Controls.Add(btstudentreport);
            Controls.Add(btexit);
            Controls.Add(label1);
            Controls.Add(tablereportclass);
            Name = "report";
            Text = "report";
            Load += report_Load;
            ((System.ComponentModel.ISupportInitialize)tablereportclass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablereportclass;
        private Label label1;
        private DataGridViewTextBoxColumn classid;
        private DataGridViewTextBoxColumn classname;
        private DataGridViewTextBoxColumn TotalSessions;
        private DataGridViewTextBoxColumn PresentCount;
        private DataGridViewTextBoxColumn AbsentCount;
        private DataGridViewTextBoxColumn AttendanceRate;
        private Button btexit;
        private Button btstudentreport;
    }
}