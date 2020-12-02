using ClienteFornecedor.Contexto;
using ClienteFornecedor.Entidades.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteFornecedor.Repositorio
{
    public class ClienteFornecedorRepositorio : IClienteFornecedorRepositorio, IDisposable
    {
        private ClienteFornecedorContext _contexto = null;
        #region Construtor

        public ClienteFornecedorRepositorio(ClienteFornecedorContext contexto)
        {
            _contexto = contexto;
        }
        #endregion
        #region Cliente
        public async Task<List<Cliente>> BuscarTodosClientes()
        {
            try
            {
                return await _contexto.Cliente.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Cliente> BuscarClientePorId(long Id)
        {
            try
            {
                return await _contexto.Cliente.Where(x => x.IdCliente == Id).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            try
            {
                _contexto.Cliente.Add(cliente);
                await _contexto.SaveChangesAsync();
                return BuscarTodosClientes().Result.Where(x => x.Nome == cliente.Nome).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            try
            {
                _contexto.Cliente.Update(cliente);
                await _contexto.SaveChangesAsync();
                return cliente;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeletarCliente(long id)
        {
            try
            {
                var cliente = BuscarTodosClientes().Result.Where(x => x.IdCliente == id).FirstOrDefault();
                _contexto.Cliente.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
        #region Fornecedor
        public async Task<List<Fornecedor>> BuscarTodosFornecedores()
        {
            try
            {
                return await _contexto.Fornecedor.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Fornecedor> BuscarFornecedorPorId(long Id)
        {
            try
            {
                return await _contexto.Fornecedor.Where(x => x.IdFornecedor == Id).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                _contexto.Fornecedor.Add(fornecedor);
                await _contexto.SaveChangesAsync();
                return BuscarTodosFornecedores().Result.Where(x => x.Nome == fornecedor.Nome).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                _contexto.Fornecedor.Update(fornecedor);
                await _contexto.SaveChangesAsync();
                return fornecedor;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeletarFornecedor(long id)
        {
            try
            {
                var fornecedor = BuscarTodosFornecedores().Result.Where(x => x.IdFornecedor == id).FirstOrDefault();
                _contexto.Fornecedor.Remove(fornecedor);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Itens
        public async Task<List<Itens>> BuscarTodosItens()
        {
            try
            {
                return await _contexto.Itens.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Itens> BuscarItenPorId(long Id)
        {
            try
            {
                return await _contexto.Itens.Where(x => x.IdItens == Id).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Itens> AdicionarItens(Itens itens)
        {
            try
            {
                _contexto.Itens.Add(itens);
                await _contexto.SaveChangesAsync();
                return BuscarTodosItens().Result.Where(x => x.Produto == itens.Produto).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Itens> AtualizarItens(Itens itens)
        {
            try
            {
                _contexto.Itens.Update(itens);
                await _contexto.SaveChangesAsync();
                return itens;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeletarItens(long id)
        {
            try
            {
                var cliente = BuscarTodosItens().Result.Where(x => x.IdItens == id).FirstOrDefault();
                _contexto.Itens.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
        #region Pedido
        public async Task<List<Pedido>> BuscarTodosPedidos()
        {
            try
            {
                return await _contexto.Pedido.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Pedido> BuscarPedidoPorId(long Id)
        {
            try
            {
                return await _contexto.Pedido.Where(x => x.IdPedido == Id).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
    }
}
