namespace Restaurant_Project
{
    partial class Login
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
            groupBox1 = new GroupBox();
            lnk_register = new LinkLabel();
            btn_login = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lnk_register);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(30, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // lnk_register
            // 
            lnk_register.AutoSize = true;
            lnk_register.Location = new Point(26, 214);
            lnk_register.Name = "lnk_register";
            lnk_register.Size = new Size(95, 25);
            lnk_register.TabIndex = 5;
            lnk_register.TabStop = true;
            lnk_register.Text = "Register";
            lnk_register.LinkClicked += lnk_register_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Location = new Point(193, 161);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(213, 44);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(178, 97);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(268, 32);
            txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(178, 45);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(268, 32);
            txt_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 332);
            Controls.Add(groupBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel lnk_register;
        private Button btn_login;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
    }
}
