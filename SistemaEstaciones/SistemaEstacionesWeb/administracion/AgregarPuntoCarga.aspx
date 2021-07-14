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

                <!-- Capacidad Punto de carga -->
                <div class="form-group">
                    <label for="capMax">Capacidad maxima de vehiculos:</label>
                    <asp:TextBox ID="capMax" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <!-- VIDA UTIL -->
                <div class="form-group">
                    <label for="fecha_pc">fecha de reemplazo:</label>
                    <asp:TextBox ID="TextBoxRecibeFecha" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButtonCalendario" runat="server" Width="28px" Height="24px" ImageUrl="~/img/calendario.png" OnClick="ImageButtonCalendario_Click" />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" TitleFormat="Month" Width="400px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                        <DayStyle Width="14%" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                        <TodayDayStyle BackColor="#CCCC99" />
                    </asp:Calendar>
                </div>

            </div>
            <asp:Button ID="ingresarPuntoBtn" runat="server" Text="Ingresar estacion." CssClass="btn btn-dark" OnClick="ingresarPuntoBtn_Click" />
            <asp:Label ID="alertRegistroPuntos" runat="server" CssClass="text-success h3"></asp:Label>
        </div>
    </div>




</asp:Content>
