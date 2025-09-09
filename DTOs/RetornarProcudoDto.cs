namespace CONTROLE_ESTOQUE_CORE.DTOs
{
    public class RetornarProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Preco { get; set; } = 0;
        public int QuantidadeEmEstoque { get; set; } = 0;
        public DateTime DataCadstro { get; set; }

    }
}
