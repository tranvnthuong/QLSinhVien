using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
    public partial class ucClasses : UserControl
    {
        public ucClasses()
        {
            InitializeComponent();

            LoadClasses();
        }

        private void LoadClasses()
        {
            dgvClasses.DataSource = DB.Query("SELECT * FROM Classes");
            dgvClasses.Columns["ClassID"].HeaderText = "Mã Lớp";
            dgvClasses.Columns["ClassName"].HeaderText = "Tên Lớp";
            dgvClasses.Columns["Department"].HeaderText = "Khoa";
        }

        private string ClassID { get => txtClassID.Text; set => txtClassID.Text = value; }
        private string ClassName { get => txtClassName.Text; set => txtClassName.Text = value; }
        private string Department { get => txtDepartment.Text; set => txtDepartment.Text = value; }
        private string SearchBox { get => txtSearchBox.Text; set => txtSearchBox.Text = value;  }

        private void ClearInput()
        {
            ClassID = string.Empty;
            ClassName = string.Empty;
            Department = string.Empty;
        }

        private bool ValidateInput()
        {
			// Spaghetti code
			int errors = 0;
            if (string.IsNullOrWhiteSpace(ClassID))
            {
                errorProvider1.SetError(txtClassID, "Mã Lớp không được để trống");
                errors++;
            }
            else
            {
				errorProvider1.SetError(txtClassID, string.Empty);
			}

            if (string.IsNullOrWhiteSpace(ClassName))
            {
                errorProvider1.SetError(txtClassName, "Tên Lớp không được để trống");
                errors++;
            }
			else
			{
				errorProvider1.SetError(txtClassName, string.Empty);
			}

			if (string.IsNullOrWhiteSpace(Department))
            {
                errorProvider1.SetError(txtDepartment, "Khoa không được để trống");
                errors++;
            }
			else
			{
				errorProvider1.SetError(txtDepartment, string.Empty);
			}

			return errors == 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Classes WHERE ClassID = @ClassID", new SqlParameter("@ClassID", ClassID));
                if (exist != null)
                {
                    MessageBox.Show("Lớp học đã tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("INSERT INTO Classes(ClassID, ClassName, Department) VALUES (@ClassID, @ClassName, @Department)",
                    new SqlParameter("@ClassID", ClassID),
                    new SqlParameter("@ClassName", ClassName),
                    new SqlParameter("@Department", Department)
                );
                if (reslut > 0)
                {
                    ClearInput();
                    LoadClasses();
                    MessageBox.Show("Thêm thông tin Lớp học thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin Lớp học thất bại", "Lỗi chèn dữ liệu");
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
                var exist = DB.Scalar("SELECT 1 FROM Classes WHERE ClassID = @ClassID", new SqlParameter("@ClassID", ClassID));
                if (exist == null)
                {
                    MessageBox.Show("Lớp học không tồn tại", "Thông báo");
                    return;
                }

                int reslut = DB.Execute("UPDATE Classes SET ClassName = @ClassName, Department = @Department WHERE ClassID = @ClassID",
                    new SqlParameter("@ClassID", ClassID),
                    new SqlParameter("@ClassName", ClassName),
                    new SqlParameter("@Department", Department)
                );
                if (reslut > 0)
                {
                    ClearInput();
                    LoadClasses();
                    MessageBox.Show("Cập nhật thông tin Lớp học thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin Lớp học thất bại", "Lỗi cập nhật dữ liệu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật dữ liệu {ex.Message}", "Lỗi ngoại lệ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCount = dgvClasses.SelectedRows.Count;
            if (selectedCount > 0)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa {selectedCount} Lớp học đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                int deletedRows = 0;
                foreach (DataGridViewRow row in dgvClasses.SelectedRows)
                {
                    try
                    {
                        string ClassID = row.Cells["ClassID"].Value.ToString();
                        int result = DB.Execute("DELETE FROM Classes WHERE ClassID = @ClassID",
                           new SqlParameter("@ClassID", ClassID)
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
                    LoadClasses();
                    MessageBox.Show($"Đã xóa {deletedRows} Lớp học", "Thông báo");
                }
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvClasses.Rows[rowIndex];
                ClassID = row.Cells["ClassID"].Value.ToString();
                ClassName = row.Cells["ClassName"].Value.ToString();
                Department = row.Cells["Department"].Value.ToString();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadClasses();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            (dgvClasses.DataSource as DataTable).DefaultView.RowFilter = $"ClassName LIKE '%{SearchBox}%'";
        }
    }
}
