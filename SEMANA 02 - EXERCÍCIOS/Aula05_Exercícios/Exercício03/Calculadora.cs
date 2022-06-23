using System;
using System.Threading;

namespace Exercício03
{
    public class Calculadora
    {
        private double resultado;
        public char realizarNovaOperacao;

        public Calculadora()
        {
            Menu();
        }

        private void Menu()
        {
            do
            {
                Console.WriteLine("Calculadora v1.0\n");

                Console.WriteLine("Escolha qual operação deseja realizar: ");
                Console.Write("1 - Soma / 2 - Subtração / 3 - Multiplicação / 4 - Divisão / 5 - Sair do Menu: ");
                int operacao = int.Parse(Console.ReadLine());

                double numero01 = 0;
                double numero02 = 0;

                if (operacao < 5)
                {
                    Console.Write("\nDigite o 1° número que será utilizado na operação: ");
                    numero01 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o 2° número que será utilizado na operação: ");
                    numero02 = double.Parse(Console.ReadLine());
                }

                switch (operacao)
                {
                    case 1:
                        SomarValor(numero01, numero02);
                        Console.WriteLine($"O resultado da operação é: {resultado}.\n");
                        break;

                    case 2:
                        SubtrairValor(numero01, numero02);
                        Console.WriteLine($"O resultado da operação é: {resultado}.\n");
                        break;

                    case 3:
                        MultiplicarValor(numero01, numero02);
                        Console.WriteLine($"O resultado da operação é: {resultado}.\n");
                        break;

                    case 4:
                        DividirValor(numero01, numero02);
                        Console.WriteLine($"O resultado da operação é: {resultado}.\n");
                        break;

                    case 5:
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("\nO número inserido não é válido.\n");
                        break;
                }

                Console.Write("Deseja realizar outra operação (S/N)? ");
                realizarNovaOperacao = char.Parse(Console.ReadLine());

                Thread.Sleep(500);
                Console.Clear();

            } while (realizarNovaOperacao == 'S'); 
        }

        public void SomarValor(double valor01, double valor02)
        {
            resultado = valor01 + valor02;
        }

        public void SubtrairValor(double valor01, double valor02)
        {
            resultado = valor01 - valor02;
        }

        public void DividirValor(double valor01, double valor02)
        {
            resultado = valor01 / valor02;
        }

        public void MultiplicarValor(double valor01, double valor02)
        {
            resultado = valor01 * valor02;
        }
    }
}