using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Projeto_Psi.Areas.Seguranca.Models;
using Projeto_Psi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Psi.Infraestrutura
{
    public class GerenciadorPapel : RoleManager<Papel>, IDisposable
    {
        public GerenciadorPapel(RoleStore<Papel> store) : base(store)
        {
        }
        public static GerenciadorPapel Create(IdentityFactoryOptions<GerenciadorPapel> options, IOwinContext context)
        {
            return new GerenciadorPapel(new RoleStore<Papel>(context.Get<IdentityDbContextAplicacao>()));
        }
    }
}