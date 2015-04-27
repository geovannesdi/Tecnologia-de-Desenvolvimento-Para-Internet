using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome ");

            string nome = Console.ReadLine();

            Console.WriteLine("Seja bem vindo: " + nome);

            Console.WriteLine("Digite qualquer tecla para sair.");

            Console.ReadKey();
        }
    }
}
