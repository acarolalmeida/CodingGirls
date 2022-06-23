using System;

namespace Desafio
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Para qual forma você deseja calcular a área (1 - Quadrado / 2 - Círculo / 3 - Triângulo)? ");

            int forma = int.Parse(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    Quadrado forma02 = new Quadrado();
                    Console.Write("\nPor favor, insira o valor do lado do quadrado para cálculo da área: ");
                    forma02.parametro = Convert.ToDouble(Console.ReadLine());
                    double areaForma02 = forma02.CalculaDimensao();
                    Console.WriteLine($"A área do quadrado é: {Math.Round(areaForma02, 2)}.\n");
                    break;
                
                case 2:
                    Círculo forma01 = new Círculo();
                    Console.Write("\nPor favor, insira o valor do raio do círculo para cálculo da área: ");
                    forma01.parametro = Convert.ToDouble(Console.ReadLine());
                    double areaForma01 = forma01.CalculaDimensao();
                    Console.WriteLine($"A área do círculo é: {Math.Round(areaForma01, 2)}.\n");
                    break;
                
                case 3:
                    Triângulo forma03 = new Triângulo();
                    Console.Write("\nPor favor, insira o valor da base do triângulo para cálculo da área: ");
                    forma03.parametro = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Por favor, insira o valor da altura do triângulo para cálculo da área: ");
                    forma03.parametro02 = Convert.ToDouble(Console.ReadLine());
                    double areaForma03 = forma03.CalculaDimensao();
                    Console.WriteLine($"A área do triângulo é: {Math.Round(areaForma03, 2)}.\n");
                    break;

                default:
                    Console.WriteLine("\nO número inserido não é válido.\n");
                    break;
            }
        }
    }
}
