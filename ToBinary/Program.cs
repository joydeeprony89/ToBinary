using System;
using System.Collections.Generic;

namespace ToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ToBinary(10);
            Console.WriteLine(str);
            ToDecimal(str);
            ToBinaryV(10); 
        }

        public static string ToBinary(int n)
        {
            if (n < 2) return n.ToString();

            int div = n / 2;
            int rem = n % 2;

            return ToBinary(div) + rem;
        }

        public static void ToBinaryV(int n)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(n);

            while(n > 1)
            {
                n = n / 2;
                stack.Push(n);
            }

            foreach (int i in stack)
                Console.WriteLine(i % 2);
        }

        public static void ToDecimal(string str)
        {
            int result = 0;
            for(int i = 0; i < str.Length; i++)
            {
                int val = Convert.ToInt32(str[i].ToString());
                if (val > 1) throw new Exception("Invalid Data!");
                else if (val == 1)
                    result += (int)Math.Pow(2, str.Length - 1 - i);
            }

            Console.WriteLine(result);
        }
    }
}
