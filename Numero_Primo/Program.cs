using System;

namespace Numero_Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, primo = 0;

            Console.WriteLine("Digite um numero inteiro : ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    primo++;
                }
            }
            if(primo == 2)
            {
                Console.WriteLine("O numero eh Primo ");
           }else
            {
                Console.WriteLine("O numero nao eh Primo");
            }
            
        }
    }
}
