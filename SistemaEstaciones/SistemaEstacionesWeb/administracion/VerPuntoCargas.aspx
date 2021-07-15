<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPuntoCargas.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.VerPuntoCargas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
          

            <div>
                <asp:DropDownList ID="tipoDdl" runat="server" Enabled="false"
                    AutoPostBack="true" OnSelectedIndexChanged="tipoDdl_SelectedIndexChange">
                    <asp:ListItem Value="" Selected="True" Text="seleccione"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Electrico"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Dual"></asp:ListItem>
                </asp:DropDownList>

                <asp:checkbox ID="tchx" Checked="true" runat="server" AutoPostBack="true" 
                    OnCheckedChanged="TiposCheckedChanged" Text="Ver todos los tipos de auto" />
            </div>

        <!-- Tabla -->
        <div class="mt-5">
            <asp:GridView ID="pcGrid" runat="server" AutoGenerateColumns="False"
                CssClass="table table-hover bg-white" OnRowCommand="puntosGrid_RowCommand" 
                EmptyDataText="No hay estaciones de servicio registradas" 
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                >
           
                <AlternatingRowStyle BackColor="White" />
           
                <Columns>
                    <asp:BoundField HeaderText="Id Punto de Carga" DataField="IdPuntoCarga" />
                    <asp:BoundField HeaderText="Tipo" DataField="TipoCarga" />
                    <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxVehiculos" />
                    <asp:BoundField HeaderText="Fecha de reemplazo" DataField="FechaReemplazo" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Eliminar" CommandName="eliminar"
                                CommandArgument= '<%# Eval("idPuntoCarga") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-primary" ID="Btn_2" runat="server" Text="Actualizar" CommandName="actualizar"
                                OnClick="actualizarBtn_Click" />
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
