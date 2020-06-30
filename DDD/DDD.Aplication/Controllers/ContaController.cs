using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDD.Domain.Entities;
using DDD.Service.Services;
using DDD.Domain;

namespace DDD.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ContaController : ControllerBase
    {
        private ContaService service = new ContaService();



        [HttpPost("Creditar")]
        public IActionResult Creditar([FromBody] CreditarDto dto)
        {
            try
            {
                var saldoAtual = service.Creditar(dto.id, dto.valor);
        
                return new ObjectResult(saldoAtual);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Debitar")]
        public IActionResult Debitar([FromBody] DebitarDto dto)
        {
            try
            {
                var saldoAtual = service.Debitar(dto.id, dto.valor);

                return new ObjectResult(saldoAtual);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get()); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
         
    }
}