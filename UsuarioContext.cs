using System;

namespace RepositoryPattern
{

    public class UsuarioContext : Repositorio<Usuario>
    {
        public override void Inserir(Usuario entity)
        {
            using (var context = new GenericContext<Usuario>())
            {
                entity.DataInclusao = DateTime.Now;
                context.Entity.Add(entity);
                context.SaveChanges();
            }
        }
    }
}