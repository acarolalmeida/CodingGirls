using System;

namespace Revisao_POO
{
    internal class Program
    {
        static void Main()
        {
            Humano professor = new Humano();

            professor.especie = "Humano";
            professor.Falar();

            Gato persa = new Gato();
            persa.Falar();
        }
    }
}
