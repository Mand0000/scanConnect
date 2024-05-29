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
using System.IO;
using Guna.UI2.WinForms;

namespace ScanConnect
{
    public partial class Info : Form
    {
        private studentInfo studInfo = new studentInfo();
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        public Info()
        {
            InitializeComponent();
        }

        public void data1_Click(object sender, EventArgs e)
        {
            if (sender is Control cont) {
                if (cont is Panel panel)
                {
                    Control idTxt = panel.Controls["idTxt"];
                    if (idTxt is Label idNum)
                    {
                        string id = idNum.Text;
                        displayInfo(id);
                        studInfo.Show();
                    }
                } else
                {
                    Control control = cont.Parent;
                    if (control is Panel pan)
                    {
                        Control idTxt = pan.Controls["idTxt"];
                        if (idTxt is Label idNum)
                        {
                            string id = idNum.Text;
                            displayInfo(id);
                            studInfo.Show();
                        }
                    }
                }
            }
            
        }

        private void displayInfo(string id)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string qry = "SELECT * FROM `registration_tb` WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                studInfo.id.Text = id;
                studInfo.name.Text = reader.GetString("Name");
                string gender = reader.GetString("Gender");
                if (gender == "Male")
                {
                    studInfo.maleBtn.Checked = true;
                } else
                {
                    studInfo.femaleBtn.Checked = true;
                }
                studInfo.email.Text = reader.GetString("EmailAddress");
                studInfo.contact.Text = Convert.ToString(reader.GetInt64("ContactNumber"));
                studInfo.birthdate.Text = reader.GetString("DateOfBirth");
                studInfo.guardian.Text = reader.GetString("GuardianName");
                studInfo.course.Text = reader.GetString("Class");

                byte[] imageBytes = (byte[])reader["Photo"];
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        studInfo.studentPic.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        public void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this data?", "",  MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                if (sender is Control cont)
                {
                    if (cont is Guna2ImageButton del)
                    {
                        Control pan = del.Parent;
                        if (pan is Panel panel)
                        {
                            Control lbl = panel.Controls["idTxt"];
                            if (lbl is Label idTxt)
                            {
                                string id = idTxt.Text;
                                MySqlConnection con = new MySqlConnection(conString);
                                con.Open();
                                string qry = "DELETE FROM `registration_tb` WHERE ID = @id";
                                MySqlCommand cmd = new MySqlCommand(qry, con);
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                                int delRow = cmd.ExecuteNonQuery();
                                if (delRow > 0)
                                {
                                    MessageBox.Show(Convert.ToString(delRow) + "Data Deleted");
                                    studentsPanel.Controls.Remove(panel);
                                }
                                else
                                {
                                    MessageBox.Show("0 Data Deleted");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
