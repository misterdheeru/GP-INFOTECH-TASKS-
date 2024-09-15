using gp_DALL.Models;
using gp_DALL.Repository;
using System.Collections.Generic;
using System.Linq;

namespace gp_BALL.ServicesRepository
{
    public class StudentsServicesRepository
    {

        StudentsRepository objdall = new StudentsRepository();
        public int insertStudentRecord(Students obj)
        {
            int i = objdall.InsertRecord(obj);

            return i;   
        }
        public List<GETALL> AllStudents()
        {
            return objdall.GetAllSutents().ToList();
        }
        public List<GETALL> SingleStudents(int ID)
        {
            return objdall.SingelStudent(ID).ToList();
        }

        public int DeleteStudent(int ID)
        {
            return objdall.DeleteStudent(ID);
        }

        public int updateStudent(int ID , Students obj)
        {
            return objdall.UpdateStudent(ID,obj);
        }

        public List<Login> LoginStudents(Students Obj)
        {
            var res  = objdall.GetLogin(Obj).ToList();

            return res;
        }
    }
}
