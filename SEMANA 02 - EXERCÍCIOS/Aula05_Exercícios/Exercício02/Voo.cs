using System;

namespace Exercício02
{
    public class Voo
    {
        private int[] _cadeiras = new int[100];
        private char reservarMaisVagas;
        private int contadorVagasLivres;

        public Voo() 
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.Write("1 - Escolher Assentos / 2 - Verificar Todos os Assentos Livres / 3 - Verificar o Primeiro Assento Livre / 4 - Verificar Data e Horário do Vôo / 5 - Sair do Menu: ");
            int escolhaDoUsuario = int.Parse(Console.ReadLine());
            
            switch (escolhaDoUsuario)
            {
                case 1:
                OcupacaoVagas:
                    do
                    {
                        Console.Write("\nEscolha o assento que deseja ocupar: ");
                        bool confirmacao = OcuparVaga(int.Parse(Console.ReadLine()));

                        if (!confirmacao)
                        {
                            goto OcupacaoVagas;
                        }

                        Console.Write("Deseja reservar mais assentos (S/N)? ");
                        reservarMaisVagas = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                    } while (reservarMaisVagas == 'S');

                    Menu();
                    break;
                    
                case 2:
                    VagasLivres();
                    Menu();
                    break;
                    
                case 3:
                    CadeiraLivre();
                    Menu();
                    break;
                    
                case 4:
                    VerHorario();
                    Menu();
                    break;
                    
                case 5:
                    Console.WriteLine();
                    break;
                    
                default:
                    Console.WriteLine("\nA opção inserida não é válida.\n");
                    Menu();
                    break;
            }
        }

        public bool OcuparVaga(int cadeira)
        {
            if (_cadeiras[cadeira - 1] == 0)
            { 
                _cadeiras[cadeira - 1] = 1;
                Console.WriteLine("Escolha de assento confirmada!\n");
                return true;
            }
            
            else
            {
                Console.WriteLine("Este assento já está reservado! Por favor, selecione outro.\n");
                return false;
            }
        }

        public void VagasLivres()
        {
            for (int i = 0; i < _cadeiras.Length; i++)
            {
                if (_cadeiras[i] == 0)
                {
                    contadorVagasLivres++;
                }
            }

            Console.WriteLine($"\nNeste momento, existem {contadorVagasLivres} assentos disponíveis neste vôo.");
            Console.WriteLine("\n");
            contadorVagasLivres = 0;
        }

        public void CadeiraLivre()
        {
            Console.Write("\nO primeiro assento disponível neste vôo é o de número: ");
            int primeiroAssentoVazio = Array.IndexOf(_cadeiras, 0);
            Console.WriteLine($"{primeiroAssentoVazio + 1}.\n");
        }
        
        public void VerHorario()
        {
            Random rand = new Random();

            string RandomDay()
            {
                DateTime start = new DateTime(2022, 6, 19);
                DateTime end = new DateTime(2022, 12, 31);
                int range = (end - start).Days;
                return start.AddDays(rand.Next(range)).ToString("dd/MM/yyyy");
            }

            string RandomHours()
            {
                DateTime start = DateTime.Today;
                int range = 24 * 60;
                return start.AddMinutes(rand.Next(range)).ToString("HH:mm");
            }

            string dataVoo = RandomDay();
            string horaVoo = RandomHours();

            Console.WriteLine($"\nO horário do vôo é às {horaVoo}h no dia {dataVoo}.\n");
        }
    }
}
