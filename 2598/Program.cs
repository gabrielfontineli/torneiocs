using System;

namespace _2598
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float a,b;
            while(n>0){
                n-=1;
                string[] pomba = Console.ReadLine().Split();
                a = float.Parse(pomba[0]);b = float.Parse(pomba[1]);
                float x = a/b;
                Console.WriteLine(Math.Ceiling(x));
}
        }
    }
}
