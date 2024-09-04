using gp_DALL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace gp_DALL.Repository
{
    public class CountriesRepository
    {
        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";
        public List<Countrys> GetAllCountrys()
        {
            List<Countrys> std = new List<Countrys>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("countryscrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Countrys obj = new Countrys
                {
                    COUNTRY_ID = (dr["COUNTRY_ID"] as int?).GetValueOrDefault(),
                    COUNTRY_CODE = dr["COUNTRY_CODE"].ToString(),
                    COUNTRY_NAME = dr["COUNTRY_NAME"].ToString(),
                    CREATED_BY = dr["CREATED_BY"].ToString(),
                    CREATED_ON = dr["CREATED_ON"].ToString(),
                    UPDATED_BY = dr["UPDATED_BY"].ToString(),
                    UPDATED_ON = dr["UPDATED_ON"].ToString(),
                    COUNTRY_IMG = dr["COUNTRY_IMG"] as byte[]  ,
                   
                };
                std.Add(obj);
            }

            return std;
        }
        public int InsertRecord(Countrys obj)
        {

            DateTime Date = DateTime.Now;

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("countryscrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "INSERT");
            cmd.Parameters.AddWithValue("@ID", obj.COUNTRY_ID);
            cmd.Parameters.AddWithValue("@CODE", obj.COUNTRY_CODE);
            cmd.Parameters.AddWithValue("@NAME", obj.COUNTRY_NAME);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATED_BY);
            cmd.Parameters.AddWithValue("@CREATEDON", Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATED_BY);
            cmd.Parameters.AddWithValue("@COUNTRY_IMG", obj.COUNTRY_IMG ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@COUNTRY_IMG_PATH", obj.COUNTRY_IMG_Path ?? (object)DBNull.Value);  // New parameter
            int i = cmd.ExecuteNonQuery();
            return i;

        }
        public int UpdateCountrys(int ID, Countrys obj)
        {
            DateTime Date = DateTime.Now;

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("countryscrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "UPDATE");
            cmd.Parameters.AddWithValue("@ID", obj.COUNTRY_ID);
            cmd.Parameters.AddWithValue("@CODE", obj.COUNTRY_CODE);
            cmd.Parameters.AddWithValue("@NAME", obj.COUNTRY_NAME);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATED_BY);
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATED_BY);
            cmd.Parameters.AddWithValue("@UPDATEDON", Date.ToString("MM/dd/yyyy"));

            int i = cmd.ExecuteNonQuery();

            return i;
        }

        public int DeleteCountrys(int ID)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("countryscrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "DELETE");
            cmd.Parameters.AddWithValue("@ID", ID);
            int i = cmd.ExecuteNonQuery();

            return i;
        }

    }
}
