namespace App.HospitalHub.GUI
{
    partial class UcFoodPatientView
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.breakfast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Our Food Menu";
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breakfast,
            this.lunch,
            this.snacks,
            this.dinner});
            this.dgvFood.Location = new System.Drawing.Point(149, 67);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.Size = new System.Drawing.Size(756, 329);
            this.dgvFood.TabIndex = 3;
            // 
            // breakfast
            // 
            this.breakfast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.breakfast.DataPropertyName = "breakfast";
            this.breakfast.HeaderText = "Breakfast";
            this.breakfast.Name = "breakfast";
            this.breakfast.ReadOnly = true;
            // 
            // lunch
            // 
            this.lunch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lunch.DataPropertyName = "lunch";
            this.lunch.HeaderText = "Lunch";
            this.lunch.Name = "lunch";
            this.lunch.ReadOnly = true;
            // 
            // snacks
            // 
            this.snacks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.snacks.DataPropertyName = "snacks";
            this.snacks.HeaderText = "Snacks";
            this.snacks.Name = "snacks";
            this.snacks.ReadOnly = true;
            // 
            // dinner
            // 
            this.dinner.DataPropertyName = "dinner";
            this.dinner.HeaderText = "Dinner";
            this.dinner.Name = "dinner";
            this.dinner.ReadOnly = true;
            // 
            // UcFoodPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFood);
            this.Name = "UcFoodPatientView";
            this.Size = new System.Drawing.Size(1067, 434);
            this.Load += new System.EventHandler(this.UcFoodPatientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn snacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner;
    }
}
