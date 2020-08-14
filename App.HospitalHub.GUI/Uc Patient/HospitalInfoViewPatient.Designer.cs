namespace App.HospitalHub.GUI
{
    partial class HospitalInfoViewPatient
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucHospitalDeptView1 = new App.HospitalHub.GUI.UcHospitalDeptView();
            this.ucDiagnosisViewPatient1 = new App.HospitalHub.GUI.UcDiagnosisViewPatient();
            this.ucOtherServicesPatients1 = new App.HospitalHub.GUI.UcOtherServicesPatients();
            this.ucRatingPatient1 = new App.HospitalHub.GUI.UcRatingPatient();
            this.ucFoodPatientView1 = new App.HospitalHub.GUI.UcFoodPatientView();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnUcDeptDoctor = new System.Windows.Forms.Button();
            this.btnUcOther = new System.Windows.Forms.Button();
            this.btnUcDiagnosis = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblHospitalName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 68);
            this.pnlTop.TabIndex = 9;
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalName.Location = new System.Drawing.Point(71, 23);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(177, 33);
            this.lblHospitalName.TabIndex = 0;
            this.lblHospitalName.Text = "Hospital Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btnRating);
            this.panel1.Controls.Add(this.btnUcDeptDoctor);
            this.panel1.Controls.Add(this.btnUcOther);
            this.panel1.Controls.Add(this.btnUcDiagnosis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 50);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ucHospitalDeptView1
            // 
            this.ucHospitalDeptView1.Location = new System.Drawing.Point(3, 124);
            this.ucHospitalDeptView1.Name = "ucHospitalDeptView1";
            this.ucHospitalDeptView1.Size = new System.Drawing.Size(1067, 434);
            this.ucHospitalDeptView1.TabIndex = 8;
            this.ucHospitalDeptView1.Load += new System.EventHandler(this.ucHospitalDeptView1_Load);
            // 
            // ucDiagnosisViewPatient1
            // 
            this.ucDiagnosisViewPatient1.Location = new System.Drawing.Point(0, 124);
            this.ucDiagnosisViewPatient1.Name = "ucDiagnosisViewPatient1";
            this.ucDiagnosisViewPatient1.Size = new System.Drawing.Size(1067, 434);
            this.ucDiagnosisViewPatient1.TabIndex = 14;
            // 
            // ucOtherServicesPatients1
            // 
            this.ucOtherServicesPatients1.Location = new System.Drawing.Point(3, 124);
            this.ucOtherServicesPatients1.Name = "ucOtherServicesPatients1";
            this.ucOtherServicesPatients1.Size = new System.Drawing.Size(1067, 434);
            this.ucOtherServicesPatients1.TabIndex = 15;
            // 
            // ucRatingPatient1
            // 
            this.ucRatingPatient1.Location = new System.Drawing.Point(0, 124);
            this.ucRatingPatient1.Name = "ucRatingPatient1";
            this.ucRatingPatient1.Size = new System.Drawing.Size(1067, 434);
            this.ucRatingPatient1.TabIndex = 16;
            // 
            // ucFoodPatientView1
            // 
            this.ucFoodPatientView1.Location = new System.Drawing.Point(0, 124);
            this.ucFoodPatientView1.Name = "ucFoodPatientView1";
            this.ucFoodPatientView1.Size = new System.Drawing.Size(1067, 434);
            this.ucFoodPatientView1.TabIndex = 17;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFood.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_food_16px;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(644, 0);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnFood.Size = new System.Drawing.Size(182, 50);
            this.btnFood.TabIndex = 14;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRating.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_thumbs_up_24px;
            this.btnRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRating.Location = new System.Drawing.Point(832, 0);
            this.btnRating.Name = "btnRating";
            this.btnRating.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.btnRating.Size = new System.Drawing.Size(182, 50);
            this.btnRating.TabIndex = 13;
            this.btnRating.Text = "Rating";
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnUcDeptDoctor
            // 
            this.btnUcDeptDoctor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUcDeptDoctor.FlatAppearance.BorderSize = 0;
            this.btnUcDeptDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcDeptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcDeptDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUcDeptDoctor.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_medical_doctor_26px;
            this.btnUcDeptDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcDeptDoctor.Location = new System.Drawing.Point(66, 0);
            this.btnUcDeptDoctor.Name = "btnUcDeptDoctor";
            this.btnUcDeptDoctor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUcDeptDoctor.Size = new System.Drawing.Size(197, 50);
            this.btnUcDeptDoctor.TabIndex = 12;
            this.btnUcDeptDoctor.Text = "Department ";
            this.btnUcDeptDoctor.UseVisualStyleBackColor = false;
            this.btnUcDeptDoctor.Click += new System.EventHandler(this.btnUcDeptDoctor_Click);
            // 
            // btnUcOther
            // 
            this.btnUcOther.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUcOther.FlatAppearance.BorderSize = 0;
            this.btnUcOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcOther.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUcOther.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_food_service_50px;
            this.btnUcOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcOther.Location = new System.Drawing.Point(457, 0);
            this.btnUcOther.Name = "btnUcOther";
            this.btnUcOther.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.btnUcOther.Size = new System.Drawing.Size(182, 50);
            this.btnUcOther.TabIndex = 11;
            this.btnUcOther.Text = "Services";
            this.btnUcOther.UseVisualStyleBackColor = false;
            this.btnUcOther.Click += new System.EventHandler(this.btnUcOther_Click);
            // 
            // btnUcDiagnosis
            // 
            this.btnUcDiagnosis.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUcDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnUcDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcDiagnosis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUcDiagnosis.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_health_checkup_50px1;
            this.btnUcDiagnosis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcDiagnosis.Location = new System.Drawing.Point(269, 0);
            this.btnUcDiagnosis.Name = "btnUcDiagnosis";
            this.btnUcDiagnosis.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.btnUcDiagnosis.Size = new System.Drawing.Size(182, 50);
            this.btnUcDiagnosis.TabIndex = 9;
            this.btnUcDiagnosis.Text = "Diagnosis";
            this.btnUcDiagnosis.UseVisualStyleBackColor = false;
            this.btnUcDiagnosis.Click += new System.EventHandler(this.btnUcDiagnosis_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_back_arrow_32px;
            this.btnBack.Location = new System.Drawing.Point(12, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HospitalInfoViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 558);
            this.Controls.Add(this.ucFoodPatientView1);
            this.Controls.Add(this.ucRatingPatient1);
            this.Controls.Add(this.ucOtherServicesPatients1);
            this.Controls.Add(this.ucDiagnosisViewPatient1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.ucHospitalDeptView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HospitalInfoViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalInfoViewPatient";
            this.Load += new System.EventHandler(this.HospitalInfoViewPatient_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UcHospitalDeptView ucHospitalDeptView1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUcOther;
        private System.Windows.Forms.Button btnUcDiagnosis;
        private System.Windows.Forms.Button btnUcDeptDoctor;
        private UcDiagnosisViewPatient ucDiagnosisViewPatient1;
        private UcOtherServicesPatients ucOtherServicesPatients1;
        private System.Windows.Forms.Button btnRating;
        private UcRatingPatient ucRatingPatient1;
        private System.Windows.Forms.Button btnFood;
        private UcFoodPatientView ucFoodPatientView1;
    }
}