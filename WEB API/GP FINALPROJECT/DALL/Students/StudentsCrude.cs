using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Auth;

namespace DALL.Students
{
    public class StudentsCrude
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=gp_webapi;uid=sa;pwd=123";

        public List<GETALL> GetAll()
        {

            List<GETALL> obj = new List<GETALL>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    GETALL std = new GETALL
                    {

                        ID = (dr["ID"] as int?).GetValueOrDefault(),
                        FNAME = dr["FNAME"].ToString(),
                        USERNAME = dr["USERNAME"].ToString(),
                        PASSWORD = dr["PASSWORD"].ToString(),
                        SNAME = dr["SNAME"].ToString(),
                        AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                        EMAIL = dr["EMAIL"].ToString(),
                        MOBILE = dr["MOBILE"].ToString(),
                        ADDRESS = dr["ADDRESS"].ToString(),
                        IS_ACTIVE = (dr["IS_ACTIVE"] as bool?).GetValueOrDefault(),
                        CREATEDBY = dr["CREATEDBY"].ToString(),
                        CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                        UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                        UPDATED_BY = dr["UPDATEDBY"].ToString(),
                        COUNTRY_NAME = dr["COUNTRY_NAME"].ToString(),
                        STATE_NAME = dr["STATE_NAME"].ToString(),
                        CITI_NAME = dr["CITY_NAME"].ToString(),

                    };

                    obj.Add(std);

                }

                return obj;
            }

        }


        public int INSERT(Students obj)
        {


            using (SqlConnection conn = new SqlConnection(cs))
            {
                DateTime Date = new DateTime();

                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.Parameters.AddWithValue("@ACTION", "INSERT");
                cmd.Parameters.AddWithValue("@USERNAME", obj.FNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", obj.SNAME);
                cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
                cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
                cmd.Parameters.AddWithValue("@AGE", obj.AGE);
                cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
                cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
                cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
                cmd.Parameters.AddWithValue("@IS_ACTIVE", obj.IS_ACTIVE);
                cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATEDBY);
                cmd.Parameters.AddWithValue("@CREATEDON", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATED_BY);
                cmd.Parameters.AddWithValue("@UPDATEDON", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@COUNTRY_ID  ", obj.COUNTRY_ID);
                cmd.Parameters.AddWithValue("@CITI_ID ", obj.CITI_ID);
                cmd.Parameters.AddWithValue("@STATE_ID", obj.STATE_ID);
                cmd.Parameters.AddWithValue("@ACTION", "INSERT");

                int i = cmd.ExecuteNonQuery();

                return i;

            }
        }

        public List<Students> SINGLE(int ID)
        {

            List<Students> stdobj = new List<Students>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SINGLE");
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Students std = new Students
                    {

                        ID = (dr["ID"] as int?).GetValueOrDefault(),
                        FNAME = dr["FNAME"].ToString(),
                        USERNAME = dr["USERNAME"].ToString(),
                        PASSWORD = dr["PASSWORD"].ToString(),
                        SNAME = dr["SNAME"].ToString(),
                        AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                        EMAIL = dr["EMAIL"].ToString(),
                        MOBILE = dr["MOBILE"].ToString(),
                        ADDRESS = dr["ADDRESS"].ToString(),
                        IS_ACTIVE = (dr["IS_ACTIVE"] as bool?).GetValueOrDefault(),
                        CREATEDBY = dr["CREATEDBY"].ToString(),
                        CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                        UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                        UPDATED_BY = dr["UPDATEDBY"].ToString(),
                        COUNTRY_ID = (dr["COUNTRY_ID"] as int?).GetValueOrDefault(),
                        STATE_ID = (dr["STATE_ID"] as int?).GetValueOrDefault(),
                        CITI_ID = (dr["CITI_ID"] as int?).GetValueOrDefault()

                    };

                    stdobj.Add(std);

                }

                return stdobj;

            }



        }

        public int DELETE(int ID)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ACTION", "DELETE");
                int i = cmd.ExecuteNonQuery();
                return i;
            }

        }

        public int UPDATE(int ID, Students obj)
        {

            using (SqlConnection conn = new SqlConnection(cs))
            {
                DateTime Date = DateTime.Now;


                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", obj.FNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", obj.SNAME);
                cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
                cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
                cmd.Parameters.AddWithValue("@AGE", obj.AGE);
                cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
                cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
                cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
                cmd.Parameters.AddWithValue("@IS_ACTIVE", obj.IS_ACTIVE);
                cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATEDBY);
                cmd.Parameters.AddWithValue("@CREATEDON", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATED_BY);
                cmd.Parameters.AddWithValue("@UPDATEDON", Date.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@COUNTRY_ID  ", obj.COUNTRY_ID);
                cmd.Parameters.AddWithValue("@CITI_ID ", obj.CITI_ID);
                cmd.Parameters.AddWithValue("@STATE_ID", obj.STATE_ID);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ACTION", "UPDATE");

                int i = cmd.ExecuteNonQuery();

                return i;
            }

        }

        public List<Login> LoginStudentWithData(Students obj)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {

                List<Login> log = new List<Login>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "DATA_LOGIN");
                cmd.Parameters.AddWithValue("@USERNAME", obj.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", obj.PASSWORD);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Login logobj = new Login
                    {

                        ID = (dr["ID"] as int?).GetValueOrDefault(),
                        USERNAME = dr["USERNAME"].ToString(),
                        PASSWORD = dr["PASSWORD"].ToString(),
                        FNAME = dr["FNAME"].ToString(),
                        SNAME = dr["SNAME"].ToString(),
                        AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                        EMAIL = dr["EMAIL"].ToString(),
                        MOBILE = dr["MOBILE"].ToString(),
                        ADDRESS = dr["ADDRESS"].ToString(),
                        IS_ACTIVE = (dr["IS_ACTIVE"] as bool?).GetValueOrDefault()

                    };

                    log.Add(logobj);
                }

                return log;
            }


        }
        public int LoginStudent(Students obj)
        {

            using (SqlConnection conn = new SqlConnection(cs))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("studentcrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "LOGIN");
                cmd.Parameters.AddWithValue("@USERNAME", obj.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", obj.PASSWORD);

                int recordCount = (int)cmd.ExecuteScalar();

                return recordCount;
            }


        }
    
     }
}
