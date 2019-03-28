using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cidade
    {
        public int ID { get; set; }
        public virtual UF UF { get; set; }
        public string Nome { get; set; }

        public Cidade(UF uf)
        {
            this.UF = uf;
        }

        public Cidade()
        {

        }
    }
}
