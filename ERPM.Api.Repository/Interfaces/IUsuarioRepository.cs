using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPM.Api.Model;

namespace ERPM.Api.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<Usuario> Obtener(int Id);
    }
}
