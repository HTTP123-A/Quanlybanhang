
namespace Quanlybanhang
{
    partial class Login_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.User_Label = new System.Windows.Forms.Label();
            this.LogIn_Butt = new System.Windows.Forms.Button();
            this.Close_Butt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.txt_User);
            this.groupBox1.Controls.Add(this.Pass_Label);
            this.groupBox1.Controls.Add(this.User_Label);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Log In";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(94, 59);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(288, 26);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(94, 29);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(288, 26);
            this.txt_User.TabIndex = 2;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Location = new System.Drawing.Point(6, 59);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(77, 19);
            this.Pass_Label.TabIndex = 1;
            this.Pass_Label.Text = "Password:";
            this.Pass_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Location = new System.Drawing.Point(6, 31);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(82, 19);
            this.User_Label.TabIndex = 0;
            this.User_Label.Text = "Username:";
            this.User_Label.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // LogIn_Butt
            // 
            this.LogIn_Butt.Location = new System.Drawing.Point(12, 101);
            this.LogIn_Butt.Name = "LogIn_Butt";
            this.LogIn_Butt.Size = new System.Drawing.Size(150, 50);
            this.LogIn_Butt.TabIndex = 1;
            this.LogIn_Butt.Text = "Log In";
            this.LogIn_Butt.UseVisualStyleBackColor = true;
            this.LogIn_Butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_Butt
            // 
            this.Close_Butt.Location = new System.Drawing.Point(220, 101);
            this.Close_Butt.Name = "Close_Butt";
            this.Close_Butt.Size = new System.Drawing.Size(150, 50);
            this.Close_Butt.TabIndex = 2;
            this.Close_Butt.Text = "Close";
            this.Close_Butt.UseVisualStyleBackColor = true;
            this.Close_Butt.Click += new System.EventHandler(this.Close_Butt_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 159);
            this.Controls.Add(this.Close_Butt);
            this.Controls.Add(this.LogIn_Butt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Login_Form";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Button LogIn_Butt;
        private System.Windows.Forms.Button Close_Butt;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
    }
}