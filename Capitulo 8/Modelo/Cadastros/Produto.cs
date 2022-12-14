﻿using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Cadastros
{
    public class Produto
    {
        [DisplayName("Id")]
        public long? ProdutoId { get; set; }

        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres", MinimumLength = 4)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime DataCadastro { get; set; }

        public string LogotipoMimeType { get; set; }
        public byte[] Logotipo { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }



        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }
        
        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }

    
        public Categoria Categoria { get; set; }
      
        public Fabricante Fabricante { get; set; }
        public bool Destaque { get; set; }
    }
}