namespace App.HospitalHub.GUI
{
    partial class ConfirmAppointment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConfirmAppointment = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultationCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmAppointment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 113);
            this.pnlTop.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::App.HospitalHub.GUI.Properties.Resources.icons8_back_arrow_32px;
            this.btnBack.Location = new System.Drawing.Point(12, 55);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accepted Appointment List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvConfirmAppointment
            // 
            this.dgvConfirmAppointment.AllowUserToAddRows = false;
            this.dgvConfirmAppointment.AllowUserToDeleteRows = false;
            this.dgvConfirmAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfirmAppointment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConfirmAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConfirmAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConfirmAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConfirmAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConfirmAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.patientId,
            this.patientName,
            this.patientPhone,
            this.patientEmail,
            this.district,
            this.division,
            this.doctorName,
            this.department,
            this.hospitalId,
            this.time,
            this.date});
            this.dgvConfirmAppointment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvConfirmAppointment.GridColor = System.Drawing.SystemColors.Control;
            this.dgvConfirmAppointment.Location = new System.Drawing.Point(23, 143);
            this.dgvConfirmAppointment.Name = "dgvConfirmAppointment";
            this.dgvConfirmAppointment.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConfirmAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConfirmAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConfirmAppointment.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConfirmAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfirmAppointment.Size = new System.Drawing.Size(984, 418);
            this.dgvConfirmAppointment.TabIndex = 8;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // patientId
            // 
            this.patientId.DataPropertyName = "patientId";
            this.patientId.HeaderText = "Patient ID";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // patientName
            // 
            this.patientName.DataPropertyName = "patientName";
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // patientPhone
            // 
            this.patientPhone.DataPropertyName = "patientPhone";
            this.patientPhone.HeaderText = "Phone";
            this.patientPhone.Name = "patientPhone";
            this.patientPhone.ReadOnly = true;
            // 
            // patientEmail
            // 
            this.patientEmail.DataPropertyName = "patientEmail";
            this.patientEmail.HeaderText = "Email";
            this.patientEmail.Name = "patientEmail";
            this.patientEmail.ReadOnly = true;
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "District";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // division
            // 
            this.division.DataPropertyName = "division";
            this.division.HeaderText = "Division";
            this.division.Name = "division";
            this.division.ReadOnly = true;
            // 
            // doctorName
            // 
            this.doctorName.DataPropertyName = "doctorName";
            this.doctorName.HeaderText = "Doctor Name";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // hospitalId
            // 
            this.hospitalId.DataPropertyName = "hospitalId";
            this.hospitalId.HeaderText = "Hospital ID";
            this.hospitalId.Name = "hospitalId";
            this.hospitalId.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationCompleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 34);
            // 
            // consultationCompleteToolStripMenuItem
            // 
            this.consultationCompleteToolStripMenuItem.Name = "consultationCompleteToolStripMenuItem";
            this.consultationCompleteToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.consultationCompleteToolStripMenuItem.Text = "Consultation Complete ";
            this.consultationCompleteToolStripMenuItem.Click += new System.EventHandler(this.consultationCompleteToolStripMenuItem_Click);
            // 
            // ConfirmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 642);
            this.Controls.Add(this.dgvConfirmAppointment);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmAppointment";
            this.Load += new System.EventHandler(this.ConfirmAppointment_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmAppointment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConfirmAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationCompleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}