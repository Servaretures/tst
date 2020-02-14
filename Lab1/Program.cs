using System;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("V = " + Convert.ToString(Calculate(a)));
            Console.WriteLine("S = " + Convert.ToString(Calculate2(a)));
        }
        public static int Calculate(int s)
        {
            int v = s * s * s;
            return v;
        }
        public static int Calculate2(int s)
        {
            int d = 6 * s * s;
            return d;
        }
    }
}
