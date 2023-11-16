using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        // Navigation property for marks relationship
        public ICollection<SubjectMark> SubjectMarks { get; set; }
    }
}
