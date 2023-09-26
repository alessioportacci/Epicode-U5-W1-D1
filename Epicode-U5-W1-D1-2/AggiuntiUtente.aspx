<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AggiuntiUtente.aspx.cs" Inherits="Epicode_U5_W1_D1_2.AggiuntiUtente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Cognome"></asp:Label>
    <asp:TextBox ID="Cognome" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Indirizzo"></asp:Label>
    <asp:TextBox ID="Indirizzo" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Codice Fiscale"></asp:Label>
    <asp:TextBox ID="CF" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label5" runat="server" Text="Sposato"></asp:Label>
    <asp:CheckBox ID="Sposato" runat="server" />
    <br />

    <asp:Label ID="Label6" runat="server" Text="Figli"></asp:Label>
    <asp:TextBox ID="Figli" type="number" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi utente" OnClick="Aggiungi_Click" />

</asp:Content>
