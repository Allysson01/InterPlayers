namespace InterPlayers.Model
{
    public class Estudante
    {
        public Estudante(string nome, string curso, bool titular, decimal media)
        {
            Nome = nome;
            Curso = curso;
            Titular = titular;
            Media = media;
        }

        public string Nome { get; }
        public string Curso { get; }
        public bool Titular { get; }
        public decimal Media { get; }        
    }
}
