using gp_BALL.crudServices;
using gp_DALL.StudentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gp_studentcrudusingadowebapi.Controllers
{
    public class StudentsController : ApiController
    {

        StudentsServices gp_ball = new StudentsServices();

        studentsRepo gp_dall = new studentsRepo();


        [HttpGet]
        public IHttpActionResult CreateStudentTable()
        {
            var std = gp_ball.getallstd(gp_dall);

            return Ok(std);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            {
                gp_ball.DELETESTD(id);

                return Ok("DELETED");

            }

        }
    }
}
