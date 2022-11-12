using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} -> ", n);
            for (int i = 1; i <= n; i++)            
                Console.Write("{0}, ", i * i * i);
            
            Console.ReadKey();
        }
    }
}