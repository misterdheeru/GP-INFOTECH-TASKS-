using gp_DALL.Models;
using gp_DALL.Repo;
using System.Collections.Generic;
using System.Linq;


namespace gp_BALL.Services
{
    public class StudentsServices
    {
        StudentsRepo obj = new StudentsRepo();
        public List<Students> AllStudents()
        {
            return obj.GetAll().ToList();
        }

        public int InsertStudent(Students stdobj)
        {
            int i = obj.InsertRecord(stdobj);

            return i;
        }
        public int DeleteStudent(int ID)
        {
            int i = obj.DeleteRecord(ID);

            return i;
        }

        public int UpdateStudent(Students stdobj, int ID)
        {
            int i = obj.UpdateRecord(stdobj, ID);

            return i;
        }

        public List<Students> SingleStudent(int ID)
        {
            return obj.GetSingle(ID).ToList();
        }
    }
}
 