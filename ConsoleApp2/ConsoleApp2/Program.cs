using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin");
            int s;
            bool parsed = int.TryParse(Console.ReadLine(), out s);
            if (parsed)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("daxil etdiyiniz eded budu :" + s + '*' + i + "=" + s * i);
                }
                
            }
            else
            {
                Console.WriteLine("warrning " );
            }
          
               
            

        }
    }
}
