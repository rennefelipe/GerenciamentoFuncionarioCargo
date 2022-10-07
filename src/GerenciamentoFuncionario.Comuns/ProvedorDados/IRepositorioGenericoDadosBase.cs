using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IRepositorioGenericoDadosBase<TEntidade> : IRepositorioGenericoLeituraDados<TEntidade> where TEntidade : EntidadeBase
    {
        void Adicionar(TEntidade entidade);
        void AdicionarVarios(IEnumerable<TEntidade> entidades);

        void Atualizar(TEntidade entidade);
        void AtualizarVarios(IEnumerable<TEntidade> entidades);

        void Excluir(TEntidade entidade);
        void ExcluirVarios(IEnumerable<TEntidade> entidades);
    }
}
