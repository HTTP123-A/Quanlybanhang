
namespace Quanlybanhang
{
    partial class FormChangePassword
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
            this.Password_change_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Oldpass_label = new System.Windows.Forms.Label();
            this.Newpass_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nhap_lai_mat_khau = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Password_change_label
            // 
            this.Password_change_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_change_label.AutoSize = true;
            this.Password_change_label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password_change_label.Location = new System.Drawing.Point(27, 9);
            this.Password_change_label.Name = "Password_change_label";
            this.Password_change_label.Size = new System.Drawing.Size(443, 36);
            this.Password_change_label.TabIndex = 0;
            this.Password_change_label.Text = "CHANGE YOUR PASSWORD";
            this.Password_change_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Password_change_label.Click += new System.EventHandler(this.Password_change_label_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Username_label.Location = new System.Drawing.Point(12, 56);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(107, 24);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username:";
            this.Username_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Oldpass_label
            // 
            this.Oldpass_label.AutoSize = true;
            this.Oldpass_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oldpass_label.Location = new System.Drawing.Point(12, 82);
            this.Oldpass_label.Name = "Oldpass_label";
            this.Oldpass_label.Size = new System.Drawing.Size(137, 24);
            this.Oldpass_label.TabIndex = 2;
            this.Oldpass_label.Text = "Old password:";
            // 
            // Newpass_label
            // 
            this.Newpass_label.AutoSize = true;
            this.Newpass_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Newpass_label.Location = new System.Drawing.Point(12, 106);
            this.Newpass_label.Name = "Newpass_label";
            this.Newpass_label.Size = new System.Drawing.Size(145, 24);
            this.Newpass_label.TabIndex = 3;
            this.Newpass_label.Text = "New password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nhap_lai_mat_khau
            // 
            this.Nhap_lai_mat_khau.AutoSize = true;
            this.Nhap_lai_mat_khau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nhap_lai_mat_khau.Location = new System.Drawing.Point(12, 130);
            this.Nhap_lai_mat_khau.Name = "Nhap_lai_mat_khau";
            this.Nhap_lai_mat_khau.Size = new System.Drawing.Size(121, 24);
            this.Nhap_lai_mat_khau.TabIndex = 9;
            this.Nhap_lai_mat_khau.Text = "Enter again:";
            this.Nhap_lai_mat_khau.Click += new System.EventHandler(this.Nhap_lai_mat_khau_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(328, 20);
            this.textBox4.TabIndex = 10;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 231);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Nhap_lai_mat_khau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Newpass_label);
            this.Controls.Add(this.Oldpass_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_change_label);
            this.Name = "FormChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_change_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Oldpass_label;
        private System.Windows.Forms.Label Newpass_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Nhap_lai_mat_khau;
        private System.Windows.Forms.TextBox textBox4;
    }
}