using API_Escola.Models;
using Moq;

namespace TDD_Escola
{
    public class EscolaTests
    {
        // 1. Fun��o dubl� / fake
        private Aluno GetAlunoById() 
        {
            Aluno aluno = new Aluno
            {
                Id = 1,
                Nome = "Ana Carolina",
                DataNascimento = DateTime.Today,
                Sexo = 'F',
                TurmaId = 1,
                TotalFaltas = 2
            };

            return aluno;
        }

        // 2. S�o os testes de cada rota ou recurso
        [Fact]
        public void Test_GetAlunoById_NotNull()
        {
            Aluno teste = GetAlunoById();

            Assert.NotNull(teste);
        }

        [Fact]
        public void Test_GetAlunoById_NotType()
        {
            Aluno teste = GetAlunoById();

            Assert.IsType<Aluno>(teste);
        }
    }
}