using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
    public partial class ucStudents : UserControl
    {

        public ucStudents()
        {
            InitializeComponent();

            LoadClassesToComboBox();
            LoadStudents();
        }

        private string SaveImage(string fullPath)
        {
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

            string fileName = Path.GetFileName(fullPath);

            string destinationPath = Path.Combine(imagesFolder, fileName);

            try
            {
                if (!fullPath.Equals(destinationPath, StringComparison.OrdinalIgnoreCase))
                {
                    File.Copy(fullPath, destinationPath, true);
                }
            }
            catch
            {
            }

            return @"Images\" + fileName;

        }

        private void LoadClassesToComboBox()
        {
            cboClasses.DataSource = DB.Query("SELECT * FROM Classes");
            cboClasses.DisplayMember = "ClassName";
            cboClasses.ValueMember = "ClassID";
        }

        private void LoadStudents()
        {
            string sql = @"
            SELECT s.StudentID,
                s.FullName,
                CASE
                    WHEN s.Gender = 0 THEN N'Nữ'
                    WHEN s.Gender = 1 THEN N'Nam'
                END AS Gender,
                s.DateOfBirth,
                s.ClassID,
                c.ClassName,
                s.AvatarPath
            FROM Students s
                LEFT JOIN Classes c 
                ON s.ClassID = c.ClassID
            ";
            dgvStudents.DataSource = DB.Query(sql);
            dgvStudents.Columns["StudentID"].HeaderText = "Mã Sinh viên";
            dgvStudents.Columns["FullName"].HeaderText = "Tên Sinh viên";
            dgvStudents.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvStudents.Columns["Gender"].HeaderText = "Giới tính";
            dgvStudents.Columns["ClassID"].HeaderText = "Mã Lớp học";
            dgvStudents.Columns["ClassName"].HeaderText = "Tên Lớp học";
            dgvStudents.Columns["AvatarPath"].HeaderText = "Ảnh đại diện";
        }

        private string StudentID { get => txtStudentID.Text; set => txtStudentID.Text = value; }
        private string FullName { get => txtFullName.Text; set => txtFullName.Text = value; }
        private DateTime DateOfBirth { get => dtpDateOfBirth.Value; set => dtpDateOfBirth.Value = value; }
        private int Gender { get => cboGender.SelectedIndex; set => cboGender.SelectedIndex = value; }
        private string ClassID { get => cboClasses.SelectedValue.ToString(); set => cboClasses.SelectedValue = value; }
        private string AvatarPath { get => txtAvatarPath.Text; set => txtAvatarPath.Text = value; }

        private void ClearInput()
        {
            StudentID = string.Empty;
            FullName = string.Empty;
            DateOfBirth = new DateTime(1900, 10, 10);
            Gender = -1;
            cboClasses.SelectedIndex = -1;
            AvatarPath = string.Empty;
            picAvatar.Image = null;
        }

        private bool ValidateInput()
        {
            // Code Mỳ Ý
            int errors = 0;
            if (string.IsNullOrWhiteSpace(StudentID))
            {
                errorProvider1.SetError(txtStudentID, "Mã Sinh viên không được để trống");
                errors++;
            }
            else
            {
                errorProvider1.SetError(txtStudentID, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(FullName))
            {
                errorProvider1.SetError(txtFullName, "Tên Sinh viên không được để trống");
                errors++;
            }
            else
            {
                errorProvider1.SetError(txtFullName, string.Empty);
            }

            if (DateOfBirth == new DateTime(1900, 10, 10))
            {
                errorProvider1.SetError(dtpDateOfBirth, "Vui lòng chọn ngày sinh");
                errors++;
            }
            else
            {
                errorProvider1.SetError(dtpDateOfBirth, string.Empty);
            }

            if (Gender == -1)
            {
                errorProvider1.SetError(cboGender, "Vui lòng chọn giới tính");
                errors++;
            }
            else
            {
                errorProvider1.SetError(cboGender, string.Empty);
            }

            if (cboClasses.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboClasses, "Vui lòng chọn lớp học");
                errors++;
            }
            else
            {
                errorProvider1.SetError(cboClasses, string.Empty);
            }

            return errors == 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var classLimit = DB.Scalar("SELECT COUNT(*) FROM Students WHERE ClassID = @ClassID", new SqlParameter("@ClassID", ClassID));
                if (classLimit != null && (int)classLimit >= 60)
                {
                    MessageBox.Show("Lớp đã đạt tối đa thành viên", "Thông báo");
                    return;
                }

                var exist = DB.Scalar("SELECT 1 FROM Students WHERE StudentID = @StudentID", new SqlParameter("@StudentID", StudentID));
                if (exist != null)
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Thông báo");
                    return;
                }

                // Đường dẫn tương đối + tên file
                string relativePath = SaveImage(AvatarPath);

                int reslut = DB.Execute("INSERT INTO Students(StudentID, FullName, DateOfBirth, Gender, AvatarPath, ClassID) VALUES (@StudentID, @FullName, @DateOfBirth, @Gender, @AvatarPath, @ClassID)",
                    new SqlParameter("@StudentID", StudentID),
                    new SqlParameter("@FullName", FullName),
                    new SqlParameter("@DateOfBirth", DateOfBirth),
                    new SqlParameter("@Gender", Gender),
                    new SqlParameter("@AvatarPath", relativePath),
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
                MessageBox.Show($"Có lỗi xảy ra khi thêm dữ liệu {ex.Message}", "Lỗi ngoại lệ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Students WHERE StudentID = @StudentID", new SqlParameter("@StudentID", StudentID));
                if (exist == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Thông báo");
                    return;
                }

                string relativePath = SaveImage(AvatarPath);

                int reslut = DB.Execute("UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, AvatarPath = @AvatarPath, ClassID = @ClassID WHERE StudentID = @StudentID",
                    new SqlParameter("@StudentID", StudentID),
                    new SqlParameter("@FullName", FullName),
                    new SqlParameter("@DateOfBirth", DateOfBirth),
                    new SqlParameter("@Gender", Gender),
                    new SqlParameter("@AvatarPath", relativePath),
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
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật dữ liệu {ex.Message}", "Lỗi ngoại lệ");
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
                    LoadStudents();
                    MessageBox.Show($"Đã xóa {deletedRows} Sinh viên", "Thông báo");
                }
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[rowIndex];
                StudentID = row.Cells["StudentID"].Value.ToString();
                FullName = row.Cells["FullName"].Value.ToString();
                DateOfBirth = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                Gender = row.Cells["Gender"].Value.ToString() == "Nữ" ? 0 : 1;
                ClassID = row.Cells["ClassID"].Value.ToString();
                AvatarPath = row.Cells["AvatarPath"].Value.ToString();
                if (!string.IsNullOrEmpty(AvatarPath))
                {
                    if (File.Exists(AvatarPath))
                    {
                        picAvatar.Image?.Dispose();

                        using (FileStream fs = new FileStream(AvatarPath, FileMode.Open, FileAccess.Read))
                        {
                              picAvatar.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        picAvatar.Image?.Dispose();
                        picAvatar.Image = null;
                    }
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            LoadClassesToComboBox();
            ClearInput();
            LoadStudents();
        }

        private void txtAvatarPath_Enter(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = openFileDialog1.FileName;

                    FileInfo fi = new FileInfo(fullPath);
                    if (fi.Exists && fi.Length > 2_000_000)
                    {
                        MessageBox.Show("Ảnh không được phép vượt quá 2MB");
                        return;
                    }

                    // Giải phóng ảnh cũ
                    picAvatar.Image?.Dispose();

                    // Dùng using để tránh lock file ảnh
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(fs);
                    }

                    AvatarPath = fullPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi thao tác với File: {ex.Message}", "Lỗi ngoại lệ");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string escapeString = txtSearch.Text
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");
            (dgvStudents.DataSource as DataTable).DefaultView
                .RowFilter = $"StudentID = '{escapeString}' OR ClassID = '{escapeString}' OR FullName LIKE '%{escapeString}%' OR Gender LIKE '%{escapeString}%' OR ClassName LIKE '%{escapeString}%'";
        }
    }
}
