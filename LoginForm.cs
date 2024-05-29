using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ScanConnect
{
    public partial class LoginForm : Form
    {
        private Dashboard dashboard = new Dashboard();
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passTxt.Text.Trim();
            if (string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("Please Fill All the fields");
            } else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();
                    string qry = "SELECT * FROM login_tb WHERE UserName= @username AND Password= @pass";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        dashboard.Show();
                    } else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        private void eye_CheckedChanged(object sender, EventArgs e)
        {
            if (eye.Checked)
            {
                passTxt.PasswordChar = '\0';
            }
            else
            {
                passTxt.PasswordChar = '*';
            }
        }
    }
}
