using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface ICargoProvedorDados
    {
        IEnumerable<Cargo> CarregaCargos();
        Cargo RecuperaCargoPorId(int id);
        void SalvaCargo(Cargo cargo);
        void AtualizaCargo(Cargo cargo);
        void ExcluiCargo(Cargo cargo);
    }
}
