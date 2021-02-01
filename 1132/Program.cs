using System;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
                    int x, y;
            int soma = 0; int i = 0; int aux = 0;
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    if (y < x)
    {
      aux = x;
      x = y;
      y = aux;
    }
    for (i = x; i <= y; i++)
    {
      if (i % 13 != 0)
      {
        soma += i;
      }
    }
    Console.WriteLine(soma);

        }
    }
}
