using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.DAL
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco {get; set;}
        public string Telefone { get; set; }
        
    }
}
