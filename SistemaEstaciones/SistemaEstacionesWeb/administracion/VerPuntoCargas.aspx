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
                    OnCheckedChanged="tchx_CheckedChanged" Text="Ver todos los tipos de auto" />
            </div>

        <!-- Tabla -->
        <div class="mt-5">
            <asp:GridView ID="pcGrid" runat="server" AutoGenerateColumns="false"
                CssClass="table table-hover bg-white" OnRowCommand="puntosGrid_RowCommand" EmptyDataText="No hay estaciones de servicio registradas">
           
                <Columns>
                    <asp:BoundField HeaderText="Id Punto de Carga" DataField="IdPuntoCarga" />
                    <asp:BoundField HeaderText="Tipo" DataField="TipoTxt" />
                    <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxVehiculos" />
                    <asp:BoundField HeaderText="Fecha de reemplazo" DataField="EstadoSensores" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Eliminar" CommandName="eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

    </div>
</asp:Content>
