using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContextoEF : DbContext, IDisposable
    {
        public ContextoEF()
            :base(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<UF> UF { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
    }
}
