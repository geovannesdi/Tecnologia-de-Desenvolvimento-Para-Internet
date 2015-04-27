using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImprimirTodosNumerosIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroUm, numeroDois;
            
            Console.WriteLine("DIGITE OS DOIS NUMERO PARA SE MOSTRAR TODOS OS NUMEROS ENTRE ELES?");

            numeroUm = int.Parse(Console.ReadLine());

            numeroDois = int.Parse(Console.ReadLine());

            if (numeroUm <= numeroDois)
            {
                for (int i = 0; i < numeroDois-numeroUm; i++)
                {
                    Console.WriteLine(numeroUm+i);
                }
            }
            else
            {
                for (int i = 0; i < numeroUm - numeroDois; i++)
                {
                    Console.WriteLine((numeroUm - numeroDois) + i);
                }
            }

            Console.WriteLine("DIGITE QUELUER TECLA PARA SAIR.");
            Console.ReadKey();
        }
    }
}
