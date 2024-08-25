using gp_crudwithLisst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace gp_crudwithList.Controllers
{

    public class StudentsController : ApiController
    {

        Students objstd = new Students();

        [Route("api/Students")]
        [HttpGet]
        public IHttpActionResult DisplayAllStudents()
        {
            var res = this.objstd.GetAllStudentsList();

            return Ok(res);
        }

        [Route("api/Students")]
        [HttpPost]
        public IHttpActionResult StudentsAdd(Students obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                objstd.AddStudents(obj);
                return Ok("RECOR IS INSERTED");
            }
        }
        [Route("api/Students/{ID}")]
        [HttpGet]
        public IHttpActionResult SingleStudent(string ID)
        {
            var res = Students.stdobj.FirstOrDefault(s => s.ID == ID);

            if (res == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(res);
            }
        }

        [Route("api/Students/{ID}")]
        [HttpDelete]
        public IHttpActionResult DeleteStudent(string ID)
        {
            var res = Students.stdobj.FirstOrDefault(s => s.ID == ID);

            if (res == null)
            {
                string message = "STUDENT RECORD WAS NOT FOUND " + ID;
                return NotFound();
            }
            else
            {
                Students.stdobj.Remove(res);
                return Ok("RECORD IS DELETED");
            }

        }

        [Route("api/Students/{ID}")]
        [HttpPut]
        public IHttpActionResult UpdateStudents(string ID, Students OBJ)
        {

            var res = Students.stdobj.FirstOrDefault(s => s.ID == ID);

            if (res == null)
            {
                return NotFound();
            }
            else
            {
                res.FNAME = OBJ.FNAME;
                res.SNAME = OBJ.SNAME;
                res.AGE = OBJ.AGE;
                res.MOBILE = OBJ.MOBILE;
                res.EMAIL = OBJ.EMAIL;
                res.COUNTRY = OBJ.COUNTRY;
                res.STATE = OBJ.STATE;
                res.CITY = OBJ.CITY;
                res.UNIVERSITY = OBJ.UNIVERSITY;
                res.COLLEGE = OBJ.COLLEGE;
                res.PROGRAM = OBJ.PROGRAM;
                res.YEAR = OBJ.YEAR;

                return Ok(res);
            }

        }

    }
}