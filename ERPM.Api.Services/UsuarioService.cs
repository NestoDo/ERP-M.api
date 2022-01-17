﻿using ERPM.Api.Model;
using ERPM.Api.Repository.Interfaces;
using ERPM.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<IEnumerable<Usuario>> Obtener(int id)
        {
            return _usuarioRepository.Obtener(id);
        }

        public Task<Usuario> Agregar(Usuario usuario)
        {
            return _usuarioRepository.Agregar(usuario);
        }

        public Task<Usuario> Editar(Usuario usuario)
        {
            return _usuarioRepository.Editar(usuario);
        }
    }
}
