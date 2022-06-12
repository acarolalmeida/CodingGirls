using System;
using System.Text;

namespace Aula02_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- EXERCÍCIO 01 ---\n");
            Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02 ---\n");
            Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03 ---\n");
            Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04 ---\n");
            Exercicio04();
            Console.WriteLine("\n--- EXERCÍCIO 05 ---\n");
            Exercicio05();
        }

        static void Exercicio01()
        {
            Console.Write("Qual o seu ano de nascimento? ");
            int anoNascimento = Convert.ToInt16(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;

            Console.WriteLine($"\nVocê tem {anoAtual - anoNascimento} anos.");
        }

        static void Exercicio02()
        {
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt16(Console.ReadLine());
                soma += numero;
            }

            Console.WriteLine($"\nA soma dos números inseridos é: {soma.ToString()}");
        }

        static void Exercicio03() 
        {
            Console.Write("Insira a quantidade de horas trabalhadas pelo funcionário: ");
            double horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor da hora do funcionário: ");
            double valorPorHora = Convert.ToDouble(Console.ReadLine());

            double salario = horas * valorPorHora;

            string salarioReal = salario.ToString("F2").Replace('.', ',');
            Console.WriteLine($"\nO salário do funcionário será: R${salarioReal}."); 
        }

        static void Exercicio04()
        {
            Console.Write("Qual a sua idade? ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"\nSua idade em anos é: {idade}.");
            Console.WriteLine($"Sua idade em meses é: {idade * 12}.");
            Console.WriteLine($"Sua idade em dias é: {idade * 365}.");
        }

        static void Exercicio05()
        {
            double valorDolarEua = 4.87;
            double valorEuro = 5.21;
            double valorLibra = 6.12;
            double valorDolarCan = 3.88;
            double valorPesoArg = 0.04;
            double valorPesoChi = 0.0059;

            Console.Write("Insira o valor em real (R$): ");
            double valorReal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nO valor inserido foi R${valorReal.ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a ${(valorReal / valorDolarEua).ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a €{(valorReal / valorEuro).ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a £{(valorReal / valorLibra).ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a C${(valorReal / valorDolarCan).ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a AR${(valorReal / valorPesoArg).ToString("F2")}.");
            Console.WriteLine($"O valor inserido é igual a CLP${(valorReal / valorPesoChi).ToString("F2")}.\n");
        }
    }
}
