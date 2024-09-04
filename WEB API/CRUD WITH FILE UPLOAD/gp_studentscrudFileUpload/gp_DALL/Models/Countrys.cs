using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_DALL.Models
{
    public class Countrys
    {
        public int COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_ON { get; set; }
        public string UPDATED_BY { get; set; }
        public string UPDATED_ON { get; set; }
        public byte[] COUNTRY_IMG { get; set; }  

        public string COUNTRY_IMG_Path { set; get; }




    }
}
