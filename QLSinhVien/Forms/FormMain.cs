using System;
using System.Windows.Forms;
using QLSinhVien.UserControls;

namespace QLSinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            UserControl uc = new ucClasses();
            uc.Dock = DockStyle.Fill;
            tabClasses.Controls.Add(uc);

            uc = new ucSubjects();
            uc.Dock = DockStyle.Fill;
            tabSubjects.Controls.Add(uc);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //frmLogin formLogin = new frmLogin();
            //if (formLogin.ShowDialog() == DialogResult.Cancel)
            //{
            //    Close();
            //    return;
            //}
            LoadDashboard();
        }
       

        private void LoadDashboard()
        {
            lblCountClasses.Text = DB.Scalar("SELECT COUNT(*) FROM Classes").ToString();
            lblCountSubjects.Text = DB.Scalar("SELECT COUNT(*) FROM Subjects").ToString();
            lblCountStudents.Text = DB.Scalar("SELECT COUNT(*) FROM Students").ToString();
            lblCountCourseRegistrations.Text = DB.Scalar("SELECT COUNT(*) FROM CourseRegistrations").ToString();
        }
    }
}
