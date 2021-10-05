﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Cadastros
{
    public class Fabricante
    {
        [DisplayName("Id")]
        public long? FabricanteId { get; set; }

        [StringLength(100, ErrorMessage = "O nome do fabricante precisa ter no mínimo 2 caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Informe o nome do fabricante")]
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}