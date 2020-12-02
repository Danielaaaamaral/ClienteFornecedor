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
    public class ItensController : Controller
    {

        private IClienteFornecedorRepositorio _repositorio;

        public ItensController(IClienteFornecedorRepositorio repositorio)
        {
            this._repositorio = repositorio;

        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<Itens>> Get()
        {
            try
            {
                return await _repositorio.BuscarTodosItens();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Itens> Get(int id)
        {
            try
            {
                return await _repositorio.BuscarItenPorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<Itens> Post([FromBody] Itens itens)
        {
            try
            {
                return await _repositorio.AdicionarItens(itens);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<Itens> Put([FromBody] Itens itens)
        {
            try
            {
                return await _repositorio.AtualizarItens(itens);
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
                await _repositorio.DeletarItens(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
