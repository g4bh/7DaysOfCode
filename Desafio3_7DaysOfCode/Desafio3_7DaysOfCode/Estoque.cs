using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_7DaysOfCode
{
    internal class Estoque
    {
        public Produto head { get; set; }
        public Produto tail { get; set; }


        //Create 
        public void CadastrarProduto(Produto novoProduto) { 
            if (head == null)
            {
                head = novoProduto;
                tail = novoProduto;
            }
            else
            {
                tail.NoPosterior = novoProduto;
                novoProduto.NoAnterior = tail;
                tail = novoProduto;
            }
        }


        //Read
        public void MostrarProdutos()
        {
            if (head == null)
            {
                Console.WriteLine("Não há produtos no estoque!");
            }
            else
            {
                var produto_atual = head;

                Console.WriteLine("Produtos do estoque: ");
                Console.WriteLine(" ");
                while (produto_atual != null)
                {
                    Console.WriteLine($"Código de barras - {produto_atual.codigoBarra} | Nome - {produto_atual.nomeP} | Preço - {produto_atual.precoP} | Quantidade - {produto_atual.quantidadeP}");
                    produto_atual = produto_atual.NoPosterior;
                }
                Console.WriteLine(" ");
            }
        }


        //Update
        public void AtualizarQuantidade(double codBarra, int novaQtt)
        {
            var produto_atual = head;

            while (produto_atual != null)
            {
                if (produto_atual.codigoBarra == codBarra)
                {
                    produto_atual.quantidadeP = novaQtt;
                    return;
                }
                produto_atual = produto_atual.NoPosterior;
            }
        }


        //Delete
        public void DeletarProduto(double codBarra) {
            if (head == null)
            {
                return;
            }
            else if (head.codigoBarra == codBarra)
            {
                head = head.NoPosterior;
                if (head != null)
                {
                    head.NoAnterior = null;
                }
                else
                {
                    tail = null;
                }
                return;
            }
            else if (tail.codigoBarra == codBarra)
            {
                tail = tail.NoAnterior;
                tail.NoPosterior = null;
                return;
            }
            else {
                var produto_atual = head;

                while (produto_atual != null)
                {
                    if (produto_atual.codigoBarra == codBarra) {
                        produto_atual.NoAnterior.NoPosterior = produto_atual.NoPosterior;
                        produto_atual.NoPosterior.NoAnterior = produto_atual.NoAnterior;
                        return;
                    }
                    produto_atual = produto_atual.NoPosterior;
                }
            }

        }


        


        
    }
}
