using System.Data.SqlClient;

namespace QLSinhVien.MiniServices
{
    public static class ClassesService
    {
        public static ServiceResult AddClass(string classId, string className, string departMent)
        {
            if (string.IsNullOrWhiteSpace(classId) || string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(departMent))
            {
                return new ServiceResult(false, "Vui lòng điền đầy đủ thông tin", "Lỗi xác thực", false);
            }
            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Classes WHERE ClassID = @classID", new SqlParameter("@classID", classId));
                if (exist != null)
                {
                    return new ServiceResult(false, "Lớp học đã tồn tại", "Thông báo", false);
                }

                int reslut = DB.Execute("INSERT INTO Classes(ClassID, ClassName, Department) VALUES (@classId, @className, @departMent)",
                    new SqlParameter("@classId", classId),
                    new SqlParameter("@className", className),
                    new SqlParameter("@departMent", departMent)
                );
                if (reslut > 0)
                {
                    return new ServiceResult(true, "Thêm thông tin Lớp học thành công", "Thông báo", false);
                }
                else
                {
                    return new ServiceResult(false, "Thêm thông tin Lớp học thất bại", "Lỗi chèn dữ liệu", false);
                }
            }
            catch (SqlException ex)
            {
                return new ServiceResult(false, $"Có lỗi xảy ra khi thêm dữ lệu: {ex}", "Lỗi ngoại lệ", true);
            }
        }

        public static ServiceResult EditClass(string classId, string className, string departMent)
        {
            if (string.IsNullOrWhiteSpace(classId) || string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(departMent))
            {
                return new ServiceResult(false, "Vui lòng điền đầy đủ thông tin", "Lỗi xác thực", false);
            }
            try
            {
                var exist = DB.Scalar("SELECT 1 FROM Classes WHERE ClassID = @classID", new SqlParameter("@classID", classId));
                if (exist == null)
                {
                    return new ServiceResult(false, "Lớp học không tồn tại", "Thông báo", false);
                }

                int reslut = DB.Execute("UPDATE Classes SET ClassName = @className, DepartMent = @departMent WHERE ClassID = @classId",
                    new SqlParameter("@classId", classId),
                    new SqlParameter("@className", className),
                    new SqlParameter("@departMent", departMent)
                );
                if (reslut > 0)
                {
                    return new ServiceResult(true, "Cập nhật thông tin Lớp học thành công", "Thông báo", false);
                }
                else
                {
                    return new ServiceResult(false, "Cập nhật thông tin Lớp học thất bại", "Lỗi cập nhật dữ liệu", false);
                }
            }
            catch (SqlException ex)
            {
                return new ServiceResult(false, $"Có lỗi xảy ra khi cập nhật dữ lệu: {ex}", "Lỗi ngoại lệ", true);
            }
        }

        public static ServiceResult DeleteClass(string classId)
        {
            try
            {
                int reslut = DB.Execute("DELETE FROM Classes WHERE ClassID = @classId",
                   new SqlParameter("@classId", classId)
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
