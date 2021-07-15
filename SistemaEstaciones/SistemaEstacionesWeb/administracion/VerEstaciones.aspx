<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerEstaciones.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.VerEstaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="mt-5">
            
            <asp:GridView ID="estacionesGrid" runat="server" AutoGenerateColumns="False"
                CssClass="table table-hover bg-white" OnRowCommand="estacionesGrid_RowCommand" EmptyDataText="No hay estaciones de servicio registradas" CellPadding="4" ForeColor="#333333" GridLines="None">
           
                <AlternatingRowStyle BackColor="White" />
           
                <Columns>
                    <asp:BoundField HeaderText="Id de estacion" DataField="IdEstacionServicio" />
                    <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                    <asp:BoundField HeaderText="Region" DataField="CodRegion" />
                    <asp:BoundField HeaderText="Capacidad" DataField="CapacidadMax" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Eliminar" CommandName="eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
