using System;
using System.Globalization;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");

            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // 'CultureInfo.InvariantCulture' Ignora padrão de país
            Console.WriteLine("---------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo = {2:F2} reais", nome, idade, saldo); //Placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo = {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo = " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            string s = "batata tomate abacaxi";
            string[] vetor = s.Split(' ');
            string p1 = vetor[0];
            string p2 = vetor[1];
            string p3 = vetor[2];

            Console.WriteLine(p1 + " - " + p2 + " - " + p3);
        }
    }
}
