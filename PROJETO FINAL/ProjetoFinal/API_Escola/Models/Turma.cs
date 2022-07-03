using System.Text.Json.Serialization;

namespace API_Escola.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }

        // NAVIGATION PROPERTIES
       [JsonIgnore] public virtual List<Aluno>? Alunos { internal get; set; }

        public static explicit operator Turma(ValueTask<Turma?> v)
        {
            throw new NotImplementedException();
        }
    }
}