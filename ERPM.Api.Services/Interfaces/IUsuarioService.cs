using ERPM.Api.Model;
using ERPM.Api.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> Obtener(int id);
        Task<Usuario> Agregar(UsuarioRequest usuario);
        Task<Usuario> Editar(UsuarioRequest usuario, int id);
    }
}
