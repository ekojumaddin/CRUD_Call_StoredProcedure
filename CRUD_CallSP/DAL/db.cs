using CRUD_CallSP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_CallSP.DAL
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void Create(barang b)
        {
            SqlCommand command = new SqlCommand("SP_Barang_Add", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nama_barang", b.nama_barang);
            command.Parameters.AddWithValue("@harga_barang", b.harga_barang);
            command.Parameters.AddWithValue("@total_barang", b.total_barang);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public void Edit(barang b)
        {
            SqlCommand command = new SqlCommand("SP_Barang_Update", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@kode_barang", b.kode_barang);
            command.Parameters.AddWithValue("@nama_barang", b.nama_barang);
            command.Parameters.AddWithValue("@harga_barang", b.harga_barang);
            command.Parameters.AddWithValue("@total_barang", b.total_barang);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public DataSet ShowById(int id)
        {
            SqlCommand com = new SqlCommand("SP_Barang_Id", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@kode_barang", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet Index()
        {
            SqlCommand com = new SqlCommand("SP_Barang_All", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void Delete(int id)
        {
            SqlCommand com = new SqlCommand("SP_Barang_Delete", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@kode_barang", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}