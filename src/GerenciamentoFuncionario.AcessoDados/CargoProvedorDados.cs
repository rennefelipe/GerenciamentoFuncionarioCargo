using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class CargoProvedorDados : ICargoProvedorDados
    {
        private List<Cargo> Cargos { get; set; }

        public CargoProvedorDados()
        {
            Cargos = new List<Cargo> {
                new Cargo(1, "Desenvolvedor"),
                new Cargo(2, "Engenheiro"),
                new Cargo(3, "Arquiteto"),
                new Cargo(4, "Gerente de Projetos")
            };
        }

        public void AtualizaCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cargo> CarregaCargos()
        {
            return Cargos;
        }

        public void ExcluiCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }

        public Cargo RecuperaCargoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SalvaCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }
    }
}
