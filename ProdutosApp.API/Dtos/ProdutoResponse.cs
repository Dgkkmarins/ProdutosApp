namespace ProdutosApp.API.Dtos
{
    /// <summary>
    /// Dto para saida de dados de produtos na API
    /// </summary>
    public record ProdutoResponse(
        Guid    Id,
        string  Nome,
        string  descricao,
        decimal preco,
        int     quantidade,
        DateTime DataCadastro
        );
    
    
}
