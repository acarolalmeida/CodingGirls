using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- EXERCÍCIO 01 ---\n");
            //Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02 ---\n");
            //Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03 ---\n");
            //Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04 ---\n");
            //Exercicio04();
            Console.WriteLine("\n--- EXERCÍCIO 05 ---\n");
            Exercicio05();
        }

        static void Exercicio01()
        {
            int[] numeros = new int[10];
            int[] numerosMultiplicados = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Por favor, insira um número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                numerosMultiplicados[i] = numeros[i] * 5;
            }

            Console.WriteLine("\nNúmeros inseridos:");
            foreach (int i in numeros)
            {
                Console.Write($"{i.ToString()} ");
            }
            
            Console.WriteLine("\n\nNúmeros inseridos multiplicados por 5:");
            foreach (int i in numerosMultiplicados)
            {
                Console.Write($"{i.ToString()} ");
            }

            Console.WriteLine();
        }

        static void Exercicio02()
        {
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Por favor, insira um número inteiro: ");
                int numeroInserido = Convert.ToInt16(Console.ReadLine());

                if((numeroInserido % 2) == 0)
                {
                    numerosPares.Add(numeroInserido);
                }

                else 
                {
                    numerosImpares.Add(numeroInserido);
                }
            }

            Console.WriteLine("\nNúmeros Pares:");
            foreach (int i in numerosPares)
            {
                Console.Write($"{i.ToString()} ");
            }

            Console.WriteLine("\n\nNúmeros Ímpares:");
            foreach (int i in numerosImpares)
            {
                Console.Write($"{i.ToString()} ");
            }

            Console.WriteLine();
        }

        static void Exercicio03()
        {
            string[] palavras = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Insira uma palavra: ");
                palavras[i] = Console.ReadLine();
            }

            var palavrasOrdenadas = palavras.OrderBy(x => x.Length).ToArray();

            Console.WriteLine("\nPalavras ordenadas:");
            foreach (string texto in palavrasOrdenadas)
            {
                Console.WriteLine($"{texto} ");
            }
        }

        static void Exercicio04()
        {
            var rand = new Random();
            string[] jogadasPossiveis = new string[] {"Pedra", "Papel", "Tesoura"};
            int jogosGanhosUsuario = 0;
            int jogosGanhosPC = 0;
            int rodadasJogadas = 0;
            char repetirJogo;

            do
            {
                Console.Write("Quantas vezes você quer jogar? ");
                int qtdeJogos = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Beleza! Vamos começar!\n");

                do
                {
                    rodadasJogadas++;

                    Console.Write("Qual será sua jogada? ");
                    string jogadaUsuario = Console.ReadLine();
                    string jogadaPC = jogadasPossiveis[rand.Next(0, jogadasPossiveis.Length - 1)];
                    Console.WriteLine($"O computador jogou: {jogadaPC}.");

                    if (jogadaUsuario == "Pedra" && jogadaPC == "Tesoura")
                    {
                        Console.WriteLine("Você ganhou esta rodada!");
                        jogosGanhosUsuario++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else if (jogadaUsuario == "Pedra" && jogadaPC == "Papel")
                    {
                        Console.WriteLine("Você perdeu esta rodada!");
                        jogosGanhosPC++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else if (jogadaUsuario == "Tesoura" && jogadaPC == "Papel")
                    {
                        Console.WriteLine("Você ganhou esta rodada!");
                        jogosGanhosUsuario++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else if (jogadaUsuario == "Tesoura" && jogadaPC == "Pedra")
                    {
                        Console.WriteLine("Você perdeu esta rodada!");
                        jogosGanhosPC++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else if (jogadaUsuario == "Papel" && jogadaPC == "Pedra")
                    {
                        Console.WriteLine("Você ganhou esta rodada!");
                        jogosGanhosUsuario++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else if (jogadaUsuario == "Papel" && jogadaPC == "Tesoura")
                    {
                        Console.WriteLine("Você perdeu esta rodada!");
                        jogosGanhosPC++;
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                    else
                    {
                        Console.WriteLine("Empate!");
                        Console.WriteLine($"PLACAR: Você {jogosGanhosUsuario} x {jogosGanhosPC} PC\n");
                    }

                } while (rodadasJogadas < qtdeJogos);

                if (jogosGanhosUsuario > jogosGanhosPC)
                {
                    Console.WriteLine("Parabéns! Você ganhou!!!");
                }

                else if (jogosGanhosUsuario < jogosGanhosPC) 
                {
                    Console.WriteLine("O computador venceu! Tente novamente!");
                }

                else
                {
                    Console.WriteLine("O jogo empatou!");
                }

                Console.WriteLine("Deseja jogar novamente (S/N)?");
                repetirJogo = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (repetirJogo == 'S');
        }

        static void Exercicio05()
        {
            char repetirJogo;
            char[,] jogoDaVelha = new char[3, 3];
            int posicao = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    posicao++;
                    jogoDaVelha[row, col] = Convert.ToChar(posicao);
                }
            }

            Console.WriteLine("--- JOGO DA VELHA ---");
            Console.WriteLine();
            Console.WriteLine($"    {jogoDaVelha[0, 0].ToString()}         |       {jogoDaVelha[0, 1]}        |       {jogoDaVelha[0, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {jogoDaVelha[1, 0]}         |       {jogoDaVelha[1, 1]}        |       {jogoDaVelha[1, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {jogoDaVelha[2, 0]}         |       {jogoDaVelha[2, 1]}        |       {jogoDaVelha[2, 2]}");


            do
            {
               int i;
                char jogada;
                char teste;

                while (posicao > 0)
                {
                    Console.WriteLine("Entre com a posição que você deseja jogar");
                    i = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Entre com X ou O");
                    jogada = Convert.ToChar(Console.ReadLine());

                    teste = (i == 1) ? jogoDaVelha[0, 0] = jogada : (i == 2) ? jogoDaVelha[0, 1] = jogada : (i == 3) ? jogoDaVelha[0, 2] = jogada :
                        (i == 4) ? jogoDaVelha[1, 0] = jogada : (i == 5) ? jogoDaVelha[1, 1] = jogada : (i == 6) ? jogoDaVelha[1, 2] = jogada :
                        (i == 7) ? jogoDaVelha[2, 0] = jogada : (i == 8) ? jogoDaVelha[2, 1] = jogada : jogoDaVelha[2, 2] = jogada;

                    Console.WriteLine();
                    Console.WriteLine($"    {jogoDaVelha[0, 0]}         |       {jogoDaVelha[0, 1]}        |       {jogoDaVelha[0, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogoDaVelha[1, 0]}         |       {jogoDaVelha[1, 1]}        |       {jogoDaVelha[1, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogoDaVelha[2, 0]}         |       {jogoDaVelha[2, 1]}        |       {jogoDaVelha[2, 2]}");

                    if ((jogoDaVelha[0, 0] == 'X' && jogoDaVelha[0, 1] == 'X' && jogoDaVelha[0, 2] == 'X') ||
                        (jogoDaVelha[0, 0] == 'X' && jogoDaVelha[1, 0] == 'X' && jogoDaVelha[2, 0] == 'X') ||
                        (jogoDaVelha[0, 1] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[2, 1] == 'X') ||
                        (jogoDaVelha[0, 0] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[2, 2] == 'X') ||
                        (jogoDaVelha[0, 2] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[0, 2] == 'X') ||
                        (jogoDaVelha[2, 0] == 'X' && jogoDaVelha[2, 1] == 'X' && jogoDaVelha[2, 2] == 'X') ||
                        (jogoDaVelha[1, 0] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[1, 2] == 'X') ||
                        (jogoDaVelha[0, 2] == 'X' && jogoDaVelha[2, 1] == 'X' && jogoDaVelha[2, 2] == 'X'))
                    {
                        Console.WriteLine("O Jogador X ganhou!");
                        break;

                    }
                    else if ((jogoDaVelha[0, 0] == 'O' && jogoDaVelha[0, 1] == 'O' && jogoDaVelha[0, 2] == 'O') ||
                        (jogoDaVelha[0, 0] == 'O' && jogoDaVelha[1, 0] == 'O' && jogoDaVelha[2, 0] == 'O') ||
                        (jogoDaVelha[0, 1] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[2, 1] == 'O') ||
                        (jogoDaVelha[0, 0] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[2, 2] == 'O') ||
                        (jogoDaVelha[0, 2] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[0, 2] == 'O') ||
                        (jogoDaVelha[2, 0] == 'O' && jogoDaVelha[2, 1] == 'O' && jogoDaVelha[2, 2] == 'O') ||
                        (jogoDaVelha[1, 0] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[1, 2] == 'O') ||
                        (jogoDaVelha[0, 2] == 'O' && jogoDaVelha[2, 1] == 'O' && jogoDaVelha[2, 2] == 'O'))
                    {
                        Console.WriteLine("O Jogador O ganhou!");
                        break;
                    }
                    else if (posicao == 1)
                    {
                        Console.WriteLine("Deu Velha!");
                    }
                    posicao++;
                }

                Console.WriteLine("Deseja jogar novamente (S/N)?");
                repetirJogo = Convert.ToChar(Console.ReadLine());

            } while (repetirJogo == 'S');
        }
    }
}
