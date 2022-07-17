using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Panel_logistyczny
{
    class DbProcedures
    {
        public DbProcedures()
        {

        }
        public int ItemLastNumber(int dep, int month, int year)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.LastNumberByDepartment", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dep", SqlDbType.Int).Value = dep;
            cmd.Parameters.AddWithValue("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.AddWithValue("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.AddWithValue("@number", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int number = (int)cmd.Parameters["@number"].Value;



            return number;
        }
        public int AddItem(string number, int deliveryType, int userId)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.AddItem", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@number", SqlDbType.VarChar).Value = number;
            cmd.Parameters.AddWithValue("@delivery", SqlDbType.Int).Value = deliveryType;
            cmd.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int result = (int)cmd.Parameters["@result"].Value;



            return result;
        }
        public int DeleteItem(string number)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.DeleteItem", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@number", SqlDbType.VarChar).Value = number;
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int result = (int)cmd.Parameters["@result"].Value;



            return result;
        }
        public int ChangingState(string number, string mode)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.ChangingState", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@it_code", SqlDbType.VarChar).Value = number;
            cmd.Parameters.AddWithValue("@mode", SqlDbType.VarChar).Value = mode;
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int result = (int)cmd.Parameters["@result"].Value;



            return result;
        }
    }

   

}
