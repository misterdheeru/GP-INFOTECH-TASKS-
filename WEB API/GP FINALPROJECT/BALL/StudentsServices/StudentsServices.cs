using DALL.Auth;
using DALL.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.StudentsServices
{
    public class StudentsServices
    {

        private DALL.Students.StudentsCrude objdall;

        public StudentsServices()
        {

            objdall = new DALL.Students.StudentsCrude();
        }

        public int InsertStudentRecord(DALL.Students.Students obj)
        {
            int i = objdall.INSERT(obj);
            return i;
        }

        public List<GETALL> AllStudents()
        {
            return objdall.GetAll().ToList();
        }

        public List<DALL.Students.Students> SingleStudents(int ID)
        {
            return objdall.SINGLE(ID).ToList();
        }

        public int DeleteStudent(int ID)
        {
            return objdall.DELETE(ID);
        }

        public int UpdateStudent(int ID, DALL.Students.Students obj)
        {
            return objdall.UPDATE(ID, obj);
        }

        public List<Login> LoginWithData(DALL.Students.Students obj)
        {
            return objdall.LoginStudentWithData(obj).ToList();
        }

        public int Login(DALL.Students.Students obj)
        {
            int i = objdall.LoginStudent(obj);
            return i;
        }
    }
}

