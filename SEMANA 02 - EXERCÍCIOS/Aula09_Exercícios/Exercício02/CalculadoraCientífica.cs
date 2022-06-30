using System;

namespace Exercício02
{
    public class CalculadoraCientífica : Calculadora
    {
        public override void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.Write("1 - Soma / 2 - Subtração / 3 - Multiplicação / 4 - Divisão / 5 - Raiz Quadrada / 6 - Potência: ");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao > 0 || operacao < 7)
            {
                Console.Write("\nDigite o primeiro número que será utilizado na operação: ");
                numero01 = double.Parse(Console.ReadLine());
                
                if (operacao != 5)
                {
                    Console.Write("Digite o segundo número que será utilizado na operação: ");
                    numero02 = double.Parse(Console.ReadLine());
                }
            }

            switch (operacao)
            {
                case 1:
                    Soma(numero01, numero02);
                    break;

                case 2:
                    Subtração(numero01, numero02);
                    break;

                case 3:
                    Multiplicação(numero01, numero02);
                    break;

                case 4:
                    Divisão(numero01, numero02);
                    break;

                case 5:
                    RaizQuadrada(numero01);
                    break;

                case 6:
                    Potência(numero01, numero02);
                    break;

                default:
                    Console.WriteLine("\nO número inserido não é válido.\n");
                    break;
            }
        }

        public void RaizQuadrada(double valor01)
        {
            resultado = Math.Sqrt(valor01);
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
        public void RaizQuadrada(int valor01)
        {
            resultado = Math.Sqrt(valor01);
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }

        public void Potência(double valor01, double valor02)
        {
            resultado = Math.Pow(valor01, valor02);
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
        public void Potência(int valor01, int valor02)
        {
            resultado = Math.Pow(valor01, valor02);
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
    }
}
