<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="SistemaEstacionesWeb.administracion.AgregarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row mt-5">

        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">

                <div class="card-header bg-info text-black-50 text-center">
                     <h3>Ingresar Estacion</h3>
                </div>

                <div class="card-body text-black-50 text-left">
                    
                        <div class="mb-3">
                            <label for="InputText1" class="form-label">
                                Nombre de la estacion
                            </label>
                            <input type="text" class="form-control" id="nomEst" value="" placeholder="Estacion villa alemana" aria-describedby="emailHelp" required>
                        </div>

                        <div class="mb-3">
                            <label for="InputText2" class="form-label">
                                Direccion
                            </label>
                            <input type="text" class="form-control" id="dirEst" value="" placeholder="calle + #numero" aria-describedby="emailHelp" required>
                        </div>
                    
                        <select id="regiones">
                            <option value="-1">--Seleccione Región--</option>
                        </select>
                        <br />
                        <select id="provincias">
                            <option value="-1">--Seleccione Provincia--</option>
                        </select>
                        <br />
                        <select id="comunas">
                            <option value="-1">--Seleccione Comunas--</option>
                        </select>

                        <div class="col-md-3">
                            <label for="selectRegion" class="form-label">Region</label>
                            <select class="form-select" id="validationCustom04" required>
                                <option selected disabled value="">Seleccione...</option>
                                <option>Región de Arica y Parinacota</option>
                                <option>Región de Tarapacá</option>
                                <option>Región de Antofagasta</option>
                                <option>Región de Atacama</option>
                                <option>Región de Coquimbo</option>
                                <option>Región de Valparaíso</option>
                                <option>Región Metropolitana de Santiago</option>
                                <option>Región del Libertador General Bernardo O’Higgins</option>
                                <option>Región del Maule</option>
                                <option>Región del Ñuble</option>
                                <option>Región del Biobío</option>
                                <option>Región de La Araucanía</option>
                                <option>Región de Los Ríos</option>
                                <option>Región de Los Lagos</option>
                                <option>Región de Aysén del General Carlos Ibáñez del Campo</option>
                                
                            </select>

                            <div class="invalid-feedback">
                                Please select a valid state.
                            </div>

                        </div>

                        <button type="submit" class="btn btn-primary">Submit</button>
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
