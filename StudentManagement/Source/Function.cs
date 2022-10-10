using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagement
{
    class Function
    {
        protected SqlConnection getconnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-PIL7QJIO\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
            return conn;
        }

        public DataTable getdata(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void setdata(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
