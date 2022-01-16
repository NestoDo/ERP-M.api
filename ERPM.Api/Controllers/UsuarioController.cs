using ERPM.Api.Model;
using ERPM.Api.Model.Response;
using ERPM.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseCall<Usuario>>> Obtener(int id)
        {
            Usuario usuario = await _usuarioService.Obtener(id);

            ResponseCall<Usuario> response = new ResponseCall<Usuario>()
            {
                response = usuario
            };

            return Ok(response);
        }
    }
}
