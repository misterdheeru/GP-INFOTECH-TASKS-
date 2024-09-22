using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GP_FINALPROJECT.Controllers.City
{
    public class CityController : ApiController
    {
        public readonly BALL.CityServices.CityServices _city;

        public CityController()
        {
            _city = new BALL.CityServices.CityServices();
        }

        [HttpGet]
        [Route("api/City")]
        public IHttpActionResult GetAllCountry()
        {
            var res = _city.GetAllCountryList();

            return Ok(res);
        }
    }
}
