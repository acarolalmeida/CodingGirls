using System;

namespace Exercício02
{
    public abstract class Calculadora
    {
        public double resultado;
        public double numero01;
        public double numero02;
        public char resposta;

        public Calculadora()
        {
            Console.WriteLine("Calculadora v1.0\n");

            do
            {
                Menu();
                
                Console.Write("Deseja realizar outra operação (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());

            } while (resposta == 'S');
        }

        public virtual void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.Write("1 - Soma / 2 - Subtração / 3 - Multiplicação / 4 - Divisão: ");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao <= 4)
            {
                Console.Write("\nDigite o primeiro número que será utilizado na operação: ");
                numero01 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número que será utilizado na operação: ");
                numero02 = double.Parse(Console.ReadLine());
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

                default:
                    Console.WriteLine("\nO número inserido não é válido.\n");
                    break;
            }
        }

        public void Soma(double valor01, double valor02)
        {
            resultado = valor01 + valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
        public void Soma(int valor01, int valor02)
        {
            resultado = valor01 + valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }

        public void Subtração(double valor01, double valor02)
        {
            resultado = valor01 - valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
        public void Subtração(int valor01, int valor02)
        {
            resultado = valor01 - valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }

        public void Divisão(double valor01, double valor02)
        {
            try
            {
                if (valor02 == 0)
                {
                    throw new Exception("CodError001 - Divisão por 0 não é possível.");
                }
                else
                {
                    resultado = valor01 / valor02;
                    Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
                }
            }

            catch (Exception error)
            {
                Console.WriteLine($"\n{error.GetType()} - {error.Message}");
                Console.WriteLine("Error located " + error.StackTrace.Trim());
                Console.WriteLine();
            }
        }
        public void Divisão(int valor01, int valor02)
        {
            try
            {
                if (valor02 == 0)
                {
                    throw new Exception("CodError001 - Divisão por 0 não é possível.");
                }
                else
                {
                    resultado = valor01 / valor02;
                    Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
                }
            }

            catch (Exception error)
            {
                Console.WriteLine($"\n{error.GetType()} - {error.Message}");
                Console.WriteLine("Error located " + error.StackTrace.Trim());
                Console.WriteLine();
            }
        }

        public void Multiplicação(double valor01, double valor02)
        {
            resultado = valor01 * valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
        public void Multiplicação(int valor01, int valor02)
        {
            resultado = valor01 * valor02;
            Console.WriteLine($"\nO resultado da operação é: {resultado}.\n");
        }
    }
}
