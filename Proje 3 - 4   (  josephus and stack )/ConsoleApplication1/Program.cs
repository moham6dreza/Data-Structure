using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SEQ obj = new SEQ();
            int[] A = { 5, 4, 6, 3, 7, 2, 1, 8 };
            obj.IsProduct(A);
            Console.ReadKey();
        }
    }
}
class SEQ
{
    public void IsProduct(int[] InputArray)
    {
        Stack<int> stack = new Stack<int>();
        int[] ArrayOne = new int[InputArray.Length];
        int[] ArrayTwo = new int[InputArray.Length];
        // ArrayOne[] = { 1,2,3,4,5,6,....}
        for (int i1 = 0; i1 < InputArray.Length; i1++)
        {
            ArrayOne[i1] = i1 + 1;
        }
        //Reverse  ArrayOne[] = { ... , 6,5,4,3,2,1 }
        Array.Reverse(ArrayOne);
        // Counters
        int i = 0; // for InputArray
        int j = 0; // for ArrayOne
        int k = 0; // for ArrayTwo
        while (i < InputArray.Length && j < ArrayOne.Length && k < ArrayTwo.Length)
        {
            //if stack is empty
            if (stack.Count == 0)
            {
                stack.Push(ArrayOne[j]);
                Console.Write("Push({0}) ", ArrayOne[j]);
                j++;
            }
            else if (stack.Peek() == InputArray[i])
            {
                ArrayTwo[k] = stack.Pop();
                Console.Write("Pop({0}) ", ArrayTwo[k]);
                k++;
                i++;
            }
            else
            {
                stack.Push(ArrayOne[j]);
                Console.Write("Push1({0})  ", ArrayOne[j]);
                j++;
            }
        }
        if (ArrayTwo.Length == InputArray.Length) Console.WriteLine(" >>>Yes");
        else Console.WriteLine(">>>No");
    }
}