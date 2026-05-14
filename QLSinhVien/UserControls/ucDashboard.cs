using System;
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
            int classes = (int)DB.Scalar("SELECT COUNT(*) FROM Classes");

            int subjects = (int)DB.Scalar("SELECT COUNT(*) FROM Subjects");

            int students = (int)DB.Scalar("SELECT COUNT(*) FROM Students");

            int registrations = (int)DB.Scalar("SELECT COUNT(*) FROM CourseRegistrations");

            lblCountClasses.Text = classes.ToString();
            lblCountSubjects.Text = subjects.ToString();
            lblCountStudents.Text = students.ToString();
            lblCountCourseRegistrations.Text = registrations.ToString();
        }
    }
}
