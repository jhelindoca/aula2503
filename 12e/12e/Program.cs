using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:  ");

            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("O número" + numero + "é par");
            else 
              Console.WriteLine("o numero é impar");

            






        }
    }
}
