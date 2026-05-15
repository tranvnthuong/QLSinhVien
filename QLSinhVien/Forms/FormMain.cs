using QLSinhVien.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            uc = new ucCourseRegistrations();
            uc.Dock = DockStyle.Fill;
            tabCourseRegistration.Controls.Add(uc);

            //tabControl1.Alignment = TabAlignment.Left;
            //tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            //tabControl1.SizeMode = TabSizeMode.Fixed;
            //tabControl1.ItemSize = new Size(50, 160);

            //tabControl1.DrawItem += tabControl1_DrawItem;
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

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabControl1.TabPages[e.Index];

            Rectangle rect = e.Bounds;

            // nền tab
            Brush bg = Brushes.LightGray;
            if (e.Index == tabControl1.SelectedIndex)
                bg = Brushes.LightBlue;

            g.FillRectangle(bg, rect);

            // chữ ngang
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(tp.Text, this.Font, Brushes.Black, rect, sf);
        }

    }
}
