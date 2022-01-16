using ERPM.Api.Model;
using ERPM.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public async Task<Usuario> Obtener(int Id)
        {
            Usuario usuario = new Usuario() { Id = 1, Nombre = "Nombre", ApellidoPaterno = "AP", ApellidoMaterno = "AM" };

            return usuario;
        }
    }
}
