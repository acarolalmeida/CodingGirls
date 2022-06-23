using System;

namespace Desafio
{
    public class Círculo : Forma
    {
        public override double CalculaDimensao()
        {
            area = Math.Pow(parametro, 2) * Math.PI;
            return area;
        }
    }
}
