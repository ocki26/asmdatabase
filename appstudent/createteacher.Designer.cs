namespace appstudent
{
    partial class createteacher
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
            tableteacher = new DataGridView();
            teacher_id = new DataGridViewTextBoxColumn();
            teacher_name = new DataGridViewTextBoxColumn();
            teacher_email = new DataGridViewTextBoxColumn();
            tbteacherid = new TextBox();
            tbteacheremail = new TextBox();
            tbteachername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btadd = new Button();
            btedit = new Button();
            btdelete = new Button();
            btcancel = new Button();
            lblerror = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tableteacher).BeginInit();
            SuspendLayout();
            // 
            // tableteacher
            // 
            tableteacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableteacher.Columns.AddRange(new DataGridViewColumn[] { teacher_id, teacher_name, teacher_email });
            tableteacher.Location = new Point(205, 415);
            tableteacher.Name = "tableteacher";
            tableteacher.RowHeadersWidth = 102;
            tableteacher.Size = new Size(1550, 375);
            tableteacher.TabIndex = 0;
            tableteacher.CellClick += tableteacher_CellClick;
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
            // teacher_email
            // 
            teacher_email.DataPropertyName = "teacher_email";
            teacher_email.HeaderText = "teacher_email";
            teacher_email.MinimumWidth = 12;
            teacher_email.Name = "teacher_email";
            teacher_email.Width = 250;
            // 
            // tbteacherid
            // 
            tbteacherid.Location = new Point(487, 62);
            tbteacherid.Name = "tbteacherid";
            tbteacherid.Size = new Size(477, 47);
            tbteacherid.TabIndex = 1;
            // 
            // tbteacheremail
            // 
            tbteacheremail.Location = new Point(487, 291);
            tbteacheremail.Name = "tbteacheremail";
            tbteacheremail.Size = new Size(477, 47);
            tbteacheremail.TabIndex = 2;
            // 
            // tbteachername
            // 
            tbteachername.Location = new Point(487, 181);
            tbteachername.Name = "tbteachername";
            tbteachername.Size = new Size(477, 47);
            tbteachername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 62);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 4;
            label1.Text = "teacherid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 184);
            label2.Name = "label2";
            label2.Size = new Size(190, 41);
            label2.TabIndex = 5;
            label2.Text = "teachername";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 297);
            label3.Name = "label3";
            label3.Size = new Size(195, 41);
            label3.TabIndex = 6;
            label3.Text = "teacher email";
            // 
            // btadd
            // 
            btadd.Location = new Point(1039, 62);
            btadd.Name = "btadd";
            btadd.Size = new Size(188, 58);
            btadd.TabIndex = 7;
            btadd.Text = "add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(1039, 175);
            btedit.Name = "btedit";
            btedit.Size = new Size(188, 58);
            btedit.TabIndex = 8;
            btedit.Text = "edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(1039, 285);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(188, 58);
            btdelete.TabIndex = 9;
            btdelete.Text = "delete";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // btcancel
            // 
            btcancel.Location = new Point(1310, 280);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(188, 58);
            btcancel.TabIndex = 10;
            btcancel.Text = "cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(1178, 168);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 41);
            lblerror.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(1300, 181);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 12;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // createteacher
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2154, 848);
            Controls.Add(button1);
            Controls.Add(lblerror);
            Controls.Add(btcancel);
            Controls.Add(btdelete);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbteachername);
            Controls.Add(tbteacheremail);
            Controls.Add(tbteacherid);
            Controls.Add(tableteacher);
            Name = "createteacher";
            Text = "createteacher";
            Load += createteacher_Load;
            ((System.ComponentModel.ISupportInitialize)tableteacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableteacher;
        private TextBox tbteacherid;
        private TextBox tbteacheremail;
        private TextBox tbteachername;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn teacher_id;
        private DataGridViewTextBoxColumn teacher_name;
        private DataGridViewTextBoxColumn teacher_email;
        private Button btadd;
        private Button btedit;
        private Button btdelete;
        private Button btcancel;
        private Label lblerror;
        private Button button1;
    }
}