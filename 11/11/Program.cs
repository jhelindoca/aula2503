using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número é Positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é Negativo.");
        }
        else
        {
            Console.WriteLine("O número é Zero.");
        }
    }
}