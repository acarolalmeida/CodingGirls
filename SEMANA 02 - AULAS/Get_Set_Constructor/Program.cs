using System;

namespace Get_Set_Constructor
{
    internal class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno("Ana", "CodingGirls");
            aluno.Sobrenome = "Almeida";
            Console.WriteLine($"Seu sobrenome é: {aluno.Sobrenome}");
        }
    }
}
