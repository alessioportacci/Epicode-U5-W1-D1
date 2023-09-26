<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AggiungiPagamento.aspx.cs" Inherits="Epicode_U5_W1_D1_2.AggiungiPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Inserisci importo:"></asp:Label>
    <asp:TextBox ID="Importo" type="number" runat="server"></asp:TextBox>

    <asp:Label ID="Label2" runat="server" Text="Stipendio:"></asp:Label>
    <asp:CheckBox ID="Stipendio" runat="server" />

    <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi pagamento" OnClick="Aggiungi_Click" />
</asp:Content>
