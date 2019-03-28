<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="WebForms.Site.Fornecedor.Cadastrar" %>

<%@ Register Src="~/Site/UserControl/Endereco.ascx" TagPrefix="uc1" TagName="Endereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastrar Fornecedor</h1>

    <p>Campo 1</p>
    <p>Campo 2</p>

    <uc1:Endereco runat="server" ID="Endereco" />

</asp:Content>
