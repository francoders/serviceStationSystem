<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.AgregarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="card">
        <div class="card-header bg-dark text-white">
            Ingresar nueva Estacion de servicio
        </div>
        <div class="card-body">
            <!--ID -->
            <div class="form-group">
                <label for="idEstacionNumb" >Id de estacion:</label>
                <asp:TextBox ID="idEstacionNumb" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
             <!--REGION -->
            <div class="form-group">
                <label for="regionDdl">Region</label>
                <asp:DropDownList ID="regionDdl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>


             <!--DIRECCION -->
            <div class="form-group">
                <label for="DireccionTxt">Direccion</label>
                <asp:TextBox ID="DireccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--CAPACIDAD-->
            <div class="form-group">
                <label for="capNumb">Capacidad Maxima:</label>
                <asp:TextBox ID="capNumb" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <!--HORARIOATENCION-->
             <div class="form-group">
                <label for="capNumb">Capacidad Maxima:</label>
                <asp:Calendar runat="server"></asp:Calendar>

            </div>

        
        </div>
        <asp:Button ID="ingresarBtn" runat="server" Text="Ingresar estacion." CssClass="btn btn-dark" OnClick="ingresarBtn_Click" />
        <div>
            <asp:Label ID="alertIngreso" runat="server" CssClass="text-success h1"></asp:Label>
        </div>
      </div>
</asp:Content>
