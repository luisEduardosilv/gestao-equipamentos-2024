using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class TelaEquipamento
    {
        RepositorioEquipamento repositorio = new RepositorioEquipamento();

        public char ApresentarMenu()
        {
            Console.Clear();

            //ExibirTitulo();

            Console.WriteLine();

            Console.WriteLine("1 - Cadastrar Equipamentos");
            Console.WriteLine("2 - Editar Equipamento");
            Console.WriteLine("3 - Excluir Equipamento");
            Console.WriteLine("4 - Visualizar Equipamentos");

            Console.WriteLine("S - Voltar");


            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Console.ReadLine()[0];

            return operacaoEscolhida;
        }

        public void CadastrarEquipamentos()
        {
            //ExibirTitulo();

            Console.WriteLine();

            Console.WriteLine("Cadastrando Equipamento...");

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

            Equipamento equipamento = new Equipamento(nome, numeroSerie, fabricante, precoAquisicao, dataFabricacao);

            repositorio.CadastrarEquipamento(equipamento);

            Program.ExibirMensagem("O equipamento foi cadastrado com sucesso!", ConsoleColor.Green);
        }

        public void EditarEquipamento()
        {
            //ExibirTitulo();

            Console.WriteLine();

            Console.WriteLine("Editando Equipamento...");

            Console.WriteLine();

            //saber qual equipamento Editar
            VisualizarEquipamentos(false);

            Console.Write("Digite o ID do equipamento que deseja editar: ");
            int idEquipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteEquipamento(idEquipamentoEscolhido))
            {
                Program.ExibirMensagem("O equipamento mencionado nao existe;", ConsoleColor.Green);
                Console.WriteLine("O equipamento mencionado nao existe;");
                return;
            }

            Console.WriteLine();

            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o numero de Serie do equipamento: ");
            string numeroSerie = Console.ReadLine();

            Console.Write("Digite o nome do fabricante do equipamento: ");
            string fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do equipamento: R$ ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento: (formato: dd-MM-aaaa): ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, numeroSerie, fabricante, precoAquisicao, dataFabricacao);

            bool conseguiEditar = repositorio.EditarEquipamento(idEquipamentoEscolhido, novoEquipamento);

            if (!conseguiEditar)
            {
                Program.ExibirMensagem("Houve um erro durante a edição do equipamento!", ConsoleColor.Red);
                return;
            }

            Program.ExibirMensagem("O equipamento foi editado com sucesso!", ConsoleColor.Green);
        }

        public void ExcluirEquipamento()
        {
            //ExibirTitulo();

            Console.WriteLine();

            Console.WriteLine("Excluindo Equipamento...");

            Console.WriteLine();

            //saber qual equipamento Excluir
            VisualizarEquipamentos(false);

            Console.Write("Digite o ID do equipamento que deseja excluir: ");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteEquipamento(equipamentoEscolhido))
            {

                Program.ExibirMensagem("O equipamento mencionado nao existe;", ConsoleColor.Green);
                Console.WriteLine("O equipamento mencionado nao existe;");
                return;
            }

            bool conseguiExcluir = repositorio.ExcluirEquipamento(equipamentoEscolhido);

            if (!conseguiExcluir)
            {
                Program.ExibirMensagem("Houve um erro durante a exclusão do equipamento!", ConsoleColor.Red);
                return;
            }

            Program.ExibirMensagem("O equipamento foi excluido com sucesso!", ConsoleColor.Green);
        }

        public void VisualizarEquipamentos(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                //ExibirTitulo();

                Console.WriteLine();

                Console.WriteLine("Visualizando Equipamentos...");
            }
            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -10} | {4, -10}",
                "Id", "Nome", "Fabricante", "Preço", "Data de Fabricação"
                );

            Equipamento[] equipamentosCadastrados = repositorio.SelecionarEquipamento();

            for (int i = 0; i < equipamentosCadastrados.Length; i++)
            {
                Equipamento e = equipamentosCadastrados[i];

                if (e == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -15} | {3, -10} | {4, -10}",
                    e.Id, e.Nome, e.Fabricante, e.PrecoAquisicao, e.DataFabricacao.ToShortDateString()
                    );
            }
            Console.ReadLine();

        }

    }
}
