namespace Get_Set_Constructor
{
    public class Aluno
    {
        private string _nome;
        private string _sobrenome;
        private string _codigoDaTurma;

        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        public Aluno(string nome, string CodigoDaTurma) // Construtores não têm nenhum retorno, nem void
        { 
            _nome = nome;
            _codigoDaTurma = CodigoDaTurma;

            Cadastrar(_nome, _codigoDaTurma);
        }

        private void Cadastrar(string Nome, string CodigoDaTurma) 
        { 
        
        }
    }
}
