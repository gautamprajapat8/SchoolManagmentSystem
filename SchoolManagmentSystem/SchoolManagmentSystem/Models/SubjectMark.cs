using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Models
{
    public class SubjectMark
    {
        public int SubjectMarkId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Marks { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
