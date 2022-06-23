using System;

namespace Exercício02
{
    public class Empregado
    {
        private readonly string _nome;
        private readonly string _cargo;
        private double _salario;

        public Empregado()
        {
            Console.Write("Insira o nome do empregado: ");
            _nome = Console.ReadLine();
            Console.Write("Insita o cargo do empregado: ");
            _cargo = Console.ReadLine();
            Console.Write("Insira o salário do empregado: ");
            _salario = double.Parse(Console.ReadLine());

            DefineSalarioMinimo();
            AumentoSalario();
            ImprimeSalario();
        }

        private void DefineSalarioMinimo() 
        {
            if (_salario < 0)
            {
                _salario = 0.0;
            }
        }

        private void AumentoSalario()
        {
            if (_salario >= 2000.00)
            {
                _salario *= 1.04;
            }

            else if (_salario >= 1200.01 && _salario < 2000.00) 
            {
                _salario *= 1.07;
            }
            
            else if (_salario >= 800.01 && _salario < 1200.01) 
            {
                _salario *= 1.1;
            }
            
            else if (_salario >= 400.01 && _salario < 800.01) 
            {
                _salario *= 1.12;
            }
            
            else 
            {
                _salario *= 1.15;
            }
        }

        private void ImprimeSalario() 
        {
            Console.WriteLine($"{_nome}, cujo cargo atual é {_cargo}, terá salário de R${Math.Round(_salario, 2)} após o reajuste.\n");
        }
    }
}