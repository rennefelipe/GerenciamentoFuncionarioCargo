using GerenciamentoFuncionario.AcessoDados;
using System;
using System.Linq;

namespace GerenciamentoFuncionario.Console
{
    class Program
    {
        static void Main()
        {
            #region Etapa 1
            var provedorFuncionario = new FuncionarioProvedorDados();
            var provedorCargo = new CargoProvedorDados();

            var funcionarios = provedorFuncionario.CarregaFuncionarios();

            foreach (var funcionario in funcionarios)
            {
                System.Console.WriteLine($"{funcionario.Id} - {funcionario.PrimeiroNome} {funcionario.UltimoNome} - {funcionario.CargoId} \n{funcionario.DataEntrada} | {funcionario.EBebedorCafe}");
                System.Console.WriteLine("--------------------------------------------------------");
                System.Console.WriteLine("\n\n");
            }
            System.Console.ReadKey();
            System.Console.Clear();
            #endregion

            #region Etapa 2
            var funcionariosIds = funcionarios.Select(x => x.Id).ToArray();
            int idSelecionado = 0;
            while (!funcionariosIds.Contains(idSelecionado))
            {
                Random objetoAleatorio = new();
                idSelecionado = objetoAleatorio.Next(funcionariosIds.Min(), funcionariosIds.Max());
            }

            var funcionarioPorId = provedorFuncionario.RecuperaFuncionarioPorId(idSelecionado);

            System.Console.WriteLine($"{funcionarioPorId.Id} - {funcionarioPorId.PrimeiroNome} {funcionarioPorId.UltimoNome} - {funcionarioPorId.CargoId} \n{funcionarioPorId.DataEntrada} | {funcionarioPorId.EBebedorCafe}");
            System.Console.ReadKey();
            System.Console.Clear();
            #endregion

            #region Etapa 3
            var funcionarioPorIdAlterado = funcionarioPorId;
            funcionarioPorIdAlterado.NomeCompleto = "Testando outro nome";
            //criar script que retorna qualquer outro cargo que não seja o atual
            provedorFuncionario.AtualizaFuncionario(funcionarioPorIdAlterado);

            System.Console.WriteLine($"{funcionarioPorIdAlterado.Id} - {funcionarioPorIdAlterado.PrimeiroNome} {funcionarioPorIdAlterado.UltimoNome} - {funcionarioPorIdAlterado.CargoId} \n{funcionarioPorIdAlterado.DataEntrada} | {funcionarioPorIdAlterado.EBebedorCafe}");
            System.Console.ReadKey();
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.WriteLine("\n\n");
            System.Console.Clear();

            foreach (var funcionario in funcionarios)
            {
                System.Console.WriteLine($"{funcionario.Id} - {funcionario.PrimeiroNome} {funcionario.UltimoNome} - {funcionario.CargoId} \n{funcionario.DataEntrada} | {funcionario.EBebedorCafe}");
                System.Console.WriteLine("--------------------------------------------------------");
                System.Console.WriteLine("\n\n");
            }
            System.Console.ReadKey();
            System.Console.Clear();
            #endregion

            #region Etapa4
            idSelecionado = 0;
            while (!funcionariosIds.Contains(idSelecionado))
            {
                Random objetoAleatorio = new();
                idSelecionado = objetoAleatorio.Next(funcionariosIds.Min(), funcionariosIds.Max());
            }

            funcionarioPorId = provedorFuncionario.RecuperaFuncionarioPorId(idSelecionado);

            var funcionarioPorIdExcluido = funcionarioPorId;
            provedorFuncionario.ExcluiFuncionario(funcionarioPorIdExcluido);

            System.Console.WriteLine($"{funcionarioPorIdExcluido.Id} - {funcionarioPorIdExcluido.PrimeiroNome} {funcionarioPorIdExcluido.UltimoNome} - {funcionarioPorIdExcluido.CargoId} \n{funcionarioPorIdExcluido.DataEntrada} | {funcionarioPorIdExcluido.EBebedorCafe}");
            System.Console.ReadKey();
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.WriteLine("\n\n");
            System.Console.Clear();

            foreach (var funcionario in funcionarios)
            {
                System.Console.WriteLine($"{funcionario.Id} - {funcionario.PrimeiroNome} {funcionario.UltimoNome} - {funcionario.CargoId} \n{funcionario.DataEntrada} | {funcionario.EBebedorCafe}");
                System.Console.WriteLine("--------------------------------------------------------");
                System.Console.WriteLine("\n\n");
            }
            System.Console.ReadKey();
            System.Console.Clear();
            #endregion
        }
    }
}
