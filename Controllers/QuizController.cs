using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SysObiOnline.DTOS;
using SysObiOnline.Service;
using System.Security.Claims;

namespace SysObiOnline.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly QuizService _quizService;

        public QuizController(QuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpPost("submit-answer")]
        [Authorize]
        public async Task<IActionResult> SubmitAnswer([FromBody] AnswerDTO dto)
        {
            try
            {
                var result = await _quizService.SubmitAnswer(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("report")]
        [Authorize]
        public async Task<IActionResult> GetReport()
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var report = await _quizService.GetUserReport(userId);
                return Ok(report);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }

}
