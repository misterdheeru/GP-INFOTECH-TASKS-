using gp_DALL.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace gp_DALL.Repo
{
    public  class StudentsRepo
    {
        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";


        public List<Students> GetAll()
        {
            List<Students> objstd = new List<Students>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Students obj = new Students
                {

                    ID = (dr["ID"] as int?).GetValueOrDefault(),
                    FNAME = dr["FNAME"].ToString(),
                    SNAME = dr["SNAME"].ToString(),
                    COUNTRY = dr["COUNTRY"].ToString(),
                    CITY = dr["CITY"].ToString(),
                    AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                    STATE = dr["STATE"].ToString(),
                    UNIVERSITY = dr["UNIVERSITY"].ToString(),
                    COLLEGE = dr["COLLEGE"].ToString(),
                    PROGRAM = dr["PROGRAM"].ToString(),
                    YEAR = dr["YEAR"].ToString(),
                    EMAIL = dr["EMAIL"].ToString(),
                    MOBILE = dr["MOBILE"].ToString()

                };

                objstd.Add(obj);
            }

            return objstd;



        }
        public int InsertRecord(Students obj)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_ID", obj.ID);
            cmd.Parameters.AddWithValue("@gp_FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@gp_SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@gp_AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@gp_MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@gp_EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@gp_COUNTRY", obj.COUNTRY);
            cmd.Parameters.AddWithValue("@gp_STATE", obj.STATE);
            cmd.Parameters.AddWithValue("@gp_CITY", obj.CITY);
            cmd.Parameters.AddWithValue("@gp_UNIVERSITY", obj.UNIVERSITY);
            cmd.Parameters.AddWithValue("@gp_COLLEGE", obj.COLLEGE);
            cmd.Parameters.AddWithValue("@gp_PROGRAM", obj.PROGRAM);
            cmd.Parameters.AddWithValue("@gp_YEAR", obj.YEAR);
            cmd.Parameters.AddWithValue("@ACTION", "INSERT");

            int i = cmd.ExecuteNonQuery();

            return i;
        }

        public int DeleteRecord(int ID)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_ID", ID);
            cmd.Parameters.AddWithValue("@ACTION", "DELETE");
            int i = cmd.ExecuteNonQuery();

            return i;
        }

        public int UpdateRecord(Students obj, int ID)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@gp_SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@gp_AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@gp_MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@gp_EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@gp_COUNTRY", obj.COUNTRY);
            cmd.Parameters.AddWithValue("@gp_STATE", obj.STATE);
            cmd.Parameters.AddWithValue("@gp_CITY", obj.CITY);
            cmd.Parameters.AddWithValue("@gp_UNIVERSITY", obj.UNIVERSITY);
            cmd.Parameters.AddWithValue("@gp_COLLEGE", obj.COLLEGE);
            cmd.Parameters.AddWithValue("@gp_PROGRAM", obj.PROGRAM);
            cmd.Parameters.AddWithValue("@gp_YEAR", obj.YEAR);
            cmd.Parameters.AddWithValue("@gp_ID", ID);
            cmd.Parameters.AddWithValue("@ACTION", "UPDATE");

            int i = cmd.ExecuteNonQuery();

            return i;

        }
        public List<Students> GetSingle(int ID)
        {
            List<Students> objstd = new List<Students>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_ID", ID);
            cmd.Parameters.AddWithValue("@ACTION", "SELECT_SINGLE_RECORD");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Students obj = new Students
                {

                    ID = (dr["ID"] as int?).GetValueOrDefault(),
                    FNAME = dr["FNAME"].ToString(),
                    SNAME = dr["SNAME"].ToString(),
                    COUNTRY = dr["COUNTRY"].ToString(),
                    CITY = dr["CITY"].ToString(),
                    AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                    STATE = dr["STATE"].ToString(),
                    UNIVERSITY = dr["UNIVERSITY"].ToString(),
                    COLLEGE = dr["COLLEGE"].ToString(),
                    PROGRAM = dr["PROGRAM"].ToString(),
                    YEAR = dr["YEAR"].ToString(),
                    EMAIL = dr["EMAIL"].ToString(),
                    MOBILE = dr["MOBILE"].ToString()

                };

                objstd.Add(obj);
            }

            return objstd;



        }


    }


}

