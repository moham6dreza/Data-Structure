using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Josephus josephus = new Josephus();
            Console.Write("Enter number of mens : ");
            int n = int.Parse(Console.ReadLine());
            josephus.Create(n);
            Console.Write("\nEnter k among the killed men : ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("\nLast Survived men number : ");
            josephus.survive(k);
            //Console.WriteLine(josephus.count);
            Console.ReadKey();
        }
    }
}
