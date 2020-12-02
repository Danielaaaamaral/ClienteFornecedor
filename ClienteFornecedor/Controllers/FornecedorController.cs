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
    public class FornecedorController : ControllerBase
    {

        private IClienteFornecedorRepositorio _repositorio;

        public FornecedorController(IClienteFornecedorRepositorio repositorio)
        {
            this._repositorio = repositorio;

        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<Fornecedor>> Get()
        {
            try
            {
                return await _repositorio.BuscarTodosFornecedores();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Fornecedor> Get(int id)
        {
            try
            {
                return await _repositorio.BuscarFornecedorPorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<Fornecedor> Post([FromBody] Fornecedor fornecedor)
        {
            try
            {
                return await _repositorio.AdicionarFornecedor(fornecedor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<Fornecedor> Put([FromBody] Fornecedor fornecedor)
        {
            try
            {
                return await _repositorio.AtualizarFornecedor(fornecedor);
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
                await _repositorio.DeletarFornecedor(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
