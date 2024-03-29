﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.AgregarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="container pt-5">
        <div class="card">
            <div class="card-header bg-info text-dark text-center">
                Agregar Estacion de servicio
            </div>
            <div class="card-body m-3">
                <!--ID -->
                <div class="form-group">
                    <label for="idEstacionNumb">Id de estacion</label>
                    <asp:TextBox ID="idEstacionNumb" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_1" runat="server" 
                        ErrorMessage="Debe Ingresar un ID" CssClass="text-danger" ControlToValidate="idEstacionNumb">

                    </asp:RequiredFieldValidator>
                </div>

                <!--DIRECCION -->
                <div class="form-group">
                    <label for="DireccionTxt">Direccion</label>
                    <asp:TextBox ID="DireccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_2" runat="server" 
                        ErrorMessage="Debe Ingresar una direccion" CssClass="text-danger" ControlToValidate="DireccionTxt">

                    </asp:RequiredFieldValidator>
                </div>

                <!--REGION -->
                <div class="form-group">
                    <label for="regionDdl">Region</label>
                    <asp:DropDownList ID="regionDdl" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <!--CAPACIDAD-->
                <div class="form-group">
                    <label for="capNumb">Capacidad Maxima</label>
                    <asp:TextBox ID="capNumb" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RFV_3" runat="server" 
                        ErrorMessage="Debe Ingresar la capacidad maxima" CssClass="text-danger" ControlToValidate="capNumb">

                    </asp:RequiredFieldValidator>
                </div>

                <!--HORARIO ATENCION-->
                <div class="form-group">
                    <label for="horarioAtencion">Horario</label>
                    <asp:TextBox ID="idHorarioAtencion" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFV_4" runat="server"
                        ErrorMessage="Debe Ingresar un Horario de Atencion" CssClass="text-danger" ControlToValidate="idHorarioAtencion">

                    </asp:RequiredFieldValidator>
                </div>


            </div>
            <asp:Button ID="ingresarBtn" runat="server" Text="Agregar Estacion" CssClass="btn btn-dark" OnClick="ingresarBtn_Click" />
            <div>
                <asp:Label ID="alertIngreso" runat="server" CssClass="text-success h3"></asp:Label>
            </div>
        </div>


    </div>


</asp:Content>
