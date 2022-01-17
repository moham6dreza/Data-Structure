using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    public class Node
    {
        public int DATA;
        public int LeftBit;
        public int RightBit;
        public Node Left;
        public Node Right;
        public Node(int data)
        {
            DATA = data;
        }
    }
}
