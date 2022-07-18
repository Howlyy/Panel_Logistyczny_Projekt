using System;
using System.Collections.Generic;
using System.Text;

namespace Panel_logistyczny
{
    class ItemState
    {
        
        public abstract class State
        {
            protected Item _item;

            public void SetContext(Item item)
            {
                this._item = item;
            }

            public abstract void HandleForward();
            public abstract void HandleBackward();

        }

        public class Item
        {
            private State _state = null;
            public Item(State state)
            {
                this.TransitionTo(state);
            }

            public void TransitionTo(State state)
            {
                this._state = state;
                this._state.SetContext(this);
            }
            public void StateForward()
            {
                this._state.HandleForward();
            }
            public void StateBackward()
            {
                this._state.HandleBackward();
            }

        }

        public class State1  : State
        {
            

            public State1()
            {
                //MainForm main;
                //main.ButtonsEnable(true, false, true);
            }

            public override void HandleForward()
            {
                this._item.TransitionTo(new State2());
            }

            public override void HandleBackward()
            {
            }

        }
        public class State2 : State
        {
            public State2()
            {
               // MainForm main = new MainForm();
                //main.ButtonsEnable(false, true, true);
            }
            public override void HandleForward()
            {
                this._item.TransitionTo(new State3());
            }

            public override void HandleBackward()
            {
                this._item.TransitionTo(new State1());
            }

        }

        public class State3 : State
        {
            public State3()
            {
               // MainForm main = new MainForm();
               // main.ButtonsEnable(false, false, true);
            }
            public override void HandleForward()
            {

            }

            public override void HandleBackward()
            {
                this._item.TransitionTo(new State2());
            }

        }


    }
}
