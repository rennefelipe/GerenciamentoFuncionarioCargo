using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        private readonly Contexto _contexto;

        public FuncionarioProvedorDados()
        {
            _contexto = new Contexto();
        }

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            _contexto.Funcionarios.ForEach(x =>
            {
                if (x.Id.Equals(funcionario.Id))
                {
                    x = funcionario;
                    return;
                }
            });
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            _contexto.Funcionarios.Remove(funcionario);
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            return _contexto.Funcionarios.Find(x => x.Id.Equals(id));
        }

        public void SalvaFuncionario(string nomeCompleto, int cargoId, bool eBebedorCafe)
        {
            var novoFuncionario = new Funcionario(RecuperaUltimoIdFuncionarios(), nomeCompleto, cargoId, eBebedorCafe);
            _contexto.Funcionarios.Add(novoFuncionario);
            Debug.WriteLine($"Funcionário salvo: {novoFuncionario.PrimeiroNome}");
        }

        public IEnumerable<Funcionario> CarregaFuncionarios() => _contexto.Funcionarios;

        private int TotalFuncionarios() => CarregaFuncionarios().Count();

        private int RecuperaUltimoIdFuncionarios() => CarregaFuncionarios().Last().Id;

    }
}
