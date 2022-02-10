using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public byte IdEspecialidade { get; set; }

        [Required(ErrorMessage ="É necessario informar nome da especialidade")]
        [MaxLength(100, ErrorMessage = "O nome da especialidade deve conter no máximo 100 caracteres")]
        public string NomeEspecialidade { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
