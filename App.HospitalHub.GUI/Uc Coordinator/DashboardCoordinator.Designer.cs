namespace App.HospitalHub.GUI
{
    partial class DashboardCoordinator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnAppoinment = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPatientDetails = new System.Windows.Forms.Button();
            this.btnDashboad = new System.Windows.Forms.Button();
            this.ucAppoinmentOrdinator1 = new App.HospitalHub.GUI.UcAppoinmentOrdinator();
            this.ucViewHospitalBasicInfo1 = new App.HospitalHub.GUI.UcViewHospitalBasicInfo();
            this.ucServicesAdd1 = new App.HospitalHub.GUI.UcServicesAdd();
            this.ucDiagnosisAdd1 = new App.HospitalHub.GUI.UcDiagnosisAdd();
            this.ucDoctorUpdate1 = new App.HospitalHub.GUI.UcDoctorUpdate();
            this.ucDepartmentUpdate1 = new App.HospitalHub.GUI.UcDepartmentUpdate();
            this.ucOrdinatorProfile1 = new App.HospitalHub.GUI.UcOrdinatorProfile();
            this.PnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlTop.Controls.Add(this.panel1);
            this.PnlTop.Controls.Add(this.btnExit);
            this.PnlTop.Controls.Add(this.label1);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1264, 34);
            this.PnlTop.TabIndex = 5;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(197, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 642);
            this.panel1.TabIndex = 14;
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
            this.pnlMenu.Controls.Add(this.btnDiagnosis);
            this.pnlMenu.Controls.Add(this.btnAppoinment);
            this.pnlMenu.Controls.Add(this.btnServices);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.btnDepartment);
            this.pnlMenu.Controls.Add(this.btnPatientDetails);
            this.pnlMenu.Controls.Add(this.btnDashboad);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 34);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(199, 642);
            this.pnlMenu.TabIndex = 6;
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
            this.btnLogout.Location = new System.Drawing.Point(31, 553);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_health_checkup_50px;
            this.btnDiagnosis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosis.Location = new System.Drawing.Point(-1, 474);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnDiagnosis.Size = new System.Drawing.Size(200, 51);
            this.btnDiagnosis.TabIndex = 4;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnAppoinment
            // 
            this.btnAppoinment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAppoinment.FlatAppearance.BorderSize = 0;
            this.btnAppoinment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoinment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinment.ForeColor = System.Drawing.Color.White;
            this.btnAppoinment.Image = global::App.HospitalHub.GUI.Properties.Resources.appointment;
            this.btnAppoinment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppoinment.Location = new System.Drawing.Point(-4, 417);
            this.btnAppoinment.Name = "btnAppoinment";
            this.btnAppoinment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAppoinment.Size = new System.Drawing.Size(200, 51);
            this.btnAppoinment.TabIndex = 3;
            this.btnAppoinment.Text = "Appoinments";
            this.btnAppoinment.UseVisualStyleBackColor = false;
            this.btnAppoinment.Click += new System.EventHandler(this.btnAppoinment_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_food_service_50px;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(0, 360);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnServices.Size = new System.Drawing.Size(196, 51);
            this.btnServices.TabIndex = 2;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital Hub © 2020 ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_medical_doctor_26px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-3, 303);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.button4.Size = new System.Drawing.Size(200, 51);
            this.button4.TabIndex = 0;
            this.button4.Text = "Doctor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDepartment.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_department_26px;
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(-3, 242);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDepartment.Size = new System.Drawing.Size(200, 55);
            this.btnDepartment.TabIndex = 0;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnPatientDetails
            // 
            this.btnPatientDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPatientDetails.FlatAppearance.BorderSize = 0;
            this.btnPatientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetails.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetails.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_update_left_rotation_24px;
            this.btnPatientDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientDetails.Location = new System.Drawing.Point(-3, 182);
            this.btnPatientDetails.Name = "btnPatientDetails";
            this.btnPatientDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPatientDetails.Size = new System.Drawing.Size(200, 54);
            this.btnPatientDetails.TabIndex = 0;
            this.btnPatientDetails.Text = "Update Basic Info";
            this.btnPatientDetails.UseVisualStyleBackColor = false;
            this.btnPatientDetails.Click += new System.EventHandler(this.btnPatientDetails_Click);
            // 
            // btnDashboad
            // 
            this.btnDashboad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboad.FlatAppearance.BorderSize = 0;
            this.btnDashboad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboad.ForeColor = System.Drawing.Color.White;
            this.btnDashboad.Image = global::App.HospitalHub.GUI.Properties.Resources.profile;
            this.btnDashboad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboad.Location = new System.Drawing.Point(-3, 113);
            this.btnDashboad.Name = "btnDashboad";
            this.btnDashboad.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnDashboad.Size = new System.Drawing.Size(200, 63);
            this.btnDashboad.TabIndex = 0;
            this.btnDashboad.Text = "Profile";
            this.btnDashboad.UseVisualStyleBackColor = false;
            this.btnDashboad.Click += new System.EventHandler(this.btnDashboad_Click);
            // 
            // ucAppoinmentOrdinator1
            // 
            this.ucAppoinmentOrdinator1.Location = new System.Drawing.Point(194, 34);
            this.ucAppoinmentOrdinator1.Name = "ucAppoinmentOrdinator1";
            this.ucAppoinmentOrdinator1.Size = new System.Drawing.Size(1067, 642);
            this.ucAppoinmentOrdinator1.TabIndex = 13;
            // 
            // ucViewHospitalBasicInfo1
            // 
            this.ucViewHospitalBasicInfo1.Location = new System.Drawing.Point(197, 34);
            this.ucViewHospitalBasicInfo1.Name = "ucViewHospitalBasicInfo1";
            this.ucViewHospitalBasicInfo1.Size = new System.Drawing.Size(1067, 642);
            this.ucViewHospitalBasicInfo1.TabIndex = 12;
            this.ucViewHospitalBasicInfo1.Load += new System.EventHandler(this.ucViewHospitalBasicInfo1_Load);
            // 
            // ucServicesAdd1
            // 
            this.ucServicesAdd1.Location = new System.Drawing.Point(197, 34);
            this.ucServicesAdd1.Name = "ucServicesAdd1";
            this.ucServicesAdd1.Size = new System.Drawing.Size(1067, 642);
            this.ucServicesAdd1.TabIndex = 11;
            // 
            // ucDiagnosisAdd1
            // 
            this.ucDiagnosisAdd1.Location = new System.Drawing.Point(197, 34);
            this.ucDiagnosisAdd1.Name = "ucDiagnosisAdd1";
            this.ucDiagnosisAdd1.Size = new System.Drawing.Size(1067, 642);
            this.ucDiagnosisAdd1.TabIndex = 10;
            // 
            // ucDoctorUpdate1
            // 
            this.ucDoctorUpdate1.Location = new System.Drawing.Point(197, 34);
            this.ucDoctorUpdate1.Name = "ucDoctorUpdate1";
            this.ucDoctorUpdate1.Size = new System.Drawing.Size(1067, 642);
            this.ucDoctorUpdate1.TabIndex = 9;
            // 
            // ucDepartmentUpdate1
            // 
            this.ucDepartmentUpdate1.Location = new System.Drawing.Point(197, 34);
            this.ucDepartmentUpdate1.Name = "ucDepartmentUpdate1";
            this.ucDepartmentUpdate1.Size = new System.Drawing.Size(1067, 642);
            this.ucDepartmentUpdate1.TabIndex = 8;
            // 
            // ucOrdinatorProfile1
            // 
            this.ucOrdinatorProfile1.Location = new System.Drawing.Point(194, 34);
            this.ucOrdinatorProfile1.Name = "ucOrdinatorProfile1";
            this.ucOrdinatorProfile1.Size = new System.Drawing.Size(1067, 642);
            this.ucOrdinatorProfile1.TabIndex = 14;
            // 
            // DashboardCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 676);
            this.Controls.Add(this.ucOrdinatorProfile1);
            this.Controls.Add(this.ucAppoinmentOrdinator1);
            this.Controls.Add(this.ucViewHospitalBasicInfo1);
            this.Controls.Add(this.ucServicesAdd1);
            this.Controls.Add(this.ucDiagnosisAdd1);
            this.Controls.Add(this.ucDoctorUpdate1);
            this.Controls.Add(this.ucDepartmentUpdate1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardCoordinator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardCoordinator";
            this.Load += new System.EventHandler(this.DashboardCoordinator_Load);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPatientDetails;
        private System.Windows.Forms.Button btnDashboad;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnAppoinment;
        private System.Windows.Forms.Button btnServices;
        private UcDepartmentUpdate ucDepartmentUpdate1;
        private UcDoctorUpdate ucDoctorUpdate1;
        private UcDiagnosisAdd ucDiagnosisAdd1;
        private UcServicesAdd ucServicesAdd1;
        private UcViewHospitalBasicInfo ucViewHospitalBasicInfo1;
        private System.Windows.Forms.Panel panel1;
        private UcAppoinmentOrdinator ucAppoinmentOrdinator1;
        private UcOrdinatorProfile ucOrdinatorProfile1;
        private System.Windows.Forms.Button btnLogout;
    }
}