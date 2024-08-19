using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Single_Page_Applicaton.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("conn")
        {

        }

        public DbSet <Employee>Emps { set; get; }
    }
}