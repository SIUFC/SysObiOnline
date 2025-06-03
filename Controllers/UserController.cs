using Microsoft.AspNetCore.Mvc;
using SysObiOnline.Data;
using SysObiOnline.DTOS;
using SysObiOnline.Service;

namespace SysObiOnline.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly AppDbContext _context;

        public UserController(UserService userService, AppDbContext context)
        {
            _userService = userService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO dto)
        {
            try
            {
                await _userService.CreateUser(dto);
                return Ok(new { message = "Usuário criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
