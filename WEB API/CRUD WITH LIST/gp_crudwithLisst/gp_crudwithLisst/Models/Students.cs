using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gp_crudwithLisst.Models
{
    public class Students
    {
        public string ID { set; get; }

        public string FNAME { set; get; }

        public string SNAME { set; get; }

        public byte AGE { set; get; }

        public string MOBILE { set; get; }

        public string EMAIL { set; get; }

        public string COUNTRY { set; get; }

        public string STATE { set; get; }

        public string CITY { set; get; }

        public string UNIVERSITY { set; get; }

        public string COLLEGE { set; get; }

        public string PROGRAM { set; get; }

        public string YEAR { set; get; }

        public static List<Students> stdobj = new List<Students>();


        public Students()
        {
            Guid objid = Guid.NewGuid();
            this.ID = objid.ToString();
        }

        public List<Students> GetAllStudentsList()
        {
            var res = stdobj.ToList();
            return res;
        }

        public void AddStudents(Students obj)
        {
            stdobj.Add(obj);
        }



    }
}