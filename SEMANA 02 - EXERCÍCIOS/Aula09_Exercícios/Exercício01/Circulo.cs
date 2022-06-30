using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    public class Circulo : FiguraGeometrica
    {
        private double _raio;

        public double Raio
        {
            get { return _raio; }
            set { _raio = value; }
        }

        public Circulo(double raio)
        {
            Raio = raio;
            CalculaArea();
        }

        public override void CalculaArea()
        {
            double area = Math.PI * Math.Pow(_raio, 2);
            Console.WriteLine($"A área do círculo é: {Math.Round(area, 2)}.");
        }
    }
}
