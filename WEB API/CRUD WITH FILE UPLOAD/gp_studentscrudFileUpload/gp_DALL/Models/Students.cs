using System;
namespace gp_DALL.Models
{
    public class Students
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
        public string CREATEDBY { set; get; }

        public bool IS_ACTIVE { set; get; }
        public DateTime CREATEDON { set; get; }
        public string UPDATED_BY { set; get; }
        public DateTime UPDATEDON { set; get; }
        public int COUNTRY_ID { set; get; }
        public int STATE_ID { set; get; }
        public int CITI_ID { set; get; }

    }
}
