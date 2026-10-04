using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using StudentRESTService.Models;

namespace StudentRESTService.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Rahul", Course = "BSc IT", Age = 20 },
            new Student { Id = 2, Name = "Priya", Course = "BSc IT", Age = 21 }
        };

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        public IHttpActionResult PostStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return Ok(student);
        }

        public IHttpActionResult PutStudent(int id, Student student)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == id);
            if (existingStudent == null) return NotFound();

            existingStudent.Name = student.Name;
            existingStudent.Course = student.Course;
            existingStudent.Age = student.Age;
            return Ok(existingStudent);
        }

        public IHttpActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();

            students.Remove(student);
            return Ok(student);
        }
    }
}
