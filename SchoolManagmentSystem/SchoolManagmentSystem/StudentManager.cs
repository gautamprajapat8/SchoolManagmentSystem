using SchoolManagmentSystem.DataAccess;
using SchoolManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem
{
    public class StudentManager
    {
        private readonly SchoolDbContext _dbContext;

        public StudentManager(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddNewStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
        }


    }
}
