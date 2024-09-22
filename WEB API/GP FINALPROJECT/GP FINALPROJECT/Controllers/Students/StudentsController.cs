using BALL.StudentsServices;
using DALL.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GP_FINALPROJECT.Controllers.Students
{
    public class StudentsController : ApiController
    {
        private readonly StudentsServices _studentsService;


        public StudentsController()
        {
            _studentsService = new StudentsServices();
        }

        [HttpGet]
        [Route("api/students")]
        public IHttpActionResult GetAllStudents()
        {
            List<GETALL> students = _studentsService.AllStudents();

            return Ok(students);
        }


        [HttpGet]
        [Route("api/students/{id}")]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = _studentsService.SingleStudents(id);
            if (student == null || !student.Any())
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        [Route("api/students")]
        public IHttpActionResult InsertStudent(DALL.Students.Students student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data.");
            }

            int result = _studentsService.InsertStudentRecord(student);
            if (result > 0)
            {
                return Ok("Student record inserted successfully.");
            }
            else
            {
                return BadRequest("Error inserting student record.");
            }
        }


        [HttpPut]
        [Route("api/students/{id}")]
        public IHttpActionResult UpdateStudent(int id, DALL.Students.Students student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data.");
            }

            int result = _studentsService.UpdateStudent(id, student);
            if (result > 0)
            {
                return Ok("Student record updated successfully.");
            }
            else
            {
                return BadRequest("Error updating student record.");
            }
        }


        [HttpDelete]
        [Route("api/students/{id}")]
        public IHttpActionResult DeleteStudent(int id)
        {
            int result = _studentsService.DeleteStudent(id);
            if (result > 0)
            {
                return Ok("Student record deleted successfully.");
            }
            else
            {
                return BadRequest("Error deleting student record.");
            }
        }


        [HttpPost]
        [Route("api/students/login")]
        public IHttpActionResult Login(DALL.Students.Students student)
        {
            if (student == null)
            {
                return BadRequest("Invalid login data.");
            }

            int result = _studentsService.Login(student);
            if (result > 0)
            {
                return Ok("Login successful.");
            }
            else
            {
                return BadRequest("Login failed.");
            }
        }
    
    }
}
