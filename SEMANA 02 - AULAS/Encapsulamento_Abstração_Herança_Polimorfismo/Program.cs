using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento_Abstração_Herança_Polimorfismo
{
    internal class Program
    {
        static void Main()
        {
            Humano professor = new Humano();
            professor.Falar();

            Mamifero gato = new Mamifero();
            gato.Falar();
        }
    }
}
