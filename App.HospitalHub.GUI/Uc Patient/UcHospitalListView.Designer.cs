namespace App.HospitalHub.GUI
{
    partial class UcHospitalListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHospitalList = new System.Windows.Forms.DataGridView();
            this.hospitalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.tbSearch);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 113);
            this.pnlTop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Info";
            // 
            // dgvHospitalList
            // 
            this.dgvHospitalList.AllowUserToAddRows = false;
            this.dgvHospitalList.AllowUserToDeleteRows = false;
            this.dgvHospitalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHospitalList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHospitalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHospitalList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHospitalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hospitalId,
            this.name,
            this.phone,
            this.Division,
            this.District,
            this.area,
            this.road,
            this.house});
            this.dgvHospitalList.Location = new System.Drawing.Point(82, 186);
            this.dgvHospitalList.Name = "dgvHospitalList";
            this.dgvHospitalList.ReadOnly = true;
            this.dgvHospitalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalList.Size = new System.Drawing.Size(898, 379);
            this.dgvHospitalList.TabIndex = 7;
            this.dgvHospitalList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospitalList_CellClick);
            this.dgvHospitalList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospitalList_CellContentDoubleClick);
            // 
            // hospitalId
            // 
            this.hospitalId.DataPropertyName = "hospitalId";
            this.hospitalId.HeaderText = "Hospital ID";
            this.hospitalId.Name = "hospitalId";
            this.hospitalId.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Division
            // 
            this.Division.DataPropertyName = "division";
            this.Division.HeaderText = "division";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            // 
            // District
            // 
            this.District.DataPropertyName = "district";
            this.District.HeaderText = "district";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // road
            // 
            this.road.DataPropertyName = "road";
            this.road.HeaderText = "Road No";
            this.road.Name = "road";
            this.road.ReadOnly = true;
            // 
            // house
            // 
            this.house.DataPropertyName = "house";
            this.house.HeaderText = "House No";
            this.house.Name = "house";
            this.house.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(184)))), ((int)(((byte)(243)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSearch.Location = new System.Drawing.Point(774, 64);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(206, 22);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UcHospitalListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHospitalList);
            this.Controls.Add(this.pnlTop);
            this.Name = "UcHospitalListView";
            this.Size = new System.Drawing.Size(1067, 642);
            this.Load += new System.EventHandler(this.UcHospitalListView_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHospitalList;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn road;
        private System.Windows.Forms.DataGridViewTextBoxColumn house;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
