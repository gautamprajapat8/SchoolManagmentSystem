using SchoolManagmentSystem.DataAccess;
using SchoolManagmentSystem.Models;
using Microsoft.EntityFrameworkCore; // Add this using directive
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem
{
    public class ReportManager
    {
        private readonly SchoolDbContext _dbContext;

        public ReportManager(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetStudentsWithScoreGreaterThan60Percent()
        {
            var students = _dbContext.Students
                .Include(s => s.SubjectMarks)
                .Where(s => s.SubjectMarks.Average(m => m.Marks) > 60)
                .ToList();

            return students;
        }
    }
}
