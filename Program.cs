using System;

namespace Cidades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 3 - Faça um programa que exiba os nomes das cidades do litoral sul de São Paulo, um em cada linha.

            string[] cidades = new string[]{"Iguape","Ilha Comprida","Cananéia","Peruíbe","Itanhaém","Mongaguá","Praia Grande","São Vicente","Santos","Guarujá","Cubatão","Bertioga"};

            // Título
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cidades do litoral sul de São Paulo\n");

            Console.ResetColor(); // Reinicia as cores do título

            // Resolução do exercício
            foreach (var c in cidades)
            {
                Console.WriteLine("{0}\n",c);
            }

            // Aguardar o usuário fechar o programa ou apertar um botão.
            Console.Write("Pressione qualquer tecla para fechar. . .");
            Console.ReadKey();
        }
    }
}
