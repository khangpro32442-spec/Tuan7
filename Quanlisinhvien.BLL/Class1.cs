using Microsoft.EntityFrameworkCore;
using Quanlisinhvien.DAL;
using Quanlisinhvien.DAL.Entities;

namespace Quanlisinhvien.BLL
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            using var context = new QLSVDBContext();
            return context.Students
                .AsNoTracking()
                .ToList();
        }
    }
}
