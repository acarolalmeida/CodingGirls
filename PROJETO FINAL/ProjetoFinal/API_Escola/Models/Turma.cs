using System.Text.Json.Serialization;

namespace API_Escola.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }

        // NAVIGATION PROPERTIES
       [JsonIgnore] public virtual List<Aluno>? Alunos { get; set; }
    }
}