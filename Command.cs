using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    public interface ICommand
    {
        void Execute();

    }

    
    public class AddItem : ICommand
    {
        private string _number;
        private int _deliveryType;
        private int _userId = Program.Singleton.UserId;
        private int _department;
        private Receiver _receiver;
        DbProcedures proc = new DbProcedures();
        

        public AddItem(Receiver receiver, string number, int deliveryType, int department)
        {
            this._number = number;
            this._deliveryType = deliveryType;
            this._department = department;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.AddItem();

            proc.AddItem(_number, _deliveryType, _department, _userId);
        }

    }

    public class DeleteItem : ICommand
    {
        private string _number;
        private Receiver _receiver;
        DbProcedures proc = new DbProcedures();

        public DeleteItem(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.DeleteItem();
            proc.DeleteItem(_number);
        }

    }

    public class StateForward : ICommand
    {
        private string _number;
        private Receiver _receiver;
        DbProcedures proc = new DbProcedures();


        public StateForward(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.StateForward();

            int result = proc.ChangingState(_number, "Forward");

            MainForm main = new MainForm(result);
            
        }

    }

    public class StateBackward : ICommand
    {
        private string _number;
        private Receiver _receiver;
        DbProcedures proc = new DbProcedures();


        public StateBackward(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.StateBackward();
            proc.ChangingState(_number, "Backward");
        }

    }


    public class Receiver
    {

        public void AddItem()
        {
            MessageBox.Show("Dodawanie przesyłki");
        }
        public void DeleteItem()
        {
            MessageBox.Show("Usuwanie przesyłki");
        }
        public void StateForward()
        {
            MessageBox.Show("Zmiana stanu przesyłki na następny");
        }
        public void StateBackward()
        {
            MessageBox.Show("Zmiana stanu przesyłki na poprzedni");
        }

    }

    public class Invoker
    {
        private ICommand _command;
        public Invoker(ICommand command)
        {
            this._command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
    
}
