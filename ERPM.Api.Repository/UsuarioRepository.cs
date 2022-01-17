using Dapper;
using ERPM.Api.Model;
using ERPM.Api.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("ERPMApi");
        }

        public async Task<IEnumerable<Usuario>> Obtener(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return (IEnumerable<Usuario>)await db.QueryAsync<Usuario>(
                    "ObtenerUsuario",
                    new { id },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
