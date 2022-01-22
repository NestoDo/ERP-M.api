using ERPM.Api.Model;
using ERPM.Api.Model.Request;
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
            _usuarioService=usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseCall<IEnumerable<Usuario>>>> Obtener([FromQuery] int id)
        {
            IEnumerable<Usuario> usuario = await _usuarioService.Obtener(id);

            ResponseCall<IEnumerable<Usuario>> response = new ResponseCall<IEnumerable<Usuario>>()
            {
                response = usuario
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseCall<Usuario>>> Agregar([FromBody] UsuarioRequest usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            Usuario usuarioResultado = await _usuarioService.Agregar(usuario);

            ResponseCall<Usuario> response = new ResponseCall<Usuario>()
            {
                response = usuarioResultado
            };

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseCall<Usuario>>> Editar([FromBody] UsuarioRequest usuario, int id)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            Usuario usuarioResultado = await _usuarioService.Editar(usuario, id);

            ResponseCall<Usuario> response = new ResponseCall<Usuario>()
            {
                response = usuarioResultado
            };

            return Ok(response);
        }
    }
}
