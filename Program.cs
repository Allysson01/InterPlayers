using InterPlayers.DAO;
using System;

namespace InterPlayers
{
    class Program
    {
        static void Main(string[] args)
        {

            var repositorioFake = new RepositorioFake();

            var listaEstudantes = repositorioFake.RetornaLista();

            foreach (var item in listaEstudantes)
            {
                var estudante = $"Nome: {item.Nome} | Curso: {item.Curso} | Media das notas do Projeto Integrado: {item.Media}";
                Console.WriteLine(estudante);
            }

            Console.ReadLine();

        }
    }
}
