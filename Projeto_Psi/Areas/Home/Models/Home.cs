using Modelo.Cadastros;
using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Psi.Areas.Home.Models
{
    public class Home
    {
        /*public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual ICollection<Fabricante> Fabricantes { get; set; }*/
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
        public Produto Produto { get; set; }
    }
}