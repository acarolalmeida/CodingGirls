using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    public class Animal
    {
        private string _nome;
        private int _numeroPatas;
        private string _cor;
        private string _ambiente;
        private double _velocidadeMedia;
        public string Nome 
        { 
            get { return _nome; } 
            set { _nome = value; } 
        }
        public int NumeroPatas
        {
            get { return _numeroPatas; }
            set { _numeroPatas = value; }
        }
        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }
        public string Ambiente
        {
            get { return _ambiente; }
            set { _ambiente = value; }
        }
        public double VelocidadeMedia
        {
            get { return _velocidadeMedia; }
            set { _velocidadeMedia = value; }

        }

        public Animal()
        { 

        }

        public Animal(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia)
        {
            Nome = nome;
            NumeroPatas = numeroPatas;
            Cor = cor;
            Ambiente = ambiente;
            VelocidadeMedia = velocidadeMedia;
        }

        public virtual void Dados()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Número de Patas: {NumeroPatas}.");
            Console.WriteLine($"Cor: {Cor}.");
            Console.WriteLine($"Ambiente: {Ambiente}.");
            Console.WriteLine($"Velocidade Média: {VelocidadeMedia} km/h.");
            Console.WriteLine();
        }
    }
}
