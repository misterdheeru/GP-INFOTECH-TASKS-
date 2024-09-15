using gp_BALL.ServicesRepository;
using gp_DALL.Models;
using gp_DALL.Repository;
using System.Linq;
using System.Web.Http;

namespace gp_studentscrudFileUpload.Controllers
{
    public class RegistrationController : ApiController
    {
        StudentsRepository objdall = new StudentsRepository();

        StudentsServicesRepository objball = new StudentsServicesRepository();


        [HttpPost]
        public IHttpActionResult Login( Students obj)
        {
            var res = objball.LoginStudents(obj).ToList();

            return Ok(res);
        }
    }
}
