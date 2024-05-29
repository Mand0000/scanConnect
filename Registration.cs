using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data;
using MySql.Data.MySqlClient;
using QRCoder;
using System.IO;

namespace ScanConnect
{
    public partial class Registration : Form
    {
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        bool isMale = false, isFemale = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                profilePic.Image = Image.FromFile(fd.FileName);
            }
        }

        private void maleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maleBtn.Checked)
            {
                isMale = true;
            } else
            {
                isMale = false;
            }
        }

        private void femaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleBtn.Checked)
            {
                isFemale = true;
            } else
            {
                isFemale = false;
            }
        }

        private void IdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if(char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Text = "";
            nameTxt.Text = "";
            maleBtn.Checked = false;
            femaleBtn.Checked = false;
            datePick.Value = DateTime.Now;
            contactTxt.Text = "";
            emailTxt.Text = "";
            guardianTxt.Text = "";
            classDrop.Text = "";
            profilePic.Image = null;
        }

        private void contactTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            QRPop qrBox = new QRPop();
            string Gender = "";

            if (string.IsNullOrEmpty(IdTxt.Text) || string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(contactTxt.Text) || string.IsNullOrEmpty(emailTxt.Text) || string.IsNullOrEmpty(guardianTxt.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else if (!isMale && !isFemale)
            {
                MessageBox.Show("Please Select A Gender");
            }
            else if (datePick.Value.Year > 2019)
            {
                MessageBox.Show("Please Select A Proper Birth Date");
            }
            else if (contactTxt.Text.Length != 10)
            {
                MessageBox.Show("Contact Number must be 10 digits");
            }
            else if (!IsValidEmail(emailTxt.Text.Trim()))
            {
                MessageBox.Show("Email is invalid");
            }
            else if (string.IsNullOrEmpty(classDrop.Text))
            {
                MessageBox.Show("Please Select A Course");
            }
            else if (profilePic.Image == null)
            {
                MessageBox.Show("Please Upload a Photo");
            }
            else
            {
                if (isMale)
                {
                    Gender = "Male";
                }
                else if (isFemale)
                {
                    Gender = "Female";
                }
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var MyData = QG.CreateQrCode(IdTxt.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(MyData);
                qrBox.qrPic.Image = code.GetGraphic(100);
                MemoryStream ms = new MemoryStream();
                profilePic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();
                string qry = "INSERT INTO `registration_tb`(`ID`, `Name`, `GuardianName`, `EmailAddress`, `DateOfBirth`, `Class`, `ContactNumber`, `Gender`, `Photo`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                MySqlCommand cmd = new MySqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("param1", IdTxt.Text.Trim());
                cmd.Parameters.AddWithValue("param2", nameTxt.Text.Trim());
                cmd.Parameters.AddWithValue("param3", guardianTxt.Text.Trim());
                cmd.Parameters.AddWithValue("param4", emailTxt.Text.Trim());
                cmd.Parameters.AddWithValue("param5", datePick.Text.Trim());
                cmd.Parameters.AddWithValue("param6", classDrop.Text.Trim());
                cmd.Parameters.AddWithValue("param7", contactTxt.Text.Trim());
                cmd.Parameters.AddWithValue("param8", Gender);
                cmd.Parameters.AddWithValue("param9", Photo);
                cmd.ExecuteNonQuery();
                qrBox.name = nameTxt.Text;
                qrBox.ShowDialog();
            }
        }
    }
}
