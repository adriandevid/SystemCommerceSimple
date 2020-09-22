
using Autofac;
using MRY.Application;
using MRY.Application.Interface;
using MRY.Domain.Abstracts.Repository;
using MRY.Domain.Abstracts.Service;
using MRY.Domain.Services;
using MRY.Infrastructure.DataAcesss.Context;
using MRY.Infrastructure.DataAcesss.Repository;

namespace MRY.Infrastructure.IOC
{
    public static class IoC
    {
       public static IContainer Configure()
       {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            builder.RegisterType<UsuarioContext>().As<UsuarioContext>();
            builder.RegisterType<UsuarioApplication>().As<IUsuarioAppService>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterType<ProdutoContext>().As<ProdutoContext>();
            builder.RegisterType<ProdutoApplication>().As<IProdutoAppService>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            return builder.Build();
        }

    }
}
/*var container = IoC.Configure();
using (var scope = container.BeginLifetimeScope())
{
   teste unitario de funcionalidades do software
   var app = scope.Resolve<IUsuarioAplication>();
    app.Cadastrar(Nome.Text, senha.Text, Empresa.Text, funcao.Text);
}
*/