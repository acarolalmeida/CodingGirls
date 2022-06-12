using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadastro();
            //TipoDado();
            //Atribuições();
        }

        static void Cadastro()
        {
            Console.WriteLine("--- CADASTRO DE USUÁRIO ---");

            /*Entrada de Dados*/

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine()); //ou
            //int idade = int.Parse(Console.ReadLine());

            /*Saída de Dados*/

            Console.WriteLine($"Nome: {nome}, Cidade: {cidade}, Idade: {idade}");
        }

        static void TipoDado()
        {
            int meuInt = 10;
            float meuFloat = 10.78f;

            // Conversão Implícita
            long meuLong = meuInt;
            double meuDouble = meuFloat;

            // Conversão Explícita
            double salario = 1.250;
            int roundSalario = (int)salario;

            // Método Convert
            int valor = 100;
            double valorDolar = 5.50;
            bool booleano = true;
 
            Console.WriteLine($"{meuLong}, {meuDouble}");
            Console.WriteLine($"{salario}, {roundSalario}");
            Console.WriteLine(Convert.ToString(valor));
            Console.WriteLine(Convert.ToDouble(valor));
            Console.WriteLine(Convert.ToInt64(valor));
            Console.WriteLine(Convert.ToInt32(valorDolar));
            Console.WriteLine(Convert.ToDecimal(valorDolar));
            Console.WriteLine(Convert.ToString(booleano));
        }

        static void Atribuições()
        {
            /* Operadores de Atribuição */
            int i = 10;
            int j = 24;

            Console.WriteLine($"Soma: {i + j}");
            Console.WriteLine($"Subtração: {i - j}");
            Console.WriteLine($"Multiplicação: {i * j}");
            Console.WriteLine($"Divisão: {i / j}");
            Console.WriteLine("Atribuições:");
            Console.WriteLine($"Soma: {i+=5}");
            Console.WriteLine($"Subtração: {i-=5}");
            Console.WriteLine($"Multiplicação: {i*=5}");
            Console.WriteLine($"Divisão: {i/=5}");
            Console.WriteLine("Incrementos:");
            Console.WriteLine($"Incremento: {++i}");
            Console.WriteLine($"Dencremento: {--i}");
        }
    }
}
