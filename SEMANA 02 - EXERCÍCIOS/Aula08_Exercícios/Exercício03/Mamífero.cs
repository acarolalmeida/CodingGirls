using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    public class Mamífero : Animal
    {
        private string _alimento;
        public string Alimento 
        { 
            get { return _alimento; } 
            set { _alimento = value; } 
        }

        public Mamífero(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia, string alimento)
        {
            Nome = nome;
            NumeroPatas = numeroPatas;
            Cor = cor;
            Ambiente = ambiente;
            VelocidadeMedia = velocidadeMedia;
            Alimento = alimento;
        }

        public override void Dados()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Número de Patas: {NumeroPatas}.");
            Console.WriteLine($"Cor: {Cor}.");
            Console.WriteLine($"Ambiente: {Ambiente}.");
            Console.WriteLine($"Velocidade Média: {VelocidadeMedia} km/h.");
            Console.WriteLine($"Alimento: {Alimento}.");
            Console.WriteLine();
        }
    }
}
