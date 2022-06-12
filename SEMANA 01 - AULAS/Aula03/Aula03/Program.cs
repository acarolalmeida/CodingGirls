using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valorTeste = false; // true or false

            /* OPERADORES DE COMPARAÇÃO */

            int num = 10;
            int num2 = 15;

            Console.WriteLine($"É igual a: {num == num2}");
            Console.WriteLine($"É diferente de: {num != num2}");
            Console.WriteLine($"É maior que: {num > num2}");
            Console.WriteLine($"É menor que: {num < num2}");
            Console.WriteLine($"É maior ou igual: {num >= num2}");
            Console.WriteLine($"É menor ou igual: {num <= num2}");
            Console.WriteLine();

            /* OPERADORES LÓGICOS */

            Console.WriteLine($"{num > num2 && num == num2}");
            Console.WriteLine($"{num < num2 || num == num2}");
            Console.WriteLine($"{!(num != num2)}");
            Console.WriteLine();

            /* OPERADORES LÓGICOS */

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Valor inválido!");
            }
            else if(num == 10)
            {
                Console.WriteLine("Valor igual a: " + num);
            }
            else
            {
                Console.WriteLine("Valor válido!");
            }

            Console.WriteLine();

            /* CÁLCULO DE MÉDIA */

            Console.WriteLine("**Cálculo da Média**");

            Console.Write("Digite a 1ª nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a 2ª nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a 3ª nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine($"Aluno aprovado com média de {media} pontos.");

                if (media > 9) // Estrutura de ifs aninhados - if dentro de if
                {
                    Console.WriteLine($"Aluno nota 10!");
                }
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine($"Aluno em recuperação com média de {media} pontos.");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com média de {media} pontos.");
            }

            Console.WriteLine();

            /* OPERADORES TERNÁRIOS */

            string valorMedia = (media > 8) ? "Muito bom!" : "Poderia ser melhor :(";
            Console.WriteLine(valorMedia);
        }
    }
}
