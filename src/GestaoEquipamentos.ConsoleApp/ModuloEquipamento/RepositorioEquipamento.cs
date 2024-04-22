using GestaoEquipamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class RepositorioEquipamento
    {
        Equipamento[] equipamentos = new Equipamento[100];


        public void CadastrarEquipamento(Equipamento novoEquipamento)
        {
            novoEquipamento.Id = GeradorId.GerarIdEquipamento();

            RegistrarItem(novoEquipamento);
        }

        public bool EditarEquipamento(int id, Equipamento novoEquipamento)
        {
            novoEquipamento.Id = id;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;
                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = novoEquipamento;

                    return true;
                }
            }

            return false;
        }

        public bool ExcluirEquipamento(int id)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                {
                    continue;
                }
                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = null;
                    return true;
                }
            }
            return false;

        }

        public Equipamento[] SelecionarEquipamento()
        {
            Equipamento[] equipamentosExistentes = new Equipamento[100];

            int contadorElementosExistentes = 0;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;
                else
                {
                    equipamentosExistentes[i] = equipamentos[i];
                    contadorElementosExistentes++;
                }
            }

            return equipamentos;
        }

        private void RegistrarItem(Equipamento equipamento)
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

        public bool ExisteEquipamento(int idEquipamento)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;

                else if (e.Id == idEquipamento)
                    return true;
            }

            return false;
        }
    }
}

