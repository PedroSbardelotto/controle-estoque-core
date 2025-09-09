namespace CONTROLE_ESTOQUE_CORE.Models // O namespace agora usa o nome da pasta
{
    public class Produto
    {
        public Produto(string nome, string descricao, decimal preco, int quantidadeEmEstoque)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio.", nameof(nome));
            }

            Id = Guid.NewGuid();
            DataCadastro = DateTime.UtcNow;
            Ativo = true;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}