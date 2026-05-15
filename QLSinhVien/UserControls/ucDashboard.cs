using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSinhVien.UserControls
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();

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
