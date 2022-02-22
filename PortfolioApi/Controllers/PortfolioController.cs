using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _service;
        public PortfolioController(IPortfolioService service)
        {
            _service = service;
        }

        [HttpGet("Home/{id}")]
        public async Task<IActionResult> GetHomePege(int id)
        {
            try
            {
                var developer = await _service.BuscaPorId(id);
                if (developer == null) return NotFound("Não foram encontrados dados no servidor. Tente novamente!");

                return Ok(developer);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }

        [HttpGet("About/{id}")]
        public async Task<IActionResult> GetAboutPage(int id)
        {
            try
            {
                var developer = await _service.BuscaPorId(id);
                if (developer == null) return NotFound("Não foram encontrados dados no servidor. Tente novamente!");

                return Ok(developer);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }

        [HttpGet("Resume/{id}")]
        public async Task<IActionResult> GetResumePage(int id)
        {
            try
            {
                var developer = await _service.BuscaPorId(id, true, true);
                if (developer == null) return NotFound("Não foram encontrados dados no servidor. Tente novamente!");

                return Ok(developer);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }

        [HttpGet("Contact/{id}")]
        public async Task<IActionResult> GetContactPage(int id)
        {
            try
            {
                var developer = await _service.BuscaPorId(id, false, false);
                if (developer == null) return NotFound("Não foram encontrados dados no servidor. Tente novamente!");

                return Ok(developer);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }

    }
}
