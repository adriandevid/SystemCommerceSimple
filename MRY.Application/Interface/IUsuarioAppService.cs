using MRY.Domain.Models;

namespace MRY.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        bool Login(string nome, string senha);
        void Cadastrar(string nome, string senha, string empresa, string Funcao);
    }
}