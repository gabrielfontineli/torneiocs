using System;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
    double s = double.Parse(Console.ReadLine());
    double t = 0;

    if (s < 400.01) {
      t = s + s * 0.15;
      Console.WriteLine($"Novo salario: {t:.00}");
      Console.WriteLine($"Reajuste ganho: {s * 0.15:.00}");
      Console.WriteLine("Em percentual: 15 %");
    }
    if (400.00 < s && s < 800.01) {
      t = s + s * 0.12;
      Console.WriteLine($"Novo salario: {t:.00}");
      Console.WriteLine($"Reajuste ganho: {s * 0.12:.00}");
      Console.WriteLine("Em percentual: 12 %");
    }
    if (800.00 < s && s < 1200.01) {
      t = s + s * 0.1;
      Console.WriteLine($"Novo salario: {t:.00}");
      Console.WriteLine($"Reajuste ganho: {s * 0.1:.00}");
      Console.WriteLine("Em percentual: 10 %");
    }
    if (1200.00 < s && s < 2000.01) {
      t = s + s * 0.07;
      Console.WriteLine($"Novo salario: {t:.00}");
      Console.WriteLine($"Reajuste ganho: {s * 0.07:.00}");
      Console.WriteLine("Em percentual: 7 %");
    }
    if (2000.00 < s) {
      t = s + s * 0.04;
      Console.WriteLine($"Novo salario: {t:.00}");
      Console.WriteLine($"Reajuste ganho: {s * 0.04:.00}");
      Console.WriteLine("Em percentual: 4 %");
    }
            
        }
    }
}
