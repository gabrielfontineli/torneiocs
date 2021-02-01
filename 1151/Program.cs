using System;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int ant = 0;
            int prox = 0;
            int fib = 1;
            for (int i = 1;i<=n;i++){
                if(i==n) Console.WriteLine(ant);
                else Console.Write(ant+" ");
                prox = ant+fib;
                ant = fib;
                fib = prox;

            }
            
        }
    }
}
