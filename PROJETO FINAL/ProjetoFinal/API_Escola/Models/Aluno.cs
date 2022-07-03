using System.Text.Json.Serialization;

namespace API_Escola.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int TurmaId { get; set; }
        public int? TotalFaltas { get; set; }

        // NAVIGATION PROPERTIES
        [JsonIgnore] public virtual Turma? Turma { get; set; }
    }
}