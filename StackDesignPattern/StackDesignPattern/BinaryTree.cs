using System;
using System.Collections.Generic;
using System.Text;

namespace StackDesignPattern
{
    class BinaryTree
    {
        Node root;
        
        public BinaryTree()
        {
            root = null;
        }

        public Node add(Node node, string message)
        {
            if(node == null)
            {
                node = new Node();
                node.setMessage(message);
                return node;
            }

            if (message.CompareTo(node.getMessage()) < 0)
            {
                node.leftNode = add(node.leftNode, message);
            }
            else if(message.CompareTo(node.getMessage()) > 0)
            {
                node.rightNode = add(node.rightNode, message);
            }
            return node;
        }
        
        public void add(string message)
        {
            this.root = add(this.root, message);
        }

        public void printNode(Node root)
        {
            if(root != null)
            {
                printNode(root.leftNode);
                Console.WriteLine(root.getMessage());
                printNode(root.rightNode);
            }
        }

        public void printNode()
        {
            this.printNode(this.root);
        }
     
    }
}
