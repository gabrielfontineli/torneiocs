using System;

namespace _1091
{
    class Program
    {
        static void Main(string[] args)
        {
                      while(true){
                int k,n,m,x,y;
                k = int.Parse(Console.ReadLine());
                if (k==0) break;
                string[] ent = Console.ReadLine().Split();
                n = int.Parse(ent[0]);
                m = int.Parse(ent[1]);

                for(int i = 0; i<k;i++){
                    string[] cord = Console.ReadLine().Split();
                    x = int.Parse(cord[0]);y = int.Parse(cord[1]);

                    if(x==n ||y==m) Console.WriteLine("divisa");
                    else if(x > n && y > m) Console.WriteLine("NE");
                    else if(x > n && y < m) Console.WriteLine("SE");
                    else if(x < n && y > m) Console.WriteLine("NO");
                    else if(x <n && y <m)Console.WriteLine("SO");
}}
        }
    }
}
