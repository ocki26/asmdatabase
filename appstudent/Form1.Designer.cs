namespace appstudent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbusers = new TextBox();
            tbpassword = new TextBox();
            btlogin = new Button();
            btexit = new Button();
            lblerror = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 209);
            label1.Name = "label1";
            label1.Size = new Size(123, 41);
            label1.TabIndex = 0;
            label1.Text = "account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 400);
            label2.Name = "label2";
            label2.Size = new Size(145, 41);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // tbusers
            // 
            tbusers.Location = new Point(600, 305);
            tbusers.Name = "tbusers";
            tbusers.Size = new Size(933, 47);
            tbusers.TabIndex = 2;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(600, 504);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '*';
            tbpassword.Size = new Size(933, 47);
            tbpassword.TabIndex = 3;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(599, 609);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(188, 58);
            btlogin.TabIndex = 4;
            btlogin.Text = "login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // btexit
            // 
            btexit.Location = new Point(1345, 609);
            btexit.Name = "btexit";
            btexit.Size = new Size(188, 58);
            btexit.TabIndex = 5;
            btexit.Text = "exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(1483, 367);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 41);
            lblerror.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2155, 834);
            Controls.Add(lblerror);
            Controls.Add(btexit);
            Controls.Add(btlogin);
            Controls.Add(tbpassword);
            Controls.Add(tbusers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbusers;
        private TextBox tbpassword;
        private Button btlogin;
        private Button btexit;
        private Label lblerror;
    }
}
