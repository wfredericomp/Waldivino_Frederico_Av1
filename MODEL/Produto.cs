using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
    }
}
