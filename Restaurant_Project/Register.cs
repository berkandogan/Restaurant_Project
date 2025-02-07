using Restaurant_Project.Context;
using Restaurant_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class Register : Form
    {
        DataContext db = new DataContext();
        public Register()
        {
            InitializeComponent();
        }

        private void lnk_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if(txt_password == txt_repassword)
            {
                admin.Username = txt_username.Text;
                admin.Password = txt_password.Text;
                admin.Name = txt_name.Text;
                admin.Surname = txt_surname.Text;
                db.Admins.Add(admin);
                db.SaveChanges();
                MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
