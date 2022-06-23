using System;

namespace Exercício03
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Por favor, insira o número do pedido: ");
            int numeroPedido = int.Parse(Console.ReadLine());
            Console.Write("Agora, insira a descrição do produto comprado: ");
            string descricaoProduto = Console.ReadLine();
            Console.Write("Insira a quantidade comprada: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor unitário do produto (R$): ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Fatura faturaProduto = new Fatura(numeroPedido, quantidade, precoUnitario, descricaoProduto);
            faturaProduto.CalculaFatura();
        }
    }
}
