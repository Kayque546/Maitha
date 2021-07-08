using Dominio;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtorepositorio)
        {
            _produtoRepositorio = produtorepositorio;
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id?}")]
        public async Task<IActionResult > Get(int id = 0)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(_produtoRepositorio.ObterPorId((int)id));
                }
                else
                {
                    return Ok(_produtoRepositorio.ObterPorTodos());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
        {
            try
            {
                if (id != produto.Id) return BadRequest("O Id é diferente do Id do cliente! Por favor insira um Id válido!");
                _produtoRepositorio.Atualizar(produto);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] Produto produto)
        {
            try
            {
                _produtoRepositorio.Deletar(produto);
                return Ok("Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
