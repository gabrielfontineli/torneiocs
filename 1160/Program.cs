using System;

namespace _1160
{
    class Program
    {
        static void Main(string[] args)
        {
                        int t = int.Parse(Console.ReadLine());
            int PA,PB,cont = 0;
            double G1,G2;
            for(int i = 0;i<t;i++){
                string[] entrada = Console.ReadLine().Split();
                PA = int.Parse(entrada[0]);
                PB = int.Parse(entrada[1]);
                G1 = double.Parse(entrada[2]);
                G2 = double.Parse(entrada[3]);
                while(PA<=PB&&cont<101){
                    PA += (int)((PA * G1)/100);
                    PB += (int)((PB*G2)/100);
                    cont++;

                }
                if(cont>100)Console.WriteLine("Mais de 1 seculo.");
                else Console.WriteLine($"{cont} anos.");
                cont = 0;
                

            }
        }
    }
}
