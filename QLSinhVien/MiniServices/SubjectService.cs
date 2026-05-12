
using System.Data.SqlClient;

namespace QLSinhVien.MiniServices
{
    public static class SubjectService
    {
        public static ServiceResult AddSubject(string subjectId, string subjectName, string departMent)
        {
            if (string.IsNullOrWhiteSpace(subjectId) || string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(departMent))
            {
                return new ServiceResult(false, "Vui lòng điền đầy đủ thông tin", "Lỗi xác thực", false);
            }
            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Subjects WHERE SubjectID = @subjectID", new SqlParameter("@subjectID", subjectId));
                if (exist != null)
                {
                    return new ServiceResult(false, "Môn học đã tồn tại", "Thông báo", false);
                }

                int reslut = DB.Execute("INSERT INTO Subjects(SubjectID, ClassName, Department) VALUES (@subjectId, @subjectName, @departMent)",
                    new SqlParameter("@subjectId", subjectId),
                    new SqlParameter("@subjectName", subjectName),
                    new SqlParameter("@departMent", departMent)
                );
                if (reslut > 0)
                {
                    return new ServiceResult(true, "Thêm thông tin Môn học thành công", "Thông báo", false);
                }
                else
                {
                    return new ServiceResult(false, "Thêm thông tin Môn học thất bại", "Lỗi chèn dữ liệu", false);
                }
            }
            catch (SqlException ex)
            {
                return new ServiceResult(false, $"Có lỗi xảy ra khi thêm dữ lệu: {ex}", "Lỗi ngoại lệ", true);
            }
        }

        public static ServiceResult EditSubject(string subjectId, string subjectName, string departMent)
        {
            if (string.IsNullOrWhiteSpace(subjectId) || string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(departMent))
            {
                return new ServiceResult(false, "Vui lòng điền đầy đủ thông tin", "Lỗi xác thực", false);
            }
            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Subjects WHERE SubjectID = @subjectID", new SqlParameter("@subjectID", subjectId));
                if (exist == null)
                {
                    return new ServiceResult(false, "Môn học không tồn tại", "Thông báo", false);
                }

                int reslut = DB.Execute("UPDATE Subjects SET ClassName = @subjectName, DepartMent = @departMent WHERE SubjectID = @subjectId",
                    new SqlParameter("@subjectId", subjectId),
                    new SqlParameter("@subjectName", subjectName),
                    new SqlParameter("@departMent", departMent)
                );
                if (reslut > 0)
                {
                    return new ServiceResult(true, "Cập nhật thông tin Môn học thành công", "Thông báo", false);
                }
                else
                {
                    return new ServiceResult(false, "Cập nhật thông tin Môn học thất bại", "Lỗi cập nhật dữ liệu", false);
                }
            }
            catch (SqlException ex)
            {
                return new ServiceResult(false, $"Có lỗi xảy ra khi cập nhật dữ lệu: {ex}", "Lỗi ngoại lệ", true);
            }
        }

        public static ServiceResult DeleteSubject(string subjectId)
        {
            try
            {
                int reslut = DB.Execute("DELETE FROM Subjects WHERE SubjectID = @subjectId",
                   new SqlParameter("@subjectId", subjectId)
                );
                return new ServiceResult(reslut > 0, "", "", false);
            }
            catch (SqlException ex)
            {
                return new ServiceResult(false, $"Có lỗi xảy ra khi xóa dữ lệu: {ex}", "Lỗi ngoại lệ", true);
            }
        }
    }
}
