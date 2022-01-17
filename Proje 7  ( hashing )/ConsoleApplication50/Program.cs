using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Size Of Table : ");
            int n = int.Parse(Console.ReadLine());
            HashTABLE Table = new HashTABLE(n);
            int choice;
            do
            {
                choice = Table.Menu();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("How many keys do you want to add  ");
                            int num = int.Parse(Console.ReadLine());
                            if (num > n) num = n;
                            Console.WriteLine("Enter keys");
                            for (int i = 0; i < num; i++)
                            {
                                int key = Convert.ToInt32(Console.ReadLine());
                                Table.Add(key);
                            }
                            Console.WriteLine("keys Are Adding");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter key For Search  ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            if (Table.Search(key) == -1) Console.WriteLine("Not Found");
                            else Console.WriteLine("loc : {0}",Table.Search(key));
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter key To Remove  ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            Table.Remove(key);
                            Console.WriteLine("Key Is Removing");
                            break;
                        }
                    case 4:
                        {
                            Table.GetSize();
                            Console.WriteLine("-----------PRINT.Table-----------");
                            Table.Print();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("TABLE Cleared");
                            Table.MakeEmpty();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong number");
                            break;   
                        }
                }
            } while (choice != 6);
        }
    }
}
