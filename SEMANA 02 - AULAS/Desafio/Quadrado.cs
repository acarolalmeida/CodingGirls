using System;

namespace Desafio
{
    public class Quadrado : Forma
    {
        public override double CalculaDimensao()
        {
            area = Math.Pow(parametro, 2);
            return area;
        }
    }
}
