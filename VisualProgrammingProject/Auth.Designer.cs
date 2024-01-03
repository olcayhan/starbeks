namespace VisualProgrammingProject
{
    partial class Auth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.LogBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(83, 64);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(227, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(83, 114);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(227, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(144, 149);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(105, 37);
            this.LogBtn.TabIndex = 4;
            this.LogBtn.Text = "Log In";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(144, 250);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(105, 37);
            this.signupBtn.TabIndex = 6;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "---------------------------------------- You have no any account ----------------" +
    "------------------------";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label label3;
    }
}