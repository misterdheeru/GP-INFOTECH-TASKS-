using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace gp_crudwithList.Controllers
{
    // Student class definition
    public class Student
    {
        public int ID { get; set; }
        public string FNAME { get; set; }
        public string SNAME { get; set; }
        public string EMAIL { get; set; }
        public byte AGE { get; set; }
        public string MOBILE { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string UNIVERSITY { get; set; }
        public string COLLEGE { get; set; }
        public string PROGRAM { get; set; }
        public string YEAR { get; set; }

        // Sample static list of students
        public static List<Student> stdList = new List<Student>
        {
            new Student {ID = 1, FNAME = "RAMA", SNAME = "KRISHNA", EMAIL = "ramakrishna@gmail.com", AGE = 25, MOBILE = "9845878548", COUNTRY = "INDIA", STATE = "TELANGANA", CITY = "HYDERABAD", UNIVERSITY = "OU", COLLEGE = "SIDDHARTHA DEGREE CLG", PROGRAM = "BCA", YEAR = "2023" },
            new Student {ID = 2, FNAME = "ROHITH", SNAME = "CHOWDARY", EMAIL = "rohith@gmail.com", AGE = 25, MOBILE = "9845878549", COUNTRY = "INDIA", STATE = "TELANGANA", CITY = "HYDERABAD", UNIVERSITY = "OU", COLLEGE = "SIDDHARTHA DEGREE CLG", PROGRAM = "BCA", YEAR = "2023" },
            new Student {ID = 3, FNAME = "SAI", SNAME = "KRISHNA", EMAIL = "saikrishna@gmail.com", AGE = 25, MOBILE = "9845878550", COUNTRY = "INDIA", STATE = "TELANGANA", CITY = "HYDERABAD", UNIVERSITY = "OU", COLLEGE = "SIDDHARTHA DEGREE CLG", PROGRAM = "BCA", YEAR = "2023" }
        };
    }

    // API controller with CRUD operations
    public class StudentsController : ApiController
    {
        // GET: api/Students - Retrieve all students
        [HttpGet]
        public IHttpActionResult GetAllStudentRecords()
        {
            return Ok(Student.stdList);
        }

        // GET: api/Students/1 - Retrieve a single student by ID

        [HttpGet]

        public IHttpActionResult GetStudentById(int id)
        {
            var student = Student.stdList.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // POST: api/Students - Create a new student

        [HttpPost]
        public IHttpActionResult CreateStudent([FromBody] Student newStudent)
        {
            if (newStudent == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }

            newStudent.ID = Student.stdList.Count > 0 ? Student.stdList.Max(s => s.ID) + 1 : 1;
            Student.stdList.Add(newStudent);
            return Ok(newStudent);
        }

        // PUT: api/Students/1 - Update an existing student

        [HttpPut]
        public IHttpActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            if (updatedStudent == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }

            var existingStudent = Student.stdList.FirstOrDefault(s => s.ID == id);
            if (existingStudent == null)
            {
                return NotFound();
            }

            existingStudent.FNAME = updatedStudent.FNAME;
            existingStudent.SNAME = updatedStudent.SNAME;
            existingStudent.EMAIL = updatedStudent.EMAIL;
            existingStudent.AGE = updatedStudent.AGE;
            existingStudent.MOBILE = updatedStudent.MOBILE;
            existingStudent.COUNTRY = updatedStudent.COUNTRY;
            existingStudent.STATE = updatedStudent.STATE;
            existingStudent.CITY = updatedStudent.CITY;
            existingStudent.UNIVERSITY = updatedStudent.UNIVERSITY;
            existingStudent.COLLEGE = updatedStudent.COLLEGE;
            existingStudent.PROGRAM = updatedStudent.PROGRAM;
            existingStudent.YEAR = updatedStudent.YEAR;

            return Ok(existingStudent);
        }

        // DELETE: api/Students/1 - Delete a student by ID
        [HttpDelete]
        public IHttpActionResult DeleteStudent(int id)
        {
            var student = Student.stdList.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            Student.stdList.Remove(student);
            return Ok($"Student with ID {id} has been deleted.");
        }
    }
}
