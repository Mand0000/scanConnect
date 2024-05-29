
namespace ScanConnect
{
    partial class Registration
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
            this.regisPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.femaleBtn = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.maleBtn = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.uploadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.datePick = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.classDrop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.contactTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guardianTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.regisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // regisPanel
            // 
            this.regisPanel.BackColor = System.Drawing.Color.Transparent;
            this.regisPanel.BorderRadius = 20;
            this.regisPanel.Controls.Add(this.profilePic);
            this.regisPanel.Controls.Add(this.saveBtn);
            this.regisPanel.Controls.Add(this.label8);
            this.regisPanel.Controls.Add(this.femaleBtn);
            this.regisPanel.Controls.Add(this.maleBtn);
            this.regisPanel.Controls.Add(this.label7);
            this.regisPanel.Controls.Add(this.uploadBtn);
            this.regisPanel.Controls.Add(this.datePick);
            this.regisPanel.Controls.Add(this.classDrop);
            this.regisPanel.Controls.Add(this.label6);
            this.regisPanel.Controls.Add(this.label5);
            this.regisPanel.Controls.Add(this.label4);
            this.regisPanel.Controls.Add(this.label3);
            this.regisPanel.Controls.Add(this.label2);
            this.regisPanel.Controls.Add(this.label1);
            this.regisPanel.Controls.Add(this.nameTxt);
            this.regisPanel.Controls.Add(this.contactTxt);
            this.regisPanel.Controls.Add(this.emailTxt);
            this.regisPanel.Controls.Add(this.guardianTxt);
            this.regisPanel.Controls.Add(this.IdTxt);
            this.regisPanel.Controls.Add(this.clearBtn);
            this.regisPanel.FillColor = System.Drawing.Color.LightBlue;
            this.regisPanel.Location = new System.Drawing.Point(6, 25);
            this.regisPanel.Name = "regisPanel";
            this.regisPanel.ShadowDecoration.Parent = this.regisPanel;
            this.regisPanel.Size = new System.Drawing.Size(784, 429);
            this.regisPanel.TabIndex = 8;
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.FillColor = System.Drawing.Color.White;
            this.profilePic.Location = new System.Drawing.Point(571, 14);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Parent = this.profilePic;
            this.profilePic.Size = new System.Drawing.Size(200, 200);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 28;
            this.profilePic.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(157)))), ((int)(((byte)(164)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(280, 367);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(137, 43);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "GENDER:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // femaleBtn
            // 
            this.femaleBtn.CheckedState.Image = global::ScanConnect.Properties.Resources.red_female_icon;
            this.femaleBtn.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.femaleBtn.CheckedState.Parent = this.femaleBtn;
            this.femaleBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.femaleBtn.HoverState.Parent = this.femaleBtn;
            this.femaleBtn.Image = global::ScanConnect.Properties.Resources.female_iCon;
            this.femaleBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.femaleBtn.Location = new System.Drawing.Point(80, 140);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.femaleBtn.PressedState.Parent = this.femaleBtn;
            this.femaleBtn.Size = new System.Drawing.Size(40, 40);
            this.femaleBtn.TabIndex = 25;
            this.femaleBtn.CheckedChanged += new System.EventHandler(this.femaleBtn_CheckedChanged);
            // 
            // maleBtn
            // 
            this.maleBtn.CheckedState.Image = global::ScanConnect.Properties.Resources.red_male_icon;
            this.maleBtn.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.maleBtn.CheckedState.Parent = this.maleBtn;
            this.maleBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.maleBtn.HoverState.Parent = this.maleBtn;
            this.maleBtn.Image = global::ScanConnect.Properties.Resources.male_icon;
            this.maleBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.maleBtn.Location = new System.Drawing.Point(31, 140);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.maleBtn.PressedState.Parent = this.maleBtn;
            this.maleBtn.Size = new System.Drawing.Size(40, 40);
            this.maleBtn.TabIndex = 24;
            this.maleBtn.CheckedChanged += new System.EventHandler(this.maleBtn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "BIRTHDATE:";
            // 
            // uploadBtn
            // 
            this.uploadBtn.BorderRadius = 10;
            this.uploadBtn.CheckedState.Parent = this.uploadBtn;
            this.uploadBtn.CustomImages.Parent = this.uploadBtn;
            this.uploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(157)))), ((int)(((byte)(164)))));
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.HoverState.Parent = this.uploadBtn;
            this.uploadBtn.Location = new System.Drawing.Point(611, 245);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.ShadowDecoration.Parent = this.uploadBtn;
            this.uploadBtn.Size = new System.Drawing.Size(120, 39);
            this.uploadBtn.TabIndex = 22;
            this.uploadBtn.Text = "UPLOAD";
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // datePick
            // 
            this.datePick.BorderColor = System.Drawing.Color.Transparent;
            this.datePick.BorderRadius = 5;
            this.datePick.CheckedState.Parent = this.datePick;
            this.datePick.FillColor = System.Drawing.Color.White;
            this.datePick.ForeColor = System.Drawing.Color.Black;
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePick.HoverState.Parent = this.datePick;
            this.datePick.Location = new System.Drawing.Point(280, 130);
            this.datePick.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePick.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePick.Name = "datePick";
            this.datePick.ShadowDecoration.Parent = this.datePick;
            this.datePick.Size = new System.Drawing.Size(170, 41);
            this.datePick.TabIndex = 21;
            this.datePick.Value = new System.DateTime(2024, 5, 23, 9, 16, 18, 966);
            // 
            // classDrop
            // 
            this.classDrop.BackColor = System.Drawing.Color.Transparent;
            this.classDrop.BorderRadius = 5;
            this.classDrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDrop.FocusedColor = System.Drawing.Color.Empty;
            this.classDrop.FocusedState.Parent = this.classDrop;
            this.classDrop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.classDrop.FormattingEnabled = true;
            this.classDrop.HoverState.Parent = this.classDrop;
            this.classDrop.ItemHeight = 30;
            this.classDrop.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Information System",
            "Bachelor of Science in Entertainment and Multimedia Computing"});
            this.classDrop.ItemsAppearance.Parent = this.classDrop;
            this.classDrop.Location = new System.Drawing.Point(282, 291);
            this.classDrop.Name = "classDrop";
            this.classDrop.ShadowDecoration.Parent = this.classDrop;
            this.classDrop.Size = new System.Drawing.Size(273, 36);
            this.classDrop.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "COURSE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "GUARDIAN NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "CONTACT NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "EMAIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // nameTxt
            // 
            this.nameTxt.BorderColor = System.Drawing.Color.Transparent;
            this.nameTxt.BorderRadius = 5;
            this.nameTxt.BorderThickness = 0;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.Parent = this.nameTxt;
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.FocusedState.Parent = this.nameTxt;
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(282, 65);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(273, 35);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // contactTxt
            // 
            this.contactTxt.BorderColor = System.Drawing.Color.Transparent;
            this.contactTxt.BorderRadius = 5;
            this.contactTxt.BorderThickness = 0;
            this.contactTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactTxt.DefaultText = "";
            this.contactTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTxt.DisabledState.Parent = this.contactTxt;
            this.contactTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTxt.FocusedState.Parent = this.contactTxt;
            this.contactTxt.ForeColor = System.Drawing.Color.Black;
            this.contactTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTxt.HoverState.Parent = this.contactTxt;
            this.contactTxt.IconLeft = global::ScanConnect.Properties.Resources._63_1_removebg_preview;
            this.contactTxt.IconLeftOffset = new System.Drawing.Point(-20, 0);
            this.contactTxt.IconLeftSize = new System.Drawing.Size(70, 40);
            this.contactTxt.Location = new System.Drawing.Point(31, 216);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.PasswordChar = '\0';
            this.contactTxt.PlaceholderText = "";
            this.contactTxt.SelectedText = "";
            this.contactTxt.ShadowDecoration.Parent = this.contactTxt;
            this.contactTxt.Size = new System.Drawing.Size(207, 35);
            this.contactTxt.TabIndex = 10;
            this.contactTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactTxt_KeyPress);
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.Color.Transparent;
            this.emailTxt.BorderRadius = 5;
            this.emailTxt.BorderThickness = 0;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(282, 216);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(273, 35);
            this.emailTxt.TabIndex = 9;
            this.emailTxt.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guardianTxt
            // 
            this.guardianTxt.BorderColor = System.Drawing.Color.Transparent;
            this.guardianTxt.BorderRadius = 5;
            this.guardianTxt.BorderThickness = 0;
            this.guardianTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guardianTxt.DefaultText = "";
            this.guardianTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guardianTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guardianTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianTxt.DisabledState.Parent = this.guardianTxt;
            this.guardianTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guardianTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianTxt.FocusedState.Parent = this.guardianTxt;
            this.guardianTxt.ForeColor = System.Drawing.Color.Black;
            this.guardianTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guardianTxt.HoverState.Parent = this.guardianTxt;
            this.guardianTxt.Location = new System.Drawing.Point(29, 291);
            this.guardianTxt.Name = "guardianTxt";
            this.guardianTxt.PasswordChar = '\0';
            this.guardianTxt.PlaceholderText = "";
            this.guardianTxt.SelectedText = "";
            this.guardianTxt.ShadowDecoration.Parent = this.guardianTxt;
            this.guardianTxt.Size = new System.Drawing.Size(209, 35);
            this.guardianTxt.TabIndex = 8;
            this.guardianTxt.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // IdTxt
            // 
            this.IdTxt.BorderColor = System.Drawing.Color.Transparent;
            this.IdTxt.BorderRadius = 5;
            this.IdTxt.BorderThickness = 0;
            this.IdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxt.DefaultText = "";
            this.IdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.DisabledState.Parent = this.IdTxt;
            this.IdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.FocusedState.Parent = this.IdTxt;
            this.IdTxt.ForeColor = System.Drawing.Color.Black;
            this.IdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.HoverState.Parent = this.IdTxt;
            this.IdTxt.Location = new System.Drawing.Point(29, 65);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.PasswordChar = '\0';
            this.IdTxt.PlaceholderText = "";
            this.IdTxt.SelectedText = "";
            this.IdTxt.ShadowDecoration.Parent = this.IdTxt;
            this.IdTxt.Size = new System.Drawing.Size(209, 35);
            this.IdTxt.TabIndex = 5;
            this.IdTxt.TextOffset = new System.Drawing.Point(5, 0);
            this.IdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTxt_KeyPress);
            // 
            // clearBtn
            // 
            this.clearBtn.BorderColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 10;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.CheckedState.Parent = this.clearBtn;
            this.clearBtn.CustomImages.Parent = this.clearBtn;
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(157)))), ((int)(((byte)(164)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(101, 367);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(137, 43);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 488);
            this.Controls.Add(this.regisPanel);
            this.Name = "Registration";
            this.Text = "Registration";
            this.regisPanel.ResumeLayout(false);
            this.regisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox contactTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox guardianTxt;
        private Guna.UI2.WinForms.Guna2TextBox IdTxt;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button uploadBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePick;
        private Guna.UI2.WinForms.Guna2ComboBox classDrop;
        private Guna.UI2.WinForms.Guna2ImageRadioButton maleBtn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ImageRadioButton femaleBtn;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        public Guna.UI2.WinForms.Guna2Panel regisPanel;
        public Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2PictureBox profilePic;
    }
}