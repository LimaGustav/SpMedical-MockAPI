using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Fotoperfil
    {
        public int IdFotoPerfil { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeArquivo { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
