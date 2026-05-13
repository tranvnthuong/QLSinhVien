using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
    public partial class ucCourseRegistrations : UserControl
    {
        public ucCourseRegistrations()
        {
            InitializeComponent();

            LoadStudentsToComboBox();
            LoadSubjectsToComboBox();
            LoadCourseRegistrations();
        }

        private void LoadStudentsToComboBox()
        {
            cboStudents.DataSource = DB.Query("SELECT StudentID, FullName FROM Students");
            cboStudents.DisplayMember = "FullName";
            cboStudents.ValueMember = "StudentID";
        }

        private void LoadSubjectsToComboBox()
        {
            cboSubjects.DataSource = DB.Query("SELECT SubjectID, SubjectName FROM Subjects");
            cboSubjects.DisplayMember = "SubjectName";
            cboSubjects.ValueMember = "SubjectID";
        }

        private void LoadCourseRegistrations()
        {
            string sql = @"
                SELECT cr.StudentID,
                    cr.SubjectID,
                    sd.FullName,
                    sj.SubjectName,
                    cr.RegistrationDate
                FROM CourseRegistrations cr
                LEFT JOIN Students sd ON cr.StudentID = sd.StudentID
                LEFT JOIN Subjects sj ON cr.SubjectID = sj.SubjectID
            ";
            dgvCourseRegistrations.DataSource = DB.Query(sql);
            dgvCourseRegistrations.Columns["StudentID"].HeaderText = "Mã Sinh viên";
            dgvCourseRegistrations.Columns["FullName"].HeaderText = "Tên Sinh viên";
            dgvCourseRegistrations.Columns["SubjectID"].HeaderText = "Mã Môn học";
            dgvCourseRegistrations.Columns["SubjectName"].HeaderText = "Tên Môn học";
            dgvCourseRegistrations.Columns["RegistrationDate"].HeaderText = "Ngày đăng ký";
        }

        private string StudentID { get => cboStudents.SelectedValue.ToString(); set => cboStudents.SelectedValue = value; }
        private string SubjectID { get => cboSubjects.SelectedValue.ToString(); set => cboSubjects.SelectedValue = value; }

        private void ClearInput()
        {
            cboStudents.SelectedIndex = -1;
            cboSubjects.SelectedIndex = -1;
        }

        private bool ValidateInput()
        {
			int errors = 0;
            if (cboStudents.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboStudents, "Vui lòng chọn Sinh viên");
                errors++;
            }
            else
            {
				errorProvider1.SetError(cboStudents, string.Empty);
			}

            if (cboSubjects.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboSubjects, "Vui lòng chọn Môn học");
                errors++;
            }
            else
			{
				errorProvider1.SetError(cboSubjects, string.Empty);
			}

			return errors == 0;
        }

        private bool CheckSubjectTypeLimit(int limit, string type)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM CourseRegistrations cr
                JOIN Subjects sj ON cr.SubjectID = sj.SubjectID
                WHERE sj.SubjectType = @type
            ";
            var crLimit = DB.Scalar(sql, new SqlParameter("@type", type));
            if (crLimit != null && (int)crLimit >= limit)
            {
                MessageBox.Show($"Môn {type} đã đạt tối đa, không thể đăng ký", "Thông báo");
                return true;
            }
            return false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM CourseRegistrations WHERE StudentID = @StudentID",
                    new SqlParameter("@StudentID", StudentID)
                );
                if (exist != null)
                {
                    MessageBox.Show("Mỗi Sinh viên chỉ được phép đăng ký Một Môn học", "Thông báo");
                    return;
                }

                if (CheckSubjectTypeLimit(60, "Lý thuyết")) return;

                if (CheckSubjectTypeLimit(30, "Thực hành")) return;

                if (CheckSubjectTypeLimit(30, "Tích hợp")) return;

                int reslut = DB.Execute("INSERT INTO CourseRegistrations(StudentID, SubjectID) VALUES (@StudentID, @SubjectID)",
                    new SqlParameter("@StudentID", StudentID),
                    new SqlParameter("@SubjectID", SubjectID)
                );
                if (reslut > 0)
                {
                    ClearInput();
                    LoadCourseRegistrations();
                    MessageBox.Show("Đã đăng ký Môn học Cho Sinh viên", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đăng ký Môn học Cho Sinh viên thất bại", "Lỗi chèn dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thêm dữ liệu {ex.Message}", "Lỗi ngoại lệ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM CourseRegistrations WHERE StudentID = @StudentID",
                   new SqlParameter("@StudentID", StudentID)
                );
                if (exist == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại trong danh sách Đăng ký môn học", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("UPDATE CourseRegistrations SET SubjectID = @SubjectID WHERE StudentID = @StudentID",
                    new SqlParameter("@SubjectID", SubjectID),
                    new SqlParameter("@StudentID", StudentID)
                );
                if (reslut > 0)
                {
                    ClearInput();
                    LoadCourseRegistrations();
                    MessageBox.Show("Đã cập nhật Môn học đăng ký cho Sinh viên", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật Môn học đăng ký cho Sinh viên thất bại", "Lỗi cập nhật dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật dữ liệu {ex.Message}", "Lỗi ngoại lệ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCount = dgvCourseRegistrations.SelectedRows.Count;
            if (selectedCount > 0)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa {selectedCount} Đăng ký môn học đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                int deletedRows = 0;
                foreach (DataGridViewRow row in dgvCourseRegistrations.SelectedRows)
                {
                    try
                    {
                        string StudentID = row.Cells["StudentID"].Value.ToString();
                        int result = DB.Execute("DELETE FROM CourseRegistrations WHERE StudentID = @StudentID",
                           new SqlParameter("@StudentID", StudentID)
                        );
                        if (result > 0)
                            deletedRows++;
                    }
                    catch (SqlException ex)
                    {
                        // Foreign key constraint
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Không thể xóa vì dữ liệu đang được sử dụng", "Lỗi ràng buộc");
                        }
                        else
                        {
                            MessageBox.Show($"Có lỗi xảy ra khi xóa dữ liệu: {ex.Message}", "Lỗi ngoại lệ");
                        }
                        return;
                    }
                }

                if (deletedRows > 0)
                {
                    LoadCourseRegistrations();
                    MessageBox.Show($"Đã xóa {deletedRows} Đăng ký môn học", "Thông báo");
                }
            }
        }

        private void dgvCourseRegistrations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvCourseRegistrations.Rows[rowIndex];
                StudentID = row.Cells["StudentID"].Value.ToString();
                SubjectID = row.Cells["SubjectID"].Value.ToString();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            LoadStudentsToComboBox();
            LoadSubjectsToComboBox();
            ClearInput();
        }
    }
}
