using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class RepositorioChamado
    {
        private Chamado[] equipamentos = new Chamado[100];

        public void CadastrarChamado(Chamado novoChamado)
        {
            novoChamado.Id = GeradorId.GerarIdChamado();

            RegistrarItem(novoChamado);
        }

        public bool EditarChamado(int id, Chamado novoChamado)
        {
            novoChamado.Id = id;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;

                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = novoChamado;

                    return true;
                }
            }

            return false;
        }

        public bool ExcluirChamado(int id)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;

                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = null;
                    return true;
                }
            }

            return false;
        }

        public Chamado[] SelecionarChamados()
        {
            return equipamentos;
        }

        public bool ExisteChamado(int id)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Chamado e = equipamentos[i];

                if (e == null)
                    continue;

                else if (e.Id == id)
                    return true;
            }

            return false;
        }

        private void RegistrarItem(Chamado equipamento)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] != null)
                    continue;

                else
                {
                    equipamentos[i] = equipamento;
                    break;
                }
            }
        }
    }
}