using MRY.Application.Interface;
using MRY.Domain.Abstracts.Service;
using MRY.Domain.Models;
using System;
using System.Collections.Generic;

namespace MRY.Application
{
    public class UsuarioApplication : IUsuarioAppService
    {
        public IUsuarioService ServiceUser { get; set; }

        public UsuarioApplication(IUsuarioService _serviceUser)
        {
            ServiceUser = _serviceUser;
        }

        public bool Login(string nome, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(string nome, string senha, string empresa, string Funcao)
        {
            throw new NotImplementedException();
        }

        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
