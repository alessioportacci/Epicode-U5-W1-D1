<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagamenti.aspx.cs" Inherits="Epicode_U5_W1_D1_2.Pagamenti1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="Repeater1" runat="server" ItemType="Epicode_U5_W1_D1_2.Pagamenti">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <%#Item.Nome %>
                <div>
                    <ul>
                        <li>
                            Somma: <%#Item.Somma  %>
                        </li>
                        <li>
                            Data: <%#Item.Data  %>
                        </li>                        
                    </ul>
                </div>
            </li>

            
            <br />
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>



</asp:Content>
