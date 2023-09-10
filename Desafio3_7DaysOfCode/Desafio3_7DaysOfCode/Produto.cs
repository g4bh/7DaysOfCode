using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_7DaysOfCode
{
    internal class Produto
    {
        public string nomeP { get; set;}
        public double codigoBarra { get; set; }
        public float precoP { get; set; }
        public int quantidadeP { get; set; }
        public Produto NoAnterior { get; set; }
        public Produto NoPosterior { get; set; }

    }
}
