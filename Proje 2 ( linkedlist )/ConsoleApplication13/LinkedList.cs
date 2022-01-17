using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    public class LinkedList
    {
        public Node head;
        private int count;
        //constractor
        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        //list size
        public int Count
        {
            get { return count; }
        }
        //remove duplicates from Time O(n *n)
        public object PurgeList()
        {

            Node current = head;
            if (IsEmpty() || current == null || current.Next == null) { return current; }
            else
            {
                while (current != null)
                {
                    Node run = current;
                    while (run.Next != null)
                    {
                        if (current.Data.Equals(run.Next.Data))
                        {
                            Node tmp = run.Next; tmp = null;
                            run.Next = run.Next.Next;
                            count--;
                        }
                        else { run = run.Next; }
                    }
                    current = current.Next;
                }
                return current;
            }
        }
        //rempve duplicates from Time O(n *log n)
        public object purgelist()
        {
            Node current = head;
            if (IsEmpty() || current == null || current.Next == null) { return current; }
            else
            {
                while (current.Next != null)
                {
                    if (current.Data.Equals(current.Next.Data))
                    {
                        Node del = current.Next; del = null;
                        current.Next = current.Next.Next;
                        count--;
                    }
                    else { current = current.Next; }
                }
                return current;
            }
        }
        public object this[int index]
        {
            get { return Get(index); }
        }
        public int AddFirst(int InsertData)
        {
            head = new Node(InsertData, head);
            count++;
            return InsertData;
        }
        public int Add(int index,int InsertData)
        {
            if (index > count) { index = count; }
            Node current = head;
            if (IsEmpty() || index == 0) { head = new Node(InsertData, head); }
            else
            {
                for (int i = 0; i < index - 1; i++) { current = current.Next; }
                current.Next = new Node(InsertData, current.Next);
            }
            count++;
            return InsertData;
        }
        public int AddLast(int InsertData)
        {
            return Add(count, InsertData);
        }
        public object Remove_index(int index)
        {
            if (IsEmpty()) return null;
            if (index > count) index = count - 1;
            Node current = head;
            object result = null;
            if (index == 0)
            {
                result = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++) current = current.Next;
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public object Remove_data(int InsertData)
        {
            int index = IndexOf(InsertData);
            Node current = head;
            object result = null;
            if (index == 0)
            {
                result = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++) current = current.Next;
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public void Clear()
         {
             head = null;
             count = 0;
         }
        public object Reverse()
        {
            if (Count <= 1)
            {
                return head;
            }
            Node current = head;
            Node run = current.Next;
            Node tmp = run.Next;
            current.Next = null;
            while (tmp != null)
            {
                run.Next = current;
                current = run;
                run = tmp;
                tmp = tmp.Next;
            }
            run.Next = current;
            head = run;
            return head;
        }
        public int IndexOf(int InsertData)
        {
            Node current = head;
            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(InsertData)) return i;
                current = current.Next;
            }
            return -1;
        }
        public bool Contains(int InsertData)
        {
            return IndexOf(InsertData) >= 0;
        }
        public object Get(int index)
        {
            if (IsEmpty() || index < 1) return null;
            //if index bigger than list size
            if (index > count) index = count - 1;
            Node current = head;
            for (int i = 0; i < index - 1; i++) current = current.Next;
            return current.Data;
        }
        public int getLength()
        {
            int size = 0;
            Node current = head;
            while (current != null)
            {
                current = current.Next;
                size++;
            }
            return size;
        }
        public bool Replace(int index, int InsertData)
        {
            if (IsEmpty() || index < 1) { return false; }
            Node current = head;
            for (int i = 1; i < index; i++) { current = current.Next; }
            current.Data = InsertData;
            return true;
        }
        public void ShowAllNodes()
        {
            if (IsEmpty()) { Console.WriteLine("list is empty"); }
            else
            {
                Console.WriteLine("list is ");
                Node current = head;
                while (current != null)
                {
                    Console.Write("{0} -> ", current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        public int Menu()
        {
            int Choice;
            Console.WriteLine("\tMenu\n*****************************\n1.Add\n2.Remove\n3.Replace\n4.Clear the List\n5.Index of Data\n6.Get Data\n7.Contains Data\n8.Reverse the List\n9.Purgelist\n10.Get Lenght of List\n11.Delete List Elements\n12.ShowList\n13.MergeSort");
            Console.WriteLine("*****************************");
            Console.Write("Choice A Number : ");
            Choice = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------");
            return Choice;
        }
        public void DeleteListElements()
        {
            while (head != null)
            {
                Node curr = head;
                head = head.Next;
                curr = null;
            }
            count = 0;
        }
        public void split(Node L,out Node L1,out Node L2)
        {
            if (L == null)
            {
                L1 = null;
                L2 = null;
                return;
            }
            if (L.Next == null)
            {
                L1 = null;
                L2 = L;
                return;
            }
            L1 = L;
            L2 = L.Next;
            split(L2.Next,out L.Next,out L2.Next);
            return;
        }
        //combine 2 sorted lists
        public Node Merge(Node L1, Node L2)
        {
            if (L1 == null) return L2;
            if (L2 == null) return L1;
            else if (L1.Data <= L2.Data)
            {
                L1.Next = Merge(L1.Next, L2);
                return L1;
            }
            else
            {
                L2.Next = Merge(L1, L2.Next);
                return L2;
            }
        }
        //split list and merge
        public void MergeSort()
        {
            if (getLength() > 1)
            {
                LinkedList L1 = new LinkedList();
                LinkedList L2 = new LinkedList();
                split(head,out L1.head,out L2.head);
                L1.MergeSort();
                L2.MergeSort();
                head = Merge(L1.head, L2.head);
            }
        }
    }
}
