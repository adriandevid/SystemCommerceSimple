using System;
using System.Collections.Generic;
using System.Text;

namespace MRY.Domain.Models
{
    public class NivelDeAcesso
    {
        public int NivelDeAcessoId { get; set; }
        public string NomeDeAcesso { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
