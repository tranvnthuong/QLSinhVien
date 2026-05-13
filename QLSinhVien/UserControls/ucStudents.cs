using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
    public partial class ucStudents : UserControl
    {
        public ucStudents()
        {
            InitializeComponent();
            LoadCboClasses();
            LoadStudents();
        }

        private void LoadCboClasses()
        {
            cboClasses.DataSource = DB.Query("SELECT * FROM Classes");
            cboClasses.DisplayMember = "ClassName";
            cboClasses.ValueMember = "ClassID";
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = DB.Query("SELECT s.*, c.ClassName FROM Students s LEFT JOIN Classes c ON s.ClassID = c.ClassID");
            dgvStudents.Columns["StudentID"].HeaderText = "Mã Sinh viên";
            dgvStudents.Columns["FullName"].HeaderText = "Tên Sinh viên";
            dgvStudents.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvStudents.Columns["Gender"].HeaderText = "Giới tính";
            dgvStudents.Columns["AvatarPath"].HeaderText = "Ảnh đại diện";
            dgvStudents.Columns["ClassName"].HeaderText = "Tên Lớp học";
        }

        private string StudentID { get => txtStudentID.Text; set => txtStudentID.Text = value; }
        private string FullName { get => txtFullName.Text; set => txtFullName.Text = value; }
        private DateTime DateOfBirth { get => dtpDateOfBirth.Value; set => dtpDateOfBirth.Value = value; }
        private int Gender { get => cboGender.SelectedIndex; set => cboGender.SelectedIndex = value; }
        private string ClassID { get => cboClasses.SelectedValue.ToString(); set => cboClasses.SelectedValue = value; }
        private string AvatarPath { get => txtAvatarPath.Text; set => txtAvatarPath.Text = value; }

        private void ClearError()
        {
            errorProvider1.SetError(txtStudentID, "");
            errorProvider1.SetError(txtFullName, "");
            errorProvider1.SetError(dtpDateOfBirth, "");
            errorProvider1.SetError(cboGender, "");
            errorProvider1.SetError(cboClasses, "");
        }

        private void ClearInput()
        {
            StudentID = "";
            FullName = "";
            DateOfBirth = new DateTime(1900, 10, 10);
            Gender = 0;
            ClassID = "";
        }

        private bool ValidateInput()
        {
            int errors = 0;
            if (string.IsNullOrWhiteSpace(StudentID))
            {
                errorProvider1.SetError(txtStudentID, "Mã Sinh viên không được để trống");
                errors++;
            }
            if (string.IsNullOrWhiteSpace(FullName))
            {
                errorProvider1.SetError(txtFullName, "Tên Sinh viên không được để trống");
                errors++;
            }
            if (DateOfBirth == new DateTime(1900, 10, 10))
            {
                errorProvider1.SetError(dtpDateOfBirth, "Vui lòng chọn ngày sinh");
                errors++;
            }
            if (string.IsNullOrEmpty(ClassID))
            {
                errorProvider1.SetError(cboClasses, "Vui lòng chọn lớp học");
                errors++;
            }
            return errors == 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            ClearError();

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Students WHERE StudentID = @StudentID", new SqlParameter("@StudentID", StudentID));
                if (exist != null)
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("INSERT INTO Students(StudentID, FullName, DateOfBirth, Gender, AvatarPath, ClassID) VALUES (@StudentID, @FullName, @DateOfBirth, @Gender, @AvatarPath, @ClassID)",
                    new SqlParameter("@StudentID", StudentID),
                    new SqlParameter("@FullName", FullName),
                    new SqlParameter("@DateOfBirth", DateOfBirth),
                    new SqlParameter("@Gender", Gender),
                    new SqlParameter("@AvatarPath", ""),
                    new SqlParameter("@ClassID", ClassID)
                );
                if (reslut > 0)
                {
                    ClearInput();
                    LoadStudents();
                    MessageBox.Show("Thêm thông tin Sinh viên thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin Sinh viên thất bại", "Lỗi chèn dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thêm dữ liệu {ex}", "Thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            ClearError();

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Students WHERE StudentID = @StudentID", new SqlParameter("@StudentID", StudentID));
                if (exist == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, AvatarPath = @AvatarPath, ClassID = @ClassID WHERE StudentID = @StudentID",
                    new SqlParameter("@StudentID", StudentID),
                    new SqlParameter("@FullName", FullName),
                    new SqlParameter("@DateOfBirth", DateOfBirth),
                    new SqlParameter("@Gender", Gender),
                    new SqlParameter("@AvatarPath", ""),
                    new SqlParameter("@ClassID", ClassID)
                );

                if (reslut > 0)
                {
                    ClearInput();
                    LoadStudents();
                    MessageBox.Show("Cập nhật thông tin Sinh viên thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin Sinh viên thất bại", "Lỗi cập nhật dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật dữ liệu {ex}", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCount = dgvStudents.SelectedRows.Count;
            if (selectedCount > 0)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa {selectedCount} Sinh viên đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                int deletedRows = 0;
                foreach (DataGridViewRow row in dgvStudents.SelectedRows)
                {
                    try
                    {
                        string StudentID = row.Cells["StudentID"].Value.ToString();
                        int result = DB.Execute("DELETE FROM Students WHERE StudentID = @StudentID",
                           new SqlParameter("@StudentID", StudentID)
                        );
                        if (result > 0)
                            deletedRows++;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa dữ liệu: {ex}", "Lỗi ngoại lệ");
                        return;
                    }
                }

                if (deletedRows > 0)
                {
                    LoadStudents();
                    MessageBox.Show($"Đã xóa {deletedRows} Sinh viên", "Thông báo");
                }
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra e.RowIndex để tránh lỗi khi người dùng click vào phần Header (tiêu đề cột)
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                // 2. Truy cập vào hàng hiện tại được click
                DataGridViewRow row = dgvStudents.Rows[rowIndex];

                // 3. Trích xuất dữ liệu từ các ô (Cells)
                // Bạn có thể dùng tên cột (Column Name) hoặc vị trí (Index)
                StudentID = row.Cells["StudentID"].Value.ToString();
                FullName = row.Cells["FullName"].Value.ToString();
                DateOfBirth = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                Gender = int.Parse(row.Cells["Gender"].Value.ToString());
                AvatarPath = row.Cells["AvatarPath"].Value.ToString();
                ClassID = row.Cells["ClassID"].Value.ToString();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearError();
            ClearInput();
        }

        private void txtAvatarPath_Enter(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAvatarPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
