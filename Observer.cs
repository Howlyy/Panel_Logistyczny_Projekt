using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Panel_logistyczny
{
    public interface IObserver
    {
        void Update(Subject subject);
    }


    public  class Subject 
    {
        private int _state;
        public int StateObser 
        { 
            get { return _state; }
            set { _state = value; }
        }

        private List<IObserver> _observers = new List<IObserver>();

        public Subject()//int state
        {
            
        }

        public void Attach(IObserver observer)
        {

            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
               
                observer.Update(this);
            }
        }


        public void SomeOperation(int state)
        {
            StateObser = state;
            Notify();
        }


    }

    public class ObserverState : IObserver
    {
        public ObserverState() 
        {

        }

        public void Update(Subject subject)
        {
            if (subject.StateObser == 3)
            {
                MessageBox.Show("Powiadomienie zostało wysłane do oddziału!");
            }
        }
    }

}
