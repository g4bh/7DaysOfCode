using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_7daysOfCode
{
    internal class ListaDeCompras
    {
        ArrayList itens = new ArrayList();
        ArrayList quantidade = new ArrayList();


        public void AdicionarItem(string nomeItem, int qtddItem)
        {
            itens.Add(nomeItem);
            quantidade.Add(qtddItem);
        }

        public void RemoverItem(string nomeItem) {

            for (int i = 0; i < itens.Count; i++)
            {   
                if (itens.IndexOf(nomeItem) == i)
                {
                    itens.RemoveAt(i);
                    quantidade.RemoveAt(i);
                }
                else {
                    Console.WriteLine("\nNão há nenhum item com esse valor!\n");
                    Console.WriteLine(" ");
                }
                
            }
        }

        public void ListarItens() {

            if (itens.Count == 0)
            {
                Console.WriteLine("Não há itens na lista!\n");
                Console.WriteLine(" ");
            }
            else
            {
                for (int i = 0; i < itens.Count; i++)
                {
                    Console.WriteLine($"\nItem: " + itens[i] + " | Quantidade: " + quantidade[i]);
                    Console.WriteLine(" ");
                }
            }
        }
    }

    
}
