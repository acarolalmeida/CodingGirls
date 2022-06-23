using System;

namespace Tratamentodeerros
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Digite um valor para ser dividido: ");
                int valordivisao = int.Parse(Console.ReadLine());

                int calculo = valordivisao / 0;

                Console.WriteLine(calculo);
            }

            catch (Exception error)
            {
                Console.WriteLine(error.GetType());
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace.Trim());
                Console.WriteLine("Valor inválido! Reinicie o programa!");
            }

            finally
            {
                Console.WriteLine("Apresentar a intro novamente..");
            }

            //fica dentro de condicionais, no meio do código
            throw new Exception("Valor inserido é inválido.");
        }
    }
}
