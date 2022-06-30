using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercício01
{
    public class Aluno
    {
        private string _name;
        private readonly double[,] _notas = new double[100, 2];
        private double _frequencia;

        private readonly string[] alunosCadastrados = new string[100];
        private readonly double[] frequenciaAlunosCadastrados = new double[100];

        public Aluno()
        { 
        }

        public static int Menu() 
        {
            Console.WriteLine("Selecione o que deseja fazer:");
            Console.Write("1 - Cadastrar novo aluno / 2 - Adicionar notas / 3 - Consultar aluno por Id / 4 - Listar alunos cadastrados: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return opcaoEscolhida;
        }

        public void CadastrarNovoAluno() 
        {
            Random rand = new Random();
            int id = rand.Next(100);

            Console.Write("Insira o nome do(a) novo(a) aluno(a): ");
            _name = Console.ReadLine();
            alunosCadastrados[id] = _name;
            Console.WriteLine($"Aluno(a) cadastrado(a) com sucesso! Id de cadastro: {id}. Guarde este número para consultas futuras.\n");
        }

        public void AdicionarNotas()
        {
            Console.Write("Digite o Id do(a) aluno(a) para o qual você deseja inserir as notas: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nInsira a nota da 1ª prova: ");
            _notas[id, 0] = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota da 2ª prova: ");
            _notas[id, 1] = double.Parse(Console.ReadLine());
            Console.Write("Insira a frequência do(a) aluno(a). O valor deve estar entre 0 e 1: ");
            _frequencia = double.Parse(Console.ReadLine());
            frequenciaAlunosCadastrados[id] = _frequencia;
            Console.WriteLine();
        }

        public void ConsultaAluno()
        {
            Console.Write("Digite o Id do aluno que deseja consultar: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nNome do(a) aluno(a): {alunosCadastrados[id]}");
            Console.WriteLine($"Nota da 1ª prova: {_notas[id, 0]}");
            Console.WriteLine($"Nota da 2ª prova: {_notas[id, 1]}");
            Console.WriteLine($"Frequência do(a) aluno(a): {frequenciaAlunosCadastrados[id] * 100}%");
            Console.WriteLine();
        }

        public void ConsultaTodosAlunos()
        {
            List<string> totalAlunos = alunosCadastrados.ToList();

            foreach (string aluno in totalAlunos)
            {
                if (aluno != null)
                {
                    Console.WriteLine($"Id: {totalAlunos.IndexOf(aluno)}, Nome do(a) aluno(a): {aluno}.");
                }
                    
            }

            Console.WriteLine();
        }
    }
}
