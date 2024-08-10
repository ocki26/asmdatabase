namespace appstudent
{
    partial class createsubject
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
            teablesubject = new DataGridView();
            subject_id = new DataGridViewTextBoxColumn();
            subject_name = new DataGridViewTextBoxColumn();
            credit = new DataGridViewTextBoxColumn();
            btadd = new Button();
            btdelete = new Button();
            btedit = new Button();
            btcancel = new Button();
            subjectid = new Label();
            lab = new Label();
            label3 = new Label();
            tbsubjectid = new TextBox();
            tbsubjectcredit = new TextBox();
            tbsubjectname = new TextBox();
            lblerror = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)teablesubject).BeginInit();
            SuspendLayout();
            // 
            // teablesubject
            // 
            teablesubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teablesubject.Columns.AddRange(new DataGridViewColumn[] { subject_id, subject_name, credit });
            teablesubject.Location = new Point(74, 485);
            teablesubject.Name = "teablesubject";
            teablesubject.RowHeadersWidth = 102;
            teablesubject.Size = new Size(1940, 375);
            teablesubject.TabIndex = 0;
            teablesubject.CellClick += teablesubject_CellClick;
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
            // credit
            // 
            credit.DataPropertyName = "credit";
            credit.HeaderText = "credit";
            credit.MinimumWidth = 12;
            credit.Name = "credit";
            credit.Width = 250;
            // 
            // btadd
            // 
            btadd.Location = new Point(359, 370);
            btadd.Name = "btadd";
            btadd.Size = new Size(188, 58);
            btadd.TabIndex = 1;
            btadd.Text = "add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(950, 370);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(188, 58);
            btdelete.TabIndex = 2;
            btdelete.Text = "delete";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(662, 370);
            btedit.Name = "btedit";
            btedit.Size = new Size(188, 58);
            btedit.TabIndex = 3;
            btedit.Text = "edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btcancel
            // 
            btcancel.Location = new Point(1200, 370);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(188, 58);
            btcancel.TabIndex = 4;
            btcancel.Text = "cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // subjectid
            // 
            subjectid.AutoSize = true;
            subjectid.Location = new Point(183, 38);
            subjectid.Name = "subjectid";
            subjectid.Size = new Size(138, 41);
            subjectid.TabIndex = 5;
            subjectid.Text = "subjectid";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(183, 134);
            lab.Name = "lab";
            lab.Size = new Size(187, 41);
            lab.TabIndex = 6;
            lab.Text = "subjectname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 239);
            label3.Name = "label3";
            label3.Size = new Size(196, 41);
            label3.TabIndex = 7;
            label3.Text = "subject credit";
            // 
            // tbsubjectid
            // 
            tbsubjectid.Location = new Point(502, 32);
            tbsubjectid.Name = "tbsubjectid";
            tbsubjectid.Size = new Size(690, 47);
            tbsubjectid.TabIndex = 8;
            // 
            // tbsubjectcredit
            // 
            tbsubjectcredit.Location = new Point(489, 233);
            tbsubjectcredit.Name = "tbsubjectcredit";
            tbsubjectcredit.Size = new Size(703, 47);
            tbsubjectcredit.TabIndex = 9;
            // 
            // tbsubjectname
            // 
            tbsubjectname.Location = new Point(502, 128);
            tbsubjectname.Name = "tbsubjectname";
            tbsubjectname.Size = new Size(690, 47);
            tbsubjectname.TabIndex = 10;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(1447, 215);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 41);
            lblerror.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(1468, 370);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 12;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // createsubject
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2135, 890);
            Controls.Add(button1);
            Controls.Add(lblerror);
            Controls.Add(tbsubjectname);
            Controls.Add(tbsubjectcredit);
            Controls.Add(tbsubjectid);
            Controls.Add(label3);
            Controls.Add(lab);
            Controls.Add(subjectid);
            Controls.Add(btcancel);
            Controls.Add(btedit);
            Controls.Add(btdelete);
            Controls.Add(btadd);
            Controls.Add(teablesubject);
            Name = "createsubject";
            Text = "createsubject";
            Load += createsubject_Load;
            ((System.ComponentModel.ISupportInitialize)teablesubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView teablesubject;
        private Button btadd;
        private Button btdelete;
        private Button btedit;
        private Button btcancel;
        private Label subjectid;
        private Label lab;
        private Label label3;
        private TextBox tbsubjectid;
        private TextBox tbsubjectcredit;
        private TextBox tbsubjectname;
        private DataGridViewTextBoxColumn subject_id;
        private DataGridViewTextBoxColumn subject_name;
        private DataGridViewTextBoxColumn credit;
        private Label lblerror;
        private Button button1;
    }
}