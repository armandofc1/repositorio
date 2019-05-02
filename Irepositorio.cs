using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern
{    public interface IRepositorio<T> where T : class
    {
        IList<T> PesquisarTodos();
        IList<T> PesquisarPorId(long id);
        void Inserir(T entity);
        void InserirVarios(List<T> entities);
        void Atualizar(T entity);
        void AtualizarVarios(List<T> entities);
        void Excluir(T entity);
        void ExcluirVarios(List<T> entities);
    }
}