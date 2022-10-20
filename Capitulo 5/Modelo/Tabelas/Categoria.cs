﻿using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Tabelas
{
    public class Categoria
    {
        public long CategoriaId { get; set; }

        [Required]
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}