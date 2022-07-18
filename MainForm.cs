using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Panel_logistyczny
{
    public partial class MainForm : Form
    {
        private string _number;
        private static int _state;

        public int StateItems 
        {
            get { return _state; }
            set 
            { 
                _state = value;
                
            }
        }
        Receiver receiver = new Receiver();
        Invoker invoker;
       // ObserverState observerState = new ObserverState(_state);

        public MainForm()
        {
            InitializeComponent();
            DataBinding();
            
            //observerState.Attach(new Observer());
        }
        public MainForm(int state)
        {
            var subject = new Subject();
            var observerA = new ObserverState();
            subject.Attach(observerA);
            subject.SomeOperation(_state);


            subject.Detach(observerA);
            subject.SomeOperation(_state);
            //StateItems = state;
            //observerState.Detach(new Observer());


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


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            if (dataGridView1.SelectedRows != null)
            {
                _number = (string)dataGridView1.CurrentRow.Cells["Kod przesyłki"].Value;
                
                if ((string)dataGridView1.CurrentRow.Cells["Stan"].Value == "Przyjęta")
                {
                    _state = 1;
                    //ItemState.Item item = new ItemState.Item(new ItemState.State1());
                    
                }
                else if ((string)dataGridView1.CurrentRow.Cells["Stan"].Value == "Procedowana")
                {
                    _state = 2;
                    //ItemState.Item item = new ItemState.Item(new ItemState.State2());
                }
                else
                {
                    _state = 3;
                    //ItemState.Item item = new ItemState.Item(new ItemState.State3());
                }
            }
            
            
        }

        public  void ButtonsEnable(bool deleteBTN, bool forwardBTN, bool backwardBTN)
        {
            if (deleteBTN == true)
            {
                DeleteBTN.Enabled = true;
            }
            else
            {
                DeleteBTN.Enabled = false;
            }

            if (forwardBTN == true)
            {
                NextStateBTN.Enabled = true;
            }
            else
            {
                NextStateBTN.Enabled = false;
            }

            if (backwardBTN == true)
            {
                BackStateBTN.Enabled = true;
            }
            else
            {
                BackStateBTN.Enabled = false;
            }
        }


        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            DeleteItem delete = new DeleteItem(receiver, _number);
            invoker = new Invoker(delete);
            invoker.Execute();
            dataGridView1.DataSource = null;
            DataBinding();

        }

        private void BackStateBTN_Click(object sender, EventArgs e)
        {
            _state -= 1;
            StateBackward backward = new StateBackward(receiver, _number);
            invoker = new Invoker(backward);
            invoker.Execute();
            dataGridView1.DataSource = null;
            DataBinding();
            
        }

        private void NextStateBTN_Click(object sender, EventArgs e)
        {
            _state += 1;
            StateForward forward = new StateForward(receiver, _number);
            invoker = new Invoker(forward);
            invoker.Execute();
            dataGridView1.DataSource = null;
            DataBinding();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataBinding();
        }

        
    }
}
