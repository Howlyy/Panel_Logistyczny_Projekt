using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    public partial class AddForm : Form
    {
        
        DbProcedures dbProcedures;
        DateTime _date;
        int month;
        int year;
        int dep;
        
        public AddForm()
        {
            InitializeComponent();
            _date = DateTime.Today;
            month = _date.Month;
            year = _date.Year;
            dep = dbProcedures.DepartmentID(DepLB.Text);
            NumberTB.Text = dbProcedures.ItemLastNumber(dep, month, year).ToString() + "/" + month.ToString() + "/" + year.ToString().Substring(2,2) + "/" + dep.ToString();
            DeliLB.Text = "1";
            DepLB.Text = "Oddział Rzeszów";
        }
        
        int LastNumber(int dep, int month, int year)
        {
            int result = dbProcedures.ItemLastNumber(dep, month, year);

            return result;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            if (DeliLB.Text == "1")
            {
                
                client.ClientCode(new CreateRoadDelivery(), NumberTB.Text, Convert.ToInt32(DeliLB.Text), dep, Program.Singleton.UserId);
            }
            else if (DeliLB.Text == "2")
            {
                client.ClientCode(new CreateWaterDelivery(), NumberTB.Text, Convert.ToInt32(DeliLB.Text), dep, Program.Singleton.UserId);
            }
            else if (DeliLB.Text == "3")
            {
                client.ClientCode(new CreateAirDelivery(), NumberTB.Text, Convert.ToInt32(DeliLB.Text), dep, Program.Singleton.UserId);
            }

        }
    }
}
