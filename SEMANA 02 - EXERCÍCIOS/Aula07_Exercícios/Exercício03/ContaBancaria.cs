using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    public class ContaBancaria
    {
        private string numeroConta;
        private string nomeCliente;
        private double saldo;

        public string NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; } 
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public ContaBancaria(string nomeCliente, string numeroConta, [Optional] double saldo)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
            Saldo = saldo;

            char resposta;

            do
            {
                Menu();

                Console.Write("Deseja realizar outra operação (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (resposta == 'S');
        }

        public void Menu()
        {
            Console.WriteLine("Selecione o que deseja fazer:");
            Console.Write("1 - Sacar dinheiro / 2 - Depositar dinheiro / 3 - Verificar Extrato / 4 - Alterar nome do titular: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcaoEscolhida)
            {
                case 1:
                    RealizaSaque();
                    break;
                case 2:
                    RealizarDeposito();
                    break;
                case 3:
                    VerificaExtrato();
                    break;
                case 4:
                    AlteraNomeTitular();
                    break;
                default:
                    Console.WriteLine("Esta opção não é válida.\n");
                    break;
            }
        }

        public void AlteraNomeTitular() 
        {
            Console.Write("Digite o novo nome do titular da conta: ");
            nomeCliente = Console.ReadLine();
            Console.WriteLine();
        }

        public void RealizarDeposito() 
        {
            Console.Write("Quanto deseja depositar? ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                saldo += valor;
                Console.WriteLine("\nSaque realizado com sucesso!\n");
            }

            else
            {
                Console.WriteLine("\nValor inválido! Tente novamente!\n");
                RealizarDeposito();
            }
        }

        public void RealizaSaque() 
        {
            Console.Write("Quanto deseja sacar? ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("\nSaque realizado com sucesso!\n");
            }

            else 
            {
                Console.WriteLine("\nValor inválido! Tente novamente!\n");
                RealizaSaque();
            }
        }
        public void VerificaExtrato() 
        {
            Console.WriteLine($"Número da conta: {numeroConta}");
            Console.WriteLine($"Cliente: {nomeCliente}");
            Console.WriteLine($"Saldo: {saldo}\n");
        }
    }
}
