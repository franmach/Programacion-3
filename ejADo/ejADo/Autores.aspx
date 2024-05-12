<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Autores.aspx.cs" Inherits="ejADo.Autores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Autores</h1>
<div class="row">
   
    <div>
        <asp:TextBox runat="server" id="txtNyA" Placeholder="Nombre y apellido"/>
        <asp:Button runat="server" Text="Buscar" OnClick="Buscar_Click"></asp:Button>
    </div>
    <div>
        
    </div>
</div>

<asp:GridView ID="gvAutores" runat="server" Width="100%" BorderWidth="2px" CellSpacing="5"
    DataKeyNames="ID"
    AutoGenerateColumns="false"
    >
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:Label ID="lbl1" runat="server" Text='<%# Bind("ID")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Nombre">
            <ItemTemplate>
                <asp:Label ID="lbl2" runat="server" Text='<%# Bind("nombre")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Apellido">
            <ItemTemplate>
                <asp:Label ID="lbl3" runat="server" Text='<%# Bind("apellido")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Fecha de nacimiento">
            <ItemTemplate>
                <asp:Label ID="lbl4" runat="server" Text='<%# Bind("fechaNac")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
