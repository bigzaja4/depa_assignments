using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class Out : UserState
    {
        public void exit(User user)
        {
            user.setState(new Out());
        }

        public void getIn(User user)
        {
            user.setState(new In());
        }
         
        public void getOut(User user)
        {
            user.setState(new Out());
        }
        public void increase(User user)
        {
        }

        public void view(User user)
        {
            Console.WriteLine("State ( Out )");
        }
    }
}
