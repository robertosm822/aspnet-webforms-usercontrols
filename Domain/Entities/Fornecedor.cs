using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fornecedor : Endereco
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
