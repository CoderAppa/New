using System.Collections.Generic;

namespace DependencyInjectionDemo.Models
{
    public interface IStudentService
    {
        List<string> GetStudents();
    }
}
