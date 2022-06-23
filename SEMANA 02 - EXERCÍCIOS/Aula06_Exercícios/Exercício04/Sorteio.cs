using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04
{
    public class Sorteio
    {
        private int numeroSorteado;

        private void SorteiaNumero() 
        {
            Random rand = new Random();

            numeroSorteado = rand.Next(0, 1000);

        }
        

    }
}
