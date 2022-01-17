using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            var Time = new System.Diagnostics.Stopwatch();
            LinkedList list = new LinkedList();
            int choice,
                num_add,
                index_data,
                num_remove,
                Number_of_add,
                insert_data;
            do
            {
                Console.WriteLine("---------------------------------------------------------------------");
                choice = list.Menu();
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("1.Add First\n2.Add Last\n3.Add(index,data)");
                            Console.Write("choice : ");
                            num_add = int.Parse(Console.ReadLine());
                            switch (num_add)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Please enter a data for add the list : ");
                                        insert_data = int.Parse(Console.ReadLine());
                                        list.AddFirst(insert_data);
                                        Console.WriteLine("nodes added");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("enter number of adds : ");
                                        Number_of_add = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Please enter a data for add the list : ");
                                        for (int i = 0; i < Number_of_add; i++)
                                        {
                                            insert_data = int.Parse(Console.ReadLine());
                                            list.AddLast(insert_data);
                                        }
                                        Console.WriteLine("nodes added");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("Please enter a data for add the list : ");
                                        insert_data = int.Parse(Console.ReadLine());
                                        Console.Write("And index : ");
                                        index_data = int.Parse(Console.ReadLine());
                                        list.Add(index_data, insert_data);
                                        Console.WriteLine("node added");
                                        break;
                                    }
                            }break;
                        }
                    case 2:
                        {
                            Console.WriteLine("1.Remove(data)\n2.Remove(index)");
                            Console.Write("choice : ");
                            num_remove = int.Parse(Console.ReadLine());
                            switch (num_remove)
                            {
                                case 1:
                                    {
                                        Console.Write("Please enter data for remove : ");
                                        insert_data = int.Parse(Console.ReadLine());
                                        list.Remove_data(insert_data);
                                        Console.WriteLine("node removed");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Please enter index for remove : ");
                                        index_data = int.Parse(Console.ReadLine());
                                        list.Remove_index(index_data);
                                        Console.WriteLine("node removed");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Please enter new data : ");
                            insert_data = int.Parse(Console.ReadLine());
                            Console.Write("And index : ");
                            index_data = int.Parse(Console.ReadLine());
                            list.Replace(index_data, insert_data);
                            Console.WriteLine("node info updated");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("list cleared");
                            list.Clear();
                            list.ShowAllNodes();
                            Console.WriteLine("list size {0}", list.Count);
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Enter data : ");
                            insert_data = int.Parse(Console.ReadLine());
                            Console.WriteLine("index of data : {0}",list.IndexOf(insert_data));
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Enter index : ");
                            index_data = int.Parse(Console.ReadLine());
                            Console.WriteLine("data is : {0}",list.Get(index_data));
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Enter data : ");
                            insert_data = int.Parse(Console.ReadLine());
                            Console.WriteLine("is contain ? {0}",list.Contains(insert_data));
                            break;
                        }
                    case 8:
                        {
                            list.ShowAllNodes();
                            Console.WriteLine("List reversed");
                            list.Reverse();
                            list.ShowAllNodes();
                            Console.WriteLine("list size : {0}",list.Count);
                            break;
                        }
                    case 9:
                        {
                            list.ShowAllNodes();
                            Time.Start();
                            Console.WriteLine("Removing duplicates--This is from O(n*n)");
                            list.PurgeList();
                            Time.Stop();
                            list.ShowAllNodes();
                            Console.WriteLine("list size {0}",list.Count);
                            Console.WriteLine("Time : {0}", Time.Elapsed.TotalMilliseconds);
                            Time.Restart();
                            Console.WriteLine("Removing duplicates--This is from O(nlogn)");
                            list.purgelist();
                            Time.Stop();
                            list.ShowAllNodes();
                            Console.WriteLine("list size {0}", list.Count);
                            Console.WriteLine("Time : {0}",Time.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("List size : {0}",list.getLength());
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("list elements deleting");
                            list.DeleteListElements();
                            list.ShowAllNodes();
                            Console.WriteLine("list size {0}", list.Count);
                            break;
                        }
                    case 12:
                        {
                            list.ShowAllNodes();
                            break;
                        }
                    case 13:
                        {
                            list.ShowAllNodes();
                            Console.WriteLine("After sort : ");
                            list.MergeSort();
                            list.ShowAllNodes();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("system exit");
                            break;
                        }
                }
            } while (choice != 14);
            Console.ReadKey();
        }
    }
}
