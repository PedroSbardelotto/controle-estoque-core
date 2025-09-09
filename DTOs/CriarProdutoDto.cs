namespace CONTROLE_ESTOQUE_CORE.DTOs
{
    public class CriarProduto
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0;
        public int QuantidadeEmEstoque { get; set; } = 0;

    }
}