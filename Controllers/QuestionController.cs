using Microsoft.AspNetCore.Mvc;

namespace SysObiOnline.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SysObiOnline.Models;
    using SysObiOnline.Service;

    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Administrator")] 
    public class QuestionController : ControllerBase
    {
        private readonly QuestionService _questionService;

        public QuestionController(QuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Question question)
        {
            try
            {
                var created = await _questionService.CreateQuestion(question);
                return Ok(created);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var question = await _questionService.GetByName(name);
                return question != null ? Ok(question) : NotFound("Question not found.");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("update/{name}")]
        public async Task<IActionResult> Update(string name, [FromBody] Question updated)
        {
            try
            {
                var result = await _questionService.UpdateQuestion(name, updated);
                return Ok(result);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }

}
