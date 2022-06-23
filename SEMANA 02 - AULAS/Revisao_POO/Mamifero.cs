using System;

namespace Revisao_POO
{
    // Encapsulamento
    class Mamifero
    {
        // Abstração - Controle de Acesso
        private int idade = 0;

        public string especie = "";

        public virtual void Falar()
        { 

        }

        public void Andar()
        { 

        }
    }

    // Herança
    class Humano : Mamifero
    {
        public override void Falar()
        {
            Console.WriteLine("Olá!");
        }
    }

    class Gato : Mamifero
    {
        public override void Falar()
        {
            Console.WriteLine("Miau");
        }
    }
}
