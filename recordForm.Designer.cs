
namespace ScanConnect
{
    partial class recordForm
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
            this.recordPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attendanceRecord = new System.Windows.Forms.FlowLayoutPanel();
            this.data1 = new Guna.UI2.WinForms.Guna2Panel();
            this.date = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.recordPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.attendanceRecord.SuspendLayout();
            this.data1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordPanel
            // 
            this.recordPanel.BackColor = System.Drawing.Color.Transparent;
            this.recordPanel.BorderRadius = 20;
            this.recordPanel.Controls.Add(this.guna2Panel1);
            this.recordPanel.Controls.Add(this.attendanceRecord);
            this.recordPanel.FillColor = System.Drawing.Color.LightBlue;
            this.recordPanel.ForeColor = System.Drawing.Color.Black;
            this.recordPanel.Location = new System.Drawing.Point(8, 11);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.ShadowDecoration.Parent = this.recordPanel;
            this.recordPanel.Size = new System.Drawing.Size(784, 427);
            this.recordPanel.TabIndex = 10;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 35);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(753, 35);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // attendanceRecord
            // 
            this.attendanceRecord.AutoScroll = true;
            this.attendanceRecord.BackColor = System.Drawing.Color.LightBlue;
            this.attendanceRecord.Controls.Add(this.data1);
            this.attendanceRecord.Location = new System.Drawing.Point(9, 73);
            this.attendanceRecord.Name = "attendanceRecord";
            this.attendanceRecord.Size = new System.Drawing.Size(772, 343);
            this.attendanceRecord.TabIndex = 0;
            // 
            // data1
            // 
            this.data1.BorderRadius = 5;
            this.data1.Controls.Add(this.date);
            this.data1.Controls.Add(this.name);
            this.data1.Controls.Add(this.time);
            this.data1.Controls.Add(this.id);
            this.data1.FillColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(3, 3);
            this.data1.Name = "data1";
            this.data1.ShadowDecoration.Parent = this.data1;
            this.data1.Size = new System.Drawing.Size(753, 47);
            this.data1.TabIndex = 0;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(599, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(18, 20);
            this.date.TabIndex = 9;
            this.date.Text = "#";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(175, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(18, 20);
            this.name.TabIndex = 8;
            this.name.Text = "#";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(388, 13);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(18, 20);
            this.time.TabIndex = 7;
            this.time.Text = "#";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(16, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 20);
            this.id.TabIndex = 1;
            this.id.Text = "#";
            // 
            // recordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recordPanel);
            this.Name = "recordForm";
            this.Text = "recordForm";
            this.recordPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.attendanceRecord.ResumeLayout(false);
            this.data1.ResumeLayout(false);
            this.data1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel recordPanel;
        public System.Windows.Forms.FlowLayoutPanel attendanceRecord;
        private Guna.UI2.WinForms.Guna2Panel data1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label date;
    }
}