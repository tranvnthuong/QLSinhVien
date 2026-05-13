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

            LoadOptionalPieChart(classes, subjects, students, registrations);
        }

        private void LoadOptionalPieChart(int classes, int subjects, int students, int registrations)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            Series series = new Series
            {
                Name = "Overview",
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Lớp học", classes);
            series.Points.AddXY("Môn học", subjects);
            series.Points.AddXY("Sinh viên", students);
            series.Points.AddXY("Đăng ký Môn học", registrations);

            series.IsValueShownAsLabel = true;

            chart1.Series.Add(series);

            chart1.Legends[0].Enabled = true;

            chart1.Titles.Add("Tổng quan hệ thống");
        }
    }
}
