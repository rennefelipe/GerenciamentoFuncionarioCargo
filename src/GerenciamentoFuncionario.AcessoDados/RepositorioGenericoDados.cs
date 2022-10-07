using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class RepositorioGenericoDados<TEntidade> : IRepositorioGenericoDados<TEntidade> where TEntidade : EntidadeBase, new()
    {
        public RepositorioGenericoDados()
        {

        }

        #region Expectate
        //public virtual void Adicionar(params T[] itens)
        //{
        //    #region EFCore
        //    //using (var context = new Entidades())
        //    //{
        //    //    foreach (T item in itens)
        //    //    {
        //    //        context.Entry(item).State = System.Data.EntityState.Added;
        //    //    }
        //    //    context.SaveChanges();
        //    //} 
        //    #endregion
        //}

        //public virtual void Atualizar(params T[] itens)
        //{
        //    #region EFCore
        //    //using (var context = new Entidades())
        //    //{
        //    //    foreach (T item in itens)
        //    //    {
        //    //        context.Entry(item).State = System.Data.EntityState.Modified;
        //    //    }
        //    //    context.SaveChanges();
        //    //} 
        //    #endregion
        //}

        //public IList<T> Recupera(Expression<Func<T, bool>> clausulaWhere = null, Func<IQueryable<T>, IOrderedQueryable<T>> ordenarPor = null, string propriedadesNavegacao = "")
        //{
        //    //IQueryable<T> query = dbSet;

        //    //if (clausulaWhere != null)
        //    //    query = query.Where(clausulaWhere);


        //    //foreach (var includeProperty in propriedadesNavegacao.Split
        //    //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    //{
        //    //    query = query.Include(includeProperty);
        //    //}

        //    //if (ordenarPor != null)
        //    //    return ordenarPor(query).ToList();
        //    //else
        //    //    return query.ToList();

        //    return null;
        //}

        //public virtual IList<T> RecuperaTodos(params Expression<Func<T, object>>[] propriedadesNavegacao)
        //{
        //    //List<T> list;
        //    #region EFCore
        //    //using (var context = new Entidades())
        //    //{
        //    //    IQueryable<T> dbQuery = context.Set<T>();

        //    //    //Apply eager loading
        //    //    foreach (Expression<Func<T, object>> propriedadeNavegacao in propriedadesNavegacao)
        //    //        dbQuery = dbQuery.Include<T, object>(propriedadeNavegacao);

        //    //    list = dbQuery
        //    //        .AsNoTracking()
        //    //        .ToList<T>();
        //    //}
        //    #endregion
        //    //return list;             
        //    return null;
        //}

        //public virtual T RecuperaUnico(Func<T, bool> clausulaWhere, params Expression<Func<T, object>>[] propriedadesNavegacacao)
        //{
        //    //T item = null;
        //    #region EFCore
        //    //using (var context = new Entidades())
        //    //{
        //    //    IQueryable<T> dbQuery = context.Set<T>();

        //    //    //Apply eager loading
        //    //    foreach (Expression<Func<T, object>> navigationProperty in propriedadesNavegacacao)
        //    //        dbQuery = dbQuery.Include<T, object>(navigationProperty);

        //    //    item = dbQuery
        //    //        .AsNoTracking() //Don't track any changes for the selected item
        //    //        .FirstOrDefault(clausulaWhere); //Apply where clause
        //    //} 
        //    #endregion
        //    //return item;
        //    return null;
        //}

        //public virtual void Remover(params T[] itens)
        //{
        //    #region EFCore
        //    //using (var context = new Entidades())
        //    //{
        //    //    foreach (T item in itens)
        //    //    {
        //    //        context.Entry(item).State = System.Data.EntityState.Deleted;
        //    //    }
        //    //    context.SaveChanges();
        //    //} 
        //    #endregion
        //} 
        #endregion

        public virtual void Adicionar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void AdicionarVarios(IEnumerable<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual void Atualizar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void AtualizarVarios(IEnumerable<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual void Excluir(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void ExcluirVarios(IEnumerable<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<TEntidade>> Recupera(Expression<Func<TEntidade, bool>> clausulaWhere = null, 
            Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> ordenarPor = null, string propriedadesNavegacao = "",
            bool asNoTracking = false)
        {
            IQueryable<TEntidade> query;
            //IQueryable<TEntidade> query = dbSet;

            //if (clausulaWhere != null)
            //    query = query.Where(clausulaWhere);

            //if (asNoTracking)
            //    query = query.AsNoTracking();

            //foreach (var includeProperty in propriedadesNavegacao.Split
            //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    query = query.Include(includeProperty);
            //}

            //return ordenarPor != null ? ordenarPor(query).ToList() : query.ToList();
            return null;

        }

        public virtual async Task<IEnumerable<TEntidade>> RecuperaTodos(Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> ordenarPor = null, 
            string propriedadesNavegacao = "", bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntidade> RecuperaUnico(Func<TEntidade, bool> clausulaWhere, bool asNoTracking = false, 
            params Expression<Func<TEntidade, object>>[] propriedadesNavegacao)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntidade> RecuperaUnicoPorId(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
