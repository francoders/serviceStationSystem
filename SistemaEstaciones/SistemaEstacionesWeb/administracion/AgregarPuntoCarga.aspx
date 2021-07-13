<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPuntoCarga.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.AgregarPuntoCarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="card">
            <div class="card-header bg-light text-dark">
                Agregar Punto Carga
            </div>
            <div class="card-body">
                <!-- ID PUNTO DE CARGA-->
                 <div class="form-group">
                    <label for="idPc">Id del Punto de Carga:</label>
                    <asp:TextBox ID="idPc" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!-- Tipo ELECTRICO/DUAL -->
                <div class="form-group">
                <label for="tipoRbl">Tipo:</label>
                    <asp:RadioButtonList ID="tipoRbl" runat="server" CssClass="form-control">
                    <asp:ListItem Value="1" Text="Dual"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Electrico"></asp:ListItem>
                </asp:RadioButtonList>
                </div>
                <!-- VIDA UTIL -->
                <div class="form-group">
                    <label for="fecha_pc">fecha de reemplazo:</label>
                    <asp:Calendar runat="server"></asp:Calendar>
                </div>
                <!-- Capacidad Punto de carga -->
                <div class="form-group">
                    <label for="capMax">Capacidad maxima de vehiculos:</label>
                    <asp:TextBox ID="capMax" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            
            <asp:Button ID="ingresarPuntoBtn" runat="server" Text="Ingresar estacion." CssClass="btn btn-dark" OnClick="ingresarPuntoBtn_Click" />

        </div>
    </div>




</asp:Content>
