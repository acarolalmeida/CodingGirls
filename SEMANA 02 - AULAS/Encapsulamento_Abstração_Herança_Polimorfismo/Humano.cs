using System;

namespace Encapsulamento_Abstração_Herança_Polimorfismo
{
    internal class Humano : Mamifero
    {
        public override void Falar()
        {
            Console.WriteLine("Olá!");
        }
    }
}
