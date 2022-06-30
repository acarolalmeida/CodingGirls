using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    public class Retangulo : FiguraGeometrica
    {
        private double _base;
        private double _altura;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
            CalculaArea();
        }

        public override void CalculaArea()
        {
            double area = _base * _altura;
            Console.WriteLine($"\nA área do retângulo é: {Math.Round(area, 2)}.\n");
        }
    }
}
