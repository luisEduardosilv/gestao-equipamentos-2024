using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    internal class TelaChamado
    {

        RepositorioChamado repositorio = new RepositorioChamado();
    }
    public char ApresentarMenu()
    {
        Console.Clear();

        //ExibirTitulo();

        Console.WriteLine();

        Console.WriteLine("1 - Cadastrar Chamados");
        Console.WriteLine("2 - Editar Chamado");
        Console.WriteLine("3 - Excluir Chamado");
        Console.WriteLine("4 - Visualizar Chamados");

        Console.WriteLine("S - Voltar");


        Console.Write("Escolha uma das opções: ");
        char operacaoEscolhida = Console.ReadLine()[0];

        return operacaoEscolhida;
    }

    public void CadastrarChamados()
    {
        //ExibirTitulo();

        Console.WriteLine();

        Console.WriteLine("Cadastrando Chamado...");

        Console.WriteLine();


        //processo de cadastro
        Console.Write("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o numero de Serie do equipamento: ");
        string numeroSerie = Console.ReadLine();

        Console.Write("Digite o nome do fabricante do equipamento: ");
        string fabricante = Console.ReadLine();

        Console.Write("Digite o preço de aquisição do equipamento: R$ ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricação do equipamento: (formato: dd/MM/aaaa): ");
        DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());
        
        Console.WriteLine("Digite o ID do equipamento defeituoso");

        //Chamado equipamento = new Chamado(nome, numeroSerie, fabricante, precoAquisicao, dataFabricacao);

        //repositorio.CadastrarChamado(equipamento);

        Program.ExibirMensagem("O equipamento foi cadastrado com sucesso!", ConsoleColor.Green);
    }
}
