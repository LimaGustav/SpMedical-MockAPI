﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroupWebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "É necessario informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessario informar a senha")]
        [MinLength(8, ErrorMessage = "A senha precisa conter de 8 a 25 caracteres")]
        [MaxLength(25, ErrorMessage = "A senha precisa conter de 8 a 25 caracteres")]
        public string Senha { get; set; }
    }
}
