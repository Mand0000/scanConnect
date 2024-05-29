
namespace ScanConnect
{
    partial class Info
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
            this.infoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.studentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.data1 = new Guna.UI2.WinForms.Guna2Panel();
            this.nameTxt = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.Label();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.infoPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.data1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.BorderRadius = 20;
            this.infoPanel.Controls.Add(this.studentsPanel);
            this.infoPanel.FillColor = System.Drawing.Color.LightBlue;
            this.infoPanel.ForeColor = System.Drawing.Color.Black;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.ShadowDecoration.Parent = this.infoPanel;
            this.infoPanel.Size = new System.Drawing.Size(800, 429);
            this.infoPanel.TabIndex = 9;
            // 
            // studentsPanel
            // 
            this.studentsPanel.AutoScroll = true;
            this.studentsPanel.BackColor = System.Drawing.Color.LightBlue;
            this.studentsPanel.Controls.Add(this.data1);
            this.studentsPanel.Location = new System.Drawing.Point(9, 16);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(779, 400);
            this.studentsPanel.TabIndex = 0;
            // 
            // data1
            // 
            this.data1.BorderRadius = 20;
            this.data1.Controls.Add(this.nameTxt);
            this.data1.Controls.Add(this.idTxt);
            this.data1.Controls.Add(this.deleteBtn);
            this.data1.Controls.Add(this.label5);
            this.data1.Controls.Add(this.label1);
            this.data1.Controls.Add(this.guna2PictureBox1);
            this.data1.FillColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(3, 3);
            this.data1.Name = "data1";
            this.data1.ShadowDecoration.Parent = this.data1;
            this.data1.Size = new System.Drawing.Size(753, 112);
            this.data1.TabIndex = 0;
            this.data1.Click += new System.EventHandler(this.data1_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.BackColor = System.Drawing.Color.Transparent;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(184, 46);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(18, 20);
            this.nameTxt.TabIndex = 8;
            this.nameTxt.Text = "#";
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.BackColor = System.Drawing.Color.Transparent;
            this.idTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(155, 16);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(18, 20);
            this.idTxt.TabIndex = 7;
            this.idTxt.Text = "#";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Image = global::ScanConnect.Properties.Resources.Delete;
            this.deleteBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteBtn.Location = new System.Drawing.Point(691, 37);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PressedState.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(30, 30);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "NAME: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Location = new System.Drawing.Point(28, 16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoPanel);
            this.Name = "Info";
            this.Text = "Info";
            this.infoPanel.ResumeLayout(false);
            this.studentsPanel.ResumeLayout(false);
            this.data1.ResumeLayout(false);
            this.data1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel infoPanel;
        private Guna.UI2.WinForms.Guna2Panel data1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        public System.Windows.Forms.FlowLayoutPanel studentsPanel;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label idTxt;
    }
}