using GerenciamentoFuncionario.Comuns.Modelos;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IRepositorioGenericoDados<TEntidade> : IRepositorioGenericoDadosBase<TEntidade> where TEntidade : EntidadeBase
    {

    }
}
