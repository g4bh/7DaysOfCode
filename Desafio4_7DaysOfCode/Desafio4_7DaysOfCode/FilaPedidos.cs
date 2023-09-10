using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4_7DaysOfCode
{
    internal class FilaPedidos
    {
        ArrayList nomePrato = new ArrayList();
        ArrayList numeroMesa = new ArrayList();



        public void CadastrarPedido(string nomeP, int numeroM) {
            nomePrato.Add(nomeP);
            numeroMesa.Add(numeroM);
        }

        public void DeletarPedido () {

            nomePrato.RemoveAt(0);
            numeroMesa.RemoveAt(0);

        }

        public void ListarPedido() {

            if (nomePrato.Count == 0 || numeroMesa.Count == 0)
            {
                Console.WriteLine("Não há pedidos na lista!");
            }
            else {
                Console.WriteLine("PEDIDOS: ");
                for (int i = 0; i < nomePrato.Count; i++) {
                    Console.WriteLine($"Nome do Prato:" + nomePrato[i] + " | Número da mesa: " + numeroMesa[i] );
                }
                Console.WriteLine(" ");
            }
        }
    }
}
