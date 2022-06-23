using System;

namespace Encapsulamento_Abstração_Herança_Polimorfismo
{
    // Modificador de Classe: Define a visibilidade/comportamento da classe
    // public - sem restrição
    // abstract - não pode ser instanciada, classe base, modelo
    // sealed - não permite herança
    // static - pode ser utilizada sem ser instanciada

    // Controle de Acesso: Especifica em que momento um membro da classe pode ser acessado
    // public - sem restrição
    // private - acesso apenas pela própria classe
    // protected - acesso pela própria classe + classes derivadas, não podem ser vistos na instância
    // virtual - método pode ser redefinido por classes derivadas
    // static - podem ser acessados sem a necessidade da instância

    public class Mamifero
    {
        protected string Nome = "";

        public virtual void Falar()
        {
            Console.WriteLine("Oi");

        }
    }
}
