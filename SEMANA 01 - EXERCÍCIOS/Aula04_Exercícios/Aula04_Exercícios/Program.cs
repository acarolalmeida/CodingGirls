using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula04_Exercícios
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

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
                Console.Write($"{i} ");
            }
            
            Console.WriteLine("\n\nNúmeros inseridos multiplicados por 5:");
            foreach (int i in numerosMultiplicados)
            {
                Console.Write($"{i} ");
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
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nNúmeros Ímpares:");
            foreach (int i in numerosImpares)
            {
                Console.Write($"{i} ");
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

                Console.Write("\nDeseja jogar novamente (S/N)?");
                repetirJogo = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (repetirJogo == 'S');
        }

        static void Exercicio05()
        {
            char repetirJogo;
            char[,] padraoPosicoes = new char[3, 3];
            char[,] jogoDaVelha = new char[3, 3];
            int posicao = 0;
            int qtdeJogadas = 0;
            string jogadorX;
            string jogadorO;
            char turno = 'X';

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    posicao++;
                    padraoPosicoes[row, col] = (char) posicao;
                }
            }

            Console.WriteLine("Jogo da Velha v1.0\n");

            Console.Write("Digite o nome do Jogador 01 - X: ");
            jogadorX = Console.ReadLine();
            Console.Write("Digite o nome do Jogador 02 - O: ");
            jogadorO = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($" {(int)padraoPosicoes[0, 0]} | {(int)padraoPosicoes[0, 1]} | {(int)padraoPosicoes[0, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {(int)padraoPosicoes[1, 0]} | {(int)padraoPosicoes[1, 1]} | {(int)padraoPosicoes[1, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {(int)padraoPosicoes[2, 0]} | {(int)padraoPosicoes[2, 1]} | {(int)padraoPosicoes[2, 2]}");

            Console.WriteLine($"\nJogador X: {jogadorX} - Jogador O: {jogadorO}");

            do
            {
                while (qtdeJogadas < 9)
                {
                    Console.Write($"\nJogador {turno} - Entre com a posição que você deseja jogar: ");
                    int i = Convert.ToInt16(Console.ReadLine());
                    bool posicaoValida = (i > 0 && i < 10);

                    if (posicaoValida)
                    {

                        switch (i)
                        {
                            case 1:
                                if (!(char.IsLetter(jogoDaVelha[0, 0])))
                                {
                                    jogoDaVelha[0, 0] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else 
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 2:
                                if (!(char.IsLetter(jogoDaVelha[0, 1])))
                                {
                                    jogoDaVelha[0, 1] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 3:
                                if (!(char.IsLetter(jogoDaVelha[0, 2])))
                                {
                                    jogoDaVelha[0, 2] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 4:
                                if (!(char.IsLetter(jogoDaVelha[1, 0])))
                                {
                                    jogoDaVelha[1, 0] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 5:
                                if (!(char.IsLetter(jogoDaVelha[1, 1])))
                                {
                                    jogoDaVelha[1, 1] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 6:
                                if (!(char.IsLetter(jogoDaVelha[1, 2])))
                                {
                                    jogoDaVelha[1, 2] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 7:
                                if (!(char.IsLetter(jogoDaVelha[2, 0])))
                                {
                                    jogoDaVelha[2, 0] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 8:
                                if (!(char.IsLetter(jogoDaVelha[2, 1])))
                                {
                                    jogoDaVelha[2, 1] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                            case 9:
                                if (!(char.IsLetter(jogoDaVelha[2, 2])))
                                {
                                    jogoDaVelha[2, 2] = turno;
                                    qtdeJogadas++;
                                    turno = (turno == 'X') ? 'O' : 'X';
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                    break;
                                }
                        }

                        Console.WriteLine();
                        Console.WriteLine($" {jogoDaVelha[0, 0]} | {jogoDaVelha[0, 1]} | {jogoDaVelha[0, 2]}");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {jogoDaVelha[1, 0]} | {jogoDaVelha[1, 1]} | {jogoDaVelha[1, 2]}");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {jogoDaVelha[2, 0]} | {jogoDaVelha[2, 1]} | {jogoDaVelha[2, 2]}");
                    }

                    else
                    {
                        Console.WriteLine("A posição inserida é inválida. Tente novamente.");
                    }

                    if ((jogoDaVelha[0, 0] == 'X' && jogoDaVelha[0, 1] == 'X' && jogoDaVelha[0, 2] == 'X') ||
                        (jogoDaVelha[1, 0] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[1, 2] == 'X') ||
                        (jogoDaVelha[2, 0] == 'X' && jogoDaVelha[2, 1] == 'X' && jogoDaVelha[2, 2] == 'X') ||
                        (jogoDaVelha[0, 0] == 'X' && jogoDaVelha[1, 0] == 'X' && jogoDaVelha[2, 0] == 'X') ||
                        (jogoDaVelha[0, 1] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[2, 1] == 'X') ||
                        (jogoDaVelha[0, 2] == 'X' && jogoDaVelha[1, 2] == 'X' && jogoDaVelha[2, 2] == 'X') ||
                        (jogoDaVelha[0, 0] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[2, 2] == 'X') ||
                        (jogoDaVelha[0, 2] == 'X' && jogoDaVelha[1, 1] == 'X' && jogoDaVelha[2, 0] == 'X'))
                    {
                        Console.WriteLine("\nO Jogador X ganhou!");
                        qtdeJogadas = 0;
                        turno = 'X';
                        Array.Clear(jogoDaVelha, 0, jogoDaVelha.Length);
                        break;
                    }

                    else if ((jogoDaVelha[0, 0] == 'O' && jogoDaVelha[0, 1] == 'O' && jogoDaVelha[0, 2] == 'O') ||
                        (jogoDaVelha[1, 0] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[1, 2] == 'O') ||
                        (jogoDaVelha[2, 0] == 'O' && jogoDaVelha[2, 1] == 'O' && jogoDaVelha[2, 2] == 'O') ||
                        (jogoDaVelha[0, 0] == 'O' && jogoDaVelha[1, 0] == 'O' && jogoDaVelha[2, 0] == 'O') ||
                        (jogoDaVelha[0, 1] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[2, 1] == 'O') ||
                        (jogoDaVelha[0, 2] == 'O' && jogoDaVelha[1, 2] == 'O' && jogoDaVelha[2, 2] == 'O') ||
                        (jogoDaVelha[0, 0] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[2, 2] == 'O') ||
                        (jogoDaVelha[0, 2] == 'O' && jogoDaVelha[1, 1] == 'O' && jogoDaVelha[2, 0] == 'O'))
                    {
                        Console.WriteLine("\nO Jogador O ganhou!");
                        qtdeJogadas = 0;
                        turno = 'X';
                        Array.Clear(jogoDaVelha, 0, jogoDaVelha.Length);
                        break;
                    }

                    if (qtdeJogadas == 8)
                    {
                        Console.WriteLine("\nDeu Velha!");
                    }

                }

                Console.Write("\nDeseja jogar novamente (S/N)? ");
                repetirJogo = Convert.ToChar(Console.ReadLine());

            } while (repetirJogo == 'S');
        }
    }
}
