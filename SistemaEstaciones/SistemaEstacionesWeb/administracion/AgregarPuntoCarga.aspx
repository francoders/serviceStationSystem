<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPuntoCarga.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.AgregarPuntoCarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <h1>Agregar Punto Carga</h1>

    <div class="card">
        <div class="card-body">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Tipo</label>
                <input type="text" class="form-control" id="tipoTxt" aria-describedby="tipo">
            </div>

            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Capacidad Maxima de Vehiculos</label>
                <input type="text" class="form-control" id="capMaxVehiculos">
            </div>

            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Estado Sensores</label>
                <input type="text" class="form-control" id="estadoSensoresTxt">
            </div>
        </div>

        <div class="card-footer">
            <button type="submit" class="btn btn-primary">Agregar Punto Carga</button>
        </div>
    </div>




</asp:Content>
