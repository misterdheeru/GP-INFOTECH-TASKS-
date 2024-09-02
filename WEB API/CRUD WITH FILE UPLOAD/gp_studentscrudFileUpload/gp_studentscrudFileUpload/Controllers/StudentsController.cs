using gp_BALL.ServicesRepository;
using gp_DALL.Models;
using gp_DALL.Repository;
using System.Linq;
using System.Web.Http;

namespace gp_studentscrudFileUpload.Controllers
{
    public class StudentsController : ApiController
    {
        StudentsRepository objdall = new StudentsRepository();

        StudentsServicesRepository objball = new StudentsServicesRepository();


        [HttpGet]
        public IHttpActionResult GetAllStudentsRecord()
        {
            var res = objball.AllStudents().ToList();

            return Ok(res);
        }

        [HttpPost]
        public IHttpActionResult InsertRecord(Students obj)
        {

            int i = objball.insertStudentRecord(obj);

            if(i==1)
            {
          return      Ok("RECORD IS INSERTED");
            }
          else
            {
                return Ok("RECORD IS FAILED TO  INSERTED");
            }

        }

        [HttpGet]

        public IHttpActionResult GetSingeleStudentRecord(int ID)
        {
            var res = objball.SingleStudents(ID).ToList();

            return Ok(res);
        }

        [HttpDelete]

        public IHttpActionResult StudentDelete(int ID)
        {
            int i = objball.DeleteStudent(ID);

            if (i == 1)
            {
                return Ok("RECORD IS DELETED");
            }
            else
            {
                return BadRequest();
            }

        }


        [HttpPut]

        public IHttpActionResult StudentUpdate(int ID, Students obj)
        {
            int i = objball.updateStudent(ID,obj);

            if (i == 1)
            {
                return Ok("RECORD IS UPDATED");
            }
            else
            {
                return BadRequest();
            }

        }



    }
}
