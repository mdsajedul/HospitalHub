using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.HospitalHub.GUI
{
    public partial class ManagementDashboard : Form
    {
        Point lastPoint;
       
        public ManagementDashboard()
        {
            InitializeComponent();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            ucPatientLists1.Hide();
            ucHospitalList1.Show();
            ucHospitalList1.BringToFront();
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ManagementDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ucHospitalList1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucHospitalList1.Hide();
            ucPatientLists1.Show();
            ucPatientLists1.BringToFront();
        }
    }
}
