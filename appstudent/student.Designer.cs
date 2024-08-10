namespace appstudent
{
    partial class student
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
            tablestudent = new DataGridView();
            student_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            registration_date = new DataGridViewTextBoxColumn();
            date_of_birth = new DataGridViewTextBoxColumn();
            addres = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            lblstudent = new Label();
            button1 = new Button();
            btreport = new Button();
            ((System.ComponentModel.ISupportInitialize)tablestudent).BeginInit();
            SuspendLayout();
            // 
            // tablestudent
            // 
            tablestudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablestudent.Columns.AddRange(new DataGridViewColumn[] { student_id, student_name, registration_date, date_of_birth, addres, email, age, gender });
            tablestudent.Location = new Point(107, 234);
            tablestudent.Name = "tablestudent";
            tablestudent.RowHeadersWidth = 102;
            tablestudent.Size = new Size(1999, 561);
            tablestudent.TabIndex = 0;
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
            date_of_birth.HeaderText = "date_of_birth";
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
            // lblstudent
            // 
            lblstudent.AutoSize = true;
            lblstudent.Location = new Point(104, 57);
            lblstudent.Name = "lblstudent";
            lblstudent.Size = new Size(0, 41);
            lblstudent.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1822, 99);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 2;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btreport
            // 
            btreport.Location = new Point(1592, 99);
            btreport.Name = "btreport";
            btreport.Size = new Size(188, 58);
            btreport.TabIndex = 3;
            btreport.Text = "report";
            btreport.UseVisualStyleBackColor = true;
            btreport.Click += btreport_Click;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2134, 833);
            Controls.Add(btreport);
            Controls.Add(button1);
            Controls.Add(lblstudent);
            Controls.Add(tablestudent);
            Name = "student";
            Text = "student";
            Load += student_Load;
            ((System.ComponentModel.ISupportInitialize)tablestudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablestudent;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn registration_date;
        private DataGridViewTextBoxColumn date_of_birth;
        private DataGridViewTextBoxColumn addres;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn gender;
        private Label lblstudent;
        private Button button1;
        private Button btreport;
    }
}