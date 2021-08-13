using InterPlayers.Model;
using System.Collections.Generic;
using System.Linq;

namespace InterPlayers.DAO
{
    public class RepositorioFake
    {
        public List<Estudante> RetornaLista()
        {
            var estudantes = new List<Estudante>
            {
                new Estudante("Fulano da Silva", "Mecatronica", true, 7.25M),
                new Estudante("Beltrano de Souza", "ADM", true, 6.25M),
                new Estudante("Ciclano das Dores", "Quimica Indutrial", false, 6.98M),
                new Estudante("Oscar da Silva Mundongo", "Economia", false, 9.75M)
            };

            return estudantes.OrderBy(o => o.Nome).ToList();
        }
    }
}
