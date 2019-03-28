<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Endereco.ascx.cs" Inherits="WebForms.Site.UserControl.Endereco" %>

    <div class="form-group col-xs-6">
        <asp:Label id="lblUF" runat="server" Text="UF:"></asp:Label>
        <asp:DropDownList ID="ddlUF" CssClass="form-control" runat="server"
            OnSelectedIndexChanged="ddlUF_SelectedIndexChanged" AutoPostBack="true"
            ></asp:DropDownList>
    </div>
    <div class="form-group col-xs-6">
        <asp:Label id="lblCidade" runat="server" Text="Cidade:"></asp:Label>
        <asp:DropDownList ID="ddlCidade" CssClass="form-control" runat="server"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Label id="lblLogradouro" runat="server" Text="Logradouro:"></asp:Label>
        <asp:TextBox ID="txtLogradouro" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group" id="divNumero" runat="server">
        <asp:Label id="lblNumero" runat="server" Text="Número:"></asp:Label>
        <asp:TextBox ID="txtNumero" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group" id="divCEP" runat="server">
        <asp:Label id="lblCEP" runat="server" Text="CEP:"></asp:Label>
        <asp:TextBox ID="txtCEP" CssClass="form-control" runat="server"></asp:TextBox>
    </div>