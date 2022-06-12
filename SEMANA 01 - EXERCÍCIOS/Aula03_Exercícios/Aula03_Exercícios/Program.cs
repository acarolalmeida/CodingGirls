using System;
using System.Linq;

namespace Aula03_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

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
            Console.Write("Digite o valor, em R$, a ser decomposto: ");
            float valor = float.Parse(Console.ReadLine());
            float resto = 9999;
            int[] valores = {100, 50, 20, 10, 5, 2};

            Console.WriteLine($"\nO valor R${valor} será decomposto da seguinte forma:");
            
            while (resto >= 2)
            {
                for (int i = 0; i < valores.Count(); i++)
                {
                    int notas = (int)Math.Truncate(valor / valores[i]);
                    resto = valor - (notas * valores[i]);
                    valor = resto;
                    if (notas != 0)
                    {
                        Console.WriteLine($"{notas} nota(s) de R${valores[i]};");
                    }
                }
            }

            if(resto != 0)
            {
                Console.WriteLine($"E restam R${Math.Round(resto, 2)} a serem devolvidos em moedas.\n");
            }
        }

        static void Exercicio02()
        {
            int[] numeros = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Insira um número inteiro: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            if (numeros[0] > numeros[1] && numeros[0] > numeros[2])
            {
                Console.WriteLine($"\n{numeros[0]} é o maior número inserido.");
            }
            else if (numeros[1] > numeros[0] && numeros[1] > numeros[2])
            {
                Console.WriteLine($"\n{numeros[1]} é o maior número inserido.");
            }
            else 
            {
                Console.WriteLine($"\n{numeros[2]} é o maior número inserido.");
            }

            Console.WriteLine();
        }

        static void Exercicio03()
        {
            float[] notas = new float[3];
            float soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Insira a {(i+1)}ª nota com até 1 (uma) casa decimal: ");
                notas[i] = float.Parse(Console.ReadLine());
                soma = soma + notas[i];
            }

            double media = Math.Round(Convert.ToDouble(soma / 3), 1);

            if(media >= 7) 
            {
                Console.WriteLine($"\nO aluno tirou {media} e foi aprovado.\n");
            }
            else 
            {
                Console.WriteLine($"\nO aluno tirou {media} e foi reprovado.\n");
            }
        }

        static void Exercicio04()
        {
            float[] notas = new float[3];
            float soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Insira a {(i + 1)}ª nota: ");
                notas[i] = float.Parse(Console.ReadLine());
                soma = soma + notas[i];
            }

            double media = Math.Round(Convert.ToDouble(soma / 3), 1);

            if (media >= 9 && media <= 10)
            {
                Console.WriteLine($"\nO aluno tirou A. Sensacional! Parabéns!\n");
            }
            else if(media >= 8 && media < 9)
            {
                Console.WriteLine($"\nO aluno tirou B. Muito bom! Parabéns!\n");
            }
            else if(media >= 7 && media < 8)
            {
                Console.WriteLine($"\nO aluno tirou C. Bom trabalho!\n");
            }
            else if(media >= 6 && media < 7)
            {
                Console.WriteLine($"\nO aluno tirou D. Dá pra melhorar! Estude um pouco mais!\n");
            }
            else
            {
                Console.WriteLine($"\nO aluno tirou F e foi reprovado. Que pena!\n");
            }
        }

        static void Exercicio05()
        {
            Console.Write("Por favor, insira seu salário atual: ");
            float salario = float.Parse(Console.ReadLine());
            float percentualAumento = 0;
            float novoSalario = 0;
            float reajusteSalario = 0;

            if (salario > 0 && salario <= 400.00) 
            {
                percentualAumento = 0.15f;
                novoSalario = salario * (1 + percentualAumento);
                reajusteSalario = novoSalario - salario;
            }
            else if (salario > 400.00 && salario <= 800.00) 
            {
                percentualAumento = 0.12f;
                novoSalario = salario * (1 + percentualAumento);
                reajusteSalario = novoSalario - salario;
            }
            else if (salario > 800.00 && salario <= 1200.00) 
            {
                percentualAumento = 0.1f;
                novoSalario = salario * (1 + percentualAumento);
                reajusteSalario = novoSalario - salario;
            }
            else if (salario > 1200.00 && salario <= 2000.00) 
            {
                percentualAumento = 0.07f;
                novoSalario = salario * (1 + percentualAumento);
                reajusteSalario = novoSalario - salario;
            }
            else 
            {
                percentualAumento = 0.04f;
                novoSalario = salario * (1 + percentualAumento);
                reajusteSalario = novoSalario - salario;
            }

            Console.WriteLine($"\nNovo salário: R${novoSalario.ToString("F2")}. Reajuste ganho: R${reajusteSalario.ToString("F2")}. Em percentual: {percentualAumento * 100}%.\n");
        }
    }
}
