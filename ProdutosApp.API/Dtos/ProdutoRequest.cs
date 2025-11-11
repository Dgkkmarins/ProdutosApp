namespace ProdutosApp.API.Dtos
{
    /// <summary>
    /// DTO para entrada de dados de proditos na api
    /// </summary>
    public record ProdutoRequest(
        string Nome,
        string descricao,
        decimal preco,
        int    quantidade
        );
    

}
