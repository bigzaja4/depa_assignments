using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class User
    {
        private string name = "Big";
        private int value = 0;

        private UserState userState = new Out();
        public void setState(UserState us)
        {
            this.userState = us;
        }

        public UserState getState()
        {
            return this.userState;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setValue(int num)
        {
            this.value = num;
        }
        public int getValue()
        {
            return this.value;
        }
        public void getOut()
        {
            userState.getOut(this);
        }

        public void getIn()
        {
            userState.getIn(this);
        }
        public void exit()
        {
            userState.exit(this);
        }
        public void printState()
        {
            userState.view(this);
        }
        public void hello()
        {
            Console.WriteLine("Hello " + name + " , " + value);
        }
        public void increase()
        {
            userState.increase(this);
        }

    }
}
