using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_7daysOfCode
{
    internal class ListaPaciente
    {
        public Paciente head { get; set; }

        //Create
        public void CadastrarPaciente(Paciente novoPaciente) {
            if (head == null)
            {
                head = novoPaciente;
            }
            else {
                var ultimoPaciente = PegarUltimoPaciente();
                ultimoPaciente.ProximoNo = novoPaciente;
            }

        }
        public Paciente PegarUltimoPaciente() {
            var pacienteTemp = head;

            while (pacienteTemp.ProximoNo != null) { 
                pacienteTemp = pacienteTemp.ProximoNo;
            }
            return pacienteTemp;
        }


        //Read
        public void MostrarPaciente() {
            var pacienteTemporario = head;

            if (head == null)
            {
                Console.WriteLine("Não há pacientes na lista");
            }
            else
            {
                Console.WriteLine("Mostrando todos os pacientes do hospital:");
                while (pacienteTemporario != null)
                {
                    Console.WriteLine($"ID - {pacienteTemporario.Id_Paciente} | Nome do paciente - {pacienteTemporario.Nome_Paciente} | Estado do paciente - {pacienteTemporario.Estado_Paciente}");
                    pacienteTemporario = pacienteTemporario.ProximoNo;
                }
                Console.WriteLine(" ");
            }
          

            

        }


        //Update
        public void AtualizarPaciente(Paciente paciente) {
            var pacienteTemp = head;

            while( pacienteTemp != null)
            {
                if (pacienteTemp.Id_Paciente == paciente.Id_Paciente) {
                    pacienteTemp.Nome_Paciente = paciente.Nome_Paciente;
                    pacienteTemp.Estado_Paciente = paciente.Estado_Paciente;
                    return;
                }

                pacienteTemp = pacienteTemp.ProximoNo;
            }
        }


        //Delete
        public void DeletarPaciente(int Id) {
            var pacientTemp = head;

            if (head.Id_Paciente == Id)
            {
                head = head.ProximoNo;
            }
            else {
                while(pacientTemp != null)
                {
                    if(Id == pacientTemp.ProximoNo.Id_Paciente)
                    {
                        pacientTemp.ProximoNo = pacientTemp.ProximoNo.ProximoNo;
                        return;
                    }
                    pacientTemp = pacientTemp.ProximoNo;
                }
            }
        }
    }
}
