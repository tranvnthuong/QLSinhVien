using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
    public partial class ucSubjects : UserControl
    {
        public ucSubjects()
        {
            InitializeComponent();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            dgvSubjects.DataSource = DB.Query("SELECT * FROM Subjects");
            dgvSubjects.Columns["SubjectID"].HeaderText = "Mã Môn học";
            dgvSubjects.Columns["SubjectName"].HeaderText = "Tên Môn học";
            dgvSubjects.Columns["SubjectType"].HeaderText = "Kiểu Môn học";
            dgvSubjects.Columns["Credits"].HeaderText = "Số tín chỉ";
        }

        private string SubjectID { get => txtSubjectID.Text; set => txtSubjectID.Text = value; }
        private string SubjectName { get => txtSubjectName.Text; set => txtSubjectName.Text = value; }
        private string SubjectType { get => txtSubjectType.Text; set => txtSubjectType.Text = value; }
        private string Credits { get => txtCredits.Text; set => txtCredits.Text = value; }

        private bool ValidateInput()
        {
            int errors = 0;
            if (string.IsNullOrWhiteSpace(SubjectID))
            {
                errorProvider1.SetError(txtSubjectID, "Mã Môn học không được để trống");
                errors++;
            }
            if (string.IsNullOrWhiteSpace(SubjectName))
            {
                errorProvider1.SetError(txtSubjectName, "Tên Môn học không được để trống");
                errors++;
            }
            if (string.IsNullOrWhiteSpace(SubjectType))
            {
                errorProvider1.SetError(txtSubjectType, "Kiểu Môn học không được để trống");
                errors++;
            }
            if (string.IsNullOrWhiteSpace(Credits))
            {
                errorProvider1.SetError(txtCredits, "Tín chỉ không được để trống");
                errors++;
                if (int.TryParse(Credits, out int creditValue))
                {
                    if (creditValue <= 0)
                    {
                        errorProvider1.SetError(txtCredits, "Tín chỉ phải lớn hơn không (số dương)");
                        errors++;
                    }
                }
                else
                {
                    errorProvider1.SetError(txtCredits, "Tín chỉ phải là một số nguyên");
                    errors++;
                }
            }
            return errors == 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Subjects WHERE SubjectID = @SubjectID", new SqlParameter("@SubjectID", SubjectID));
                if (exist != null)
                {
                    MessageBox.Show("Môn học đã tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("INSERT INTO Subjects(SubjectID, SubjectName, SubjectType, Credits) VALUES (@SubjectID, @SubjectName, @SubjectType, @Credits)",
                    new SqlParameter("@SubjectID", SubjectID),
                    new SqlParameter("@SubjectName", SubjectName),
                    new SqlParameter("@SubjectType", SubjectType),
                    new SqlParameter("@Credits", Credits)
                );
                if (reslut > 0)
                {
                    LoadSubjects();
                    MessageBox.Show("Thêm thông tin Môn học thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin Môn học thất bại", "Lỗi chèn dữ liệu");
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

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Subjects WHERE SubjectID = @SubjectID", new SqlParameter("@SubjectID", SubjectID));
                if (exist == null)
                {
                    MessageBox.Show("Môn học không tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("UPDATE Subjects SET SubjectName = @SubjectName, SubjectType = @SubjectType, Credits = @Credits WHERE SubjectID = @SubjectID",
                    new SqlParameter("@SubjectID", SubjectID),
                    new SqlParameter("@SubjectName", SubjectName),
                    new SqlParameter("@SubjectType", SubjectType),
                    new SqlParameter("@Credits", Credits)
                );
                if (reslut > 0)
                {
                    LoadSubjects();
                    MessageBox.Show("Cập nhật thông tin Môn học thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin Môn học thất bại", "Lỗi cập nhật dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật dữ liệu {ex}", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCount = dgvSubjects.SelectedRows.Count;
            if (selectedCount > 0)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa {selectedCount} Môn học đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                int deletedRows = 0;
                foreach (DataGridViewRow row in dgvSubjects.SelectedRows)
                {
                    try
                    {
                        string SubjectID = row.Cells["SubjectID"].Value.ToString();
                        int result = DB.Execute("DELETE FROM Subjects WHERE SubjectID = @SubjectID",
                           new SqlParameter("@SubjectID", SubjectID)
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
                    LoadSubjects();
                    MessageBox.Show($"Đã xóa {deletedRows} Môn học", "Thông báo");
                }
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra e.RowIndex để tránh lỗi khi người dùng click vào phần Header (tiêu đề cột)
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                // 2. Truy cập vào hàng hiện tại được click
                DataGridViewRow row = dgvSubjects.Rows[rowIndex];

                // 3. Trích xuất dữ liệu từ các ô (Cells)
                // Bạn có thể dùng tên cột (Column Name) hoặc vị trí (Index)
                SubjectID = row.Cells["SubjectID"].Value.ToString();
                SubjectName = row.Cells["SubjectName"].Value.ToString();
                SubjectType = row.Cells["SubjectType"].Value.ToString();
                Credits = row.Cells["Credits"].Value.ToString();
            }
        }
    }
}
