using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    public class Josephus
    {
        private Node head,
            current,
            temp;
        private int count;
        private int Size()
        {
            return count;
        }
        private bool IsEmpty()
        {
            return Size() == 0;
        }
        public void Create(int n)
        {
            head = current = new Node(1);
            temp = current;
            for (int i = 2; i <= n; i++)
            {
                temp.Next = new Node(i, temp.Next);
                temp = temp.Next;
            }//circular
            temp.Next = current;
            count = n;
        }
        private void Delete_After(Node node)
        {
            if (IsEmpty() || node == null || node.Next == null)
            { Console.WriteLine("Element Does Not Exit"); }
            else
            {
                current = node.Next;
                node.Next = current.Next;
                //current = null;
                count--;
            }
        }
        public void survive(int k)
        {
            current = head;
            if (k == 1)
            {
                //while remain one node
                while (current.Next != current)
                {
                    Delete_After(current);
                    current = current.Next;
                }
                Console.WriteLine(current.Data);
            }
            else
            {
                for (int i = 0; i < k - 1; i++)
                { current = current.Next; }
                Delete_After(current);
                //
                while (current.Next != current)
                {
                    for (int i = 0; i < k; i++)
                    { current = current.Next; }
                    Delete_After(current);
                }
                Console.WriteLine(current.Data);
            }
        }
    }
}