using Microsoft.Data.SqlClient;

namespace QuanLyHoSoSinhVien
{
    public class Database
    {
        public static string ConnectionString =
            @"Server=localhost;Database=QuanLyHoSoSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}