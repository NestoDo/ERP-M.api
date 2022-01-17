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
        public async Task<ActionResult<ResponseCall<IEnumerable<Usuario>>>> Obtener(int id)
        {
            IEnumerable<Usuario> usuario = await _usuarioService.Obtener(id);

            ResponseCall<IEnumerable<Usuario>> response = new ResponseCall<IEnumerable<Usuario>>()
            {
                response = usuario
            };

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseCall<Usuario>>> Agregar([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            Usuario usuarioCreado = await _usuarioService.Agregar(usuario);

            ResponseCall<Usuario> response = new ResponseCall<Usuario>()
            {
                response = usuarioCreado
            };

            return Ok(response);
        }
    }
}
