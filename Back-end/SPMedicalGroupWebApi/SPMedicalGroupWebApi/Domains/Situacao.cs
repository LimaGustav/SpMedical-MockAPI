using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consulta>();
        }

        public byte IdSituacao { get; set; }

        [Required(ErrorMessage = "É necessario informar nome da situação")]
        [MaxLength(40, ErrorMessage = "O nome da situação deve conter no máximo 40 caracteres")]
        public string NomeSituacao { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
