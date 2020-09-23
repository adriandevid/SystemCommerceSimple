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
            return ServiceUser.Login(nome, senha);
        }

        public void Cadastrar(string nome, string senha, string empresa, string Funcao)
        {
            ServiceUser.Cadastrar(nome, senha, empresa, Funcao);
        }

        public void Add(Usuario obj)
        {
            ServiceUser.Add(obj);
        }

        public List<Usuario> GetAll()
        {
            return ServiceUser.GetAll();
        }

        public void Update(Usuario obj)
        {
            ServiceUser.Update(obj);
        }

        public void Remove(Usuario obj)
        {
            ServiceUser.Remove(obj);
        }

        public void SaveChanges()
        {
            ServiceUser.SaveChanges();
        }
    }
}
