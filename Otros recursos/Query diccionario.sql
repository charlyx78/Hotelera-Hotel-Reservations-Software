SELECT IC.COLUMN_NAME, IC.Data_TYPE, EP.[Value] as [MS_Description], IKU.CONSTRAINT_NAME,
ITC.CONSTRAINT_TYPE, IC.IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS IC
INNER JOIN sys.columns sc ON OBJECT_ID(QUOTENAME(IC.TABLE_SCHEMA) + '.' +
QUOTENAME(IC.TABLE_NAME)) = sc.[object_id] AND IC.COLUMN_NAME = sc.name
LEFT OUTER JOIN sys.extended_properties EP ON sc.[object_id] = EP.major_id AND
sc.[column_id] = EP.minor_id AND EP.name = 'MS_Description' AND EP.class = 1
LEFT OUTER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IKU ON IKU.COLUMN_NAME =
IC.COLUMN_NAME and IKU.TABLE_NAME = IC.TABLE_NAME and IKU.TABLE_CATALOG = IC.TABLE_CATALOG
LEFT OUTER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS ITC ON ITC.TABLE_NAME =
IKU.TABLE_NAME and ITC.CONSTRAINT_NAME = IKU.CONSTRAINT_NAME
WHERE IC.TABLE_CATALOG = 'Hotelera'
and IC.TABLE_SCHEMA = 'dbo'
--and IC.TABLE_NAME = 'Table'
order by IC.ORDINAL_POSITION

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Estado',
@level2type = N'Column', @level2name = 'idEstado';
GO
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre que describe el estado de cada dato (activo, inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Estado',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
    @name = N'MS_Description',
    @value = 'Clave de 3 chars de cada Pa�s',
    @level0type = N'Schema',
    @level0name = 'dbo',
    @level1type = N'Table',
    @level1name = 'Pais',
    @level2type = N'Column',
    @level2name = 'cvePais';
GO

EXEC sp_addextendedproperty
    @name = N'MS_Description',
    @value = 'Nombre del Pa�s',
    @level0type = N'Schema',
    @level0name = 'dbo',
    @level1type = N'Table',
    @level1name = 'Pais',
    @level2type = N'Column',
    @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de 5 caracteres de cada Ciudad',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Ciudad',
@level2type = N'Column', @level2name = 'cveCiudad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la Ciudad',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Ciudad',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de 5 caracteres del Pa�s al que pertenece la Ciudad',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Ciudad',
@level2type = N'Column', @level2name = 'cvePais';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'idPersona';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido paterno de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'apellidoPaterno';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido materno de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'apellidoMaterno';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de nacimiento de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'fechaNacimiento';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Calle de residencia de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'calle';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Colonia de residencia de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'colonia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de 5 caracteres de la ciudad de residencia de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'cveCiudad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de 5 caracteres del pa�s de residencia de la persona',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Persona',
@level2type = N'Column', @level2name = 'cvePais';

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del tipo de usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoUsuario',
@level2type = N'Column', @level2name = 'idTipoUsuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del tipo de usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoUsuario',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'idUsuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Correo electr�nico del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'correo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Contrase�a del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'contrasena';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'N�mero de n�mina del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'noNomina';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del tipo de usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'tipoUsuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la persona asociada al usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'idPersona';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� a este usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la zona tur�stica',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ZonaTuristica',
@level2type = N'Column', @level2name = 'idZonaTuristica';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la zona tur�stica',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ZonaTuristica',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'idHotel';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Calle del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'calle';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Colonia del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'colonia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de la ciudad donde se encuentra el hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'cveCiudad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave del pa�s donde se encuentra el hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'cvePais';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de pisos del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'cantPisos';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de habitaciones del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'cantHabitaciones';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Tipos de habitaci�n disponibles en el hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'tiposHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la zona tur�stica donde se encuentra el hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'zonaTuristica';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de apertura del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'fechaApertura';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� el hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado del hotel (activo, inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'idServicioAdicional';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Costo del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'costo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� el servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado del servicio adicional (activo, inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'ServicioAdicional',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la relaci�n entre hotel y servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel_ServicioAdicional',
@level2type = N'Column', @level2name = 'idHotel_Servicio';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel_ServicioAdicional',
@level2type = N'Column', @level2name = 'idHotel';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel_ServicioAdicional',
@level2type = N'Column', @level2name = 'idServicioAdicional';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la relaci�n entre hotel y servicio adicional (activo, inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Hotel_ServicioAdicional',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del tipo de cama',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoCama',
@level2type = N'Column', @level2name = 'idTipoCama';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del tipo de cama',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoCama',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del tipo de cama',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoCama',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del nivel de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NivelHabitacion',
@level2type = N'Column', @level2name = 'idNivelHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del nivel de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NivelHabitacion',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del nivel de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NivelHabitacion',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'idTipoHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de camas en la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'cantCamas';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del tipo de cama',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'idTipoCama';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Costo por persona en la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'costoPersona';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Capacidad m�xima de personas en la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'capacidadPersonas';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del nivel de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'idNivelHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� el tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado del tipo de habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la disponibilidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'DisponibilidadHabitacion',
@level2type = N'Column', @level2name = 'idDisponibilidad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la disponibilidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'DisponibilidadHabitacion',
@level2type = N'Column', @level2name = 'nombre';
GO


EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'idHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'N�mero de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'noHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'N�mero de piso de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'noPiso';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del hotel al que pertenece la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'idHotel';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'idTipoHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la disponibilidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'idDisponibilidad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Habitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la amenidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idAmenidadHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la amenidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n de la amenidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� la amenidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro de la amenidad de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la amenidad de la habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la caracter�stica de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idCaractHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la caracter�stica de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n de la caracter�stica de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� la caracter�stica de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro de la caracter�stica de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la caracter�stica de la habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la relaci�n entre tipo de habitaci�n y amenidad de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idTipoHab_AmenHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idTipoHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la amenidad de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idAmenidadHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la relaci�n entre tipo de habitaci�n y amenidad de habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_AmenidadHabitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la relaci�n entre tipo de habitaci�n y caracter�stica de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idTipoHab_CaractHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del tipo de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idTipoHabitacion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la caracter�stica de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idCaractHab';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado de la relaci�n entre tipo de habitaci�n y caracter�stica de habitaci�n (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'TipoHabitacion_CaracteristicaHabitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del estado civil',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoCivil',
@level2type = N'Column', @level2name = 'idEstadoCivil';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del estado civil',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoCivil',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del estado civil',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoCivil',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico de la referencia',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Referencia',
@level2type = N'Column', @level2name = 'idReferencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre de la referencia',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Referencia',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n de la referencia',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Referencia',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'idCliente';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido paterno del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'apellidoPaterno';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido materno del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'apellidoMaterno';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Calle de la direcci�n del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'calle';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Colonia de la direcci�n del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'colonia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave de la ciudad de la direcci�n del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'cveCiudad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave del pa�s de la direcci�n del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'cvePais';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'RFC (Registro Federal de Contribuyentes) del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'RFC';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Correo electr�nico del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'correo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Tel�fono de casa del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'telefonoCasa';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'N�mero de celular del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'celular';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la referencia del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'idReferencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de nacimiento del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'fechaNacimiento';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado civil del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'idEstadoCivil';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario que registr� al cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'registradoPor';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha y hora de registro del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Estado del cliente (activo/inactivo)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cliente',
@level2type = N'Column', @level2name = 'idEstado';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del m�todo de pago',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'MetodoPago',
@level2type = N'Column', @level2name = 'idMetodoPago';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del m�todo de pago',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'MetodoPago',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del m�todo de pago',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'MetodoPago',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID �nico del estado de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoReservacion',
@level2type = N'Column', @level2name = 'idEstadoReserv';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del estado de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoReservacion',
@level2type = N'Column', @level2name = 'nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripci�n del estado de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'EstadoReservacion',
@level2type = N'Column', @level2name = 'descripcion';
GO

-- cdoReservacion
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'cdoReservacion';
GO

-- cveCiudad
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'C�digo de la ciudad',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'cveCiudad';
GO

-- fechaLlegada
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de llegada',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'fechaLlegada';
GO

-- fechaSalida
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de salida',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'fechaSalida';
GO

-- idEstadoReserv
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'idEstadoReserv';
GO

-- montoAnticipo
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Monto del anticipo',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'montoAnticipo';
GO

-- cdoCheckIn
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del check-in',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'cdoCheckIn';
GO

-- fechaCheckIn
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha del check-in',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'fechaCheckIn';
GO

-- cdoCheckOut
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del check-out',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'cdoCheckOut';
GO

-- fechaCheckOut
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha del check-out',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'fechaCheckOut';
GO

-- extEstancia
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Extensi�n de la estancia',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'extEstancia';
GO

-- montoServ
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Monto del servicio',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'montoServ';
GO

-- montoPendiente
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Monto pendiente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'montoPendiente';
GO

-- montoSubtotal
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Monto subtotal',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'montoSubtotal';
GO

-- montoTotal
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Monto total',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'montoTotal';
GO

-- idMetodoPago
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del m�todo de pago',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'idMetodoPago';
GO

-- idCliente
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del cliente',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'idCliente';
GO

-- registradoPor
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del usuario registrado',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'registradoPor';
GO

-- fechaRegistro
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'fechaRegistro';
GO

-- idHotel
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del hotel',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'idHotel';
GO

-- idEstado
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

-- idReserv_Hab
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la reserva de habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_Habitacion',
@level2type = N'Column', @level2name = 'idReserv_Hab';
GO

-- cdoReservacion
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'C�digo de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_Habitacion',
@level2type = N'Column', @level2name = 'cdoReservacion';
GO

-- idHabitacion
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID de la habitaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_Habitacion',
@level2type = N'Column', @level2name = 'idHabitacion';
GO

-- cantPersonas
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de personas',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_Habitacion',
@level2type = N'Column', @level2name = 'cantPersonas';
GO

-- idEstado
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_Habitacion',
@level2type = N'Column', @level2name = 'idEstado';
GO

-- idReserv_Servicio
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del servicio adicional de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_ServicioAdicional',
@level2type = N'Column', @level2name = 'idReserv_Servicio';
GO

-- cdoReservacion
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'C�digo de la reservaci�n',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_ServicioAdicional',
@level2type = N'Column', @level2name = 'cdoReservacion';
GO

-- idServicioAdicional
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del servicio adicional',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_ServicioAdicional',
@level2type = N'Column', @level2name = 'idServicioAdicional';
GO

-- idEstado
EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'ID del estado',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Reservacion_ServicioAdicional',
@level2type = N'Column', @level2name = 'idEstado';
GO