using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    public class MundoAnimal
    {
        Peixe peixe = new Peixe("Salmão", 0, "Laranja", "Mar", 50, "Pode viver tanto em água doce quanto em água salgada");
        Mamífero mamífero = new Mamífero("Zebra", 4, "Preto e Branco", "Savana", 65, "Carne");

        public MundoAnimal()
        {
            ExibeListaAnimais();
        }

        public void ExibeListaAnimais()
        {
            peixe.Dados();
            mamífero.Dados();
        }
    }
}
