using System;

namespace Desafio___Tratamento_de_Erro
{
    public class Calculadora
    {
        private double resultadoAnterior;

        public Calculadora() 
        {
            Console.WriteLine("Calculadora v1.0\n"); 
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.Write("1 - Soma / 2 - Subtração / 3 - Multiplicação / 4 - Divisão / 5 - Zerar Calculadora: ");
            int operacao = int.Parse(Console.ReadLine());

            double numero = 0;

            if (operacao != 5)
            {
                Console.Write("Digite o número que será utilizado na operação: ");
                string numeroUsuario = Console.ReadLine();
                bool conversaoNumeroUsuario = double.TryParse(numeroUsuario, out numero);

                try
                {
                    if (!conversaoNumeroUsuario)
                    {
                        throw new Exception("CodError002 - O usuário não pode inserir qualquer valor além de números.");
                    }
                }

                catch (Exception error)
                {
                    Console.WriteLine($"\n{error.GetType()} - {error.Message}");
                    Console.WriteLine("Error located " + error.StackTrace.Trim());
                    Console.WriteLine();
                    Menu();
                }
            }
            
            switch (operacao)
            {
                case 1:
                    SomarValor(numero);
                    Console.WriteLine($"O resultado da operação é: {resultadoAnterior}.\n");
                    Menu();
                    break;
                
                case 2:
                    SubtrairValor(numero);
                    Console.WriteLine($"O resultado da operação é: {resultadoAnterior}.\n");
                    Menu();
                    break;

                case 3:
                    MultiplicarValor(numero);
                    Console.WriteLine($"O resultado da operação é: {resultadoAnterior}.\n");
                    Menu();
                    break;

                case 4:
                    DividirValor(numero);
                    Console.WriteLine($"O resultado da operação é: {resultadoAnterior}.\n");
                    Menu();
                    break;

                case 5:
                    ZerarResultado();
                    Console.WriteLine();
                    Menu();
                    break;
                
                default:
                    Console.WriteLine("\nO número inserido não é válido.\n");
                    Menu();
                    break;
            }
        }

        public void SomarValor(double valor)
        {
            resultadoAnterior += valor;
        }

        public void SubtrairValor(double valor)
        {
            resultadoAnterior -= valor;
        }

        public void DividirValor(double valor)
        {
            try 
            {
                if (valor == 0)
                {
                    throw new Exception("CodError001 - Divisão por 0 não é possível.");
                }
                else 
                {
                    resultadoAnterior /= valor;
                }
            }

            catch (Exception error)
            {
                Console.WriteLine($"\n{error.GetType()} - {error.Message}");
                Console.WriteLine("Error located " + error.StackTrace.Trim());
                Console.WriteLine();
                Menu();
            }
        }

        public void MultiplicarValor(double valor) 
        {
            resultadoAnterior *= valor;
        }

        public void ZerarResultado() 
        {
            resultadoAnterior = 0;
        }
    }
}
