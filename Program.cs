using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logowanie());
        }

        public sealed class Singleton
        {
            private static Singleton _instance = null;
            private static readonly object padlock = new object();
            public static SqlConnection db_con;
            public static int UserId;
            public static int UserType;

            private Singleton()
            {
                db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["PLdb"].ConnectionString);
            }

            public static Singleton Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                        return _instance;
                    }
                }
            }

            public void Open()
            {
                db_con.Open();
            }
            public void Close()
            {
                db_con.Close();
            }

            public void SetUserId(string login, string pass)
            {
                _instance.Open();

                SqlCommand cmd = new SqlCommand("dbo.LogId", db_con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@login", SqlDbType.Int).Value = login;
                cmd.Parameters.AddWithValue("@password", SqlDbType.Int).Value = pass;
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@typ", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();


                var Id = cmd.Parameters["@id"].Value;
                var Type = cmd.Parameters["@typ"].Value;

                _instance.Close();

                UserId = Convert.ToInt32(Id);
                UserType = Convert.ToInt32(Type);
            }        
        }
    }
}
