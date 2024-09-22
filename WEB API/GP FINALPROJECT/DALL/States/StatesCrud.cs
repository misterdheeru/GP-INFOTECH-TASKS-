using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.States
{
    public class StatesCrud
    {
        string cs = "server=LAPTOP-0C6MBQ3H;database=gp_webapi;uid=sa;pwd=123";
        public List<States> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<States> std = new List<States>();


                conn.Open();
                SqlCommand cmd = new SqlCommand("statescrud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    States obj = new States
                    {

                        STATES_ID = (dr["STATE_ID"] as int?).GetValueOrDefault(),
                        STATES_CODE = dr["STATE_CODE"].ToString(),
                        STATES_NAME = dr["STATE_NAME"].ToString(),
                        CREATED_BY = dr["CREATED_BY"].ToString(),
                        CREATED_ON = dr["CREATED_ON"].ToString(),
                        UPDATED_ON = dr["UPDATED_ON"].ToString(),
                        UPDATED_BY = dr["UPDATED_BY"].ToString(),
                        COUNTRY_ID = (dr["COUNTRY_ID"] as int?).GetValueOrDefault()

                    };

                    std.Add(obj);
                }

                return std;
            }

        }

    }


}
