using Restaurant_Project.Context;
using Restaurant_Project.Entities;

namespace Restaurant_Project
{
    public partial class Login : Form
    {
        DataContext db = new DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            Admin admin = db.Admins.Where(i => i.Username == username && i.Password == password).FirstOrDefault();

            if (admin != null)
            {
                MessageBox.Show("Login  Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderPanel orderPanel = new OrderPanel();
                orderPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login not Successful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
