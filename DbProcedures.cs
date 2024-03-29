﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    class DbProcedures
    {
        public ObservableCollection<string> departmentsNames = new ObservableCollection<string>();
        public ObservableCollection<string> deliveryType = new ObservableCollection<string>();

        public DbProcedures()
        {

        }
        public int ItemLastNumber(int dep, int month, int year)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.LastNumerByDepartment", Program.Singleton.db_con);
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
        public int AddItem(string number, int deliveryType, int department, int userId)
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
        public int DepartmentID(string depName)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.DepartmentId", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = depName;
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int result = (int)cmd.Parameters["@result"].Value;



            return result;
        }
        public int DeliveryTypID (string deliveryName)
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("dbo.DeliveryTypeId", Program.Singleton.db_con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = deliveryName;
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Program.Singleton.Instance.Close();

            int result = (int)cmd.Parameters["@result"].Value;



            return result;
        }

        public void DepartmentToList()
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("Select dp_nazwa from dbo.Departments", Program.Singleton.db_con);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();




            while (sqlDataReader.Read())
            {
                departmentsNames.Add(sqlDataReader.GetString("dp_nazwa"));
            }



            Program.Singleton.Instance.Close();
        }

        public void DeliveryToList()
        {


            Program.Singleton.Instance.Open();

            SqlCommand cmd = new SqlCommand("Select dv_nazwa from dbo.Delivery_type", Program.Singleton.db_con);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();




            while (sqlDataReader.Read())
            {
                deliveryType.Add(sqlDataReader.GetString("dv_nazwa"));
            }



            Program.Singleton.Instance.Close();
        }
    }

   

}
