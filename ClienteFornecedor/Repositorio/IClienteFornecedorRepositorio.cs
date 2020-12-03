using ClienteFornecedor.Entidades.classes;
using ClienteFornecedor.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Repositorio
{
    public interface IClienteFornecedorRepositorio 
    {
        #region Cliente
        Task<List<Cliente>> BuscarTodosClientes();
        Task<Cliente> BuscarClientePorId(long Id);
        Task DeletarCliente(long id);
        Task<Cliente> AtualizarCliente(Cliente cliente);
        Task<Cliente> AdicionarCliente(Cliente cliente);
        #endregion
        #region fornecedor
        Task<List<Fornecedor>> BuscarTodosFornecedores();
        Task<Fornecedor> BuscarFornecedorPorId(long Id);
        Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor);
        Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor);
        Task DeletarFornecedor(long id);

        #endregion
        #region itens
        Task<List<Itens>> BuscarTodosItens();
        Task<Itens> BuscarItenPorId(long Id);
        Task<Itens> AdicionarItens(Itens itens);

        Task<Itens> AtualizarItens(Itens itens);

        Task DeletarItens(long id);

        #endregion
        #region pedido
        Task<List<Pedido>> BuscarTodosPedidos();
        Task<Pedido> BuscarPedidoPorId(long Id);
        Task<Pedido> AdicionarPedido(PedidoDto pedidoDto);
        Task<Pedido> AtualizarPedido(PedidoDto pedidoDto,long id);
        Task DeletarPedido(long id);

        #endregion
    }
}
