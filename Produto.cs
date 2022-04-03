using System;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {
            Quantidade = 5;
            // Construtor padrão
        }
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
        public double QuantidadeTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public int AdicionarProduto(int quantidade)
        {
            return Quantidade += quantidade;
        }
        public int RemoverProduto(int quantidade)
        {
            return Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades ,Total: {QuantidadeTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}