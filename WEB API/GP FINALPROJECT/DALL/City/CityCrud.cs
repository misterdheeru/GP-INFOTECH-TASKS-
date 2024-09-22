using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.City
{
    public class CityCrud
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=gp_webapi;uid=sa;pwd=123";
        public List<City> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<City> std = new List<City>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("citiescrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    City obj = new City
                    {
                        CITI_ID = (dr["CITI_ID"] as int?).GetValueOrDefault(),
                        CITI_CODE = dr["CITY_CODE"].ToString(),
                        CITI_NAME = dr["CITY_NAME"].ToString(),
                        CREATED_BY = dr["CREATED_BY"].ToString(),
                        CREATED_ON = dr["CREATED_ON"].ToString(),
                        UPDATED_BY = dr["UPDATED_BY"].ToString(),
                        UPDATED_ON = dr["UPDATED_ON"].ToString(),
                        COUNTRY_ID = (dr["COUNTRY_ID"] as int?).GetValueOrDefault(),
                        STATE_ID = (dr["STATE_ID"] as int?).GetValueOrDefault()
                    };

                    std.Add(obj);
                }

                return std;
            }

        }
    }
}
