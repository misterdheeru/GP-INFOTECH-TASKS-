
using gp_DALL.Models;
using gp_DALL.StudentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_BALL.crudServices
{
    public class StudentsServices
    {
        studentsRepo obj = new studentsRepo();
        public List<Students> getallstd(studentsRepo obj)
        {
            return obj.GetAllStudentsRecords();

        }

        public int DELETESTD (int id) 
         {
            int i = obj.Delete(id);

            return i;
         }
           

    }
}
