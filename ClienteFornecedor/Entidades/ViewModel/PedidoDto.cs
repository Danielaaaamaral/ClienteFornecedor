using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Entidades.ViewModel
{
    public class PedidoDto
    {
        public long IdCliente { get; set; }
        public long IdFornecedor { get; set; }
        public List<long> ListItens { get; set; }

    }
}
