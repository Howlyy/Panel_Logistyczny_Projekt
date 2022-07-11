using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    

    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Program.Singleton.Instance.SetUserId(LoginTB.Text, PassTB.Text);


            if (Program.Singleton.UserId != 0)
            {
                this.Hide();
                mainForm.Show();

                MessageBox.Show($"Id: {Program.Singleton.UserId} --- type: {Program.Singleton.UserType}");
            }
            else
            {
                MessageBox.Show("Błędne dane logowania...");
                MessageBox.Show($"Id: {Program.Singleton.UserId} --- type: {Program.Singleton.UserType}");
            }
        }

    }
}
