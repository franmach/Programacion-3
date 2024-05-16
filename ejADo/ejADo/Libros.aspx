<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="ejADo.Libros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        .row {
            margin-bottom: 8px;
        }

        td, th {
            border: 2px solid grey;
            padding: 10px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Libros</h3>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" placeholder="Titulo"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo"
                ErrorMessage="Ingrese un titulo" ForeColor="Red" Display="Dynamic" ValidationGroup="Guardar">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control" placeholder="Descripcion"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion"
                ErrorMessage="Ingrese una descripcion" ForeColor="Red" Display="Dynamic" ValidationGroup="Guardar">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="opcAnio" runat="server" TextMode="Number" CssClass="form-control" placeholder="Año"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAnio" runat="server" ControlToValidate="opcAnio"
                ErrorMessage="Ingrese un documento" ForeColor="Red" Display="Dynamic" ValidationGroup="Guardar">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Autores:" ID="lblAutores" runat="server"> </asp:Label>
            <asp:DropDownList ID="ddlAutores" runat="server">

         </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-dark" Text="Guardar" ValidationGroup="Guardar" OnClick="btnGuardar_Click" />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>

        </div>
    </div>
    <div class="row">
        <div>
            <select id="slcOpciones" runat="server">
                <option value="anio">Año</option>
                <option value="autor">Autor</option>
                <option value="titulo">Titulo</option>
            </select>
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtOpcion" />
            <asp:Button runat="server" Text="Buscar" OnClick="Buscar_Click"></asp:Button>
        </div>
        <div>
        </div>
    </div>

    <h3>Buscar libros</h3>


    <asp:GridView ID="gvLibros" runat="server" Width="100%" BorderWidth="2px" CellSpacing="5"
        DataKeyNames="ID"
        AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="lbl1" runat="server" Text='<%# Bind("ID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Titulo">
                <ItemTemplate>
                    <asp:Label ID="lbl2" runat="server" Text='<%# Bind("titulo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Descripcion">
                <ItemTemplate>
                    <asp:Label ID="lbl3" runat="server" Text='<%# Bind("descripcion")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Año">
                <ItemTemplate>
                    <asp:Label ID="lbl4" runat="server" Text='<%# Bind("anio")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
