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

        DbProcedures dbProcedures = new DbProcedures();
        DateTime _date;
        int month;
        int year;
        int dep;
        int deli;
        Receiver receiver = new Receiver();
        Invoker invoker;
        
        public AddForm()
        {
            InitializeComponent();

            _date = DateTime.Today;
            month = _date.Month;
            year = _date.Year;
            


            dbProcedures.DepartmentToList();
            DepLB.DataSource = dbProcedures.departmentsNames;
            dep = dbProcedures.DepartmentID(DepLB.Text);

            dbProcedures.DeliveryToList();
            DeliLB.DataSource = dbProcedures.deliveryType;
            deli = dbProcedures.DeliveryTypID(DeliLB.Text);

            NumberTB.Text = dbProcedures.ItemLastNumber(dep, month, year).ToString() + "/" + month.ToString() + "/" + year.ToString().Substring(2, 2) + "/" + dep.ToString();

        }

        public void AddBTN_Click(object sender, EventArgs e)
        {

            AddItem addItem = new AddItem(receiver, NumberTB.Text, DeliLB.Text, dep);
            invoker = new Invoker(addItem);
            invoker.Execute();

           
            this.Hide();


        }

        private void DepLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            dep = dbProcedures.DepartmentID(DepLB.Text);
            NumberTB.Text = dbProcedures.ItemLastNumber(dep, month, year).ToString() + "/" + month.ToString() + "/" + year.ToString().Substring(2, 2) + "/" + dep.ToString();
            DepLB.Refresh();
        }
    }
}
