using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    public class Program
    {
        static void Main()
        {
            char resposta;

            do
            {
                Console.Clear();
                Console.WriteLine("Para qual forma geométrica você deseja calcular a área?");
                Console.Write("1 - Quadrado / 2 - Retângulo / 3 - Triângulo / 4 - Círculo: ");
                int escolhaUsuario = int.Parse(Console.ReadLine());

                switch (escolhaUsuario)
                {
                    case 1:
                        Console.Write("\nPor favor, insira o valor do lado do quadrado: ");
                        Quadrado quadrado = new Quadrado(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("\nPor favor, insira o valor da base do retângulo: ");
                        double baseRetangulo = double.Parse(Console.ReadLine());
                        Console.Write("\nPor favor, insira o valor da altura do retângulo: ");
                        double alturaRetangulo = double.Parse(Console.ReadLine());
                        Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);
                        break;
                    case 3:
                        Console.Write("\nPor favor, insira o valor da base do triângulo: ");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("\nPor favor, insira o valor da altura do triângulo: ");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                        break;
                    case 4:
                        Console.Write("\nPor favor, insira o valor do raio do círculo: ");
                        Circulo circulo = new Circulo(double.Parse(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("\nO número inserido não é válido!\n");
                        break;
                }

                Console.Write("Deseja calcular a área de outra forma geométrica (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());

            } while (resposta == 'S'); 
        }
    }
}
