using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerício02
{
    public class Program
    {
        static void Main()
        {
            char resposta;

            Conta conta01 = new Conta();
            
            do
            {
                conta01.Menu();
                
                Console.Write("Deseja realizar outra operação (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (resposta == 'S');
        }
    }
}
