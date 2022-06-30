using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    public class Triangulo : FiguraGeometrica
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

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            Base = baseTriangulo;
            Altura = alturaTriangulo;
            CalculaArea();
        }

        public override void CalculaArea()
        {
            double area = (_base * _altura) / 2;
            Console.WriteLine($"\nA área do triângulo é: {Math.Round(area, 2)}.\n");
        }
    }
}
