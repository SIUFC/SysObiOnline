using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SysObiOnline.Data;
using SysObiOnline.Models;
using SysObiOnline.Service;
using System.Net;

namespace SysObiOnline.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly QuestionService _questionservice;
        private readonly AppDbContext _context;

        public QuestionController (QuestionService questionService, AppDbContext context)
        {
            _questionservice = questionService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(Question question)
        {
            try
            {
                await _questionservice.CreateQuestion(question);
                return Ok(new { message = "Questão criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetBynName(string name)
        {
            try
            {
                await _questionservice.GetByName(name);
                return Ok(name);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }

        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{name}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateQuestion(string name, Question question)
        {
            try
            {
                var updated = await _questionservice.UpdateQuestion(name, question);
                return Ok(updated);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao atualizar a questão.");
            }
        }





    }
}
