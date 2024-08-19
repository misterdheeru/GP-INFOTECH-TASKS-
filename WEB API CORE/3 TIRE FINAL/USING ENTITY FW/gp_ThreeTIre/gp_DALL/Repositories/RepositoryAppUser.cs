using gp_DALL.Contacts;
using gp_DALL.Data;
using gp_DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_DALL.Repositories
{
    public class RepositoryAppUser : IRepository
    {
        public readonly DataContext gp_datacontext;

        public RepositoryAppUser(DataContext gp_datacontext)
        {
            this.gp_datacontext  = gp_datacontext;
        }

        public List<Students> GetAllStudnets()
        {
            return gp_datacontext.Students.ToList();   
        }
    }
}
