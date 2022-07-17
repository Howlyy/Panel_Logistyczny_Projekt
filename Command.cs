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
        private Receiver _receiver;
        private DbProcedures _dbProc;
        

        public AddItem(Receiver receiver, string number, int deliveryType)
        {
            this._number = number;
            this._deliveryType = deliveryType;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.AddItem();

            _dbProc.AddItem(_number, _deliveryType, _userId);
        }

    }

    public class DeleteItem : ICommand
    {
        private string _number;
        private Receiver _receiver;
        private DbProcedures _dbProc;


        public DeleteItem(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.AddItem();

            _dbProc.DeleteItem(_number);
        }

    }

    public class StateForward : ICommand
    {
        private string _number;
        private Receiver _receiver;
        private DbProcedures _dbProc;


        public StateForward(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.AddItem();

            _dbProc.ChangingState(_number, "Forward");
        }

    }

    public class StateBackward : ICommand
    {
        private string _number;
        private Receiver _receiver;
        private DbProcedures _dbProc;


        public StateBackward(Receiver receiver, string number)
        {
            this._number = number;
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.AddItem();

            _dbProc.ChangingState(_number, "Backward");
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
