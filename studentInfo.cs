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
using System.Text.RegularExpressions;
using System.IO;

namespace ScanConnect
{
    public partial class studentInfo : Form
    {
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        private bool isEditing = false;
        public studentInfo()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Use IdnMapping class to convert Unicode domain names.
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Return true if email is in valid e-mail format.
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            // Use IdnMapping class to convert Unicode domain names.
            var idn = new System.Globalization.IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            return match.Groups[1].Value + domainName;
        }

        private void femaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void maleBtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void nameEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void emailTxt_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void contactEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void contactBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void birthdateEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void courseEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guardianEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                studentPic.Image = Image.FromFile(fd.FileName);
            }
            MemoryStream ms = new MemoryStream();
            studentPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] Photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(Photo, 0, Photo.Length);
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string qry = "UPDATE `registration_tb` SET `Photo`= @img WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@img", Photo);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            cmd.ExecuteNonQuery();
        }

        

        private void enableEditing(bool enable)
        {
            nameBox.ReadOnly = !enable;
            emailBox.ReadOnly = !enable;
            contactBox.ReadOnly = !enable;
            datePick.Enabled = enable;
            courseDrop.Enabled = enable;
            guardianBox.ReadOnly = !enable;
            maleBtn.Enabled = enable;
            femaleBtn.Enabled = enable;
        }

        private void saveChanges()
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            try
            {
                string qry = "UPDATE `registration_tb` SET `Name`=@name, `EmailAddress`=@mail, `ContactNumber`=@contact, `DateOfBirth`=@date, `Class`=@course, `GuardianName`=@guardian, `Gender`=@gender WHERE ID=@id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", nameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@mail", emailBox.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", contactBox.Text.Trim());
                cmd.Parameters.AddWithValue("@date", datePick.Value);
                cmd.Parameters.AddWithValue("@course", courseDrop.Text.Trim());
                cmd.Parameters.AddWithValue("@guardian", guardianBox.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", maleBtn.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Changes Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            enableEditing(isEditing);

            if (!isEditing)
            {
                saveChanges();
            }
        }
    }
}
