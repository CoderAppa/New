using System.Collections.Generic;

namespace DependencyInjectionDemo.Models
{
    public class StudentService : IStudentService
    {
        public List<string> GetStudents()
        {
            return new List<string>
            {
                "Rahul", "Priya", "Amit", "Sneha"
            };
        }
    }
}
