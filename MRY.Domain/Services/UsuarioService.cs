using System.Collections.Generic;
using MRY.Domain.Abstracts.Repository;
using MRY.Domain.Abstracts.Service;
using MRY.Domain.Models;

namespace MRY.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository UsuarioRepository)
        {
            _usuarioRepository = UsuarioRepository;
        }
        public void Add(Usuario obj)
        {
            _usuarioRepository.Add(obj);
        }

        public List<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }


        public void Remove(Usuario obj)
        {
            _usuarioRepository.Remove(obj);
        }

        public void Update(Usuario obj)
        {
            _usuarioRepository.Update(obj);
        }
        public void Cadastrar(string nome, string senha, string empresa, string Funcao)
        {
            _usuarioRepository.Add(new Usuario {
                Nome = nome,
                Senha = senha,
                EmpresaRelacionada = empresa,
                Funcao = Funcao,
                NivelDeAcesso = { }
            });
        }

        public bool Login(string nome, string senha)
        {
            bool VerificUserState = false;
            List<Usuario> ListUsers = _usuarioRepository.GetAll();
            foreach (Usuario Usuario in ListUsers)
            {
                if(nome == Usuario.Nome && senha == Usuario.Senha)
                {
                    return VerificUserState = true;
                }
            }
            return VerificUserState;
        }

        public void SaveChanges()
        {
           _usuarioRepository.SaveChanges();
        }
    }
}