using System;

namespace _2188
{
    class Program
    {
        static void Main(string[] args)
        {
                        int teste =0;
            int n = int.Parse(Console.ReadLine());
            while (n>0){
                int x  = -10000;
                int v = -10000;
                int y = 10000;
                int u = 10000;
                int ent0,ent1,ent2,ent3;
                for (int i = 1; i<= n;i++){
                    string[] ent = Console.ReadLine().Split();
                    ent0 = int.Parse(ent[0]);   
                    ent1 = int.Parse(ent[1]);
                    ent2 = int.Parse(ent[2]);
                    ent3 = int.Parse(ent[3]);
                    
                    if(ent0>x) x = ent0;
                    if(ent1<y) y = ent1;
                    if(ent2<u) u = ent2;
                    if(ent3>v) v = ent3;
                }
                    teste += 1;
                    Console.WriteLine($"Teste {teste}");
                    if (x<u && v<y)Console.WriteLine($"{x} {y} {u} {v}");
                    else Console.WriteLine("nenhum");
                    Console.WriteLine("");
                    n = int.Parse(Console.ReadLine());


                

            }        }
        
    }
}
