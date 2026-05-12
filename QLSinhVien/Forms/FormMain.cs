using QLSinhVien.Forms;
using QLSinhVien.MiniServices;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //frmLogin formLogin = new frmLogin();
            //if (formLogin.ShowDialog() == DialogResult.Cancel)
            //{
            //    Close();
            //    return;
            //}

            lblAppTitle.Text = "Quản lý Sinh viên";
        }
       

        private void LoadDashboard()
        {
            lblCountClasses.Text = DB.Scalar("SELECT COUNT(*) FROM Classes").ToString();
            lblCountSubjects.Text = DB.Scalar("SELECT COUNT(*) FROM Subjects").ToString();
            lblCountStudents.Text = DB.Scalar("SELECT COUNT(*) FROM Students").ToString();
            lblCountCourseRegistrations.Text = DB.Scalar("SELECT COUNT(*) FROM CourseRegistrations").ToString();
        }

        private void LoadClasses()
        {
            dgvClasses.DataSource = DB.Query("SELECT * FROM Classes");
            dgvClasses.Columns["ClassID"].HeaderText = "Mã lớp";
            dgvClasses.Columns["ClassName"].HeaderText = "Tên Lớp";
            dgvClasses.Columns["Department"].HeaderText = "Khoa";
        }

        private void LoadSubjects()
        {
            dgvSubjects.DataSource = DB.Query("SELECT * FROM Subjects");
            dgvSubjects.Columns["SubjectID"].HeaderText = "Mã môn học";
            dgvSubjects.Columns["SubjectName"].HeaderText = "Tên môn";
            dgvSubjects.Columns["SubjectType"].HeaderText = "Kiểu môn học";
            dgvSubjects.Columns["Credits"].HeaderText = "Só tín chỉ";
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = DB.Query("SELECT * FROM Students");
            dgvStudents.Columns["StudentID"].HeaderText = "Mã học sinh";    
            dgvStudents.Columns["FullName"].HeaderText = "Họ tên đầy đủ";
            dgvStudents.Columns["DateOfBirth"].HeaderText = "Sinh nhật";
            dgvStudents.Columns["AvatarPath"].HeaderText = "Đường dẫn";
            dgvStudents.Columns["ClassID"].HeaderText = "Mã lớp học";
        }

        private void LoadCourseRegistration()
        {
            dgvCourseRegistration.DataSource = DB.Query("SELECT * FROM CourseRegistrations");
            dgvCourseRegistration.Columns["StudentID"].HeaderText = "Mã học sinh";
            dgvCourseRegistration.Columns["SubjectID"].HeaderText = "Mã môn học";
            dgvCourseRegistration.Columns["RegistrationDate"].HeaderText = "Kiểu môn học";
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabDashboard)
            {
                lblAppTitle.Text = "Quản lý Sinh viên";
                LoadDashboard();
            }
            else if (tabControl1.SelectedTab == tabClasses)
            {
                lblAppTitle.Text = "Quản lý lớp học";
                LoadClasses();
            }
            else if (tabControl1.SelectedTab == tabSubjects)
            {
                lblAppTitle.Text = "Quản lý môn học";
                LoadSubjects();
            }
            else if (tabControl1.SelectedTab == tabStudents)
            {
                lblAppTitle.Text = "Quản lý hồ sơ Sinh viên";
                LoadStudents();
            }
            else if (tabControl1.SelectedTab == tabCourseRegistration)
            {
                lblAppTitle.Text = "Quản lý môn học đăng ký";
                LoadCourseRegistration();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ServiceResult result = ClassesService.AddClass(txtClassID.Text, txtClassName.Text, txtDepartment.Text);
            MessageBox.Show(result.Message, result.Tile);
            LoadClasses();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            ServiceResult result = ClassesService.EditClass(txtClassID.Text, txtClassName.Text, txtDepartment.Text);
            MessageBox.Show(result.Message, result.Tile);
            LoadClasses();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                int deletedRows = 0;
                foreach (DataGridViewRow row in dgvClasses.SelectedRows)
                {
                    string classID = row.Cells["ClassID"].Value.ToString();
                    ServiceResult result = ClassesService.DeleteClass(classID);
                    if (result.Success)
                        deletedRows++;
                    if (result.Except)
                    {
                        MessageBox.Show(result.Message, result.Tile);
                        return;
                    }
                }

                if (deletedRows > 0)
                {
                    MessageBox.Show($"Đã xóa {deletedRows} mục", "Thông báo");
                    LoadClasses();
                }
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra e.RowIndex để tránh lỗi khi người dùng click vào phần Header (tiêu đề cột)
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                // 2. Truy cập vào hàng hiện tại được click
                DataGridViewRow row = dgvClasses.Rows[rowIndex];

                // 3. Trích xuất dữ liệu từ các ô (Cells)
                // Bạn có thể dùng tên cột (Column Name) hoặc vị trí (Index)
                txtClassID.Text = row.Cells["ClassID"].Value.ToString();
                txtClassName.Text = row.Cells["ClassName"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }
    }
}
