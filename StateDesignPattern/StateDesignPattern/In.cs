using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class In : UserState
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
            user.setState(new Out());
        }
        public void increase(User user)
        {
            int num = user.getValue() + 1;
            user.setValue(num);
        }

        public void view(User user)
        {
            Console.WriteLine("State ( In )");
        }
    }
}
