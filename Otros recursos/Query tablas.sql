CREATE TABLE Estado (
	idEstado BIT NOT NULL,
	nombre VARCHAR(20) NOT NULL,
	CONSTRAINT PK_idEstatus
		PRIMARY KEY(idEstado)
);
INSERT INTO Estado(idEstado, nombre) VALUES
(0, 'Inactivo'),
(1, 'Activo')

CREATE TABLE Pais (
	cvePais			VARCHAR(5) NOT NULL,
	nombre			VARCHAR(40) NOT NULL,
	CONSTRAINT PK_cvePais
		PRIMARY KEY(cvePais)
);
CREATE TABLE Ciudad (
	cveCiudad		VARCHAR(5)	NOT NULL,
	nombre			VARCHAR(40) NOT NULL,
	cvePais			VARCHAR(5)	NOT NULL
	CONSTRAINT PK_cveCiudad
		PRIMARY KEY(cveCiudad),
	CONSTRAINT FK_cvePais_Ciudad
		FOREIGN KEY(cvePais) REFERENCES Pais(cvePais)
);

CREATE TABLE Persona (
	idPersona		INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(20) NOT NULL,
	apellidoPaterno VARCHAR(20) NOT NULL,
	apellidoMaterno VARCHAR(20) NOT NULL,
	fechaNacimiento	DATE		NOT NULL,
	calle			VARCHAR(20) NOT NULL,
	colonia			VARCHAR(20) NOT NULL,
	cveCiudad		VARCHAR(5)	NOT NULL,
	cvePais			VARCHAR(5)	NOT NULL,
	telefonoCasa	VARCHAR(8),
	celular			VARCHAR(10) NOT NULL,
	idEstado		BIT			NOT NULL
	CONSTRAINT PK_idPersona
		PRIMARY KEY(idPersona),
	CONSTRAINT FK_idEstado_Persona
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE TipoUsuario (
	idTipoUsuario	TINYINT		NOT NULL,
	nombre			VARCHAR(20) NOT NULL,
	CONSTRAINT PK_idTipoUsuario
		PRIMARY KEY(idTipoUsuario)
);
INSERT INTO TipoUsuario(idTipoUsuario,nombre) VALUES
(1,'Administrador'),
(2,'Operativo')

CREATE TABLE Usuario (
	idUsuario		INT			NOT NULL	IDENTITY(1000,1),
	correo			VARCHAR(40) NOT NULL	UNIQUE,
	contrasena		VARCHAR(20) NOT NULL,
	noNomina		VARCHAR(6)	NOT NULL	UNIQUE,
	tipoUsuario		TINYINT		NOT NULL,
	idPersona		INT			NOT NULL,
	registradoPor	INT,
	fechaRegistro	DATETIME	NOT NULL	DEFAULT(GETDATE()),
	idEstado		BIT			NOT NULL
	CONSTRAINT PK_idUsuario 
		PRIMARY KEY(idUsuario),
	CONSTRAINT FK_idPersona_Usuario
		FOREIGN KEY(idPersona) REFERENCES Persona(idPersona),
	CONSTRAINT FK_idTipoUsuario_Usuario
		FOREIGN KEY(tipoUsuario) REFERENCES TipoUsuario(idTipoUsuario),
	CONSTRAINT FK_idUsuario_Usuario
		FOREIGN KEY (registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstado_Usuario 
		FOREIGN KEY(idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE ZonaTuristica (
	idZonaTuristica INT NOT NULL IDENTITY,
	nombre			VARCHAR(40) NOT NULL
	CONSTRAINT PK_idZonaTuristica PRIMARY KEY (idZonaTuristica)
);

CREATE TABLE Hotel (
	idHotel				INT			NOT NULL	IDENTITY(1000,1),
	nombre				VARCHAR(40),
	calle				VARCHAR(20) NOT NULL,
	colonia				VARCHAR(20) NOT NULL,
	cveCiudad			VARCHAR(5)	NOT NULL,
	cvePais				VARCHAR(5)	NOT NULL,
	cantPisos			INT			NOT NULL,
	cantHabitaciones	INT			NOT NULL,
	tiposHabitacion		INT			NOT NULL,
	zonaTuristica		INT			NOT NULL,
	fechaApertura		DATE		NOT NULL,
	registradoPor		INT			NOT NULL,
	fechaRegistro		DATETIME	NOT NULL	DEFAULT(GETDATE()),
	idEstado			BIT			NOT NULL
	CONSTRAINT PK_idHotel
		PRIMARY KEY(idHotel),
	CONSTRAINT FK_zonaTuristica_Hotel 
		FOREIGN KEY (zonaTuristica) REFERENCES ZonaTuristica(idZonaTuristica),
	CONSTRAINT FK_idUsuario_Hotel
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstado_Hotel
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);


CREATE TABLE ServicioAdicional (
	idServicioAdicional INT			NOT NULL	IDENTITY(1000,1),
	nombre				VARCHAR(40) NOT NULL,
	descripcion			VARCHAR(144),
	costo				MONEY		NOT NULL,
	registradoPor		INT			NOT NULL, 
	fechaRegistro		DATETIME	NOT NULL	DEFAULT(GETDATE()),
	idEstado			BIT		NOT NULL
	CONSTRAINT PK_idServicioAdicional
		PRIMARY KEY(idServicioAdicional),
	CONSTRAINT FK_idUsuario_ServicioAdicional 
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstado_ServicioAdicional
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE Hotel_ServicioAdicional (
	idHotel_Servicio		INT NOT NULL IDENTITY(1000,1),
	idHotel					INT NOT NULL,
	idServicioAdicional		INT NOT NULL,
	idEstado				BIT NOT NULL
	CONSTRAINT PK_Hotel_Servicio
		PRIMARY KEY(idHotel_Servicio),
	CONSTRAINT FK_idHotel_Hotel_Servicio
		FOREIGN KEY(idHotel) REFERENCES Hotel(idHotel),
	CONSTRAINT FK_idServicio_Hotel_Servicio
		FOREIGN KEY(idServicioAdicional) REFERENCES ServicioAdicional(idServicioAdicional),
	CONSTRAINT FK_idEstatus_Hotel_servicioAdicional
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE TipoCama (
	idTipoCama		INT			NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(20) NOT NULL,
	descripcion		VARCHAR(144)
	CONSTRAINT PK_idTipoCama
		PRIMARY KEY(idTipoCama)
);

CREATE TABLE NivelHabitacion (
	idNivelHabitacion	INT			NOT NULL IDENTITY(1000,1),
	nombre				VARCHAR(40) NOT NULL,
	descripcion			VARCHAR(144)
	CONSTRAINT PK_idNivelHabitacion
		PRIMARY KEY(idNivelHabitacion)
);

CREATE TABLE TipoHabitacion (
	idTipoHabitacion	INT			NOT NULL IDENTITY(1000,1),
	nombre				VARCHAR(40),
	cantCamas			INT			NOT NULL,
	idTipoCama			INT			NOT NULL,
	costoPersona		MONEY		NOT NULL,
	capacidadPersonas	INT			NOT NULL,
	idNivelHabitacion	INT			NOT NULL,
	registradoPor		INT			NOT NULL,
	fechaRegistro		DATETIME	NOT NULL,
	idEstado			BIT			NOT NULL
	CONSTRAINT PK_idTipoHabitacion
		PRIMARY KEY(idTipoHabitacion),
	CONSTRAINT FK_idTipoCama_TipoHabitacion
		FOREIGN KEY(idTipoCama) REFERENCES TipoCama(idTipoCama),
	CONSTRAINT FK_idNivelHabitacion_TipoHabitacion
		FOREIGN KEY(idNivelHabitacion) REFERENCES NivelHabitacion(idNivelHabitacion),
	CONSTRAINT FK_idAdministrador_TipoHabitacion	
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstatus_TipoHabitacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE DisponibilidadHabitacion(
	idDisponibilidad	TINYINT		NOT NULL,
	nombre				VARCHAR(40)	NOT NULL,
	CONSTRAINT PK_idDisponibilidad
		PRIMARY KEY(idDisponibilidad)
)

INSERT INTO DisponibilidadHabitacion VALUES
(0, 'No disponible'),
(1, 'Disponible')

CREATE TABLE Habitacion (
	idHabitacion		INT			NOT NULL	IDENTITY(1000,1),
	noHabitacion		INT			NOT NULL,
	noPiso				SMALLINT	NOT NULL,
	idHotel				INT			NOT NULL,
	idTipoHabitacion	INT			NOT NULL,
	idDisponibilidad	TINYINT		NOT NULL,
	registradoPor		INT			NOT NULL,
	fechaRegistro		DATETIME	NOT NULL	DEFAULT(GETDATE()),
	idEstado			BIT			NOT NULL
	CONSTRAINT PK_idHabitacion
		PRIMARY KEY(idHabitacion),
	CONSTRAINT UQ_noHabitacion_idHotel 
		UNIQUE (noHabitacion, idHotel),
	CONSTRAINT FK_idTipoHabitacion_Habitacion
		FOREIGN KEY(idTipoHabitacion) REFERENCES TipoHabitacion(idTipoHabitacion),
	CONSTRAINT FK_idDisponibilidad_Habitacion 
		FOREIGN KEY(idDisponibilidad)REFERENCES DisponibilidadHabitacion(idDisponibilidad),
	CONSTRAINT FK_idUsuario_Habitacion 
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstado_Habitacion 
		FOREIGN KEY(idEstado)REFERENCES Estado(idEstado) 
);

CREATE TABLE AmenidadHabitacion (
	idAmenidadHab	INT			NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144),
	registradoPor	INT			NOT NULL,
	fechaRegistro	DATETIME	NOT NULL,
	idEstado		BIT			NOT NULL
	CONSTRAINT PK_idAmenidadHab
		PRIMARY KEY(idAmenidadHab),
	CONSTRAINT FK_idUsuario_AmenidadHabitacion	
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstatus_AmenidadHabitacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE CaracteristicaHabitacion (
	idCaractHab		INT			NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144),
	registradoPor	INT			NOT NULL,
	fechaRegistro	DATETIME	NOT NULL,
	idEstado		BIT			NOT NULL
	CONSTRAINT PK_idCaractHab
		PRIMARY KEY(idCaractHab),
	CONSTRAINT FK_idUsuario_CaracteristicaHabitacion	
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstatus_CaracteristicaHabitacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE TipoHabitacion_AmenidadHabitacion (
	idTipoHab_AmenHab	INT NOT NULL IDENTITY(1000,1),
	idTipoHabitacion	INT NOT NULL,
	idAmenidadHab		INT NOT NULL,
	idEstado			BIT NOT NULL
	CONSTRAINT PK_idTipoHab_AmenHab
		PRIMARY KEY(idTipoHab_AmenHab),
	CONSTRAINT FK_idTipoHabitacion_TipoHab_AmenHab
		FOREIGN KEY(idTipoHabitacion) REFERENCES TipoHabitacion(idTipoHabitacion),
	CONSTRAINT FK_idAmenidadHab_TipoHab_AmenHab
		FOREIGN KEY(idAmenidadHab) REFERENCES AmenidadHabitacion(idAmenidadHab),
	CONSTRAINT FK_idEstatus_TipoHabitacion_AmenidadHabitacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE TipoHabitacion_CaracteristicaHabitacion (
	idTipoHab_CaractHab	INT NOT NULL IDENTITY(1000,1),
	idTipoHabitacion	INT NOT NULL,
	idCaractHab		INT NOT NULL,
	idEstado		BIT NOT NULL
	CONSTRAINT PK_idTipoHab_idCaractHab
		PRIMARY KEY(idTipoHab_CaractHab),
	CONSTRAINT FK_idTipoHabitacion_TipoHab_CaractHab
		FOREIGN KEY(idTipoHabitacion) REFERENCES TipoHabitacion(idTipoHabitacion),
	CONSTRAINT FK_idTCaractHab_TipoHab_idCaractHab
		FOREIGN KEY(idCaractHab) REFERENCES CaracteristicaHabitacion(idCaractHab),
	CONSTRAINT FK_idEstado_TipoHabitacion_CaracteristicaHabitacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE EstadoCivil (
	idEstadoCivil	INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144)
	CONSTRAINT PK_idEstadoCivil
		PRIMARY KEY(idEstadoCivil)
);

CREATE TABLE Referencia (
	idReferencia	INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144)
	CONSTRAINT PK_idReferencia
		PRIMARY KEY(idReferencia)
);

CREATE TABLE Cliente (
	idCliente		INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(20) NOT NULL,
	apellidoPaterno VARCHAR(20) NOT NULL,
	apellidoMaterno VARCHAR(20) NOT NULL,
	calle			VARCHAR(20) NOT NULL,
	colonia			VARCHAR(20) NOT NULL,
	cveCiudad		VARCHAR(5) NOT NULL,
	cvePais			VARCHAR(5) NOT NULL,
	RFC				varchar(13) NOT NULL,
	correo			VARCHAR(40) NOT NULL UNIQUE,
	telefonoCasa	VARCHAR(8),
	celular			VARCHAR(10) NOT NULL,
	idReferencia	INT NOT NULL,
	fechaNacimiento DATE NOT NULL,
	idEstadoCivil	INT NOT NULL,
	registradoPor	INT NOT NULL,
	fechaRegistro	DATETIME NOT NULL,
	idEstado		BIT NOT NULL
	CONSTRAINT PK_idCliente
		PRIMARY KEY(idCliente),
	CONSTRAINT FK_idReferencia_Cliente
		FOREIGN KEY(idReferencia) REFERENCES Referencia(idReferencia),
	CONSTRAINT FK_idEstadoCivil_Cliente
		FOREIGN KEY(idEstadoCivil) REFERENCES EstadoCivil(idEstadoCivil),
	CONSTRAINT FK_idUsuario_Cliente
		FOREIGN KEY(registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstado_Cliente
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE MetodoPago (
	idMetodoPago	INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144),
	CONSTRAINT PK_idMetodoPago
		PRIMARY KEY(idMetodoPago)
);

CREATE TABLE EstadoReservacion (
	idEstadoReserv	INT NOT NULL IDENTITY(1000,1),
	nombre			VARCHAR(40) NOT NULL,
	descripcion		VARCHAR(144),
	CONSTRAINT PK_idEstadoReservacion
		PRIMARY KEY(idEstadoReserv)
);

CREATE TABLE Reservacion (
	cdoReservacion	INT				NOT NULL IDENTITY(1000,1),
	cveCiudad		VARCHAR(5)		NOT NULL,
	fechaLlegada	DATE			NOT NULL,
	fechaSalida		DATE			NOT NULL,
	idEstadoReserv	INT				NOT NULL,
	montoAnticipo	MONEY			NOT NULL,
	cdoCheckIn		UNIQUEIDENTIFIER,
	fechaCheckIn	DATETIME,
	cdoCheckOut		UNIQUEIDENTIFIER,
	fechaCheckOut	DATETIME,
	extEstancia		INT,
	montoServ		MONEY,
	montoPendiente	MONEY			NOT NULL,
	montoSubtotal	MONEY			NOT NULL,
	montoTotal		MONEY			NOT NULL,
	idMetodoPago	INT				NOT NULL,
	idCliente		INT				NOT NULL,
	registradoPor	INT				NOT NULL,
	fechaRegistro	DATETIME		NOT NULL,
	idHotel			INT				NOT NULL,
	idEstado		BIT				NOT NULL
	CONSTRAINT PK_cdoReservacion
		PRIMARY KEY(cdoReservacion),
	CONSTRAINT FK_ciudad_Reservacion
		FOREIGN KEY(cveCiudad) REFERENCES Ciudad(cveCiudad),
	CONSTRAINT FK_hotel_Reservacion
		FOREIGN KEY(idHotel) REFERENCES Hotel(idHotel),
	CONSTRAINT FK_idCliente_Reservacion
		FOREIGN KEY(idCliente) REFERENCES Cliente(idCliente),
	CONSTRAINT FK_idMetodoPago_Reservacion
		FOREIGN KEY(idMetodoPago) REFERENCES MetodoPago(idMetodoPago),
	CONSTRAINT FK_idEstadoReserv_Reservacion
		FOREIGN KEY(idEstadoReserv) REFERENCES EstadoReservacion(idEstadoReserv),
	CONSTRAINT FK_idUsuario_Reservacion
		FOREIGN KEY (registradoPor) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_idEstatus_Reservacion
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE Reservacion_Habitacion (
	idReserv_Hab			INT NOT NULL IDENTITY(1000,1),
	cdoReservacion			INT NOT NULL,
	idHabitacion			INT NOT NULL,
	cantPersonas			INT NOT NULL,
	idEstado				BIT NOT NULL
	CONSTRAINT PK_idReserv_Hab
		PRIMARY KEY(idReserv_Hab),
	CONSTRAINT FK_cdoReservacion_Reservacion_Hab
		FOREIGN KEY(cdoReservacion) REFERENCES Reservacion(cdoReservacion),
	CONSTRAINT FK_idHab_Reservacion_TipoHab
		FOREIGN KEY(idHabitacion) REFERENCES Habitacion(idHabitacion),
	CONSTRAINT FK_idHab_Estado 
		FOREIGN KEY(idEstado) REFERENCES Estado(idEstado)
);

CREATE TABLE Reservacion_ServicioAdicional (
	idReserv_Servicio INT NOT NULL IDENTITY(1000,1),
	cdoReservacion	INT NOT NULL,
	idServicioAdicional INT NOT NULL,
	idEstado		BIT NOT NULL
	CONSTRAINT PK_idReserv_Servicio
		PRIMARY KEY(idReserv_Servicio),
	CONSTRAINT FK_cdoReservacion_Reserv_Servicio
		FOREIGN KEY(cdoReservacion) REFERENCES Reservacion(cdoReservacion),
	CONSTRAINT FK_idServicio_Reserv_Servicio
		FOREIGN KEY(idServicioAdicional) REFERENCES ServicioAdicional(idServicioAdicional),
	CONSTRAINT FK_idEstatus_Reservacion_ServicioAdicional
		FOREIGN KEY (idEstado) REFERENCES Estado(idEstado),
);

CREATE TABLE MotivoCancelacion(
	idMotivoCanc	INT NOT NULL IDENTITY(1000,1),
	descripcion		VARCHAR(144),
	CONSTRAINT PK_idMotivoCanc
		PRIMARY KEY(idMotivoCanc)
)

CREATE TABLE Cancelacion (
	idCancelacion	INT NOT NULL IDENTITY(1000,1),
	cdoReservacion	INT NOT NULL,
	idMotivoCanc INT NOT NULL,
	hechaPor	INT NOT NULL,
	fechaCancelacion	DATETIME NOT NULL DEFAULT(GETDATE())
	CONSTRAINT PK_idCancelacion		
		PRIMARY KEY(idCancelacion),
	CONSTRAINT FK_idMotivoCancelacion
		FOREIGN KEY(idMotivoCanc) REFERENCES MotivoCancelacion(idMotivoCanc),
	CONSTRAINT FK_idUsuario_Cancelacion
		FOREIGN KEY(hechaPor) REFERENCES Usuario(idUsuario),
);

CREATE TABLE Factura (
	idFactura		INT NOT NULL IDENTITY(1000,1),
	noFactura		INT NOT NULL,
	cdoReservacion	INT NOT NULL
	CONSTRAINT PK_idFactura
		PRIMARY KEY(idFactura),
	CONSTRAINT FK_cdoReservacion_Factura
		FOREIGN KEY(cdoReservacion) REFERENCES Reservacion(cdoReservacion)
);

INSERT INTO ZonaTuristica (nombre)
VALUES
('Cancún'),
('Playa del Carmen'),
('Tulum'),
('Puerto Vallarta'),
('Cabo San Lucas'),
('Mazatlán'),
('Acapulco'),
('Ixtapa'),
('Zihuatanejo'),
('Cozumel'),
('Riviera Maya'),
('Holbox'),
('Los Cabos'),
('Ciudad de México'),
('San Miguel de Allende'),
('Guanajuato'),
('Morelia'),
('Puebla'),
('Oaxaca'),
('Tepoztlán'),
('Taxco'),
('Querétaro'),
('Puerto Escondido'),
('Huasteca Potosina'),
('Bacalar'),
('Merida'),
('Isla Mujeres'),
('Mahahual'),
('Bucerías'),
('Sayulita'),
('San Pancho'),
('Chapala'),
('Ajijic'),
('Tlaquepaque'),
('Tequila'),
('Guadalajara'),
('Zacatecas'),
('San Luis Potosí'),
('Real de Catorce'),
('Durango'),
('Torreón'),
('Monterrey'),
('Saltillo'),
('Ciudad Victoria'),
('Tampico'),
('Veracruz'),
('Boca del Río'),
('Xalapa'),
('Tuxpan');

INSERT INTO TipoCama(nombre,descripcion)
VALUES
('Matrimonial','Cama para dos personas'),
('Individual', 'Cama para una o dos persona'),
('King size', 'Cama para hasta dos adultos y un bebé'),
('Queen size', 'Cama ideal para dos personas'),
('King presidencial', 'Cama para dos adultos y un niño pequeño')


INSERT INTO NivelHabitacion(nombre,descripcion)
VALUES
('Económica','Habitacion con justo lo necesario'),
('Estandar','Habitacion completa'),
('De lujo', 'Habitacion con servicios de lujo'),
('Suite', 'Habitacion de lujo y con amplia superficie')


INSERT INTO Referencia (nombre, descripcion) VALUES ('Revista', 'Anuncio en la revista X');
INSERT INTO Referencia (nombre, descripcion) VALUES ('Motor de búsqueda', 'Búsqueda en Google');
INSERT INTO Referencia (nombre, descripcion) VALUES ('Amigo', 'Recomendación de mi amigo Juan');
INSERT INTO Referencia (nombre, descripcion) VALUES ('Televisión', 'Anuncio en el canal Y');
INSERT INTO Referencia (nombre) VALUES ('Cliente recurrente'); 

INSERT INTO EstadoCivil (nombre, descripcion) VALUES 
  ('Soltero(a)', NULL),
  ('Casado(a)', NULL),
  ('Divorciado(a)', NULL),
  ('Viudo(a)', NULL),
  ('En una relación de hecho', 'Vivimos juntos desde hace 5 años');


INSERT INTO EstadoReservacion(nombre) VALUES
	('Confirmada'),
	('Pendiente'),
	('Cancelada'),
	('Pagada')

INSERT INTO Ciudad (cveCiudad, nombre, cvePais) VALUES
    ('CUN', 'Cancún', 'MEX'),
    ('GDL', 'Guadalajara', 'MEX'),
    ('MEX', 'Ciudad de México', 'MEX'),
    ('MTY', 'Monterrey', 'MEX'),
    ('PVR', 'Puerto Vallarta', 'MEX'),
    ('TIJ', 'Tijuana', 'MEX'),
    ('CJS', 'Ciudad Juárez', 'MEX'),
    ('CUA', 'Cuernavaca', 'MEX'),
    ('CUU', 'Chihuahua', 'MEX'),
    ('GYM', 'Guaymas', 'MEX'),
    ('HMO', 'Hermosillo', 'MEX'),
    ('LAP', 'La Paz', 'MEX'),
    ('LTO', 'Loreto', 'MEX'),
    ('MAM', 'Matamoros', 'MEX'),
    ('MID', 'Mérida', 'MEX'),
    ('OAX', 'Oaxaca', 'MEX'),
    ('PBC', 'Puebla', 'MEX'),
    ('QRO', 'Querétaro', 'MEX'),
    ('SJD', 'San José del Cabo', 'MEX'),
    ('ZIH', 'Zihuatanejo', 'MEX');

INSERT INTO Pais (cvePais, nombre) VALUES
	('MEX', 'México'),
	('USA', 'Estados Unidos'),
	('CAN', 'Canadá'),
	('ESP', 'España'),
	('FRA', 'Francia'),
	('ITA', 'Italia'),
	('ALE', 'Alemania'),
	('CHI', 'China'),
	('JAP', 'Japón'),
	('BRA', 'Brasil'),
	('ARG', 'Argentina'),
	('COL', 'Colombia'),
	('PER', 'Perú'),
	('VEN', 'Venezuela'),
	('CUB', 'Cuba'),
	('PRI', 'Puerto Rico'),
	('RUS', 'Rusia'),
	('IND', 'India'),
	('AUS', 'Australia'),
	('NZL', 'Nueva Zelanda');

			SELECT * FROM Reservacion
		SELECT * FROM Reservacion_Habitacion
		select * from TipoHabitacion
		select * from Habitacion
		UPDATE Habitacion set idDisponibilidad  =1 
	SELECT * FROM ServicioAdicional
	SELECT * FROM Reservacion_ServicioAdicional
		SELECT * FROM TipoHabitacion
		select * from EstadoReservacion
	DELETE Reservacion_Habitacion 
	DELETE Reservacion_ServicioAdicional
	DELETE Reservacion where cdoReservacion=3044
	update Habitacion set idDisponibilidad=1 where idHabitacion=1000
	insert into EstadoReservacion(nombre)values('Hospedada')