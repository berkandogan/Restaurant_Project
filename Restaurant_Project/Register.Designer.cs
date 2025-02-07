namespace Restaurant_Project
{
    partial class Register
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
            groupBox1 = new GroupBox();
            txt_password = new TextBox();
            label5 = new Label();
            txt_surname = new TextBox();
            label4 = new Label();
            txt_name = new TextBox();
            label3 = new Label();
            lnk_login = new LinkLabel();
            btn_register = new Button();
            txt_repassword = new TextBox();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lnk_login);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(txt_repassword);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(30, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 472);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(182, 239);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(268, 32);
            txt_password.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 242);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(181, 121);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(268, 32);
            txt_surname.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 124);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 8;
            label4.Text = "Surname";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(181, 58);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(268, 32);
            txt_name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 61);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // lnk_login
            // 
            lnk_login.AutoSize = true;
            lnk_login.Location = new Point(30, 412);
            lnk_login.Name = "lnk_login";
            lnk_login.Size = new Size(66, 25);
            lnk_login.TabIndex = 5;
            lnk_login.TabStop = true;
            lnk_login.Text = "Login";
            lnk_login.LinkClicked += lnk_login_LinkClicked;
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.GradientActiveCaption;
            btn_register.Location = new Point(197, 359);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(213, 44);
            btn_register.TabIndex = 4;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // txt_repassword
            // 
            txt_repassword.Location = new Point(182, 295);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.Size = new Size(268, 32);
            txt_repassword.TabIndex = 3;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(181, 184);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(268, 32);
            txt_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 298);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Repassword";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 187);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 529);
            Controls.Add(groupBox1);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_password;
        private Label label5;
        private TextBox txt_surname;
        private Label label4;
        private TextBox txt_name;
        private Label label3;
        private LinkLabel lnk_login;
        private Button btn_register;
        private TextBox txt_repassword;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
    }
}