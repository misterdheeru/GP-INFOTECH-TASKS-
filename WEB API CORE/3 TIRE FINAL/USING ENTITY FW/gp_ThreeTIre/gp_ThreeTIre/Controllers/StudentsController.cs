using gp_BALL.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gp_ThreeTIre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly IRepositoryServices gp_repository;

        public StudentsController(IRepositoryServices gp_repository)
        {
            this.gp_repository = gp_repository;
        }

        [HttpGet]
        public IActionResult GetAllStudentsList()
        {
            var res = gp_repository.GetAllStudnets();

           return Ok(res);
        }

    }
}
