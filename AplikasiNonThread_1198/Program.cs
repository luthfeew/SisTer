using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiNonThread_1198
{
    internal class Program
    {
        public class non_Thread
        {
            public void cuci_baju()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Cuci baju ke {0}", i);
                }
            }

            public void setrika()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Setrika ke {0}", i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Mulai melakukan pekerjaan");
            Console.WriteLine("=========================");

            non_Thread tid1 = new non_Thread();

            tid1.cuci_baju();
            tid1.setrika();

            Console.WriteLine("=========================");
            Console.WriteLine("Selesai......!");
            Console.WriteLine("=========================");
            Console.ReadLine();
        }
    }
}
