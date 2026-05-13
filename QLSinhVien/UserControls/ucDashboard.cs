using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
