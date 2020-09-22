using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MRY.Domain.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string EmpresaRelacionada { get; set; }
        public string Funcao { get; set; }
        public List<NivelDeAcesso> NivelDeAcesso { get; set; }
    }
}
