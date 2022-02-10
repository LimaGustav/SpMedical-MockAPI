using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedicalGroupWebApi.Domains
{
    public partial class Consulta
    {
        public long IdConsulta { get; set; }

        [Required(ErrorMessage ="É necessario informar a situação da consulta")]
        public byte? IdSituacao { get; set; }

        [Required(ErrorMessage ="É necessario informar o paciente")]
        public int? IdPaciente { get; set; }

        [Required(ErrorMessage = "É necessario informar o médico")]
        public short? IdMedico { get; set; }

        [Required(ErrorMessage = "É necessario informar a data da consulta")]
        public DateTime DataConsulta { get; set; }

        [MaxLength(300, ErrorMessage = "A descrição da consulta deve conter no máximo 300 caracteres")]
        public string Descricao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
    }
}
