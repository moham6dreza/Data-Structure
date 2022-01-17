using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    public class TREE
    {
        private Node ROOT;
        /** Constructor **/
        public TREE()
        {
            //create the dummy node
            // 
            ROOT = new Node(int.MaxValue);
            ROOT.LeftBit = 0;        // Left Child Is Thread
            ROOT.RightBit = 1;      // Right Child Is Link
            ROOT.Left = ROOT.Right = ROOT;
        }
        public bool IsEmpty()
        {
            return ROOT.Left == ROOT;
        }
        public int Menu()
        {
            Console.WriteLine("-----------TREE-----------\n");
            Console.WriteLine("1.Insert\n2.Delete\n3.Search\n4.Traversals\n5.Clear");
            Console.Write("----------- Choice  ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void ClearTREE()
        {
            ROOT = new Node(int.MaxValue);
            ROOT.LeftBit = 0;        // Left Child Is Thread
            ROOT.RightBit = 1;      // Right Child Is Link
            ROOT.Left = ROOT.Right = ROOT;
        }
        public bool Search(int key)
        {
            Node Current = ROOT.Left;
            for (;;)
            {
                if (Current.DATA < key)
                {
                    if (Current.RightBit == 0) { return false; }
                    Current = Current.Right;
                }
                else if (Current.DATA > key)
                {
                    if (Current.LeftBit == 0) { return false; }
                    Current = Current.Left;
                }
                else { return true; }
            }
        }
        public void Delete(int key)
        {
            Node Current = ROOT.Left;
            Node p = ROOT;
            for (;;)
            {
                if (Current.DATA < key)
                {    //not found 
                    if (Current.RightBit == 0) return;
                    p = Current;
                    Current = Current.Right;
                }
                else if (Current.DATA > key)
                {   // not found
                    if (Current.LeftBit == 0) return;
                    p = Current;
                    Current = Current.Left;
                }
                else { break; } //found // bingo
            }
            Node Target = Current;
            if (Current.LeftBit == 1 && Current.RightBit == 1)
            {
                // current has two children
                p = Current;
                // find largest node at left child
                Target = Current.Left;
                while (Target.LeftBit == 0)
                {
                    p = Target;
                    Target = Target.Right;
                }
                //using replace mode
                Current.DATA = Target.DATA;
            }
            if (p.DATA >= Target.DATA)
            {
                if (Target.RightBit == 0 && Target.LeftBit == 0)
                {
                 /*      p
                  *     /
                  *  target 
                  */   
                    p.Left = Target.Left;
                    p.LeftBit = 0;
                }
                else if (Target.RightBit == 0)
                {
                 /*         p
                  *        /
                  *     target
                  *      /
                  *  target.left 
                  */
                    Node largest = Target.Left;
                    while (largest.RightBit == 1)
                    {
                        largest = largest.Right;
                    }
                    largest.Right = p;
                    p.Left = Target.Left;
                }
                else
                {
                 /*         p
                  *        /
                  *     target
                  *        \
                  *       target.right 
                  */
                    Node smallest = Target.Right;
                    while (smallest.LeftBit == 1)
                    {
                        smallest = smallest.Left;
                    }
                    smallest.Left = Target.Left;
                    p.Left = Target.Right;
                }
            }
            else
            {
                if (Target.RightBit == 0 && Target.LeftBit == 0)
                {
                 /*    p
                  *     \
                  *     target 
                  */
                    p.Right = Target.Right;
                    p.RightBit = 0;
                }
                else if (Target.RightBit == 0)
                {
                 /*     p
                  *      \
                  *      target
                  *       / 
                  *  target.left 
                  */
                    Node largest = Target.Left;
                    while (largest.RightBit == 1)
                    {
                        largest = largest.Right;
                    }
                    largest.Right = Target.Right;
                    p.Right = Target.Left;
                }
                else
                {
                 /*     p
                  *      \
                  *      target
                  *         \ 
                  *    target.left 
                  */
                    Node smallest = Target.Right;
                    while (smallest.LeftBit == 1)
                    {
                        smallest = smallest.Left;
                    }
                    smallest.Left = p;
                    p.Right = Target.Right;
                }
            }
        }
        public Node Start()
        {
            return ROOT.Left;
        }
        public void Inorder_Left_Threading(Node Parent,Node Child)
        {
            Child.Left = Parent.Left;
            Child.LeftBit = Parent.LeftBit;
            Child.Right = Parent;
            Child.RightBit = 0;
            Parent.Left = Child;
            Parent.LeftBit = 1;
        }
        public void Inorder_Right_Threading(Node Parent,Node Child)
        {
            Child.Right = Parent.Right;
            Child.RightBit = Parent.RightBit;
            Child.Left = Parent;
            Child.LeftBit = 0;
            Parent.Right = Child;
            Parent.RightBit = 1;
        }
        public void insert2(Node[] Arr)
        {
            int i = 0; // current
            int j = 1; //for left child
            int k = 2; // for right child

            while (k < Arr.Length)
            {
                int root = i;
                int leftChild = 2 * i + 1;
                int rightChild = 2 * i + 2;

                if (ROOT.Left == ROOT && ROOT.Right == ROOT)
                {
                    Node newNode2 = Arr[root];
                    newNode2.Left = ROOT;
                    ROOT.Left = newNode2;
                    newNode2.LeftBit = ROOT.LeftBit;
                    ROOT.LeftBit = 1;
                    newNode2.Right = ROOT;
                }
                else
                {
                    Node Current = ROOT.Left;
                    while (true)
                    {
                        if (j == leftChild)
                        {
                            if (Current.LeftBit == 0)
                            {
                                //directionLeft = true;
                                break;
                            }
                            else { Current = Current.Left; }
                        }
                    }
                    Node Current1 = ROOT.Left;
                    while (true)
                    {
                        if (k == rightChild)
                        {
                            if (Current1.RightBit == 0)
                            {
                                //directionRight = true;
                                break;
                            }
                            else { Current1 = Current1.Right; }
                        }
                    }
                }
                i++;
                k += 2;
                j += 2;
            }
        }
        public void insert(int DATA)
        {
            // create new node with data DATA
            Node newNode = new Node(DATA);
            //check if new node is going to be first actual node in the tree.
            if (ROOT.Left == ROOT && ROOT.Right == ROOT)
            {
                newNode.Left = ROOT;
                ROOT.Left = newNode;
                newNode.LeftBit = ROOT.LeftBit;
                ROOT.LeftBit = 1;
                newNode.Right = ROOT;
            }
            else
            {
                Node Current = ROOT.Left;
                while (true)
                {
                    if (Current.DATA > newNode.DATA)
                    {   
                        // no child
                        if (Current.LeftBit == 0)
                        {
                            //node will be added as Left child
                            Inorder_Left_Threading(Current, newNode);
                            break;
                        }
                        else { Current = Current.Left; }
                    }
                    else
                    {
                        // no child
                        if (Current.RightBit == 0)
                        {
                            //node will be added as Right child
                            Inorder_Right_Threading(Current, newNode);
                            break;
                        }
                        else { Current = Current.Right; }
                    }
                }
            }
        }
        public void inorder_recursive(Node temp)
        {
            if (temp != null)
            {
                if (temp.LeftBit == 1) { inorder_recursive(temp.Left); }
                Console.Write("  " + temp.DATA);
                if (temp.RightBit == 1) { inorder_recursive(temp.Right); }
            }
        }
        public void pre_recursive(Node temp)
        {
            if (temp != null)
            {
                Console.Write("  " + temp.DATA);
                if (temp.LeftBit == 1) { pre_recursive(temp.Left); }
                if (temp.RightBit == 1) { pre_recursive(temp.Right); }
            }
        }
        public void Pos_recursive(Node temp)
        {
            if (temp != null)
            {
                if (temp.LeftBit == 1) { Pos_recursive(temp.Left); }
                if (temp.RightBit == 1) { Pos_recursive(temp.Right); }
                Console.Write("  " + temp.DATA);
            }
        }
        public void Levelorder()
        {
            Queue<Node> Queue = new Queue<Node>();
            Node Current = ROOT.Left;
            Queue.Enqueue(Current);
            while (Queue.Count != 0)
            {
                Current = Queue.Dequeue();
                if (Current != null)
                {
                    Console.Write("  " + Current.DATA);
                    if (Current.LeftBit == 1) { Queue.Enqueue(Current.Left); }
                    if (Current.RightBit == 1) { Queue.Enqueue(Current.Right); }
                }
            }
            Console.WriteLine();
        }
        public void Preorder_Stack()
        {
            Stack<Node> Stack = new Stack<Node>();
            Node Current = ROOT.Left;
            Stack.Push(Current);
            while (Stack.Count != 0)
            {
                Node node = Stack.Peek();
                Console.Write("  " + node.DATA);
                Stack.Pop();
                if (node.RightBit == 1) { Stack.Push(node.Right); }
                if (node.LeftBit == 1) { Stack.Push(node.Left); }
            }
            Console.WriteLine();
        }
        public void Preorder()
        {
            if (IsEmpty()) { Console.WriteLine("Tree Empty"); return; }
            Node Current = ROOT.Left;
            while (Current != ROOT)
            {
                Console.Write("  " + Current.DATA);
                if (Current.LeftBit == 1) { Current = Current.Left; }
                else
                {
                    if (Current.RightBit == 1) { Current = Current.Right; }
                    else
                    {
                        while (Current != ROOT && Current.RightBit == 0) { Current = Current.Right; }
                        if (Current != ROOT) { Current = Current.Right; }
                    }
                }
            }
            Console.WriteLine();
        }
        public void Postorder_2Stack()
        {
            Stack<Node> Stack1 = new Stack<Node>();
            Stack<Node> Stack2 = new Stack<Node>();
            //
            Node Current = ROOT.Left;
            Stack1.Push(Current);
            while (Stack1.Count != 0)
            {
                Node TEMP = Stack1.Pop();
                Stack2.Push(TEMP);
                if (TEMP.LeftBit == 1) { Stack1.Push(TEMP.Left); }
                if (TEMP.RightBit == 1) { Stack1.Push(TEMP.Right); }
            }
            while (Stack2.Count != 0)
            {
                Node TEMP = Stack2.Pop();
                Console.Write("  " + TEMP.DATA);
            }
            Console.WriteLine();
        }
        public void inorder_stack()
        {
            Stack<Node> Stack = new Stack<Node>();
            Node Current = ROOT.Left;
            while(true)
            {
                if (Current!=null)
                {
                    Stack.Push(Current);
                    Current = Current.Left;
                }
                else
                {
                    if (Stack.Count > 0)
                    {
                        Current = Stack.Pop();
                        Console.Write("  " + Current.DATA);
                        Current = Current.Right;
                    }
                    else break;
                }
            }
        }
        public void Inorder()
        {
            //start from the Left child of the dummy node
            Node Current = ROOT.Left;
            //go to the Left most node
            while (Current.LeftBit == 1)
            {
                Current = Current.Left;
            }
            //now keep traversing the next inorder successor and print it
            while (Current != ROOT)
            {
                Console.Write("  " + Current.DATA);
                Current = findNextInorder(Current);
            }
            Console.WriteLine();
        }
        public Node findNextInorder(Node Current)
        {
            //if RightBit of Current node is 0 means Current node does not
            //have Right child so use the Right pointer to move to its
            // inorder successor.
            if (Current.RightBit == 0)
            {
                return Current.Right;
            }
            //if RightBit of Current node is 0 means Current node does
            //have Right child so go to the Left most node in Right sub tree.
            Current = Current.Right;
            while (Current.LeftBit != 0)
            {
                Current = Current.Left;
            }
            return Current;
        }
    }
}
