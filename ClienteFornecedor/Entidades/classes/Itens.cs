using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Entidades.classes
{
    public class Itens
    {
        [Key]
        public long IdItens { get; set; }
        public string Produto { get; set; }
        public int Qtd { get; set; }
        public decimal Valor { get; set; }
    }
}
