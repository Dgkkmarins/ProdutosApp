using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.API.Dtos;
using ProdutosApp.Data.Entities;
using ProdutosApp.Data.Repositories;

namespace ProdutosApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
       [HttpPost]
        public IActionResult Post([FromBodyAttribute] ProdutoRequest request)
        {
            var produto = new Produto()
            {
                Nome = request.Nome,
                Descricao = request.descricao,
                Preco = request.preco,
                quantidade = request.quantidade
            };
            //instanciando a classe ProdutoRepository(objeto)
            var produtoRepository = new ProdutoRepository();
            produtoRepository.Adicionar(produto);//enviando o produto para o banco de dados
            //retornando sucesso
            return Ok(new
            {
                mensagem = "produto cadastrado com sucesso"
            });


        }
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }


       [HttpGet]
         public IActionResult GetAll()
        {//instanciando a classe produto repository (objeto)
            var produtoRepository = new ProdutoRepository();

            //COnsultando os produtos no banco de dados e guardar
            //o retorno em uma variavel do tipo lista
            var produtos = produtoRepository.ObterTodos();

            //Copiando os produtos da lista obtida do banco de dados
            //Para uma outra lista do tipo produtoResponse DTO
            var produtosDto=produtos.Select(p =>new ProdutoResponse(
                p.Id,
                p.Nome,
                p.Descricao,
                p.Preco,
                p.quantidade,
                p.Datacadastro
                )).ToList();
            
            
            //retornar ok sucesso
            return Ok(produtosDto);
        
         }
}
}
