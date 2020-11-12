using System.Collections.Generic;

namespace supermercado.API.domain.models
{
    public class categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Ilist<Produto> Produtos { get; set; } = new List<Produto>();
    }
}