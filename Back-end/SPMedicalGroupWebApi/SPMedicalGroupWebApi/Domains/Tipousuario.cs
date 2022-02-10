using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Tipousuario
    {
        public Tipousuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public byte IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "É necessario informar nome do tipo usuario")]
        [MaxLength(18, ErrorMessage = "O nome do tipo de usuário deve conter no máximo 50 caracteres")]
        public string NomeTipoUsuario { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
