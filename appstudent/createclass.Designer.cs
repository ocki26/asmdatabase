namespace appstudent
{
    partial class createclass
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
            tablecreateclass = new DataGridView();
            class_id = new DataGridViewTextBoxColumn();
            class_name = new DataGridViewTextBoxColumn();
            class_dateoftime = new DataGridViewTextBoxColumn();
            tbclassid = new TextBox();
            tbclassdatetime = new TextBox();
            tbclassname = new TextBox();
            btadd = new Button();
            btdelete = new Button();
            btcancel = new Button();
            btedit = new Button();
            classid = new Label();
            label1 = new Label();
            label2 = new Label();
            lblerror = new Label();
            lbleror = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tablecreateclass).BeginInit();
            SuspendLayout();
            // 
            // tablecreateclass
            // 
            tablecreateclass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablecreateclass.Columns.AddRange(new DataGridViewColumn[] { class_id, class_name, class_dateoftime });
            tablecreateclass.Location = new Point(259, 388);
            tablecreateclass.Name = "tablecreateclass";
            tablecreateclass.RowHeadersWidth = 102;
            tablecreateclass.Size = new Size(1786, 375);
            tablecreateclass.TabIndex = 0;
            tablecreateclass.CellClick += tablecreateclass_CellClick;
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
            // class_dateoftime
            // 
            class_dateoftime.DataPropertyName = "class_dateoftime";
            class_dateoftime.HeaderText = "class_dateoftime";
            class_dateoftime.MinimumWidth = 12;
            class_dateoftime.Name = "class_dateoftime";
            class_dateoftime.Width = 400;
            // 
            // tbclassid
            // 
            tbclassid.Location = new Point(453, 41);
            tbclassid.Name = "tbclassid";
            tbclassid.Size = new Size(369, 47);
            tbclassid.TabIndex = 1;
            // 
            // tbclassdatetime
            // 
            tbclassdatetime.Location = new Point(453, 293);
            tbclassdatetime.Name = "tbclassdatetime";
            tbclassdatetime.Size = new Size(369, 47);
            tbclassdatetime.TabIndex = 3;
            // 
            // tbclassname
            // 
            tbclassname.Location = new Point(453, 179);
            tbclassname.Name = "tbclassname";
            tbclassname.Size = new Size(369, 47);
            tbclassname.TabIndex = 4;
            // 
            // btadd
            // 
            btadd.Location = new Point(914, 321);
            btadd.Name = "btadd";
            btadd.Size = new Size(188, 58);
            btadd.TabIndex = 5;
            btadd.Text = "add";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(1108, 321);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(188, 58);
            btdelete.TabIndex = 6;
            btdelete.Text = "delete";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // btcancel
            // 
            btcancel.Location = new Point(1496, 321);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(188, 58);
            btcancel.TabIndex = 7;
            btcancel.Text = "cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // btedit
            // 
            btedit.Location = new Point(1302, 321);
            btedit.Name = "btedit";
            btedit.Size = new Size(188, 58);
            btedit.TabIndex = 8;
            btedit.Text = "edit";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // classid
            // 
            classid.AutoSize = true;
            classid.Location = new Point(110, 72);
            classid.Name = "classid";
            classid.Size = new Size(113, 41);
            classid.TabIndex = 9;
            classid.Text = "class id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 179);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 10;
            label1.Text = "class name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 293);
            label2.Name = "label2";
            label2.Size = new Size(257, 41);
            label2.TabIndex = 11;
            label2.Text = "class date of time ";
            label2.Click += label2_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(1000, 44);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 41);
            lblerror.TabIndex = 12;
            // 
            // lbleror
            // 
            lbleror.AutoSize = true;
            lbleror.Location = new Point(1051, 54);
            lbleror.Name = "lbleror";
            lbleror.Size = new Size(0, 41);
            lbleror.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(1302, 257);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 14;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // createclass
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2129, 802);
            Controls.Add(button1);
            Controls.Add(lbleror);
            Controls.Add(lblerror);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(classid);
            Controls.Add(btedit);
            Controls.Add(btcancel);
            Controls.Add(btdelete);
            Controls.Add(btadd);
            Controls.Add(tbclassname);
            Controls.Add(tbclassdatetime);
            Controls.Add(tbclassid);
            Controls.Add(tablecreateclass);
            Name = "createclass";
            Text = "createclass";
            Load += createclass_Load;
            ((System.ComponentModel.ISupportInitialize)tablecreateclass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablecreateclass;
        private TextBox tbclassid;
        private TextBox tbclassdatetime;
        private TextBox tbclassname;
        private Button btadd;
        private Button btdelete;
        private Button btcancel;
        private Button btedit;
        private Label classid;
        private Label label1;
        private Label label2;
        private Label lblerror;
        private DataGridViewTextBoxColumn class_id;
        private DataGridViewTextBoxColumn class_name;
        private DataGridViewTextBoxColumn class_dateoftime;
        private Label lbleror;
        private Button button1;
    }
}