using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "É necessario informar o id do usuario")]
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "É necessario informar a data de nascimento")]
        public DateTime DataNascimento { get; set; }
        public string NomePaciente { get; set; }

        [MaxLength(30, ErrorMessage = "O telefone deve conter no máximo 30 caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "É necessario informar o RG")]
        [MaxLength(10, ErrorMessage = "O RG deve conter no máximo 10 caracteres")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "É necessario informar o CPF")]
        [MaxLength(11, ErrorMessage = "O CPF deve conter no máximo 11 caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "É necessario informar o endereço")]
        public string Endereco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
