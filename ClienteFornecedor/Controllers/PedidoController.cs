using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteFornecedor.Entidades.classes;
using ClienteFornecedor.Entidades.ViewModel;
using ClienteFornecedor.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ClienteFornecedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private IClienteFornecedorRepositorio _repositorio;

        public PedidoController(IClienteFornecedorRepositorio repositorio)
        {
            this._repositorio = repositorio;

        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<Pedido>> Get()
        {
            try
            {
                return await _repositorio.BuscarTodosPedidos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Pedido> Get(int id)
        {
            try
            {
                return await _repositorio.BuscarPedidoPorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<Pedido> Post([FromBody] PedidoDto pedido)
        {
            try
            {
                return await _repositorio.AdicionarPedido(pedido);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<Pedido> Put([FromBody] PedidoDto pedido,int id)
        {
            try
            {
                return await _repositorio.AtualizarPedido(pedido,id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                await _repositorio.DeletarPedido(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
