using gp_DALL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace gp_DALL.StudentsRepository
{
    public class studentsRepo
    {
        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";

        public List<Students> GetAllStudentsRecords()
        {
            List<Students> studentsList = new List<Students>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("gp_studentcrud", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "SELECT_ALL");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Students student = new Students
                            {
                                ID = dr["gp_ID"] != DBNull.Value ? dr["gp_ID"].ToString() : null,
                                FIRSTNAME = dr["gp_FIRSTNAME"] != DBNull.Value ? dr["gp_FIRSTNAME"].ToString() : null,
                                SURNAME = dr["gp_SURNAME"] != DBNull.Value ? dr["gp_SURNAME"].ToString() : null,
                                AGE = dr["gp_AGE"] != DBNull.Value ? Convert.ToByte(dr["gp_AGE"]) : (byte)0,
                                MOBILE = dr["gp_MOBILE"] != DBNull.Value ? dr["gp_MOBILE"].ToString() : null,
                                EMAIL = dr["gp_EMAIL"] != DBNull.Value ? dr["gp_EMAIL"].ToString() : null,
                                COUNTRY = dr["gp_COUNTRY"] != DBNull.Value ? dr["gp_COUNTRY"].ToString() : null,
                                STATE = dr["gp_STATE"] != DBNull.Value ? dr["gp_STATE"].ToString() : null,
                                CITY = dr["gp_CITY"] != DBNull.Value ? dr["gp_CITY"].ToString() : null,
                                UNIVERSITY = dr["gp_UNIVERSITY"] != DBNull.Value ? dr["gp_UNIVERSITY"].ToString() : null,
                                COLLEGE = dr["gp_COLLEGE"] != DBNull.Value ? dr["gp_COLLEGE"].ToString() : null,
                                PROGRAM = dr["gp_PROGRAM"] != DBNull.Value ? dr["gp_PROGRAM"].ToString() : null,
                                YEAR = dr["gp_YEAR"] != DBNull.Value ? dr["gp_YEAR"].ToString() : null
                            };
                            studentsList.Add(student);
                        }
                    }
                }
            }
            return studentsList;
        }

        public int Delete (int id)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_ID", id);
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            int i  = cmd.ExecuteNonQuery();

            return i;

        }
    }
}
