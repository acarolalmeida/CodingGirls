using System;

namespace Exercício03
{
    public class Fatura
    {
        private int numeroId;
        private int quantidadeComprada;
        private double precoUnitario;
        private double valorFatura;
        private string descricaoProduto;

        public int Numero
        {
            get { return numeroId; }
            set { numeroId = value; }
        }

        public int QuantidadeComprada 
        {
            get { return quantidadeComprada; }
            set { quantidadeComprada = value; }
        }

        public double PrecoUnitario 
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public string DescricaoProduto 
        {
            get { return descricaoProduto; }
            set { descricaoProduto = value; }
        }

        public Fatura(int numero, int qtdeComprada, double preco, string descricao) 
        { 
            Numero = numero;
            QuantidadeComprada = qtdeComprada;
            PrecoUnitario = preco;
            DescricaoProduto = descricao;
        }

        public void CalculaFatura() 
        {
            valorFatura = quantidadeComprada * precoUnitario;
            Console.WriteLine($"O valor total da fatura será R${valorFatura}.\n");
        }
    }
}
