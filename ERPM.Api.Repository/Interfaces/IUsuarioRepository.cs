using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPM.Api.Model;
using ERPM.Api.Model.Request;

namespace ERPM.Api.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<IEnumerable<Usuario>> Obtener(int Id);
        public Task<Usuario> Agregar(UsuarioRequest usuario);
        public Task<Usuario> Editar(UsuarioRequest usuario, int id);
    }
}
