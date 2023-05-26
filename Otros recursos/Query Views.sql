CREATE VIEW VW_Usuarios
AS
	SELECT 
	U.idUsuario 'ID',
	U.correo 'Correo',				
	P.nombre 'Nombre',
	P.apellidoPaterno 'Apellido paterno',
	P.apellidoMaterno 'Apellido materno',
	U.noNomina 'Numero de nomina',		
	P.fechaNacimiento 'Fecha de nacimiento',	
	P.calle 'Calle',			
	P.colonia 'Colonia',			
	CD.nombre 'Ciudad',		
	PA.nombre 'Pais',			
	P.telefonoCasa 'Telefono de casa',	
	P.celular 'Telefono celular',
	E.nombre 'Estado',
	U.registradoPor 'Registrado por',
	U.fechaRegistro 'Fecha de registro'
	FROM Usuario U 
	INNER JOIN Persona P
	ON U.idPersona = P.idPersona
	INNER JOIN Ciudad CD 
	ON P.cveCiudad = CD.cveCiudad
	INNER JOIN Pais PA 
	ON P.cvePais = PA.cvePais
	INNER JOIN Estado E
	ON U.idEstado = E.idEstado
	WHERE tipoUsuario = 2

CREATE VIEW VW_ReporteOcupacion
AS
SELECT 
	 H.cveCiudad 'Ciudad'
	,H.nombre 'Nombre del hotel'
	,YEAR(R.fechaRegistro) 'Año'
	,MONTH(R.fechaRegistro) 'Mes'
	,TH.nombre 'Tipo de habitacion'
	,COUNT(TH.idTipoHabitacion) 'Cantidad de habitaciones'
	,CASE 
	 WHEN SUM(CASE WHEN HAB.idDisponibilidad = 1 THEN 1 ELSE 0 END) <> 0
	 THEN (SUM(CASE WHEN HAB.idDisponibilidad = 0 THEN 1 ELSE 0 END) / SUM(CASE WHEN HAB.idDisponibilidad = 1 THEN 1 ELSE 0 END)) * 100
	 ELSE 0
	 END AS 'Porcentaje de disponibilidad'
	,SUM(RH.cantPersonas) 'Cantidad de personas hospedadas'
FROM Reservacion_Habitacion RH
inner JOIN Habitacion HAB
ON RH.idHabitacion=HAB.idHabitacion
inner JOIN TipoHabitacion TH
ON HAB.idTipoHabitacion=TH.idTipoHabitacion
JOIN Reservacion R
ON RH.cdoReservacion=R.cdoReservacion
inner JOIN Hotel H
ON R.idHotel=H.idHotel
GROUP BY 
	 H.cveCiudad
	,H.nombre 
	,YEAR(R.fechaRegistro)
	,MONTH(R.fechaRegistro)
	,TH.nombre
	,TH.idTipoHabitacion;


CREATE VIEW VW_ReporteDeVentas
AS
SELECT
	 H.cveCiudad 'Ciudad'
	,H.nombre 'Nombre del hotel'
	,YEAR(R.fechaRegistro) 'Año'
	,MONTH(R.fechaRegistro) 'Mes'
	,COALESCE(SUM(R.montoTotal-R.montoServ),0) 'Ingresos por hospedaje'
	,COALESCE(SUM(R.montoServ),0) 'Ingresos por servicios adicionales'
	,COALESCE(SUM(R.montoTotal),0) 'Ingresos totales'
FROM Hotel H
RIGHT JOIN Reservacion R
ON H.idHotel = R.idHotel
GROUP BY 
	 H.cveCiudad 
	,H.nombre 
	,YEAR(R.fechaRegistro)
	,MONTH(R.fechaRegistro) 

CREATE VIEW VW_ReporteHistorialCliente
AS
SELECT 
	 C.idCliente 'ID'
	,CONCAT (C.nombre,' ',C.apellidoPaterno,' ',C.apellidoMaterno) 'Nombre del cliente'
	,CD.nombre 'Ciudad'
	,H.nombre 'Hotel'
	,TH.nombre 'Tipo de habitación'
	,HAB.noHabitacion 'Número de habitación'
	,RH.cantPersonas 'Número de personas hospedadas'
	,R.cdoReservacion 'Código de reservación'
	,R.fechaCheckIn 'Fecha del Check In'
	,R.fechaCheckOut 'Fecha del Check Out'
	,ER.nombre 'Estado de la reservación'
	,R.montoAnticipo 'Anticipo'
	,R.montoTotal-R.montoServ 'Monto del hospedaje'
	,R.montoServ 'Monto de servicios adicionales'
	,R.montoTotal 'Total de la factura'
FROM Reservacion_Habitacion RH
INNER JOIN Habitacion HAB
ON RH.idHabitacion=HAB.idHabitacion
INNER JOIN TipoHabitacion TH
ON HAB.idTipoHabitacion=TH.idTipoHabitacion
INNER JOIN Reservacion R
ON RH.cdoReservacion=R.cdoReservacion
INNER JOIN EstadoReservacion ER
ON ER.idEstadoReserv=R.idEstadoReserv
INNER JOIN Hotel H
ON R.idHotel=H.idHotel
INNER JOIN Cliente C
ON R.idCliente=C.idCliente
INNER JOIN Ciudad CD
ON C.cveCiudad=CD.cveCiudad


