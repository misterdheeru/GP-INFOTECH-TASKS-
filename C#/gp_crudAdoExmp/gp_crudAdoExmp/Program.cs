using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_crudAdoExmp
{

    public class std
    {
        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";
        public void createtable ()
        {
         
            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "create table std (id int primary key , name varchar(255) , mobile varchar(255))";
            SqlCommand cmd = new SqlCommand(querry, conn);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public void INSERTRECORD()
        {

            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "insert into std values (@id , @name ,@mobile)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@id", 5);
            cmd.Parameters.AddWithValue("@name", "SUNIL KUMAR");
            cmd.Parameters.AddWithValue("@mobile", "91+3652458745");
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("RECORD IS INSERTED  " + i);
            Console.ReadLine();
        }

        public void UPDATERRECORD()
        {
            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "update  std set mobile = @mobile where id = @id";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.Parameters.AddWithValue("@mobile", "91+9854785412");
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("RECORD IS UPDATED  " + i);
            Console.ReadLine();
        }
        public void DELETERECORD()
        {
            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "delete from std where id=@id";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@id", 5);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("RECORD IS UPDATED  " + i);
            Console.ReadLine();
        }
        public  void SELECTRECORD()
        {
            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "select *from std";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader dr =  cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["id"] + " " + dr["name"] + " " + dr["mobile"]);
            }
            conn.Close();
            Console.ReadLine();
        }
        public void SELECCTSINGLERECORD()
        {
            SqlConnection conn = new SqlConnection(this.cs);
            conn.Open();
            string querry = "select id , name , mobile  from std where id=@id";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@id", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["id"] + " " + dr["name"] + " " + dr["mobile"]);
            }
            conn.Close();
            Console.ReadLine();
        }


    }
    public class Program
    {

        static void Main(string[] args)
        {
            std obj = new std();
            obj.SELECCTSINGLERECORD();
        }
    }
}
