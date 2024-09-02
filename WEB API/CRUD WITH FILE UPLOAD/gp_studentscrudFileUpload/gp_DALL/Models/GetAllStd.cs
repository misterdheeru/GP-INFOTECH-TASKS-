using System;
namespace gp_DALL.Models
{
    public  class GetAllStd
    {
        public int ID { set; get; }
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
        public string COUNTRY_NAME { set; get; }
        public string STATE_NAME { set; get; }
        public string   CITI_NAME { set; get; }
    }
}
