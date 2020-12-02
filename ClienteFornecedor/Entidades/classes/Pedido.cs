using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Entidades.classes
{
    public class Pedido
    {
        [Key]
        public long IdPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Itens Itens { get; set; }
 
    }
}
