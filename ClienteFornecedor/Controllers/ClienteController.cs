using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteFornecedor.Contexto;
using ClienteFornecedor.Entidades.classes;
using ClienteFornecedor.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ClienteFornecedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       
        private IClienteFornecedorRepositorio _repositorio;

        public ClienteController(IClienteFornecedorRepositorio repositorio)
        {
            this._repositorio = repositorio;

        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<Cliente>> Get()
        {
            try
            {
                return await _repositorio.BuscarTodosClientes();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Cliente> Get(int id)
        {
            try
            {
                return await _repositorio.BuscarClientePorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<Cliente> Post([FromBody] Cliente cliente)
        {
            try
            {
                return await _repositorio.AdicionarCliente(cliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<Cliente> Put([FromBody] Cliente cliente)
        {
            try
            {
                return await _repositorio.AtualizarCliente(cliente);
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
                await _repositorio.DeletarCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
