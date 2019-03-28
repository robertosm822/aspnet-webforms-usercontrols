using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms.Site.Fornecedor
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.Endereco.ShowNumero = !String.IsNullOrEmpty(Request.QueryString["ID"]);
                this.Endereco.ShowCEP = 1 == 1;
            }
        }
    }
}