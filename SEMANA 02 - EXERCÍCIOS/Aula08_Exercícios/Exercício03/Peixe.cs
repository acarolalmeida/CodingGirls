using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    public class Peixe : Animal
    {
        private string _caracteristica;

        public string Caracteristica 
        { 
            get { return _caracteristica; } 
            set { _caracteristica = value; } 
        }

        public Peixe(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia, string caracteristica)
        {
            Nome = nome;
            NumeroPatas = numeroPatas;
            Cor = cor;
            Ambiente = ambiente;
            VelocidadeMedia = velocidadeMedia;
            Caracteristica = caracteristica;
        }

        public override void Dados()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Número de Patas: {NumeroPatas}.");
            Console.WriteLine($"Cor: {Cor}.");
            Console.WriteLine($"Ambiente: {Ambiente}.");
            Console.WriteLine($"Velocidade Média: {VelocidadeMedia} km/h.");
            Console.WriteLine($"Característica: {Caracteristica}.");
            Console.WriteLine();
        }
    }
}
