namespace dene
{
    partial class FormDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.userSettings = new dene.UserControl1();
            this.userMusteri = new dene.form.UserControl2();
            this.userodalar = new dene.form.Rooms();
            this.reserve = new dene.form.Reservation();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.kisi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1502, 97);
            this.panel1.TabIndex = 0;
            // 
            // kisi
            // 
            this.kisi.AutoSize = true;
            this.kisi.Location = new System.Drawing.Point(353, 35);
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(50, 20);
            this.kisi.TabIndex = 3;
            this.kisi.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldiniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(1087, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.buttonReservation);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.buttonSetting);
            this.panel2.Controls.Add(this.buttonRoom);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.buttonDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 748);
            this.panel2.TabIndex = 1;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(37, 164);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(93, 41);
            this.buttonReservation.TabIndex = 5;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSlide.Location = new System.Drawing.Point(14, 28);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(11, 49);
            this.panelSlide.TabIndex = 3;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(39, 213);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(90, 37);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.Location = new System.Drawing.Point(39, 119);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(90, 37);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(39, 73);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(90, 37);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(39, 28);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(90, 37);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // userSettings
            // 
            this.userSettings.Location = new System.Drawing.Point(185, 125);
            this.userSettings.Name = "userSettings";
            this.userSettings.Size = new System.Drawing.Size(1078, 568);
            this.userSettings.TabIndex = 2;
            this.userSettings.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userMusteri
            // 
            this.userMusteri.Location = new System.Drawing.Point(230, 114);
            this.userMusteri.Name = "userMusteri";
            this.userMusteri.Size = new System.Drawing.Size(1053, 568);
            this.userMusteri.TabIndex = 3;
            // 
            // userodalar
            // 
            this.userodalar.Location = new System.Drawing.Point(210, 125);
            this.userodalar.Name = "userodalar";
            this.userodalar.Size = new System.Drawing.Size(1146, 627);
            this.userodalar.TabIndex = 4;
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(186, 109);
            this.reserve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(1194, 643);
            this.reserve.TabIndex = 5;
            this.reserve.Load += new System.EventHandler(this.reserve_Load);
            // 
            // FormDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 845);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.userodalar);
            this.Controls.Add(this.userMusteri);
            this.Controls.Add(this.userSettings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDash";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Button buttonSetting;
        private Button buttonRoom;
        private Button buttonClient;
        private Button buttonDashboard;
        private Panel panelSlide;
        private Label label1;
        private Label kisi;
        private Button buttonReservation;
        private UserControl1 userSettings;
        private form.UserControl2 userMusteri;
        private form.Rooms userodalar;
        private form.Reservation reserve;
    }
}