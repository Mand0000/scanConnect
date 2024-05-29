using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using MySql.Data;
using MySql.Data.MySqlClient;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.IO;
using Guna.UI2.WinForms;

namespace ScanConnect
{
    public partial class Dashboard : Form
    {
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        private Registration regis = new Registration();
        private Info infoForm = new Info();
        private recordForm record = new recordForm();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
            Application.ExitThread();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                dropDown.Items.Add(Device.Name);

            dropDown.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            attendancePanel.Controls.Remove(infoPanel);
            detectQr.Enabled = false;
        }
        bool isScanned = false;
        private void camBtn_Click(object sender, EventArgs e)
        {
            if (camBtn.Text == "OPEN CAMERA")
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[dropDown.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                camBtn.Text = "CLOSE CAMERA";
                detectQr.Enabled = true;
            }
            else
            {
                FinalFrame.Stop();
                camBtn.Text = "OPEN CAMERA";
                detectQr.Enabled = false;
                screen.Image = null;
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap mirrorImg = (Bitmap)eventArgs.Frame.Clone();
            mirrorImg.RotateFlip(RotateFlipType.RotateNoneFlipX);
            screen.Image = mirrorImg;
        }
        DateTime date = DateTime.Today;
        TimeSpan time = DateTime.Now.TimeOfDay;
        private void detectQr_Tick(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            BarcodeReader reader = new BarcodeReader();
            if (screen.Image != null && !isScanned) {
                Result result = reader.Decode((Bitmap)screen.Image);

                if (result != null)
                {
                    string decoded = result.Text.Trim();
                    idTxt.Text = decoded;
                    isScanned = true;
                    if (!string.IsNullOrEmpty(decoded))
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand coman = new MySqlCommand
                            {
                                Connection = con,
                                CommandText = "SELECT * FROM registration_tb WHERE ID LIKE @ID"
                            };
                            coman.Parameters.AddWithValue("@ID", "%" + idTxt.Text + "%");
                            MySqlDataReader dr = coman.ExecuteReader();

                            if (dr.Read())
                            {
                                nameTxt.Text = dr["Name"].ToString();
                                guardianTxt.Text = dr["GuardianName"].ToString();
                                emailTxt.Text = dr["EmailAddress"].ToString();
                                birtdateTxt.Text = dr["DateOfBirth"].ToString();
                                classTxt.Text = dr["Class"].ToString();
                                contactTxt.Text = dr["ContactNumber"].ToString();
                                genderTxt.Text = dr["Gender"].ToString();

                                byte[] img = (byte[])dr["Photo"];
                                using (MemoryStream ms = new MemoryStream(img))
                                {
                                    dpPic.Image = Image.FromStream(ms);
                                }
                                string[] dateS = Convert.ToString(date).Split(' ');
                                string[] timeS = Convert.ToString(time).Split('.');
                                try
                                {
                                    MySqlConnection conn = new MySqlConnection(conString);
                                    conn.Open();
                                    string qry = "INSERT INTO `attendance-record`(`Id`, `Name`, `Time`, `date`) VALUES (?, ?, ?, ?)";
                                    MySqlCommand com = new MySqlCommand(qry, conn);
                                    com.Parameters.AddWithValue("param1", idTxt.Text);
                                    com.Parameters.AddWithValue("param2", nameTxt.Text);
                                    com.Parameters.AddWithValue("param3", timeS[0]);
                                    com.Parameters.AddWithValue("param4", dateS[0]);
                                    com.ExecuteNonQuery();
                                    MessageBox.Show("Attendance Recorded");
                                } catch (Exception ex)
                                {
                                    MessageBox.Show("Attendance Not Recorded, Error: " + ex.Message);
                                }
                                
                            }
                            con.Close();
                            attendancePanel.Controls.Add(infoPanel);
                            //timer2.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            attendancePanel.Controls.Remove(infoPanel);
            isScanned = false;
        }

        

        private void regisBtn_Click(object sender, EventArgs e)
        {
            title.Text = "REGISTRATION";
            registbtn.FillColor = Color.FromArgb(17, 157, 164);
            attendBtn.FillColor = Color.Transparent;
            infoBtn.FillColor = Color.Transparent;
            recordBtn.FillColor = Color.Transparent;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(regis.regisPanel);
        }

        private void attendBtn_Click(object sender, EventArgs e)
        {
            title.Text = "ATTENDANCE";
            attendBtn.FillColor = Color.FromArgb(17, 157, 164);
            registbtn.FillColor = Color.Transparent;
            infoBtn.FillColor = Color.Transparent;
            recordBtn.FillColor = Color.Transparent;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(attendancePanel);
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            title.Text = "INFORMATION";
            infoBtn.FillColor = Color.FromArgb(17, 157, 164);
            registbtn.FillColor = Color.Transparent;
            attendBtn.FillColor = Color.Transparent;
            recordBtn.FillColor = Color.Transparent;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(infoForm.infoPanel);
            infoForm.studentsPanel.Controls.Clear();

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string qry = "SELECT * FROM `registration_tb`";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guna2Panel panel = new Guna2Panel();
                panel.BorderRadius = 20;
                panel.FillColor = System.Drawing.Color.White;
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "data1";
                panel.ShadowDecoration.Parent = panel;
                panel.Size = new System.Drawing.Size(753, 112);
                panel.TabIndex = 0;
                panel.Click += new System.EventHandler(infoForm.data1_Click);

                Guna2PictureBox pic = new Guna2PictureBox();
                pic.Location = new System.Drawing.Point(28, 16);
                pic.Name = "dpPic";
                pic.ShadowDecoration.Parent = pic;
                pic.Size = new System.Drawing.Size(80, 80);
                pic.TabIndex = 0;
                pic.TabStop = false;
                //pic.Image = Convert.ToSByte(reader.GetBytes("Photo"));
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                byte[] imageBytes = (byte[])reader["Photo"];
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                pic.Click += new System.EventHandler(infoForm.data1_Click);

                Label idLbl = new Label();
                idLbl.AutoSize = true;
                idLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                idLbl.Location = new System.Drawing.Point(129, 16);
                idLbl.Name = "idLbl";
                idLbl.Size = new System.Drawing.Size(33, 20);
                idLbl.TabIndex = 1;
                idLbl.Text = "ID: ";
                idLbl.Click += new System.EventHandler(infoForm.data1_Click);

                Label nameLbl = new Label();
                nameLbl.AutoSize = true;
                nameLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLbl.Location = new System.Drawing.Point(129, 46);
                nameLbl.Name = "nameLbl";
                nameLbl.Size = new System.Drawing.Size(62, 20);
                nameLbl.TabIndex = 5;
                nameLbl.Text = "NAME: ";
                nameLbl.Click += new System.EventHandler(infoForm.data1_Click);

                Label idTxt = new Label();
                idTxt.AutoSize = true;
                idTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                idTxt.Location = new System.Drawing.Point(168, 16);
                idTxt.Name = "idTxt";
                idTxt.Size = new System.Drawing.Size(18, 20);
                idTxt.TabIndex = 7;
                idTxt.Text = Convert.ToString(reader.GetInt32("ID"));
                idTxt.Click += new System.EventHandler(infoForm.data1_Click);

                Label nameTxt = new Label();
                nameTxt.AutoSize = true;
                nameTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameTxt.Location = new System.Drawing.Point(197, 46);
                nameTxt.Name = "nameTxt";
                nameTxt.Size = new System.Drawing.Size(18, 20);
                nameTxt.TabIndex = 8;
                nameTxt.Text = reader.GetString("Name");
                nameTxt.Click += new System.EventHandler(infoForm.data1_Click);

                Guna2ImageButton deleteBtn = new Guna2ImageButton();
                deleteBtn.CheckedState.Parent = deleteBtn;
                deleteBtn.HoverState.Parent = deleteBtn;
                deleteBtn.Image = global::ScanConnect.Properties.Resources.Delete__1_;
                deleteBtn.ImageSize = new System.Drawing.Size(30, 30);
                deleteBtn.Location = new System.Drawing.Point(691, 37);
                deleteBtn.Name = "deleteBtn";
                deleteBtn.PressedState.Parent = deleteBtn;
                deleteBtn.Size = new System.Drawing.Size(30, 30);
                deleteBtn.TabIndex = 6;
                deleteBtn.Click += new System.EventHandler(infoForm.deleteBtn_Click);

                infoForm.studentsPanel.Controls.Add(panel);
                panel.Controls.Add(pic);
                panel.Controls.Add(nameLbl);
                panel.Controls.Add(nameTxt);
                panel.Controls.Add(idLbl);
                panel.Controls.Add(idTxt);
                panel.Controls.Add(deleteBtn);

            }
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            title.Text = "RECORDS";
            recordBtn.FillColor = Color.FromArgb(17, 157, 164);
            registbtn.FillColor = Color.Transparent;
            infoBtn.FillColor = Color.Transparent;
            attendBtn.FillColor = Color.Transparent;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record.recordPanel);
            record.makedataPanel();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
