using API_Escola.Context;
using API_Escola.Controllers;
using API_Escola.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;

namespace TDD_Escola
{
    public class AlunoControllerTests
    {
        [Fact]
        public void Test_ReturnNames_Sucess()
        {
            var _contextOptions = new DbContextOptionsBuilder<API_EscolaContext>().UseInMemoryDatabase("TDD_Escola").ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;

            var mockContext = new API_EscolaContext(_contextOptions);

            mockContext.Database.EnsureDeleted();
            mockContext.Database.EnsureCreated();

            mockContext.AddRange
            (
                new Aluno
                {
                    Id = 1,
                    Nome = "Ana Carolina Duque de Almeida",
                    DataNascimento = new DateTime(1995, 09, 30),
                    Sexo = 'F',
                    TurmaId = 1,
                    TotalFaltas = 2
                },

                new Aluno
                {
                    Id = 2,
                    Nome = "George Lucas Dias",
                    DataNascimento = new DateTime(1993, 10, 03),
                    Sexo = 'M',
                    TurmaId = 1,
                    TotalFaltas = 1
                }
            );

            mockContext.SaveChanges();

            // act

            AlunoController alunoController = new AlunoController(mockContext);
            var result = alunoController.GetAluno();

            Assert.NotNull(result);
        }
    }
}