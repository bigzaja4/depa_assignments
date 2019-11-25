using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    interface UserState
    {
        void exit(User user);
        void getIn(User user);
        void getOut(User user);
        void increase(User user);
        void view(User user);
    }
}
