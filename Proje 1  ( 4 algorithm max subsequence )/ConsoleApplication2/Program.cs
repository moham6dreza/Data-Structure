using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ایجاد داده های تصادفی
            Random objRandom = new Random();
            int[] Arr1 = new int[2000];

            for (int k = 0; k < Arr1.Length; k++)
            {
                Arr1[k] = objRandom.Next(-50000, 50000);
                //Console.WriteLine(Arr1[k]);
            }
            //محاسبه زمان بر حسب میلی ثانیه
            var time = System.Diagnostics.Stopwatch.StartNew();

            All_Algoritms obj = new All_Algoritms();

            Console.WriteLine("\n\t\t\t    W E L L C O M E");
            Console.WriteLine("_________________________________________________________________________\n");
            Console.WriteLine("\t\t\t\tMAX_SUB\t\t\t  Time(ms)\n\n\t\t\t    ****************\t     ******************\n");

            Console.Write("  Algoritm_1 =>\t\t\t{0}", obj.Algoritm_1(Arr1));
            time.Stop();
            Console.Write("\t\t\t{0}\n\n\n", time.Elapsed.TotalMilliseconds);

            time.Restart();
            Console.Write("  Algoritm_2 =>\t\t\t{0}", obj.Algoritm_2(Arr1));
            time.Stop();
            Console.Write("\t\t\t{0}\n\n\n", time.Elapsed.TotalMilliseconds);

            time.Restart();
            Console.Write("  Algoritm_3 =>\t\t\t{0}", obj.Algoritm_3(Arr1));
            time.Stop();
            Console.Write("\t\t\t{0}\n\n\n", time.Elapsed.TotalMilliseconds);

            time.Restart();
            Console.Write("  Algoritm_4 =>\t\t\t{0}", obj.Algoritm_4(Arr1));
            time.Stop();
            Console.Write("\t\t\t{0}\n\n", time.Elapsed.TotalMilliseconds);
            
            Console.WriteLine("__________________________________________________________________________\n");
            Console.WriteLine("\tResult =>  Algoritm_1 >> Algoritm_2 > Algoritm_3 > Algoritm_4");
            Console.WriteLine("\n\t\t   O(n *n *n) >>  O(n *n)   > O(n *Logn) > O(n)");
            Console.WriteLine("\n\n\tF I N I S H");

            Console.ReadKey();
        }
    }
}
class All_Algoritms
{
    public int Algoritm_1(int[] Array)
    {
        //algoritm1 ===> O(n*n*n)
        int maxSum = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = i; j < Array.Length; j++)
            {
                int thisSum = 0;
                for (int k = i; k <= j; k++)
                    thisSum += Array[k];
                if (thisSum > maxSum) { maxSum = thisSum; }
            }
        }
        return maxSum;
    }
    //********************************************************************************************************************
    public int Algoritm_2(int[] Array)
    {
        //algoritm2 ===> O(n*n)
        int maxSum = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            int thisSum = 0;
            for (int j = i; j < Array.Length; j++)
            {
                thisSum += Array[j];
                if (thisSum > maxSum) { maxSum = thisSum; }
            }
        }
        return maxSum;
    }
    //********************************************************************************************************************
    public int max(int a, int b)
    {
        return (a > b) ? a : b;
    }
    public int Divide_and_Conquer_Func(int[] Array, int Start, int End)
    {
        //algoritm3 ===> O(nlogn)
        //اگر ارایه یک عنصر داشته باشد ان را برمیگرداند
        if (Start == End) { return Array[Start]; }
        //عنصر وسطی
        int Mid = (Start + End) / 2; ;
        //نیمه ی سمت چپ ارایه
        int Left_Half_Func = Divide_and_Conquer_Func(Array, Start, Mid);
        //نیمه ی سمت راست ارایه 
        int Right_Half_Func = Divide_and_Conquer_Func(Array, Mid + 1, End);

        int Max_in_left = 0;
        int Max_in_right = 0;
        int thisSum = 0;

        for (int i = Mid; i >= Start; i--)
        {
            thisSum += Array[i];
            if (thisSum > Max_in_left) { Max_in_left = thisSum; }
        }

        thisSum = 0;
        for (int j = Mid + 1; j <= End; j++)
        {
            thisSum += Array[j];
            if (thisSum > Max_in_right) { Max_in_right = thisSum; }
        }

        return max(max(Left_Half_Func, Right_Half_Func), (Max_in_left + Max_in_right));
    }
    public int Algoritm_3(int[] Array)
    {
        if (Array.Length == 0) { return 0; }
        return Divide_and_Conquer_Func(Array, 0, Array.Length - 1);
    }
    //********************************************************************************************************************
    public int Algoritm_4(int[] Array)
    {
        //algoritm4 ===> O(n)
        int maxSum = 0;
        int thisSum = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            thisSum += Array[i];
            if (thisSum > maxSum) { maxSum = thisSum; }
            else if (thisSum < 0) { thisSum = 0; }
        }
        return maxSum;
    }
}