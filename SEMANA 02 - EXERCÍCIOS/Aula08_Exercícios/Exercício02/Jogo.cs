using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    public class Jogo
    {
        private string nome;
        private int classificacaoEtaria;
        private string codigo;
        private int anoDeLancamento;
        private bool emprestado;
        private string genero;

        private List<string> nomesJogos = new List<string>();

        public Jogo()
        {
        }

        public void ImprimeInfosJogo() 
        {
            Console.WriteLine($"Nome do Jogo: {nome}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Classificação Etária: {classificacaoEtaria}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Ano de lançamento: {anoDeLancamento}");
            Console.WriteLine($"Emprestado (S/N)? {emprestado}");
        }

        public void LocarJogo() 
        {
            Console.Write("Por favor, informe o nome do jogo que deseja locar: ");
            string nomeJogo = Console.ReadLine();

            //if(nomesJogos.Contains(nomeJogo) &&                                                               )
                        
        }

        public void DevolverJogo() { }
    }
}
