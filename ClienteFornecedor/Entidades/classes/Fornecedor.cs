using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Entidades.classes
{
    public class Fornecedor
    {
        [Key]
        public long IdFornecedor { get; set; }
        public string Nome { get; set; }
        public long Contato { get; set; }
        public string Endereco { get; set; }
    }
}
