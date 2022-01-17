using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Model.Request
{
    public class UsuarioRequest
    {
        public string Nombre { get; set; } = String.Empty;
        public string ApellidoPaterno { get; set; } = String.Empty;
        public string ApellidoMaterno { get; set; } = String.Empty;
    }
}
