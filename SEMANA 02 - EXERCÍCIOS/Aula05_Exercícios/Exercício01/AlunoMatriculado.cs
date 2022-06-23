using System;

namespace Exercício01
{
    public class AlunoMatriculado
    {
        private string _nome;
        private string _matricula;
        private double _notaProva01;
        private double _notaProva02;
        private double _notaTrabalho;
        private double _media;
        private double _notaFinal;

        public AlunoMatriculado(string nome, string matricula, double notaProva01, double notaProva02, double notaTrabalho)
        {
            _nome = nome;
            _matricula = matricula;
            _notaProva01 = notaProva01;
            _notaProva02 = notaProva02;
            _notaTrabalho = notaTrabalho;

            CalculaMedia();
            CalculaNotaFinal();
        }

        private void CalculaMedia()
        {
            _media = Math.Round((_notaProva01 + _notaProva02 + _notaTrabalho) / 3, 2);
            Console.WriteLine($"\nA média final do(a) aluno(a) {_nome} é: {_media}");
        }

        private void CalculaNotaFinal()
        {
            _notaFinal = Math.Round(28 - (_notaProva01 + _notaProva02 + _notaTrabalho), 2);
            Console.WriteLine($"\nConsiderando 7.0 a média mínima para aprovação, o(a) aluno(a) {_nome} deve tirar pelo menos {_notaFinal} na prova final para ser aprovado(a).\n");
        }
    }
}