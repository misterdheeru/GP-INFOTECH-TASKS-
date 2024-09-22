using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GP_FINALPROJECT.Controllers.Country
{
    public class CountryController : ApiController
    {
 
            public readonly BALL.CountryServices.CountryServices _country;

            public CountryController()
            {
                _country = new BALL.CountryServices.CountryServices();
            }

            [HttpGet]
            [Route("api/Country")]
            public IHttpActionResult GetAllCountry()
            {
                var res = _country.GetAllCountryList();

                return Ok(res);
            }


        }
  
    }
