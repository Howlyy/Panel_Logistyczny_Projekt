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


    public abstract class Subject 
    {
        private int _state;
        public int StateObser 
        { 
            get { return _state; }
            set
            {
                _state = value;
                if (_state == 3)
                {
                    Notify();
                } }
        }

        private List<IObserver> _observers = new List<IObserver>();

        public Subject(int state)
        {
            StateObser = state;
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



    }

    public class ObserverState : Subject
    {
        public ObserverState(int state) : base(state)
        {

        }
    }

    class Observer : IObserver
    {

        public Observer()
        {

        }

        public void Update(Subject subject)
        {
            MessageBox.Show("Powiadomienie zostało wysłane do oddziału!");
        }
    }
}
