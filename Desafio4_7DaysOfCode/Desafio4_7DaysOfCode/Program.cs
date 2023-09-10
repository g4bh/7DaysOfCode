namespace Desafio4_7DaysOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filaPedidos  = new FilaPedidos();

            filaPedidos.CadastrarPedido("Bife a milanesa", 1);
            filaPedidos.CadastrarPedido("Arroz com calabresa", 4);
            filaPedidos.CadastrarPedido("Pizza", 2);
            filaPedidos.CadastrarPedido("Batata assada", 3);
            filaPedidos.CadastrarPedido("Camarão", 5);
            filaPedidos.CadastrarPedido("Bolo", 6);

            filaPedidos.ListarPedido();

            filaPedidos.DeletarPedido();

            filaPedidos.ListarPedido();

            filaPedidos.DeletarPedido();

            filaPedidos.ListarPedido();

            filaPedidos.CadastrarPedido("Café", 3);

            filaPedidos.ListarPedido();

        }
    }
}