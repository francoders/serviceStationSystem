<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaEstacionesWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container text-center">
        <div id="divMenu" class="col-lg-8 col-md-6 col-sm-12">
            <div class="card mx-auto text-center">
                <div class="card-header text-center bg-info">
                    <img class="img-icon" src="img/icon.png" alt="alternative Text" />
                    <h2>Bienvenido al Sistema</h2>
                </div>

                <div class="card-body text-center">
                    <a class="nav-link " href="/administracion/AgregarEstacion.aspx">
                        <button type="button" class="btn btn-info btn-lg">Agregar Estacion Servicio</button></a>
                    <a class="nav-link" href="/administracion/AgregarPuntoCarga.aspx">
                        <button type="button" class="btn btn-info btn-lg">Agregar Punto Carga</button></a>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
