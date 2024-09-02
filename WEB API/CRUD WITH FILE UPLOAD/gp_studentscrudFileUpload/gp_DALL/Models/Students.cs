using System;
namespace gp_DALL.Models
{
    public class Students
    {
       public int   ID { set; get; } 
        public string FNAME { set; get; }
        public string SNAME { set; get; }
        public int AGE { set; get; }
        public string YEAR { set; get; }
        public string EMAIL { set; get; }
        public string MOBILE { set; get; }
        public string ADDRESS { set; get; }
        public bool ISACTIVE { set; get; }
        public string CREATEDBY { set; get; }
        public DateTime CREATEDON { set; get; }
        public string UPDATEDBY { set; get; }
        public DateTime UPDATEDON { set; get; }
        public int COUNTRY_ID { set; get; }
        public int STATE_ID { set; get; }
        public int CITI_ID { set; get; }

    }
}
