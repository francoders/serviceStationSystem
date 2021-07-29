CREATE TABLE Estacionservicio (
IdEstacionServicio VARCHAR (50) PRIMARY KEY,
Direccion VARCHAR (50) NOT NULL,
CodRegion VARCHAR (50) NOT NULL,
CapacidadMax INT NOT NULL,
HorarioAtencio VARCHAR (50) NOT NULL
);

CREATE TABLE Puntocarga (
IdPuntoCarga VARCHAR (50) PRIMARY KEY NOT NULL,
Tipo INT NOT NULL,
CapacidadMaxVehiculos INT NOT NULL,
FechaReemplazo VARCHAR (50) NOT NULL
);