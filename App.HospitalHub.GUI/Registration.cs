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
   
    public partial class Registration : Form
    {
        Point lastPoint;

        public Registration()
        {
            InitializeComponent();
        }

       

        private void btnOrdinator_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnOrdinator.Height;
            pnlLeft.Top = btnOrdinator.Top;

            ucRegistrationPatient1.Hide();
            ucOrdinatorReg1.Show();
            ucOrdinatorReg1.BringToFront();
           
        }

       

        private void Registration_Load(object sender, EventArgs e)
        {
            ucRegistrationPatient1.Show();
            ucOrdinatorReg1.Hide();

        }

        private void ucOrdinatorReg1_Load(object sender, EventArgs e)
        {

        }

        private void ucRegistrationPatient1_Load(object sender, EventArgs e)
        {

        }

      


        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            pnlLeft.Height = btnPatient.Height;
            pnlLeft.Top = btnPatient.Top;

            ucOrdinatorReg1.Hide();
            ucRegistrationPatient1.Show();
            ucRegistrationPatient1.BringToFront();
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
