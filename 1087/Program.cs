using System;

namespace _1087
{
    class Program
    {
        static void Main(string[] args)
        {
                        while(true){
                string[] n = Console.ReadLine().Split();
                int x1,y1,x2,y2;
                x1 = int.Parse(n[0]);y1 = int.Parse(n[1]);x2 = int.Parse(n[2]);y2 = int.Parse(n[3]);

                if((x1+y1+x2+y2)== 0) break;
                else if ((x1==x2) &&(y1==y2)) Console.WriteLine("0");
                else if((x1==x2)||(y1==y2)) Console.WriteLine("1");
                else if (Math.Abs(x1-x2) == Math.Abs(y1-y2))Console.WriteLine("1");
                else Console.WriteLine("2");
            }
        }
    }
}
