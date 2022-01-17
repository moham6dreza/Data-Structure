using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    public class HashTABLE
    {
        private static int CurrentSize;
        private static  int MaxCapacity = 1000;
        private HashNode[] TABLE;

        //** Constructor **//
        public HashTABLE(int size)
        {
            CurrentSize = 0;
            MaxCapacity = size;
            TABLE = new HashNode[MaxCapacity];
            for (int i = 0; i < MaxCapacity; i++)
            {
                TABLE[i] = null;
            }
        }
        public HashTABLE()
        {
            CurrentSize = 0;
            TABLE = new HashNode[MaxCapacity];
            for (int i = 0; i < MaxCapacity; i++)
            {
                TABLE[i] = null;
            }
        }
        public int GetSize()
        {
            Console.WriteLine("Table Current Size : " + CurrentSize);
            return CurrentSize;
        }
        private bool ISFull()
        {
            return CurrentSize == MaxCapacity;
        }
        private bool ISEmpty()
        {
            return CurrentSize == 0;
        }
        public void MakeEmpty()
        {
            CurrentSize = 0;
            TABLE = new HashNode[MaxCapacity];
        }
        public int HashFunc(int key)
        {
            return key % MaxCapacity;
        }
        public void Add(int key)
        {
            if (ISFull())
            { Console.WriteLine("Full"); return; }
            int loc = HashFunc(key);
            while (TABLE[loc] != null && TABLE[loc].key != key)
                loc = (loc + 1) % MaxCapacity;
            TABLE[loc] = new HashNode(key);
             CurrentSize++;
        }
        public int Search(int key)
        {
            int loc = HashFunc(key);
            while (TABLE[loc] != null)
            {
                if (TABLE[loc].key == key) return loc;
                loc = (loc + 1) % MaxCapacity;
            }
            return -1;
        }
        public bool Contain(int key)
        {
            return Search(key) != -1;
        }
        public void Remove(int key)
        {
            if (ISEmpty() || !Contain(key))
            { Console.WriteLine("Empty Or not exist"); return; }
            int loc = Search(key);
            //TABLE[loc].Deleted = true;
            TABLE[loc] = null;
            CurrentSize--;
        }
        public void Print()
        {
            if (ISEmpty())
            { Console.WriteLine("Empty");return; }
            for (int i = 0; i < MaxCapacity; i++)
            {
                if (TABLE[i] != null)
                { Console.WriteLine("{0} => {1}", i, TABLE[i].key); }
            }
            Console.WriteLine();
        }
        public int Menu()
        {
            Console.WriteLine("-----------HASH.TABLE-----------");
            Console.WriteLine("1.Insert");
            Console.WriteLine("2.Search");
            Console.WriteLine("3.Remove");
            Console.WriteLine("4.Print");
            Console.WriteLine("5.Clear");
            Console.Write("choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}