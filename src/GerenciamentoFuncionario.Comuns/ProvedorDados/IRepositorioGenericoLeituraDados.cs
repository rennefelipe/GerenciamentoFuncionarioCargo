using GerenciamentoFuncionario.Comuns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IRepositorioGenericoLeituraDados<TEntidade> where TEntidade : EntidadeBase
    {
        Task<TEntidade> RecuperaUnicoPorId(int id, bool asNoTracking = false);
        Task<TEntidade> RecuperaUnico(Func<TEntidade, bool> clausulaWhere, bool asNoTracking = false, params Expression<Func<TEntidade, object>>[] propriedadesNavegacao);

        Task<IEnumerable<TEntidade>> RecuperaTodos(Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> ordenarPor = null, string propriedadesNavegacao = "", bool asNoTracking = false);
        Task<IEnumerable<TEntidade>> Recupera(Expression<Func<TEntidade, bool>> clausulaWhere = null, Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> ordenarPor = null, string propriedadesNavegacao = "", bool asNoTracking = false);
    }
}
