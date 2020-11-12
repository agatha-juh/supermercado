namespace supermercado.API.domain.models
{
    public class Produto
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public short QuantidadedePacote { get; set; }
        public EUnidadeMedida UnidadeMedida { get; set; }
        public int CategoriaId{ get; set; }
        public categoria categoria { get; set; }  
    }
}