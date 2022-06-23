using System;

namespace Exercício01
{
    internal class Jogo
    {
        private readonly string[,] Tabuleiro = new string[3, 3];
        private string jogadorX;
        private string jogadorO;
        private int rodada = 0;
        private string turno = "X";

        public Jogo()
        {
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            Console.WriteLine("Jogo da Velha v1.0\n");

            Console.Write("Digite o nome do Jogador 01 - X: ");
            jogadorX = Console.ReadLine();
            Console.Write("Digite o nome do Jogador 02 - O: ");
            jogadorO = Console.ReadLine();

            Preencher();
            Desenhar();
            Jogada();
        }

        private void Desenhar()
        {
            Console.Clear();

            Console.WriteLine($"Jogador X: {jogadorX} - Jogador O: {jogadorO}");

            Console.WriteLine();
            Console.WriteLine($" {Tabuleiro[0, 0]} | {Tabuleiro[0, 1]} | {Tabuleiro[0, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {Tabuleiro[1, 0]} | {Tabuleiro[1, 1]} | {Tabuleiro[1, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {Tabuleiro[2, 0]} | {Tabuleiro[2, 1]} | {Tabuleiro[2, 2]}");
        }

        private void Preencher()
        {
            int posicao = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    posicao++;
                    Tabuleiro[row, col] = posicao.ToString();
                }
            }
        }

        private void Jogada()
        {
            while (rodada < 9 && !Vencedor())
            {
                Console.Write($"\nJogador {turno} - Escolha a posição que deseja jogar: ");
                bool validaEntradaUsuario = int.TryParse(Console.ReadLine(), out int escolhaDoJogador);

                if (validaEntradaUsuario)
                {
                    switch (escolhaDoJogador)
                    {
                        case 1:
                            if (string.Equals(Tabuleiro[0, 0],"1"))   
                            {
                                Tabuleiro[0, 0] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }

                        case 2:
                            if (string.Equals(Tabuleiro[0, 1], "2"))
                            {
                                Tabuleiro[0, 1] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }

                        case 3:
                            if (string.Equals(Tabuleiro[0, 2], "3"))
                            {
                                Tabuleiro[0, 2] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                            
                        case 4:
                            if (string.Equals(Tabuleiro[1, 0], "4"))
                            {
                                Tabuleiro[1, 0] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                            
                        case 5:
                            if (string.Equals(Tabuleiro[1, 1], "5"))
                            {
                                Tabuleiro[1, 1] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }

                        case 6:
                            if (string.Equals(Tabuleiro[1, 2], "6"))
                            {
                                Tabuleiro[1, 2] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                            
                        case 7:
                            if (string.Equals(Tabuleiro[2, 0], "7"))
                            {
                                Tabuleiro[2, 0] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                           
                        case 8:
                            if (string.Equals(Tabuleiro[2, 1], "8"))
                            {
                                Tabuleiro[2, 1] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                            
                        case 9:
                            if (string.Equals(Tabuleiro[2, 2], "9"))
                            {
                                Tabuleiro[2, 2] = turno;
                                rodada++;
                                turno = (turno == "X") ? "O" : "X";
                                Desenhar();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEsta posição já está preenchida, escolha novamente.");
                                break;
                            }
                            
                        default:
                            Console.WriteLine("Posição inválida!");
                            break;
                    }
                }

                if (rodada == 9)
                {
                    Console.WriteLine("\nDeu a velha!\n");
                }
            }
        }

        private bool Vencedor()
        {
            if ((Tabuleiro[0, 0] == "X" && Tabuleiro[0, 1] == "X" && Tabuleiro[0, 2] == "X") ||
                        (Tabuleiro[1, 0] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[1, 2] == "X") ||
                        (Tabuleiro[2, 0] == "X" && Tabuleiro[2, 1] == "X" && Tabuleiro[2, 2] == "X") ||
                        (Tabuleiro[0, 0] == "X" && Tabuleiro[1, 0] == "X" && Tabuleiro[2, 0] == "X") ||
                        (Tabuleiro[0, 1] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 1] == "X") ||
                        (Tabuleiro[0, 2] == "X" && Tabuleiro[1, 2] == "X" && Tabuleiro[2, 2] == "X") ||
                        (Tabuleiro[0, 0] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 2] == "X") ||
                        (Tabuleiro[0, 2] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 0] == "X"))
            {
                Console.WriteLine("\nO Jogador X ganhou!\n");
                return true;
            }

            else if ((Tabuleiro[0, 0] == "O" && Tabuleiro[0, 1] == "O" && Tabuleiro[0, 2] == "O") ||
                (Tabuleiro[1, 0] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[1, 2] == "O") ||
                (Tabuleiro[2, 0] == "O" && Tabuleiro[2, 1] == "O" && Tabuleiro[2, 2] == "O") ||
                (Tabuleiro[0, 0] == "O" && Tabuleiro[1, 0] == "O" && Tabuleiro[2, 0] == "O") ||
                (Tabuleiro[0, 1] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 1] == "O") ||
                (Tabuleiro[0, 2] == "O" && Tabuleiro[1, 2] == "O" && Tabuleiro[2, 2] == "O") ||
                (Tabuleiro[0, 0] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 2] == "O") ||
                (Tabuleiro[0, 2] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 0] == "O"))
            {
                Console.WriteLine("\nO Jogador O ganhou!\n");
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}