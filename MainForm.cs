using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataBinding();
        }

        private void DataBinding()
        {


            Program.Singleton.Instance.Open();
            SqlCommand cmd = new SqlCommand("Select * from dbo.ItemsData", Program.Singleton.db_con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Sell");
            da.Fill(dt);

            Program.Singleton.Instance.Close();

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }


    }
}
