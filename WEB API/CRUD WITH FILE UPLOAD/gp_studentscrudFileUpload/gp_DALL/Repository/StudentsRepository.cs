using gp_DALL.Models;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace gp_DALL.Repository
{
    public class StudentsRepository
    {

        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";
     
        public List<GETALL> GetAllSutents()
        {
            List<GETALL> std = new List<GETALL>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GETALL obj = new GETALL
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
                    IS_ACTIVE = (dr["IS_ACTIVE"] as bool?).GetValueOrDefault(),
                    CREATEDBY = dr["CREATEDBY"].ToString(),
                    CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                    UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                    UPDATED_BY = dr["UPDATEDBY"].ToString(),
                    COUNTRY_NAME = dr["COUNTRY_NAME"].ToString(),
                    STATE_NAME = dr["STATE_NAME"].ToString(),
                    CITI_NAME = dr["CITY_NAME"].ToString(),

                };

                std.Add(obj);
            }

            return std;
        }
        public int InsertRecord(Students obj)
        {
            DateTime Date = DateTime.Now;



            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obj.ID);
            cmd.Parameters.AddWithValue("@USERNAME", obj.USERNAME);
            cmd.Parameters.AddWithValue("@PASSWORD", obj.PASSWORD);
            cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
            cmd.Parameters.AddWithValue("@IS_ACRIVE", obj.IS_ACTIVE);
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

        public List<GETALL> SingelStudent(int ID)
        {
            List<GETALL> std = new List<GETALL>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SINGLE");
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GETALL obj = new GETALL
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
                    IS_ACTIVE = (dr["IS_ACTIVE"] as bool?).GetValueOrDefault(),
                    CREATEDBY = dr["CREATEDBY"].ToString(),
                    CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                    UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                    UPDATED_BY = dr["UPDATEDBY"].ToString(),
                    COUNTRY_NAME = dr["COUNTRY_NAME"].ToString(),
                    STATE_NAME = dr["STATE_NAME"].ToString(),
                    CITI_NAME = dr["CITY_NAME"].ToString(),

                };

                std.Add(obj);
            }

            return std;
        }

        public int DeleteStudent(int ID)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@ACTION", "DELETE");
            int i = cmd.ExecuteNonQuery();
            return i;

        }

        public int UpdateStudent(int ID, Students obj)
        {
            DateTime Date = DateTime.Now;

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERNAME", obj.USERNAME);
            cmd.Parameters.AddWithValue("@PASSWORD", obj.PASSWORD);
            cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
            cmd.Parameters.AddWithValue("@IS_ACRIVE", obj.IS_ACTIVE);
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

        public List<Login> GetLogin(Students objs)
        {
            List<Login> std = new List<Login>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "LOGIN");
            cmd.Parameters.AddWithValue("@USERNAME", objs.USERNAME);
            cmd.Parameters.AddWithValue("@PASSWORD", objs.PASSWORD);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Login obj = new Login
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

                std.Add(obj);
            }

            return std;
        }

    }
}

