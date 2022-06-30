using System;

namespace Exercício01
{
    public class Program
    {
        static void Main()
        {
            char resposta;
            Aluno aluno = new Aluno();

            do
            {
                int opcaoEscolhida = Aluno.Menu();
                
                switch (opcaoEscolhida)
                {
                    case 1:
                        aluno.CadastrarNovoAluno();
                        break;
                    case 2:
                        aluno.AdicionarNotas();
                        break;
                    case 3:
                        aluno.ConsultaAluno();
                        break;
                    case 4:
                        aluno.ConsultaTodosAlunos();
                        break;
                    default:
                        Console.WriteLine("Esta opção não é válida.\n");
                        break;
                }

                Console.Write("Deseja realizar outra operação (S/N)? ");
                resposta = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            } while (resposta == 'S');            
        }
    }
}
