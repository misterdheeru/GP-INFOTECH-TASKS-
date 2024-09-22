using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GP_FINALPROJECT.Controllers.States
{
    public class StatesController : ApiController
    {
        public readonly BALL.StatesServices.StatesServices _states;

        public StatesController()
        {
            _states = new BALL.StatesServices.StatesServices();
        }

        [HttpGet]
        [Route("api/States")]
        public IHttpActionResult GetAllCountry()
        {
            var res = _states.GetAllCountryList();

            return Ok(res);
        }


    }
}
