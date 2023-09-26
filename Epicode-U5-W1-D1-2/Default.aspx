<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epicode_U5_W1_D1_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="Repeater1" runat="server" ItemType="Epicode_U5_W1_D1_2.Dipendenti">
        <HeaderTemplate>
            <a href="AggiuntiUtente.aspx" class="btn btn-primary"> Aggiungi Utente</a>

            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <%#Item.Nome %> <%#Item.Cognome %>
                <div>
                    <ul>
                        <li>
                            Indirizzo: <%#Item.Indirizzo  %>
                        </li>
                        <li>
                            Codice fiscale: <%#Item.CF  %>
                        </li>                        
                        <li>
                            Sposato: <%#Item.Sposato %>
                        </li>                        
                        <li>
                            Figli a carico: <%#Item.FigliACarico  %>
                        </li>                        
                        <li>
                            Mansione: <%#Item.Mansione  %>
                        </li>
                    </ul>
                </div>


                <a href="AggiungiPagamento.aspx?id=<%#Item.PkDipendente %>" class="btn btn-secondary mt-3">Aggiungi pagamento</a>
            </li>

            
            <br />
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>


</asp:Content>
