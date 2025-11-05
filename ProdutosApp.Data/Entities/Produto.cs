using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Entities
{
    public class Produto
    /// <summary>
    /// modelo de entidades de produtos
    /// <sumary>
    {
        #region Propriedades

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0;
        public int quantidade { get; set; } = 0;
        public DateTime Datacadastro { get; set; } = DateTime.Now;  
        public bool ativo { get; set; } = true;

        #endregion
    }
}
