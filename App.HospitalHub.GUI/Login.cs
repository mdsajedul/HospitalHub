using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Repo;
using App.HospitalHub.Entity;
using App.HospitalHub.Framework;
using System.Data.SqlClient;


namespace App.HospitalHub.GUI
{
    public partial class Login : Form
    {
        Point lastPoint;
        LoginRepo loginRepo = new LoginRepo();
        PatientRepo patientRepo = new PatientRepo();
        CoordinatorRepo coordinatorRepo = new CoordinatorRepo();
        CurrentUserRepo userRepo = new CurrentUserRepo();
        //private DelegateClassForPatient.LoginDelegate ld;
        public static string username;

        public Login()
        {
            InitializeComponent();
            
        }


        private void Login_Load(object sender, EventArgs e)
        {


           pnlBody.BackColor = Color.FromArgb(20,20, 20, 40);
           

            string pnlBodyPic = "E:\\Study\\ProjectC#\\App.HospitalHub.Sln\\App.HospitalHub.GUI\\bin\\Image\\backg.jpg";

            pnlBody.BackgroundImage = Image.FromFile(pnlBodyPic);

        }

       

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

            string userPath = "E:\\Study\\ProjectC#\\App.HospitalHub.Sln\\App.HospitalHub.GUI\\bin\\Image\\user.png";
            this.pbUser.Image = Image.FromFile(userPath);

            string passwordPath = "E:\\Study\\ProjectC#\\App.HospitalHub.Sln\\App.HospitalHub.GUI\\bin\\Image\\password.png";
            this.pbPassword.Image = Image.FromFile(passwordPath);
            tbUser.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

       

        private void tbUser_ModifiedChanged(object sender, EventArgs e)
        {
            tbUser.Clear();
        }

        private void tbPassword_ModifiedChanged(object sender, EventArgs e)
        {
            tbPassword.Clear();
            tbPassword.PasswordChar = '•';
        }

       
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            AdminLogin aLogin = new AdminLogin();
            aLogin.username = tbUser.Text;
            aLogin.password = tbPassword.Text;

            Patient patient = new Patient();
            patient.username = tbUser.Text;
            patient.password = tbPassword.Text;

            Coordinator coordinator = new Coordinator();
            coordinator.username = tbUser.Text;
            coordinator.password=tbPassword.Text;

            CurrentUserValue currentUser = new CurrentUserValue();
            currentUser.currentUser = tbUser.Text;

            username = tbUser.Text;

            if (tbUser.Text == "")
            {
                MessageBox.Show("Username required!", "Login Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Password required!", "Login validation",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool b = loginRepo.LoginAdmin(aLogin);
                bool bp = patientRepo.PatientLogin(patient);
                bool bc = coordinatorRepo.CoordinatorLogin(coordinator);
                bool c = userRepo.CurrentUserStore(currentUser);


               
               

                if (b == true && c==true)
                {
                    MessageBox.Show("Login Successful admin");
                    this.Hide();
                    ManagementDashboard management = new ManagementDashboard();
                    management.Show();
                    this.Hide();
                }
                else if (bp == true && c==true)
                {
                    MessageBox.Show("Login Successful Patient");
                   
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else if (bc == true && c==true)
                {
                    
                    MessageBox.Show("Login Successful Coordinator");
                    this.Hide();
                    DashboardCoordinator dashboardCoordinator = new DashboardCoordinator();
                    dashboardCoordinator.Show();
                    
                  
                }
                else
                    MessageBox.Show("Login Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
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

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
               // if(tbUser.Text=="") MessageBox.Show("Username required!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLogin_Click(sender, e);
            }
        }
    }
}
