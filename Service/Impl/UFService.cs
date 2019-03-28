using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class UFService
    {
        public UF Obter(int codigo)
        {
            using (var db = new ContextoEF())
            {
                return db.UF.Find(codigo);
            }
        }

        public List<UF> Listar()
        {
            using(var db = new ContextoEF())
            {
                return db.UF.ToList();
            }
        }
    }
}
