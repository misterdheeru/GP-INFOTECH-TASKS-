using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUSSLOGIC;

namespace DATAACCESSLOGIC
{
    public class  DataAccessLogin
    {
       public String cs = "server=.;database=Company 2 ;uid=sa;pwd=123";
       public    int Eno {  get; set; }
        public string Ename {  get; set; }
        public double Esal {  get; set; }
        public string DeptName { get; set; }



        public int DeptNo { get; set; }
        public DataSet GetEmpDept()
        {
            

            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(" SELECT Emp.EmpNo, Emp.EmpName, Emp.Salary, Dept.DeptName FROM Emp JOIN Dept ON Emp.DeptNo = Dept.DeptNo", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;




        }
        public DataSet GetDept()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Dept", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet d = new DataSet();
            da.Fill(d);
            return d;
        }
        public int InsertIntoEmp( )
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Emp values( @EmoNo,@EmpName,@Salary ,@DeptName ,@DeptNo)", con);
            cmd.Parameters.AddWithValue("@EmoNo", Eno);
            cmd.Parameters.AddWithValue("@EmpName", Ename);
            cmd.Parameters.AddWithValue("@Salary", Esal);
            cmd.Parameters.AddWithValue("@DeptName", DeptName);
            cmd.Parameters.AddWithValue("@DeptNo", DeptNo);
            int i=cmd.ExecuteNonQuery();
            return i;

        }

        public int DeleteEmp()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(" Delete From Emp Where EmpNo = @empno", con);
            cmd.Parameters.AddWithValue("@empno", Eno);
            int i = cmd.ExecuteNonQuery();
            return i;

        }
        public int UpdateEmp()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Emp SET Salary = @esal WHERE EmpNo = @eno", con);
            cmd.Parameters.AddWithValue("@esal", Esal);
            cmd.Parameters.AddWithValue("@eno", Eno);
            int i = cmd.ExecuteNonQuery();
            return i;

        }

         

    }
}
