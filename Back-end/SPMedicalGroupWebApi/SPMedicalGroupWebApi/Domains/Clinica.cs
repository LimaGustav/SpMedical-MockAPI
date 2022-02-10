using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public short IdClinica { get; set; }

        [MaxLength(18, ErrorMessage = "O nome fantasia deve conter no máximo 55 caracteres")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage ="É necessario informar o CNJP da Clinica")]
        [MaxLength(18, ErrorMessage ="O CNPJ deve conter no máximo 18 caracteres")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "É necessario informar a razão social da Clinica")]
        [MaxLength(18, ErrorMessage = "A razão social deve conter no máximo 200 caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "É necessario informar o endereço da Clinica")]
        public string Endereco { get; set; }

        [MaxLength(15, ErrorMessage = "O telefone deve conter no máximo 15 caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "É necessario informar o email da Clinica")]
        [MaxLength(255, ErrorMessage = "O email deve conter no máximo 255 caracteres")]
        [EmailAddress(ErrorMessage = "Informe um endereço de email valido")]
        public string Email { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
