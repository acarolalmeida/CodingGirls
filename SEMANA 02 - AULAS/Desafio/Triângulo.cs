namespace Desafio
{
    public class Triângulo : Forma
    {
        public double parametro02 = 0;

        public override double CalculaDimensao()
        {
            area = (parametro * parametro02) / 2;
            return area;
        }
    }
}
