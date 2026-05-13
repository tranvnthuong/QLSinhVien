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

            UserControl uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            tabDashboard.Controls.Add(uc);

            uc = new ucClasses();
            uc.Dock = DockStyle.Fill;
            tabClasses.Controls.Add(uc);

            uc = new ucSubjects();
            uc.Dock = DockStyle.Fill;
            tabSubjects.Controls.Add(uc);

            uc = new ucStudents();
            uc.Dock = DockStyle.Fill;
            tabStudents.Controls.Add(uc);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //frmLogin formLogin = new frmLogin();
            //if (formLogin.ShowDialog() == DialogResult.Cancel)
            //{
            //    Close();
            //    return;
            //}
        }
      
    }
}
