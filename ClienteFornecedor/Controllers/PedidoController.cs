using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteFornecedor.Entidades.classes;
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

    }
}
