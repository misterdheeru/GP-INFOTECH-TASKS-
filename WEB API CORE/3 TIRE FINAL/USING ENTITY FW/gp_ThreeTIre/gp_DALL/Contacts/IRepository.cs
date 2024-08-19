using gp_DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_DALL.Contacts
{
    public  interface IRepository
    {
        List<Students> GetAllStudnets();
    }
}
