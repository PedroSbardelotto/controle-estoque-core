// 1. Importamos o namespace dos nossos Models para que o teste saiba o que é um "Produto".
using CONTROLE_ESTOQUE_CORE.Models;

namespace CONTROLE_ESTOQUE_CORE.Tests
{
    public class ProdutoTests
    {
        // 2. [Fact] marca este método como um teste que o xUnit deve executar.
        [Fact]
        public void Construtor_DeveLancarExcecao_QuandoNomeForVazio()
        {
            // 3. Arrange (Arrumar): Preparamos os dados de entrada inválidos.
            var nomeVazio = "";
            var descricaoQualquer = "Descrição de teste";
            var precoQualquer = 10m; // o 'm' no final indica que é um número do tipo 'decimal'
            var quantidadeQualquer = 5;

            // 4. Act (Agir) & Assert (Afirmar): Executamos a ação e verificamos o resultado.
            //    Afirmamos (Assert) que a ação de criar um 'new Produto' com nome vazio
            //    DEVE lançar (Throws) um erro do tipo 'ArgumentException'.
            Assert.Throws<ArgumentException>(() => 
            {
                new Produto(nomeVazio, descricaoQualquer, precoQualquer, quantidadeQualquer);
            });
        }
    }
}