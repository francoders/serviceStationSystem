<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerEstaciones.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.VerEstaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mt-5">
        <asp:GridView ID="estacionesGrid" runat="server" AutoGenerateColumns="false"
            CssClass="table table-hover" OnRowCommand="estacionesGrid_RowCommand" EmptyDataText="No hay estaciones de servicio registradas">
            <Columns>
                <asp:BoundField HeaderText="Id de estacion" DataField="Id" />
                <asp:BoundField HeaderText="Direccion" DataField="aaaaaaa" />
                <asp:BoundField HeaderText="Region" DataField="asdasd" />
                <asp:BoundField HeaderText="Capacidad" DataField="asd" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button  CssClass="btn btn-danger" ID="Button1" runat="server" Text="Eliminar" CommandName="eliminar" />                      
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
