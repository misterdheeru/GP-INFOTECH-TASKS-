using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gp_crudwithList.Controllers
{
    public class Students
    {
        public int ID { get; set; }
        public string FNAME { get; set; }
        public string SNAME { get; set; }
        public string EMAIL { get; set; }
        public byte AGE { get; set; }
        public string MOBILE { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string UNIVERSITY { get; set; }
        public string COLLEGE { get; set; }
        public string PROGRAM { get; set; }
        public string YEAR { get; set; }


    }

    public class StudentsController : ApiController
    {

    }
}
