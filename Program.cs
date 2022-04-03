using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome:  ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);
            Console.WriteLine(produto.ToString());

            Console.Write("Adicione mais itens ao estoque: ");
            //produto.AdicionarProduto(int.Parse(Console.ReadLine()));
            quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(quantidade);

            Console.WriteLine(produto);

            Console.Write("Remova itens ao estoque: ");
            // produto.RemoverProduto(int.Parse(Console.ReadLine()));
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quantidade);

            Console.WriteLine(produto.ToString());


            Produto produto1 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
            };

            Console.WriteLine(produto1);

            Produto produto2 = new Produto("Computador", 2500);

            Console.WriteLine(produto2);
        }
    }
}