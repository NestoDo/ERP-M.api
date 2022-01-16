using ERPM.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> Obtener(int id);
    }
}
