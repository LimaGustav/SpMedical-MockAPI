using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        public short IdMedico { get; set; }

        [Required(ErrorMessage ="É necessario informar o id do usuario")]
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "É necessario informar o id da clinica")]
        public short? IdClinica { get; set; }

        [Required(ErrorMessage = "É necessario informar o id da especialidade")]
        public byte? IdEspecialidade { get; set; }

        [Required(ErrorMessage = "É necessario informar o CRM do médico")]
        [MaxLength (10, ErrorMessage ="O CRM deve conter no máximo 10 caracteres")]
        public string Crm { get; set; }

        [MaxLength(100, ErrorMessage = "O nome do médico deve conter no máximo 100 caracteres")]
        public string NomeMedico { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
