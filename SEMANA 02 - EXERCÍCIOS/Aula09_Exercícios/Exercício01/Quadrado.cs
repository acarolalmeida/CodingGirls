using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    public class Quadrado : FiguraGeometrica
    {
        private double _lado;

        public double Lado 
        { 
            get { return _lado; }
            set { _lado = value; }
        }

        public Quadrado(double lado)
        {
            Lado = lado;
            CalculaArea();
        }

        public override void CalculaArea()
        {
            double area = Math.Pow(_lado, 2);
            Console.WriteLine($"\nA área do quadrado é: {Math.Round(area, 2)}.\n");
        }
    }
}
 