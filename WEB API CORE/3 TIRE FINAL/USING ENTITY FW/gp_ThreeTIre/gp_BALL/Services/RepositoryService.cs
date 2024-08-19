using gp_BALL.Extensions;
using gp_DALL.Contacts;
using gp_DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_BALL.Services
{
    public class RepositoryService :IRepositoryServices
    {

        public readonly IRepository gp_repository;

        public RepositoryService(IRepository gp_repository)
        {
            this.gp_repository = gp_repository;
        }

        public List<Students> GetAllStudnets()
        {
             return gp_repository.GetAllStudnets();
        }
    }
}
