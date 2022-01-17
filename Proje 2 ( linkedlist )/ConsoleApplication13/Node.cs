using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    public class Node
    {
        private int data;
        private Node next;
        //constractors
        public Node()
        {
            //data = null;
            next = null;
        }
        public Node(int newdata)
        {
            data = newdata;
            next = null;
        }
        public Node(int newdata,Node newnext)
        {
            data = newdata;
            next = newnext;
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next;
        /*
        public void setNextNode(Node n)
        {
            next = n;
        }
        public Node getNextNode()
        {
            return next;
        }
        public void setData(object o)
        {
            data = o;
        }
        public object getData()
        {
            return data;
        }
        */
    }
}
