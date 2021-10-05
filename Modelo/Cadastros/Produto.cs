using Modelo.Tabelas;
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

        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 2 caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime? DataCadastro { get; set; }

        
        [DisplayName("Preço (R$)")]
        [Required(ErrorMessage = "Informe o preço do produto")]
        public double Preco { get; set; }

        [DisplayName("Lançamento")]
        public bool Lancamento { get; set; }

        [DisplayName("Percentual de Desconto (%)")]
        public long? PercentualDesconto { get; set; }

        public string LogotipoMimeType { get; set; }

        public byte[] Logotipo { get; set; }

        public string NomeArquivo { get; set; }

        public long TamanhoArquivo { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Informe a categoria do produto")]
        public long? CategoriaId { get; set; }

        [DisplayName("Fabricante")]
        [Required(ErrorMessage = "Informe o fabricante do produto")]
        public long? FabricanteId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}