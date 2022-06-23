using System;
using System.Text;

namespace Exercício01
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Por favor, digite o nome do(a) aluno(a): ");
            string nome = Console.ReadLine();
            Console.Write("Agora, digite a matrícula do(a) aluno(a): ");
            string matricula = Console.ReadLine();
            Console.Write("Insira a nota da Prova 01: ");
            double notaProva01 = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota da Prova 02: ");
            double notaProva02 = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota do Trabalho: ");
            double notaTrabalho = double.Parse(Console.ReadLine());

            AlunoMatriculado aluno = new AlunoMatriculado(nome, matricula, notaProva01, notaProva02, notaTrabalho);

        }
    }
}
