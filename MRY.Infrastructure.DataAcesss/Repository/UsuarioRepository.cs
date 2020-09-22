using Microsoft.EntityFrameworkCore;
using MRY.Domain.Abstracts;
using MRY.Domain.Abstracts.Repository;
using MRY.Domain.Models;
using MRY.Infrastructure.DataAcesss.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MRY.Infrastructure.DataAcesss.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioContext _usuariocontext { get; private set; }
        public UsuarioRepository(UsuarioContext usuariocontext)
        {
            _usuariocontext = usuariocontext;
        }
        public List<Usuario> GetAll()
        {
            IQueryable<Usuario> query = _usuariocontext.Usuarios.Include(usuario => usuario.NivelDeAcesso);
            return query.ToList();
        }

        public void Add(Usuario obj)
        {
            _usuariocontext.Add(obj);
        }

        public void Update(Usuario obj)
        {
            _usuariocontext.Update(obj);
        }

        public void Remove(Usuario obj)
        {
            _usuariocontext.Remove(obj);
        }

        public void SaveChanges()
        {
            _usuariocontext.SaveChanges();
        }
    }
}
