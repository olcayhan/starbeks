namespace VisualProgrammingProject
{
    partial class ClientPage
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
            this.orderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.oldOrdersBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activeOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.orderBtn.Location = new System.Drawing.Point(18, 484);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(407, 65);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "Let\'s Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(48, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome to Starbeks,";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.NameLbl.Location = new System.Drawing.Point(292, 258);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(75, 27);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name";
            // 
            // oldOrdersBtn
            // 
            this.oldOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.oldOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oldOrdersBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oldOrdersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.oldOrdersBtn.Location = new System.Drawing.Point(18, 396);
            this.oldOrdersBtn.Name = "oldOrdersBtn";
            this.oldOrdersBtn.Size = new System.Drawing.Size(407, 65);
            this.oldOrdersBtn.TabIndex = 9;
            this.oldOrdersBtn.Text = "Old Orders";
            this.oldOrdersBtn.UseVisualStyleBackColor = false;
            this.oldOrdersBtn.Click += new System.EventHandler(this.oldOrdersBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualProgrammingProject.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // activeOrderBtn
            // 
            this.activeOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.activeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activeOrderBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.activeOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.activeOrderBtn.Location = new System.Drawing.Point(18, 314);
            this.activeOrderBtn.Name = "activeOrderBtn";
            this.activeOrderBtn.Size = new System.Drawing.Size(407, 65);
            this.activeOrderBtn.TabIndex = 11;
            this.activeOrderBtn.Text = "Active Order";
            this.activeOrderBtn.UseVisualStyleBackColor = false;
            this.activeOrderBtn.Click += new System.EventHandler(this.activeOrderBtn_Click);
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(440, 561);
            this.Controls.Add(this.activeOrderBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oldOrdersBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderBtn);
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button oldOrdersBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button activeOrderBtn;
    }
}