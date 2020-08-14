namespace App.HospitalHub.GUI
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ucRegistrationPatient1 = new App.HospitalHub.GUI.ucRegistrationPatient();
            this.ucOrdinatorReg1 = new App.HospitalHub.GUI.UcOrdinatorReg();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnOrdinator = new System.Windows.Forms.Button();
            this.pnlButton.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlButton.Controls.Add(this.btnPatient);
            this.pnlButton.Controls.Add(this.pnlLeft);
            this.pnlButton.Controls.Add(this.btnOrdinator);
            this.pnlButton.Location = new System.Drawing.Point(0, 122);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(217, 554);
            this.pnlButton.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLeft.Location = new System.Drawing.Point(3, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(11, 54);
            this.pnlLeft.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(256, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create an Account ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(898, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Already have an account?";
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginBack.FlatAppearance.BorderSize = 0;
            this.btnLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBack.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBack.ForeColor = System.Drawing.Color.White;
            this.btnLoginBack.Location = new System.Drawing.Point(1088, 30);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(73, 33);
            this.btnLoginBack.TabIndex = 3;
            this.btnLoginBack.Text = "Login";
            this.btnLoginBack.UseVisualStyleBackColor = false;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlHeader.Controls.Add(this.btnLoginBack);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Location = new System.Drawing.Point(0, 34);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlTop.Controls.Add(this.panel3);
            this.PnlTop.Controls.Add(this.btnExit);
            this.PnlTop.Controls.Add(this.label4);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1264, 34);
            this.PnlTop.TabIndex = 7;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(197, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 642);
            this.panel3.TabIndex = 14;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hospital Hub";
            // 
            // ucRegistrationPatient1
            // 
            this.ucRegistrationPatient1.Location = new System.Drawing.Point(223, 140);
            this.ucRegistrationPatient1.Name = "ucRegistrationPatient1";
            this.ucRegistrationPatient1.Size = new System.Drawing.Size(938, 501);
            this.ucRegistrationPatient1.TabIndex = 8;
            // 
            // ucOrdinatorReg1
            // 
            this.ucOrdinatorReg1.Location = new System.Drawing.Point(217, 125);
            this.ucOrdinatorReg1.Name = "ucOrdinatorReg1";
            this.ucOrdinatorReg1.Size = new System.Drawing.Size(938, 501);
            this.ucOrdinatorReg1.TabIndex = 9;
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_wheelchair_30px3;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(12, 1);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnPatient.Size = new System.Drawing.Size(199, 53);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click_1);
            // 
            // btnOrdinator
            // 
            this.btnOrdinator.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdinator.FlatAppearance.BorderSize = 0;
            this.btnOrdinator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdinator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdinator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdinator.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_admin_settings_male_50px;
            this.btnOrdinator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdinator.Location = new System.Drawing.Point(12, 60);
            this.btnOrdinator.Name = "btnOrdinator";
            this.btnOrdinator.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOrdinator.Size = new System.Drawing.Size(199, 53);
            this.btnOrdinator.TabIndex = 1;
            this.btnOrdinator.Text = "Coordinator";
            this.btnOrdinator.UseVisualStyleBackColor = false;
            this.btnOrdinator.Click += new System.EventHandler(this.btnOrdinator_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 676);
            this.Controls.Add(this.ucOrdinatorReg1);
            this.Controls.Add(this.ucRegistrationPatient1);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnOrdinator;
        private System.Windows.Forms.Panel pnlLeft;
        private ucRegistrationPatient registrationPatient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoginBack;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private ucRegistrationPatient ucRegistrationPatient1;
        private UcOrdinatorReg ucOrdinatorReg1;
        private System.Windows.Forms.Button btnPatient;
    }
}