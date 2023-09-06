namespace Desafio1_7daysOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDeCompras listinha = new ListaDeCompras();
            int opcao;

            Console.WriteLine("\r\n▀▀ ▀▀ ▀▀ ▀▀ ▀▀   █░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▀▀ █▀█ █▀▄▀█ █▀█ █▀█ ▄▀█ █▀   ▀▀ ▀▀ ▀▀ ▀▀ ▀▀\r\n▀▀ ▀▀ ▀▀ ▀▀ ▀▀   █▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▄▄ █▄█ █░▀░█ █▀▀ █▀▄ █▀█ ▄█   ▀▀ ▀▀ ▀▀ ▀▀ ▀▀");
            Console.WriteLine(" ");

            do
            {
                Console.WriteLine("O que deseja fazer agora?\n\n1 - Adicionar um item na lista \n2 - Excluir um item na lista \n3- Mostrar a lista \n4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do item: ");
                        string nomeItem = Console.ReadLine();
                        Console.Write("Adicione uma quantidade: ");
                        int qttdItem = int.Parse(Console.ReadLine());
                        listinha.AdicionarItem(nomeItem, qttdItem);
                        Console.Write("\nItem adicionado com sucesso!\n");
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        Console.Write("Digite o nome do produto que deseja excluir: ");
                        nomeItem = Console.ReadLine();
                        listinha.RemoverItem(nomeItem);
                        Console.Write("\nItem excluído com sucesso!\n");
                        break;

                    case 3:
                        listinha.ListarItens();
                        break;
                    
                    case 4:
                        break;
                }
            } while (opcao != 4);
        }
    }
}