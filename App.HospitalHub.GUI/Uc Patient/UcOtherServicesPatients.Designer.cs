namespace App.HospitalHub.GUI
{
    partial class UcOtherServicesPatients
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All other Services";
            // 
            // dgvSeat
            // 
            this.dgvSeat.AllowUserToAddRows = false;
            this.dgvSeat.AllowUserToDeleteRows = false;
            this.dgvSeat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seat,
            this.cost});
            this.dgvSeat.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSeat.Location = new System.Drawing.Point(91, 102);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.ReadOnly = true;
            this.dgvSeat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeat.Size = new System.Drawing.Size(421, 117);
            this.dgvSeat.TabIndex = 21;
            // 
            // seat
            // 
            this.seat.DataPropertyName = "seat";
            this.seat.HeaderText = "Available Seat";
            this.seat.Name = "seat";
            this.seat.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost per Night";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tname,
            this.transCost});
            this.dgvTransport.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTransport.Location = new System.Drawing.Point(585, 102);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true;
            this.dgvTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransport.Size = new System.Drawing.Size(412, 254);
            this.dgvTransport.TabIndex = 22;
            // 
            // tname
            // 
            this.tname.DataPropertyName = "tName";
            this.tname.HeaderText = "Transport Name";
            this.tname.Name = "tname";
            this.tname.ReadOnly = true;
            // 
            // transCost
            // 
            this.transCost.DataPropertyName = "transCost";
            this.transCost.HeaderText = "Cost";
            this.transCost.Name = "transCost";
            this.transCost.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Available seat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(701, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Transportations";
            // 
            // UcOtherServicesPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTransport);
            this.Controls.Add(this.dgvSeat);
            this.Controls.Add(this.label1);
            this.Name = "UcOtherServicesPatients";
            this.Size = new System.Drawing.Size(1067, 434);
            this.Load += new System.EventHandler(this.UcOtherServicesPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn transCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
