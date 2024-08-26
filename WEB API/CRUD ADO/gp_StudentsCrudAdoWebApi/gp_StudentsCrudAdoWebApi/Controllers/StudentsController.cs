using gp_BALL.Services;
using gp_DALL.Models;
using gp_DALL.Repo;
using System.Web.Http;

namespace gp_StudentsCrudAdoWebApi.Controllers
{
    public class StudentsController : ApiController
    {

        StudentsRepo gp_dall = new StudentsRepo();

        StudentsServices gp_ball = new StudentsServices();

        [HttpGet]
        public IHttpActionResult GetAllStudentsRecords()
        {

            var res = this.gp_ball.AllStudents();
            return Ok(res);

        }
        [HttpPost]
        public IHttpActionResult InsertStudentRecord(Students obj)
        {

            int i = this.gp_ball.InsertStudent(obj);

            if (i == 1)
            {
                return Ok("RECORD INSERTED");
            }
            else
            {
                return Ok("RECORD IS FSILED TO INSERT");
            }

        }
        [HttpDelete]
        public IHttpActionResult DeleteStudentRecord(int ID)
        {
            int i = this.gp_ball.DeleteStudent(ID);

            if (i == 1)
            {
                return Ok("RECORD DELETED");
            }
            else
            {
                return Ok("RECORD IS FAILED TO DELETE");
            }

        }

        [HttpPut]
        public IHttpActionResult UpdateStudentRecord(Students stdobj, int ID)
        {
            int i = this.gp_ball.UpdateStudent(stdobj, ID);

            if (i == 1)
            {
                return Ok("RECORD UPDATED");
            }
            else
            {
                return Ok("RECORD IS FAILED TO UPDATED");
            }

        }

        [HttpGet]
        public IHttpActionResult GetSingleStudentRecord(int ID)
        {

            var res = gp_ball.SingleStudent(ID);

            return Ok(res);
        }
    }
}
