using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_studentcrudwitstoreproc
{
    public class Students
    {
        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";

        public void GetAllStudentsRecords()
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "SELECT_ALL");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["gp_ID"] + " " + dr["gp_FIRSTNAME"]+ " " + dr["gp_SURNAME"]);
            }
        }
        public void insert()
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("gp_studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gp_ID", 4);
            cmd.Parameters.AddWithValue("@gp_FIRSTNAME", "RAMA");
            cmd.Parameters.AddWithValue("@gp_SURNAME", "KEISHNA");
            cmd.Parameters.AddWithValue("@gp_AGE ", 25);
            cmd.Parameters.AddWithValue("@gp_MOBILE", "91+9658458754");
            cmd.Parameters.AddWithValue("@gp_EMAIL", "ramakrishna@gmail.com");
            cmd.Parameters.AddWithValue("@gp_COUNTRY", "India");
            cmd.Parameters.AddWithValue("@gp_STATE", "Tealangana");
            cmd.Parameters.AddWithValue("@gp_UNIVERSITY", "OU");
            cmd.Parameters.AddWithValue("@gp_COLLEGE", "Siddhartha");
            cmd.Parameters.AddWithValue("@gp_PROGRAM", "BCA");
            cmd.Parameters.AddWithValue("@gp_YEAR", "2023");
            cmd.Parameters.AddWithValue("@gp_CITY", "Hydrabad");
            cmd.Parameters.AddWithValue("@Action", "INSERT");

            int i = cmd.ExecuteNonQuery();

            Console.WriteLine(i);
            
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Students obj = new Students();

            obj.insert();
            Console.ReadLine();


        }
    }
}
