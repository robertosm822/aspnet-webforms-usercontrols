using Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms.Site.UserControl
{
    public partial class Endereco : System.Web.UI.UserControl
    {
        //UF / Cidade / Logradouro / Numero / CEP

        //public int CodigoUF {
        //    get { return Convert.ToInt32(ddlUF.SelectedValue); }
        //    set {
        //        CarregarComboUF();
        //        ddlUF.SelectedValue = value.ToString(); 
        //    } 
        //}
        //public int CodigoCidade
        //{
        //    get { return Convert.ToInt32(ddlCidade.SelectedValue); }
        //    set {
        //        CarregarComboCidades(this.CodigoUF);
        //        ddlCidade.SelectedValue = value.ToString(); 
        //    }
        //}

        public int CodigoUF { get; set; }
        public int CodigoCidade { get; set; }
        public string Logradouro {
            get { return txtLogradouro.Text; }
            set { txtLogradouro.Text = value; } 
        }
        public string Numero {
            get { return txtNumero.Text; }
            set { txtNumero.Text = value; }
        }
        public string CEP {
            get { return txtCEP.Text; }
            set { txtCEP.Text = value; }
        }

        public bool ShowCEP { get; set; }
        public bool ShowNumero { get; set; }

        private ListItem Selecione = new ListItem("-Selecione-", "0");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CarregarComponentes();

                if (CodigoUF > 0)
                {
                    this.ddlUF.SelectedValue = CodigoUF.ToString();
                    CarregarComboCidades(CodigoUF);
                }
                if (CodigoCidade > 0)
                    this.ddlCidade.SelectedValue = CodigoCidade.ToString();
            }
        }

        public void CarregarComponentes()
        {
            CarregarComboUF();
            CarregarComboCidades(0);

            divNumero.Visible = ShowNumero;
            divCEP.Visible = ShowCEP;
        }

        private void CarregarComboUF()
        {
            var srv = new UFService();
            ddlUF.DataSource = srv.Listar();
            ddlUF.DataTextField = "Nome";
            ddlUF.DataValueField = "ID";
            ddlUF.DataBind();

            ddlUF.Items.Insert(0, Selecione);
        }

        private void CarregarComboCidades(int codigoUF)
        {
            if (codigoUF > 0)
            {
                var srv = new CidadeService();
                ddlCidade.DataSource = srv.Listar(codigoUF);
                ddlCidade.DataTextField = "Nome";
                ddlCidade.DataValueField = "ID";
                ddlCidade.DataBind();
            }
            ddlCidade.Items.Insert(0, Selecione);
        }

        protected void ddlUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboCidades(Convert.ToInt32(ddlUF.SelectedValue));
        }
    }
}