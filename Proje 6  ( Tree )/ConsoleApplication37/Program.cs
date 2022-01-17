using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            TREE TREE = new TREE();
            int choice;
            do
            {
                choice = TREE.Menu();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("\nEnter number of items to insert  ");
                            int items = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Your items");
                            for (int j = 0; j < items; j++)
                            {
                                int item = int.Parse(Console.ReadLine());
                                TREE.insert(item);
                            }
                            Console.WriteLine("Items inserted\n");
                            break;
                        }
                    case 2:
                        {
                            if (!TREE.IsEmpty())
                            {
                                Console.Write("\nEnter your item to delete  ");
                                int item = int.Parse(Console.ReadLine());
                                TREE.Delete(item);
                                Console.WriteLine("Item deleted"); Console.WriteLine();
                            }
                            else { Console.WriteLine("Tree is empty"); }
                            break;
                        }
                    case 3:
                        {
                            if (!TREE.IsEmpty())
                            {
                                Console.Write("\nEnter your item to search  ");
                                int item = int.Parse(Console.ReadLine());
                                if (TREE.Search(item)) { Console.WriteLine("Item " + item + " Found in tree"); }
                                else { Console.WriteLine("Item " + item + " not Found in tree"); }
                                Console.WriteLine();
                            }
                            else { Console.WriteLine("Tree is empty"); }
                            break;
                        }
                    case 4:
                        {
                            if (!TREE.IsEmpty())
                            {
                                Console.WriteLine("\n-----------Traversals-----------\n");

                                Console.WriteLine("Level Order");
                                TREE.Levelorder();

                                Console.WriteLine("\nInOrder");
                                Console.WriteLine("with insuccessor");
                                TREE.Inorder();
                                //Console.WriteLine("with stack");
                                //TREE.inorder_stack();
                                Console.WriteLine("with recursion");
                                TREE.inorder_recursive(TREE.Start());

                                Console.WriteLine("\n\nPreOrder");
                                Console.WriteLine("with thread");
                                TREE.Preorder();
                                Console.WriteLine("with stack");
                                TREE.Preorder_Stack();
                                Console.WriteLine("with recursion");
                                TREE.pre_recursive(TREE.Start());

                                Console.WriteLine("\n\nPostOrder");
                                Console.WriteLine("with 2 stacks");
                                TREE.Postorder_2Stack();
                                Console.WriteLine("with recursion");
                                TREE.Pos_recursive(TREE.Start());
                                Console.WriteLine(); Console.WriteLine();
                            }
                            else { Console.WriteLine("\nTree is empty\n"); }
                            break;
                        }
                    case 5:
                        {
                            TREE.ClearTREE();
                            Console.WriteLine("\nTree Cleared"); Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.Write("\nEnter number of items to insert  ");
                            int items = int.Parse(Console.ReadLine());
                            Node[] Array = new Node[items];
                            Console.WriteLine("Enter Your items");
                            for (int j = 0; j < items; j++)
                            {
                                int item = int.Parse(Console.ReadLine());
                                Array[j] = new Node(item);
                            }
                            for (int i = 0; i < Array.Length; i++)
                            {
                                Console.Write(" " + Array[i].DATA);
                            }
                            Console.WriteLine();
                            TREE.insert2(Array);
                            TREE.inorder_recursive(TREE.Start()); Console.WriteLine();
                            break;
                        }
                    default: { Console.WriteLine("\nWrong number\n"); break; }
                }
            } while (choice != 7);

            Console.ReadKey();
        }
    }
}