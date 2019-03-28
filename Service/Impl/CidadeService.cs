using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class CidadeService
    {
        public Cidade Obter(int codigo)
        {
            using(var db = new ContextoEF())
            {
                return db.Cidade.Find(codigo);
            }
        }

        public List<Cidade> Listar(int codigoUF)
        {
            using (var db = new ContextoEF())
            {
                if (codigoUF > 0)
                    return db.Cidade.Where(c => c.UF.ID == codigoUF).ToList();

                return db.Cidade.ToList();
            }
        }
    }
}
