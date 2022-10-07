using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class Contexto
    {
        public Contexto()
        {
            Cargos = new List<Cargo> {
                new Cargo(1, "Desenvolvedor"),
                new Cargo(2, "Engenheiro"),
                new Cargo(3, "Arquiteto"),
                new Cargo(4, "Gerente de Projetos")
            };

            Funcionarios = new List<Funcionario> {
                new Funcionario(1, "Fulano de Tal", 1, false),
                new Funcionario(2, "Ciclano de Tal", 2, true),
                new Funcionario(3, "Beltrano de Tal", 3, true)
            };
        }

        public List<Cargo> Cargos { get; }
        public List<Funcionario> Funcionarios { get; }
    }
}
