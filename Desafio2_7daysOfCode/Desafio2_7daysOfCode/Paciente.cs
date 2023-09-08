using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_7daysOfCode
{
    internal class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Nome_Paciente { get; set; }
        public string Estado_Paciente { get; set; }
        public Paciente ProximoNo { get; set; }

    }
}
