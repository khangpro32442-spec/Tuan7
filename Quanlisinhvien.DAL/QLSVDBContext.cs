using Microsoft.EntityFrameworkCore;
using Quanlisinhvien.DAL.Entities;

namespace Quanlisinhvien.DAL
{
    public class QLSVDBContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sửa lại Server cho đúng máy của bạn trước khi chạy thử
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-ER612F1\\SQLEXPRESS;" +
                "Database=QuanLiSinhVien;" +
                "Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
