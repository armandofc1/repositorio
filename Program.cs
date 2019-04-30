using System;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var usuario = new Usuario
            {
                Nome = "Teste",
                Sobrenome = "Teste"
            };

            Irepositorio<Usuario> repositorioUsuarios = new Repositorio<Usuario>();
            repositorioUsuarios.Inserir(usuario);

            var resultado = repositorioUsuarios.PesquisarTodos();
        }
    }
}
