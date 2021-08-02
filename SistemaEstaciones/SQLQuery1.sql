CREATE TABLE Estacionservicio (
IdEstacionServicio VARCHAR(50) PRIMARY KEY NOT NULL,
Direccion VARCHAR(50) NOT NULL,
CodRegion VARCHAR(50) NOT NULL,
CapacidadMax INT NOT NULL,
HorarioAtencion VARCHAR(50) NOT NULL,

CONSTRAINT fk_estacionservicio_region FOREIGN KEY (CodRegion) REFERENCES Region(CodigoRegion)

);

CREATE TABLE Region (
NombreRegion VARCHAR(50) NOT NULL,
CodigoRegion VARCHAR(50) PRIMARY KEY NOT NULL
);

CREATE TABLE Puntocarga (
IdPuntoCarga VARCHAR(50) PRIMARY KEY NOT NULL,
CodTipo VARCHAR(50) NOT NULL,
CapacidadMaxVehiculos INT NOT NULL,
FechaReemplazo VARCHAR(50) NOT NULL,

CONSTRAINT fk_puntocarga_tipo FOREIGN KEY (CodTipo) REFERENCES Tipo(CodigoTipo)

);

CREATE TABLE Tipo (
Tipo VARCHAR(50) NOT NULL,
CodigoTipo VARCHAR(50) PRIMARY KEY NOT NULL
);