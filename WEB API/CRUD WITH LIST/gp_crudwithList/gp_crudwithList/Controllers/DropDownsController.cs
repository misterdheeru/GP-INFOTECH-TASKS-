using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gp_crudwithLisst.Controllers
{
    public class DropDownsController : ApiController
    {

        [Route("api/DropDowns/Countrys")]
        [HttpGet]
        public HttpResponseMessage getcountrys()
        {
            List<string> countrys = new List<string>();
            countrys.Add("-select-");
            countrys.Add("india");
            countrys.Add("usa");

            return Request.CreateResponse(HttpStatusCode.OK, countrys.ToList());
        }

        [Route("api/DropDowns/States")]
        [HttpGet]
        public HttpResponseMessage getstates()
        {
            List<string> stateone = new List<string>();
            stateone.Add("-select-");
            stateone.Add("Andhra Predesh");
            stateone.Add("Telangana");

            return Request.CreateResponse(HttpStatusCode.OK, stateone.ToList());
        }

        [Route("api/DropDowns/City/One")]
        [HttpGet]

        public HttpResponseMessage getcityone()
        {
            List<string> cityone = new List<string>();
            cityone.Add("-select-");
            cityone.Add("Hyderabad");
            cityone.Add("Warangal");

            return Request.CreateResponse(HttpStatusCode.OK, cityone.ToList());
        }

        [Route("api/DropDowns/City/Two")]
        [HttpGet]
        public HttpResponseMessage getcitytwo()
        {
            List<string> citytwo = new List<string>();
            citytwo.Add("-select-");
            citytwo.Add("vizag");
            citytwo.Add("vijayawada");

            return Request.CreateResponse(HttpStatusCode.OK, citytwo.ToList());
        }


        [Route("api/DropDowns/university")]
        [HttpGet]
        public HttpResponseMessage getuniversity()
        {
            List<string> university = new List<string>();
            university.Add("-select-");
            university.Add("jntu");
            university.Add("ou");

            return Request.CreateResponse(HttpStatusCode.OK, university.ToList());
        }

        [Route("api/DropDowns/Colleges/Degree")]
        [HttpGet]
        public HttpResponseMessage getclgfordegree()
        {
            List<string> degree = new List<string>();
            degree.Add("-select-");
            degree.Add("Siddhartha Degree Clg");
            degree.Add("Wesley Degree Clg");

            return Request.CreateResponse(HttpStatusCode.OK, degree.ToList());
        }
        [Route("api/DropDowns/Colleges/Btech")]
        [HttpGet]
        public HttpResponseMessage getclgforbtech()
        {
            List<string> btech = new List<string>();
            btech.Add("-select-");
            btech.Add("malla reddy clg");
            btech.Add("cbit clg");

            return Request.CreateResponse(HttpStatusCode.OK, btech.ToList());
        }

        [Route("api/DropDowns/Program/Btech")]
        [HttpGet]
        public HttpResponseMessage getprogramfrombtech()
        {
            List<string> programbtech = new List<string>();
            programbtech.Add("-select-");
            programbtech.Add("ECE");
            programbtech.Add("EEE");
            programbtech.Add("CSE");

            return Request.CreateResponse(HttpStatusCode.OK, programbtech.ToList());
        }

        [Route("api/DropDowns/Program/Degree")]
        [HttpGet]
        public HttpResponseMessage getprogramfordegree()
        {
            List<string> programfordegree = new List<string>();
            programfordegree.Add("-select-");
            programfordegree.Add("BCA");
            programfordegree.Add("BSC");
            programfordegree.Add("BCOM");

            return Request.CreateResponse(HttpStatusCode.OK, programfordegree.ToList());
        }

        [Route("api/DropDowns/Year")]
        [HttpGet]
        public HttpResponseMessage getyears()
        {
            List<string> years = new List<string>();
            years.Add("-select-");
            years.Add("2021");
            years.Add("2022");
            years.Add("2023");

            return Request.CreateResponse(HttpStatusCode.OK, years.ToList());
        }
    }
}