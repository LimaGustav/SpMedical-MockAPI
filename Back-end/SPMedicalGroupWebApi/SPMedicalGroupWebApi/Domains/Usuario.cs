using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Fotoperfils = new HashSet<Fotoperfil>();
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage ="É necessario informar o tipo de usuario")]
        [Range(1,3,ErrorMessage ="TipoUsuario invalido.")]
        public byte? IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "É necessario informar o email")]
        [EmailAddress(ErrorMessage = "Informe um endereço de email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessario informar a senha")]
        [MinLength(8, ErrorMessage = "A senha precisa conter de 8 a 25 caracteres")]
        [MaxLength(25, ErrorMessage = "A senha precisa conter de 8 a 25 caracteres")]
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Fotoperfil> Fotoperfils { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
