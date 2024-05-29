using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ScanConnect
{
    public partial class recordForm : Form
    {
        private string conString = "server=127.0.0.1;database=user_info;user=root;";
        public recordForm()
        {
            InitializeComponent();
        }
        public void makedataPanel()
        {
            attendanceRecord.Controls.Clear();
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string qry = "SELECT * FROM `attendance-record`";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guna2Panel panel = new Guna2Panel();
                panel.BorderRadius = 5;
                panel.FillColor = System.Drawing.Color.White;
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "data1";
                panel.ShadowDecoration.Parent = this.data1;
                panel.Size = new System.Drawing.Size(753, 47);
                panel.TabIndex = 0;

                Label id = new Label();
                id.AutoSize = true;
                id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                id.Location = new System.Drawing.Point(13, 12);
                id.Name = "id";
                id.Size = new System.Drawing.Size(18, 20);
                id.TabIndex = 1;
                id.Text = Convert.ToString(reader.GetInt64("Id"));

                Label name = new Label();
                name.AutoSize = true;
                name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                name.Location = new System.Drawing.Point(160, 13);
                name.Name = "name";
                name.Size = new System.Drawing.Size(18, 20);
                name.TabIndex = 8;
                name.Text = reader.GetString("Name");

                Label time = new Label();
                time.AutoSize = true;
                time.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                time.Location = new System.Drawing.Point(377, 13);
                time.Name = "time";
                time.Size = new System.Drawing.Size(18, 20);
                time.TabIndex = 7;
                time.Text = reader.GetString("Time");

                Label date = new Label();
                date.AutoSize = true;
                date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                date.Location = new System.Drawing.Point(603, 12);
                date.Name = "date";
                date.Size = new System.Drawing.Size(18, 20);
                date.TabIndex = 9;
                date.Text = reader.GetString("Date");

                attendanceRecord.Controls.Add(panel);
                panel.Controls.Add(id);
                panel.Controls.Add(name);
                panel.Controls.Add(time);
                panel.Controls.Add(date);
            }
        }
    }
}
