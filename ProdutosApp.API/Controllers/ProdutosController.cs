using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Data.Repositories;

namespace ProdutosApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
       [HttpGet]
         public IActionResult GetAll()
        {//instanciando a classe produto repository (objeto)
            var produtoRepository = new ProdutoRepository();

            //COnsultando os produtos no banco de dados e guardar
            //o retorno em uma variavel do tipo lista
            var produtos = produtoRepository.ObterTodos();
            
            
            //retornar ok sucesso
            return Ok(produtos);
        
         }
}
}
