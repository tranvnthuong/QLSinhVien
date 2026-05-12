using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Lớp tiện ích hỗ trợ thao tác với cơ sở dữ liệu SQL Server bằng ADO.NET.
/// Cung cấp các phương thức thực thi truy vấn, lệnh và lấy dữ liệu.
/// </summary>
public static class DB
{
    /// <summary>
    /// Chuỗi kết nối đến cơ sở dữ liệu.
    /// </summary>
    private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=YY_Module01;Trusted_Connection=True;TrustServerCertificate=True;";

    /// <summary>
    /// Thực thi câu lệnh SELECT và trả về kết quả dưới dạng DataTable.
    /// </summary>
    /// <param name="sql">Câu truy vấn SQL.</param>
    /// <param name="parameters">Danh sách tham số truyền vào câu truy vấn (nếu có).</param>
    /// <returns>DataTable chứa dữ liệu truy vấn được.</returns>
    public static DataTable Query(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    /// <summary>
    /// Thực thi câu lệnh INSERT, UPDATE hoặc DELETE.
    /// </summary>
    /// <param name="sql">Câu lệnh SQL cần thực thi.</param>
    /// <param name="parameters">Danh sách tham số truyền vào (nếu có).</param>
    /// <returns>Số dòng bị ảnh hưởng.</returns>
    public static int Execute(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// Thực thi câu lệnh SQL và trả về một giá trị đơn (giá trị đầu tiên của dòng đầu tiên).
    /// </summary>
    /// <param name="sql">Câu lệnh SQL.</param>
    /// <param name="parameters">Danh sách tham số (nếu có).</param>
    /// <returns>Giá trị đơn (object), cần ép kiểu khi sử dụng.</returns>
    public static object Scalar(string sql, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteScalar();
        }
    }

}

