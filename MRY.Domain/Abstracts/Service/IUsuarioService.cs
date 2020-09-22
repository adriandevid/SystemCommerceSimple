using MRY.Domain.Models;

namespace MRY.Domain.Abstracts.Service
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        bool Login(string nome, string senha);
        void Cadastrar(string nome, string senha, string empresa, string Funcao);
    }
}