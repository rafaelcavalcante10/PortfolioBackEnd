using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private readonly IResumePageService _service;
        private readonly IExperienceDetailService _detailService;
        public ResumeController(IResumePageService service, IExperienceDetailService detailService)
        {
            _service = service;
            _detailService = detailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var developer = await _service.DadosResumePage(1);
                if (developer == null) return NotFound("Não foram encontrados dados no servidor. Tente novamente!");

                return Ok(developer);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var details = await _detailService.BuscaPorIdExperience(id);
                if (details == null) return NotFound("Não foram encontrados dodos no servidor. Tente novamente!");

                return Ok(details);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                        $"Erro ao tentar acessar a API Linux. Erro: {ex.Message}");
            }
        }
    }
}
