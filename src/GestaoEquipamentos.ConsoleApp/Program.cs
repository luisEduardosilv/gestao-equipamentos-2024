using GestaoEquipamentos.ConsoleApp.ModuloChamado;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;
using System.ComponentModel.Design;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamado telaChamado = new TelaChamado();
            
            bool opcaoSairEscolhida = false;
            
            while (!opcaoSairEscolhida)
            {
                Console.Clear();

                ExibirTitulo();

                Console.WriteLine();

                Console.WriteLine("1 - Gerência de Equipamentos");
                Console.WriteLine("2 - Controle de Chamados [não disponivel]");
                Console.WriteLine("S - Sair");

                Console.WriteLine();

                Console.WriteLine("Escolha uma das opções: ");
                char opcaoEscolhida = Console.ReadLine()[0];
                char operacaoEscolhida;

                switch (opcaoEscolhida)
                {
                    case '1':
                        operacaoEscolhida = telaEquipamento.ApresentarMenu();

                        if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                            break;

                        if (operacaoEscolhida == '1')
                            telaEquipamento.CadastrarEquipamentos();

                        else if (operacaoEscolhida == '2')
                            telaEquipamento.EditarEquipamento();


                        else if (operacaoEscolhida == '3')
                            telaEquipamento.ExcluirEquipamento();
                          

                        else if (operacaoEscolhida == '4')
                            telaEquipamento.VisualizarEquipamentos(true);
                        break;
                    case '2':
                        operacaoEscolhida = telaChamado.ApresentarMenu();

                        if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                            break;

                        if (operacaoEscolhida == '1')
                            telaEquipamento.CadastrarEquipamentos();

                        else if (operacaoEscolhida == '2')
                            telaEquipamento.EditarEquipamento();


                        else if (operacaoEscolhida == '3')
                            telaEquipamento.ExcluirEquipamento();


                        else if (operacaoEscolhida == '4')
                            telaEquipamento.VisualizarEquipamentos(true);
                        break;

                        break;
                    default:
                        opcaoSairEscolhida = true;
                        break;
                }
            }
            Console.ReadLine();
        }

        #region Exibe Titulo
        private static void ExibirTitulo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("| Gestão de Equipamentos |");
            Console.WriteLine("--------------------------\n");
        }
        #endregion



        public static void ExibirMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;

            Console.WriteLine();

            Console.WriteLine(mensagem);

            Console.ResetColor();
        }
    }
}
