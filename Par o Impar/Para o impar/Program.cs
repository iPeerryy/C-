using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void parIpar(int juan)
        {
            if (juan % 2 == 0)
            {
                Console.WriteLine($"{juan} Es par");
            }
            else
            {
                Console.WriteLine($"{juan} Es impar");

            }
        }

        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            parIpar(numero);    




        }
    }

   
}

