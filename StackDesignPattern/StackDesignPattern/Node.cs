using System;
using System.Collections.Generic;
using System.Text;

namespace StackDesignPattern
{
    class Node
    {
        private string message;
        public Node leftNode;
        public Node rightNode;

        public Node()
        {
            this.leftNode = this.rightNode = null;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }

        public string getMessage()
        {
            return this.message;
        }
    }
}
