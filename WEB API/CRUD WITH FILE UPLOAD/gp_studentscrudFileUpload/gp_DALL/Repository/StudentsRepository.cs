﻿using gp_DALL.Models;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace gp_DALL.Repository
{
    public class StudentsRepository
    {

        string cs = "server=.;database=gp_webapi;uid=sa;pwd=123";
        public List<GetAllStd> GetAllSutents()
        {
            List<GetAllStd> std = new List<GetAllStd>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SELECT_ALL");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GetAllStd obj = new GetAllStd
                {

                    ID = (dr["ID"] as int?).GetValueOrDefault(),
                    FNAME = dr["FNAME"].ToString(),
                    SNAME = dr["SNAME"].ToString(),
                    AGE   = (dr["AGE"] as int?).GetValueOrDefault(),
                    YEAR = dr["YEAR"].ToString(),
                    EMAIL = dr["EMAIL"].ToString(),
                    MOBILE = dr["MOBILE"].ToString(),
                    ADDRESS = dr["ADDRESS"].ToString(),
                    ISACTIVE = (dr["ISACTIVE"] as bool?).GetValueOrDefault(),
                    CREATEDBY = dr["CREATEDBY"].ToString(),
                    CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                    UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                    UPDATEDBY = dr["UPDATEDBY"].ToString(),
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
            cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
            cmd.Parameters.AddWithValue("@ISACTIVE", obj.ISACTIVE);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATEDBY);
            cmd.Parameters.AddWithValue("@CREATEDON", Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATEDBY);
            cmd.Parameters.AddWithValue("@UPDATEDON", Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@COUNTRY_ID  ", obj.COUNTRY_ID);
            cmd.Parameters.AddWithValue("@CITI_ID ", obj.CITI_ID);
            cmd.Parameters.AddWithValue("@STATE_ID", obj.STATE_ID);
            cmd.Parameters.AddWithValue("@ACTION", "INSERT");

            int i = cmd.ExecuteNonQuery();

            return i;
        }

        public  List<GetAllStd> SingelStudent(int ID)
        {
            List<GetAllStd> std = new List<GetAllStd>();

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ACTION", "SINGLE");
            cmd.Parameters.AddWithValue("@ID",ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GetAllStd obj = new GetAllStd
                {

                    ID = (dr["ID"] as int?).GetValueOrDefault(),
                    FNAME = dr["FNAME"].ToString(),
                    SNAME = dr["SNAME"].ToString(),
                    AGE = (dr["AGE"] as int?).GetValueOrDefault(),
                    YEAR = dr["YEAR"].ToString(),
                    EMAIL = dr["EMAIL"].ToString(),
                    MOBILE = dr["MOBILE"].ToString(),
                    ADDRESS = dr["ADDRESS"].ToString(),
                    ISACTIVE = (dr["ISACTIVE"] as bool?).GetValueOrDefault(),
                    CREATEDBY = dr["CREATEDBY"].ToString(),
                    CREATEDON = (dr["ID"] as DateTime?).GetValueOrDefault(),
                    UPDATEDON = (dr["UPDATEDON"] as DateTime?).GetValueOrDefault(),
                    UPDATEDBY = dr["UPDATEDBY"].ToString(),
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
            int i  =  cmd.ExecuteNonQuery();
            return i;

        }

        public int UpdateStudent(int ID , Students obj)
        {
            DateTime Date = DateTime.Now;

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentcrud", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FNAME", obj.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", obj.SNAME);
            cmd.Parameters.AddWithValue("@AGE", obj.AGE);
            cmd.Parameters.AddWithValue("@MOBILE", obj.MOBILE);
            cmd.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            cmd.Parameters.AddWithValue("@ADDRESS", obj.ADDRESS);
            cmd.Parameters.AddWithValue("@ISACTIVE", obj.ISACTIVE);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CREATEDBY);
            cmd.Parameters.AddWithValue("@CREATEDON", Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UPDATEDBY);
            cmd.Parameters.AddWithValue("@UPDATEDON", Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@COUNTRY_ID  ", obj.COUNTRY_ID);
            cmd.Parameters.AddWithValue("@CITI_ID ", obj.CITI_ID);
            cmd.Parameters.AddWithValue("@STATE_ID", obj.STATE_ID);
            cmd.Parameters.AddWithValue("@ID",ID);
            cmd.Parameters.AddWithValue("@ACTION", "UPDATE");

            int i = cmd.ExecuteNonQuery();

            return i;
        }

    }
}
