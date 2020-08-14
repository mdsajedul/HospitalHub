namespace App.HospitalHub.GUI
{
    partial class Dashboard
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
            this.PnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.ucHospitalListView1 = new App.HospitalHub.GUI.UcHospitalListView();
            this.ucPatientProfile1 = new App.HospitalHub.GUI.UcPatientProfile();
            this.ucAppointmentPatient1 = new App.HospitalHub.GUI.UcAppointmentPatient();
            this.PnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlTop.Controls.Add(this.btnExit);
            this.PnlTop.Controls.Add(this.label1);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1264, 30);
            this.PnlTop.TabIndex = 3;
            this.PnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTop_Paint);
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1216, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Hub";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.btnAppointment);
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnHospital);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 646);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::App.HospitalHub.GUI.Properties.Resources.logout1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(45, 523);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital Hub © 2020 ";
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Image = global::App.HospitalHub.GUI.Properties.Resources.appointment;
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(0, 248);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAppointment.Size = new System.Drawing.Size(200, 55);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::App.HospitalHub.GUI.Properties.Resources.profile;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 188);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnProfile.Size = new System.Drawing.Size(200, 54);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHospital.FlatAppearance.BorderSize = 0;
            this.btnHospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospital.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospital.ForeColor = System.Drawing.Color.White;
            this.btnHospital.Image = global::App.HospitalHub.GUI.Properties.Resources.list;
            this.btnHospital.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospital.Location = new System.Drawing.Point(0, 119);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHospital.Size = new System.Drawing.Size(200, 63);
            this.btnHospital.TabIndex = 0;
            this.btnHospital.Text = "Hospital Lists";
            this.btnHospital.UseVisualStyleBackColor = false;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // ucHospitalListView1
            // 
            this.ucHospitalListView1.Location = new System.Drawing.Point(197, 30);
            this.ucHospitalListView1.Name = "ucHospitalListView1";
            this.ucHospitalListView1.Size = new System.Drawing.Size(1067, 642);
            this.ucHospitalListView1.TabIndex = 5;
            // 
            // ucPatientProfile1
            // 
            this.ucPatientProfile1.Location = new System.Drawing.Point(197, 30);
            this.ucPatientProfile1.Name = "ucPatientProfile1";
            this.ucPatientProfile1.Size = new System.Drawing.Size(1067, 642);
            this.ucPatientProfile1.TabIndex = 6;
            // 
            // ucAppointmentPatient1
            // 
            this.ucAppointmentPatient1.Location = new System.Drawing.Point(197, 30);
            this.ucAppointmentPatient1.Name = "ucAppointmentPatient1";
            this.ucAppointmentPatient1.Size = new System.Drawing.Size(1067, 642);
            this.ucAppointmentPatient1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 676);
            this.Controls.Add(this.ucAppointmentPatient1);
            this.Controls.Add(this.ucPatientProfile1);
            this.Controls.Add(this.ucHospitalListView1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHospital;
        private UcHospitalListView ucHospitalListView1;
        private UcPatientProfile ucPatientProfile1;
        private UcAppointmentPatient ucAppointmentPatient1;
        private System.Windows.Forms.Button btnLogout;
    }
}