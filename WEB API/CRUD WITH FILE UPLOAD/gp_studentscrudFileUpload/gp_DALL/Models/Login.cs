using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_DALL.Models
{
    public class Login
    {
        public int ID { set; get; }
        public string USERNAME { set; get; }
        public string PASSWORD { set; get; }
        public string FNAME { set; get; }
        public string SNAME { set; get; }
        public int AGE { set; get; }
        public string EMAIL { set; get; }
        public string MOBILE { set; get; }
        public string ADDRESS { set; get; }
        public bool IS_ACTIVE { set; get; }
    }
}
