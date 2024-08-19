using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLOGIC;

namespace BUSSLOGIC
{
    public class BussnessLogic
    {
        DataAccessLogin OBJD = new DataAccessLogin();
        public DataSet ForwordGridGetEmpDept()
        {
            DataSet ds = OBJD.GetEmpDept();

            return ds;
        }
    
        public DataSet ForwardDropGetDept()
        {
            DataSet ds=OBJD.GetDept();
            return ds;
        }
        public int ForwardInsertEmp(DataAccessLogin OBJDD )
        {
            int i = OBJDD.InsertIntoEmp();

                
                return i;

        }
        public int ForwardDeleteEmp(DataAccessLogin OBJDD)
        {
            int i = OBJDD.DeleteEmp();


            return i;

        }
        public int ForwardUpdateEmp(DataAccessLogin OBJDD)
        {
            int i = OBJDD.UpdateEmp();


            return i;

        }
    }
}
