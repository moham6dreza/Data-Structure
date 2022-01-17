using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notations
{
    public class Polish
    {
        /**Convert InFix To PostFix**/
        public string PostFix(string InFix)
        {
            Stack<char> Stack = new Stack<char>();
            StringBuilder PostFix = new StringBuilder();
            foreach (char c in InFix.ToCharArray())
            {
                // c >= '0'  &&  c <= '9'
                if (char.IsNumber(c)) { PostFix.Append(c); }
                else if (c == '(') { Stack.Push(c); }
                else if (c == ')')
                {
                    while (Stack.Count > 0 && Stack.Peek() != '(') { PostFix.Append(Stack.Pop()); }
                    // '(' poped from stack
                    if (Stack.Count > 0) { Stack.Pop(); }
                }// + - / * ^ %
                else if (IsOperator(c))
                {
                    while (Stack.Count > 0 && Stack.Peek() != '(')
                    {// stack => ( *          c => +   
                        if (Priority(Stack.Peek()) >= Priority(c)) { PostFix.Append(Stack.Pop()); }
                        else { break; }
                    }// stack => ( +
                    Stack.Push(c);
                }
            }
            //if any operators remain in the stack, pop all & add to postfix until stack is empty 
            while (Stack.Count > 0) { PostFix.Append(Stack.Pop()); }
            //Console.WriteLine("PostFix " + PostFix);
            return PostFix.ToString();
        }

        /**Convert InFix To PreFix**/
        public string PreFix(string InFix) 
        {
            //Console.WriteLine("InFix " + InFix);
            StringBuilder str = new StringBuilder();
            StringBuilder str1 = new StringBuilder();
            //Reverse infix and all [ '(' => ')' ] And  [ ')' => '(' ]
            for (int i = InFix.Length - 1; i >= 0; i--)
            {
                char c = InFix[i];
                if (c == '(') { c = ')'; }
                else if (c == ')') { c = '('; }
                str.Append(c);
            }
            //Console.WriteLine("Reverse " + str);
            //Change to postfix
            string pos = PostFix(str.ToString());
            //Reverse Again
            for (int i = pos.Length - 1; i >= 0; i--)
            {
                char c = pos[i];
                str1.Append(c);
            }
            //Console.WriteLine("Reverse Again\nPreFix  " + str1);
            return str1.ToString();
        }

        /**Evaluation PostFix**/
        public int EvaluatePostFix(string postfix)
        {
            int Result;
            Stack<int> outStack = new Stack<int>();
            foreach (char c in postfix.ToCharArray())
            {
                if (char.IsNumber(c)) { outStack.Push((int)c - '0'); }
                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '^' || c == '%')
                {
                    Result = ApplyOperatorPostFix(outStack.Pop(), outStack.Pop(), c);
                    outStack.Push(Result);
                }
            }
            //Console.WriteLine("Result of Expression " + outStack.Peek());
            return outStack.Peek();
        }

        /**Evaluation PreFix**/
        public int EvaluatePreFix(string PreFix)
        {
            int Result;
            Stack<int> outStack = new Stack<int>();
            for (int i = PreFix.Length - 1; i >= 0; i--)
            {
                char c = PreFix[i];
                if (char.IsNumber(c)) { outStack.Push((int)c - '0'); }
                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '^' || c == '%')
                {
                    Result = ApplyOperatorPreFix(outStack.Pop(), outStack.Pop(), c);
                    outStack.Push(Result);
                }
            }
            return outStack.Peek();
        }

        /**Checking InFix Expression for Fully Parenthisizaed**/
        public bool CheckInFix(string InFix)
        {
            int a = 0, b = 0;
            for (int i = 0; i < InFix.Length; i++)
            {
                char c = InFix[i];
                if (c == '(') { a++; }
                else if (c == ')') { b++; }
            }
            return a == b;
        }

        /**Priority Of Operators**/
        private int Priority(char c)
        {
            if (c == '^') { return 3; }
            else if (c == '*' || c == '/' || c == '%') { return 2; }
            else if (c == '+' || c == '-') { return 1; }
            else { return -1; }
        }

        /** Operators**/
        private bool IsOperator(char c)
        {
            return (c == '+' || c == '-' || c == '^' || c == '*' || c == '/' || c == '%');
        }

        /**Apply Operator To Evalution PostFix Expression**/
        private int ApplyOperatorPostFix(int a, int b, char c)
        {
            if (c == '+') { return (b + a); }
            else if (c == '-') { return (b - a); }
            else if (c == '*') { return (b * a); }
            else if (c == '/') { return (b / a); }
            else if (c == '^') { return Convert.ToInt32(Math.Pow(b, a)); }
            else if (c == '%') { return (b % a); }
            else { return -1; }
        }

        /**Apply Operator To Evalution PreFix Expression**/
        private int ApplyOperatorPreFix(int a, int b, char c)
        {
            if (c == '+') { return (a + b); }
            else if (c == '-') { return (a - b); }
            else if (c == '*') { return (a * b); }
            else if (c == '/') { return (a / b); }
            else if (c == '^') { return Convert.ToInt32(Math.Pow(a, b)); }
            else if (c == '%') { return (a % b); }
            else { return -1; }
        }
    }
}
