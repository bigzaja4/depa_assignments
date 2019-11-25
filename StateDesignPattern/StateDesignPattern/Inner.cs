using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class Inner : UserState
    {
        public void exit(User user)
        {
            user.setState(new Out());
        }

        public void getIn(User user)
        {
            user.setState(new Inner());
        }

        public void getOut(User user)
        {
            user.setState(new In());
        }
        public void increase(User user)
        {
            int num = user.getValue() + 2;
            user.setValue(num);
        }

        public void view(User user)
        {
            Console.WriteLine("State ( Inner )");
        }
    }
}
