using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Country
{
    public class CountrysCrud
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=gp_webapi;uid=sa;pwd=123";
        public List<Country> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<Country> std = new List<Country>();

                conn.Open();
                SqlCommand cmd = new SqlCommand("countryscrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Country obj = new Country
                    {
                        COUNTRY_ID = (dr["COUNTRY_ID"] as int?).GetValueOrDefault(),
                        COUNTRY_CODE = dr["COUNTRY_CODE"].ToString(),
                        COUNTRY_NAME = dr["COUNTRY_NAME"].ToString(),
                        CREATED_BY = dr["CREATED_BY"].ToString(),
                        CREATED_ON = dr["CREATED_ON"].ToString(),
                        UPDATED_BY = dr["UPDATED_BY"].ToString(),
                        UPDATED_ON = dr["UPDATED_ON"].ToString(),
                        COUNTRY_IMG_Path = dr["COUNTRY_IMG_Path"].ToString(),
                    };

                    std.Add(obj);
                }

                return std;
            }



        }
    }
}
