using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManipulaçãoNumerica
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroUm, numeroDois;
            
            Console.WriteLine("Digite dois numeros, para serem manipulados");
            
            numeroUm = int.Parse(Console.ReadLine());
                 
            numeroDois = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numeros digitados "+ numeroUm + " "+ numeroDois);

            Console.WriteLine("===============================================");

            Console.WriteLine("Soma ===> "+ (numeroUm+numeroDois));
            Console.WriteLine("Multiplicação ===> " + (numeroUm * numeroDois));
            Console.WriteLine("Subtração ===> " + (numeroUm - numeroDois));

            if (numeroDois == 0 || numeroDois < 0)
            {
                Console.WriteLine("Não pode dividir por 0 ou menor que zero");
            }
            else
            {
                 Console.WriteLine("Divisão ===> " + (numeroUm / numeroDois));
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("DIGITE QUELUER TECLA PARA SAIR.");
            Console.ReadKey();
        }
    }
}
