IF OBJECT_ID('SP_GetDatosFactura') IS NOT NULL
	DROP PROCEDURE SP_GetDatosFactura;
GO
CREATE PROCEDURE SP_GetDatosFactura
	 @cdoReservacion INT
	,@opcion VARCHAR(3)
AS
BEGIN
	IF @opcion='F'
	BEGIN
		SELECT 
			 idFactura 'Número de factura'
			,H.nombre 'Nombre del hotel'
			,CONCAT(C.nombre,' ',C.apellidoPaterno,' ',C.apellidoMaterno) 'Nombre del cliente'
			,R.cdoReservacion 'Código de reservación'
			,R.fechaLlegada 'Fecha de llegada'
			,R.fechaSalida 'Fecha de salida'
		FROM Factura F
		INNER JOIN Reservacion R
		ON F.cdoReservacion=R.cdoReservacion
		INNER JOIN Hotel H
		ON R.idHotel=H.idHotel
		INNER JOIN Cliente C
		ON R.idCliente=C.idCliente
		WHERE R.cdoReservacion=@cdoReservacion
	END

	IF @opcion='H'
	BEGIN
		SELECT
			 TH.nombre 'Tipo de habitación'
			,RH.cantPersonas 'Cantidad de personas hospedadas'
			,(RH.cantPersonas*TH.costoPersona) 'Costo'
		FROM Reservacion_Habitacion RH
		LEFT JOIN Reservacion R
		ON R.cdoReservacion=RH.cdoReservacion
		LEFT JOIN Reservacion_ServicioAdicional RSA
		ON R.cdoReservacion=RSA.cdoReservacion
		INNER JOIN Habitacion H
		ON RH.idHabitacion=H.idHabitacion
		INNER JOIN TipoHabitacion TH
		ON H.idTipoHabitacion=TH.idTipoHabitacion
		WHERE R.cdoReservacion=@cdoReservacion
	END

	IF @opcion='S'
	BEGIN
		SELECT
			 SA.nombre 'Servicio adicional'
			,SA.costo 'Costo'
		FROM Reservacion R
		INNER JOIN Reservacion_Habitacion RH
		ON R.cdoReservacion=RH.cdoReservacion
		INNER JOIN Reservacion_ServicioAdicional RSA
		ON R.cdoReservacion=RSA.cdoReservacion
		INNER JOIN ServicioAdicional SA
		ON RSA.idServicioAdicional=SA.idServicioAdicional
		WHERE R.cdoReservacion=@cdoReservacion
	END
END
---------- REPORTE DE HISTORIAL DE CLIENTE ----------
IF OBJECT_ID('SP_ReporteHistorialCliente') IS NOT NULL
	DROP PROCEDURE SP_ReporteHistorialCliente;
GO
CREATE PROCEDURE SP_ReporteHistorialCliente
	 @idCliente		INT
	,@año			INT
	,@opcion		VARCHAR(3)
AS
BEGIN
	IF @opcion=''
	BEGIN 
		SELECT [Nombre del cliente],Ciudad,Hotel,[Tipo de habitación],[Número de habitación],[Número de personas hospedadas],[Código de reservación],[Fecha del Check In],[Fecha del Check Out],[Estado de la reservación],Anticipo,[Monto del hospedaje],[Monto de servicios adicionales],[Total de la factura] 
		FROM VW_ReporteHistorialCliente
	END
	IF @opcion='C'
	BEGIN
		SELECT [ID],[Nombre del cliente],Ciudad,Hotel,[Tipo de habitación],[Número de habitación],[Número de personas hospedadas],[Código de reservación],[Fecha del Check In],[Fecha del Check Out],[Estado de la reservación],Anticipo,[Monto del hospedaje],[Monto de servicios adicionales],[Total de la factura] 
		FROM VW_ReporteHistorialCliente RHC
		WHERE [ID] = @idCliente
	END
	IF @opcion='A'
	BEGIN
		SELECT [Nombre del cliente],Ciudad,Hotel,[Tipo de habitación],[Número de habitación],[Número de personas hospedadas],[Código de reservación],[Fecha del Check In],[Fecha del Check Out],[Estado de la reservación],Anticipo,[Monto del hospedaje],[Monto de servicios adicionales],[Total de la factura] 
		FROM VW_ReporteHistorialCliente RH
		INNER JOIN Reservacion R
		ON R.cdoReservacion=RH.[Código de reservación]
		WHERE YEAR(R.fechaRegistro) = @año
	END
END

---------- REPORTE DE OCUPACION ----------
IF OBJECT_ID('SP_ReporteOcupacion') IS NOT NULL
	DROP PROCEDURE SP_ReporteOcupacion;
GO
CREATE PROCEDURE SP_ReporteOcupacion
	 @cvePais	VARCHAR(5)
	,@año		INT
	,@cveCiudad	VARCHAR(5)
	,@idHotel	INT
	,@opcion	CHAR(3)
AS
BEGIN 
	IF @opcion=''
	BEGIN
	SELECT Ciudad,[Nombre del hotel],Año,Mes,[Tipo de habitacion],[Cantidad de habitaciones], [Porcentaje de ocupación], [Cantidad de personas hospedadas] FROM VW_ReporteOcupacion
	END
	IF @opcion='R'
	BEGIN
	SELECT Ciudad,[Nombre del hotel], Año, Mes, [Porcentaje de ocupación] FROM VW_ReporteOcupacionResumen
	END
	IF @opcion='P'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Tipo de habitacion],[Cantidad de habitaciones], [Porcentaje de ocupación], [Cantidad de personas hospedadas] FROM VW_ReporteOcupacion RO
		INNER JOIN Hotel H
		ON RO.[Nombre del hotel]=H.nombre
		INNER JOIN Pais P
		ON H.cvePais=P.cvePais
		WHERE H.cvePais = @cvePais
	END
	IF @opcion='PR'
	BEGIN
		SELECT Ciudad,[Nombre del hotel], Año, Mes, [Porcentaje de ocupación] FROM VW_ReporteOcupacionResumen ROR
		INNER JOIN Hotel H
		ON ROR.[Nombre del hotel]=H.nombre
		INNER JOIN Pais P
		ON H.cvePais=P.cvePais
		WHERE H.cvePais = @cvePais
	END
	IF @opcion='A'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Tipo de habitacion],[Cantidad de habitaciones], [Porcentaje de ocupación], [Cantidad de personas hospedadas] FROM VW_ReporteOcupacion
		WHERE Año= @año;
	END
	IF @opcion='AR'
	BEGIN
		SELECT Ciudad,[Nombre del hotel], Año, Mes, [Porcentaje de ocupación] FROM VW_ReporteOcupacionResumen ROR
		WHERE Año= @año;
	END
	IF @opcion='C'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Tipo de habitacion],[Cantidad de habitaciones], [Porcentaje de ocupación], [Cantidad de personas hospedadas] FROM VW_ReporteOcupacion RO
		INNER JOIN Hotel H
		ON RO.[Nombre del hotel]=H.nombre
		INNER JOIN Ciudad C
		ON H.cveCiudad=C.cveCiudad
		WHERE H.cveCiudad = @cveCiudad
	END
	IF @opcion='CR'
	BEGIN
		SELECT Ciudad,[Nombre del hotel], Año, Mes, [Porcentaje de ocupación] FROM VW_ReporteOcupacionResumen ROR
		INNER JOIN Hotel H
		ON RO.[Nombre del hotel]=H.nombre
		INNER JOIN Ciudad C
		ON H.cveCiudad=C.cveCiudad
		WHERE H.cveCiudad = @cveCiudad
	END
	IF @opcion='H'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Tipo de habitacion],[Cantidad de habitaciones], [Porcentaje de ocupación], [Cantidad de personas hospedadas] FROM VW_ReporteOcupacion RO
		INNER JOIN Hotel H
		ON RO.[Nombre del hotel]=H.nombre
		WHERE H.idHotel=@idHotel
	END
	IF @opcion='HR'
	BEGIN
		SELECT Ciudad,[Nombre del hotel], Año, Mes, [Porcentaje de ocupación] FROM VW_ReporteOcupacionResumen ROR
		INNER JOIN Hotel H
		ON RO.[Nombre del hotel]=H.nombre
		WHERE H.idHotel=@idHotel
	END
END

---------- REPORTE DE VENTAS ----------
IF OBJECT_ID('SP_ReporteVentas') IS NOT NULL
	DROP PROCEDURE SP_ReporteVentas;
GO
CREATE PROCEDURE SP_ReporteVentas
	 @cvePais	VARCHAR(5)
	,@año		INT
	,@cveCiudad	VARCHAR(5)
	,@idHotel	INT
	,@opcion	CHAR(3)
AS
BEGIN
	IF @opcion=''
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Ingresos por hospedaje],[Ingresos por servicios adicionales],[Ingresos totales]
		FROM VW_ReporteDeVentas RV
	END
	IF @opcion='P'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Ingresos por hospedaje],[Ingresos por servicios adicionales],[Ingresos totales]
		FROM VW_ReporteDeVentas RV
		INNER JOIN Hotel H
		ON RV.[Nombre del hotel]=H.nombre
		INNER JOIN Pais P
		ON H.cvePais=P.cvePais
		WHERE H.cvePais = @cvePais
	END
	if @opcion='A'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Ingresos por hospedaje],[Ingresos por servicios adicionales],[Ingresos totales]
		FROM VW_ReporteDeVentas RV
		WHERE Año= @año;
	END
	IF @opcion='C'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Ingresos por hospedaje],[Ingresos por servicios adicionales],[Ingresos totales]
		FROM VW_ReporteDeVentas RV
		INNER JOIN Hotel H
		ON RV.[Nombre del hotel]=H.nombre
		INNER JOIN Ciudad C
		ON H.cveCiudad=C.cveCiudad
		WHERE H.cveCiudad = @cveCiudad
	END
	IF @opcion='H'
	BEGIN
		SELECT Ciudad,[Nombre del hotel],Año,Mes,[Ingresos por hospedaje],[Ingresos por servicios adicionales],[Ingresos totales]
		FROM VW_ReporteDeVentas RV
		INNER JOIN Hotel H
		ON RV.[Nombre del hotel]=H.nombre
		WHERE H.idHotel=@idHotel
	END
END

---------- GESTION SERVICIOS ADICIONALES RESERVACIONES ----------
IF OBJECT_ID('SP_GestionServAdicionalesReservaciones') IS NOT NULL
	DROP PROCEDURE SP_GestionServAdicionalesReservaciones;
GO
CREATE PROCEDURE SP_GestionServAdicionalesReservaciones
	@opcion				CHAR(3)		,	
	@idReserv_Servicio	INT			,	
	@cdoReservacion		INT			, 
	@idServAdicional	INT 		,
	@idHotel			INT			,
	@rowsAffected INT OUTPUT
AS
BEGIN
	IF @opcion='I'
	BEGIN
		IF NOT EXISTS (
			SELECT *
			FROM Reservacion_ServicioAdicional
			WHERE cdoReservacion = @cdoReservacion
			AND idServicioAdicional = @idServAdicional
			AND idEstado = 1
		)
		INSERT INTO Reservacion_ServicioAdicional
		(
			cdoReservacion			
			,idServicioAdicional		
			,idEstado
		)
		VALUES
		(
			@cdoReservacion			
			,@idServAdicional		
			,1
		)
		SET @rowsAffected = @@ROWCOUNT;;
	END

	IF @opcion='S'
	BEGIN
		SELECT
		 RSA.idReserv_Servicio 'ID'
		,SA.nombre 'Nombre'
		,SA.costo 'Monto'
		FROM Reservacion_ServicioAdicional RSA
		INNER JOIN ServicioAdicional SA
		ON RSA.idServicioAdicional = SA.idServicioAdicional
		WHERE cdoReservacion = @cdoReservacion
	END

	IF @opcion='R'
	BEGIN
		SELECT SA.idServicioAdicional 'ID', nombre 'Nombre', costo 'Costo' 
		FROM Hotel_ServicioAdicional HSA
		INNER JOIN ServicioAdicional SA ON HSA.idServicioAdicional = SA.idServicioAdicional
		WHERE idHotel = @idHotel AND HSA.idEstado = 1 AND
		NOT EXISTS (
			SELECT 1 FROM Reservacion_ServicioAdicional RSA 
			WHERE RSA.idServicioAdicional = SA.idServicioAdicional 
			AND RSA.cdoReservacion = @cdoReservacion
		);
	END

	IF @opcion = 'D'
	BEGIN
		DELETE Reservacion_ServicioAdicional WHERE idReserv_Servicio = @idReserv_Servicio
	END
END

---------- GESTION HABITACIONES RESERVACIONES ----------
IF OBJECT_ID('SP_GestionHabitacionesReservaciones') IS NOT NULL
	DROP PROCEDURE SP_GestionHabitacionesReservaciones;
GO
CREATE PROCEDURE SP_GestionHabitacionesReservaciones
		@opcion			CHAR(3)			
	,@cdoReservacion	INT			 
	,@idHotel			INT 		
	,@idHabitacion		INT	
	,@idTipoHabitacion	INT	
	,@cantHabitaciones	INT			
	,@cantPersonas		INT			
	,@idReservHab		INT
	,@fechaAReservar	DATE
	,@fechaAReservar2	DATE
AS
BEGIN
	IF @opcion='I'
	BEGIN
		INSERT INTO Reservacion_Habitacion
		(
			cdoReservacion			
			,idHabitacion
			,cantPersonas
			,idEstado
		)
		VALUES
		(
			@cdoReservacion			
			,(SELECT 
				TOP 1 H.idHabitacion 
				FROM Habitacion H 
				LEFT JOIN Reservacion_Habitacion RH 
				ON RH.idHabitacion=H.idHabitacion
				LEFT JOIN Reservacion R
				ON RH.cdoReservacion=R.cdoReservacion
				WHERE
				H.idHotel = @idHotel 
				AND NOT EXISTS (
					SELECT 1
					FROM Reservacion_Habitacion RH
					INNER JOIN Reservacion R ON RH.cdoReservacion = R.cdoReservacion
					WHERE RH.idHabitacion = H.idHabitacion
						AND ((R.fechaLlegada <= @fechaAReservar2 AND R.fechaSalida >= @fechaAReservar) OR
							(R.fechaLlegada <= @fechaAReservar AND R.fechaSalida >= @fechaAReservar2))				
				)
				AND H.idTipoHabitacion=@idTipoHabitacion
			)
			,@cantPersonas
			,1
		)
	END

	IF @opcion = 'S'
	BEGIN
		SELECT 
			RH.idReserv_Hab			'ID'		
		,TH.nombre					'Tipo de habitación'
		,H.noHabitacion				'Número de habitación'
		,H.noPiso					'Número de piso'
		,RH.cantPersonas			'Cantidad de personas'
		,(TH.costoPersona*RH.cantPersonas) 'Monto'
		FROM Reservacion_Habitacion RH
		INNER JOIN Habitacion H
		ON RH.idHabitacion = H.idHabitacion
		INNER JOIN TipoHabitacion TH
		ON H.idTipohabitacion = TH.idTipoHabitacion
		WHERE cdoReservacion = @cdoReservacion
	END

	IF @opcion = 'D'
	BEGIN
		DELETE Reservacion_Habitacion WHERE idReserv_Hab = @idReservHab
	END
END

---------- GESTION RESERVACIONES ----------
IF OBJECT_ID('SP_GestionReservaciones') IS NOT NULL
	DROP PROCEDURE SP_GestionReservaciones;
GO
CREATE PROCEDURE SP_GestionReservaciones
	 @opcion			CHAR(3)			
	,@cdoReservacion	INT				
	,@cveCiudad			VARCHAR(5)		
	,@fechaLlegada		DATE			
	,@fechaSalida		DATE			
	,@idEstadoReserv	INT				
	,@montoAnticipo		MONEY			
	,@cdoCheckIn		UNIQUEIDENTIFIER
	,@fechaCheckIn		DATETIME
	,@cdoCheckOut		UNIQUEIDENTIFIER
	,@fechaCheckOut		DATETIME
	,@extEstancia		INT
	,@montoServ			MONEY
	,@montoPendiente	MONEY			
	,@montoSubtotal		MONEY			
	,@montoTotal		MONEY			
	,@idMetodoPago		INT				
	,@idCliente			INT				
	,@registradoPor		INT						
	,@idHotel			INT		
	,@fechaRegistro		DATETIME
	,@fechaOps			DATE	
	,@rowsAffected		INT OUTPUT
AS
BEGIN
	IF  @opcion = 'I'
	BEGIN
		INSERT INTO Reservacion (		
			 cveCiudad		
			,fechaLlegada	
			,fechaSalida	
			,idEstadoReserv
			,montoAnticipo	
			,cdoCheckIn	
			,fechaCheckIn	
			,cdoCheckOut	
			,fechaCheckOut	
			,extEstancia	
			,montoServ		
			,montoPendiente
			,montoSubtotal	
			,montoTotal	
			,idMetodoPago	
			,idCliente		
			,registradoPor	
			,fechaRegistro	
			,idHotel		
			,idEstado		
		) 
		VALUES (			
			 @cveCiudad		
			,@fechaLlegada	
			,@fechaSalida	
			,@idEstadoReserv
			,@montoAnticipo	
			,NULL
			,NULL	
			,NULL	
			,NULL	
			,0	
			,0		
			,0
			,0	
			,0	
			,1000	
			,@idCliente		
			,@registradoPor	
			,@fechaRegistro
			,@idHotel		
			,1							
		)
	END 

	IF @opcion = 'S'
	BEGIN
		SELECT 
			R.cdoReservacion 'ID',
			R.montoTotal 'Total'
		FROM Reservacion R
		WHERE R.cdoReservacion = @cdoReservacion
	END 

	IF @opcion = 'RES'
	BEGIN 
		SELECT 
			SA.nombre 'Nombre del servicio adicional',
			SA.costo 'Costo' 
		FROM Reservacion_ServicioAdicional RSA
		INNER JOIN ServicioAdicional SA
		ON RSA.idServicioAdicional=SA.idServicioAdicional
		WHERE cdoReservacion=@cdoReservacion
	END

	IF @opcion = 'MP'
	BEGIN 
		SELECT 
		(montoTotal-montoAnticipo) 'Monto pendiente'
		FROM Reservacion 
		WHERE cdoReservacion=@cdoReservacion
	END

	IF @opcion='PTC'
	BEGIN
		UPDATE Reservacion 
		SET montoPendiente=0,
		idMetodoPago=1003,
		idEstadoReserv=1003
		WHERE cdoReservacion=@cdoReservacion
	END

	IF @opcion='PTD'
	BEGIN
		UPDATE Reservacion 
		SET montoPendiente=0,
		idMetodoPago=1002,
		idEstadoReserv=1003
		WHERE cdoReservacion=@cdoReservacion
	END

	IF @opcion='PE'
	BEGIN
		UPDATE Reservacion 
		SET montoPendiente=0,
		idMetodoPago=1001,
		idEstadoReserv=1003
		WHERE cdoReservacion=@cdoReservacion
	END

	IF @opcion = 'UA'
	BEGIN
		UPDATE Reservacion 
		SET montoAnticipo = @montoAnticipo,
		idEstadoReserv=1000
		WHERE cdoReservacion = @cdoReservacion;
		UPDATE Reservacion 
		SET montoPendiente = montoTotal-montoAnticipo
		WHERE cdoReservacion = @cdoReservacion;
	END

	IF @opcion = 'CHI'
	BEGIN
		IF(SELECT cdoCheckIn FROM Reservacion WHERE cdoReservacion = @cdoReservacion) IS NULL
		BEGIN
			IF(@fechaOps = (SELECT fechaLlegada FROM Reservacion WHERE cdoReservacion = @cdoReservacion))
			BEGIN
				UPDATE Reservacion 
				SET 
				cdoCheckIn = NEWID(),
				fechaCheckIn = @fechaOps,
				idEstadoReserv=1004
				WHERE cdoReservacion = @cdoReservacion;
				SET @rowsAffected = @@ROWCOUNT;
			END
		END
	END

	IF @opcion = 'EXT'
	BEGIN
		UPDATE Reservacion 
		SET extEstancia= DATEDIFF(DAY,@fechaSalida,fechaSalida)
		WHERE cdoReservacion=@cdoReservacion;
		UPDATE Reservacion 
		SET fechaSalida=@fechaSalida
		WHERE cdoReservacion=@cdoReservacion;
	END

	IF @opcion = 'CHO'
	BEGIN
		IF(SELECT cdoCheckOut FROM Reservacion WHERE cdoReservacion = @cdoReservacion) IS NULL
		BEGIN
			IF(@fechaOps <= (SELECT fechaSalida FROM Reservacion WHERE cdoReservacion = @cdoReservacion))
			BEGIN
				UPDATE Reservacion 
				SET 
				cdoCheckOut = NEWID(),
				fechaCheckOut = @fechaOps
				WHERE cdoReservacion = @cdoReservacion;
				SET @rowsAffected = @@ROWCOUNT;
				INSERT INTO Factura(cdoReservacion)VALUES(@cdoReservacion);
			END
		END
	END
END

---------- GESTION CLIENTES ----------
IF OBJECT_ID('SP_GestionClientes') IS NOT NULL
	DROP PROCEDURE SP_GestionClientes;
GO
CREATE PROCEDURE SP_GestionClientes
	@opcion				CHAR(1)		,
	@idCliente			INT			,
	@nombre				VARCHAR(20)	,
	@apellidoPaterno	VARCHAR(20)	,
	@apellidoMaterno	VARCHAR(20)	,
	@calle				VARCHAR(20)	,
	@colonia			VARCHAR(20)	,
	@cveCiudad			VARCHAR(5) 	,
	@cvePais			VARCHAR(5) 	,
	@RFC				varchar(13)	,
	@correo				VARCHAR(40)	,
	@telefonoCasa		VARCHAR(8)	,
	@celular			VARCHAR(10)	,
	@idReferencia		INT		 	,
	@fechaNacimiento	DATE	  	,
	@idEstadoCivil		INT			,
	@idOperativo		INT			
AS
BEGIN
	IF @opcion = 'I'
	BEGIN 
		INSERT INTO Cliente(
			nombre			,
			apellidoPaterno	,
			apellidoMaterno	,
			calle			,
			colonia			,
			cveCiudad		,
			cvePais			,
			RFC				,
			correo			,
			telefonoCasa	,
			celular			,
			idReferencia	,
			fechaNacimiento	,
			idEstadoCivil	,
			registradoPor	,
			fechaRegistro	,
			idEstado
		)
		VALUES (
			@nombre			,
			@apellidoPaterno,
			@apellidoMaterno,
			@calle			,
			@colonia		,
			@cveCiudad		,
			@cvePais		,
			@RFC			,
			@correo			,
			@telefonoCasa	,
			@celular		,
			@idReferencia	,
			@fechaNacimiento,
			@idEstadoCivil	,
			@idOperativo	,
			GETDATE()		,
			1
		);
	END
	IF @opcion='S'
	BEGIN
		SELECT
			C.idCliente			'ID'					,
			C.nombre			'Nombre'				,
			C.apellidoPaterno	'Apellido paterno'		,
			C.apellidoMaterno	'Apellido materno'		,
			C.calle				'Calle'					,
			C.colonia			'Colonia'				,
			CD.nombre			'Ciudad'				,
			PA.nombre			'País'					,
			C.RFC				'RFC'					,
			C.correo			'Correo'				,
			C.telefonoCasa		'Teléfono de casa'		,
			C.celular			'Teléfono celular'		,
			R.nombre			'Referencia'			,
			C.fechaNacimiento	'Fecha de nacimiento'	,
			EC.nombre			'Estado civil'			,
			CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
			C.fechaRegistro		'Fecha de registro'
			FROM Cliente C
			INNER JOIN Ciudad CD
			ON C.cveCiudad=CD.cveCiudad
			INNER JOIN Pais PA
			ON C.cvePais = PA.cvePais
			INNER JOIN Referencia R
			ON C.idReferencia=R.idReferencia
			INNER JOIN EstadoCivil EC
			ON C.idEstadoCivil=EC.idEstadoCivil
			INNER JOIN Usuario U
			ON C.registradoPor = U.idUsuario
			INNER JOIN Persona P
			ON U.idPersona = P.idPersona
			WHERE C.idEstado=1;
	END

	IF @opcion = 'U'
	BEGIN 
		UPDATE Cliente SET 
			nombre				=	@nombre			,			 
			apellidoPaterno		= 	@apellidoPaterno,	
			apellidoMaterno		= 	@apellidoMaterno,	
			calle				= 	@calle			,
			colonia				= 	@colonia		,	
			cveCiudad			= 	@cveCiudad		,
			cvePais				= 	@cvePais		,	
			RFC					= 	@RFC			,	
			correo				= 	@correo			,
			telefonoCasa		= 	@telefonoCasa	,
			celular				= 	@celular		,	
			idReferencia		= 	@idReferencia	,
			fechaNacimiento		= 	@fechaNacimiento,	
			idEstadoCivil		= 	@idEstadoCivil	,
			registradoPor		= 	@idOperativo	,	
			fechaRegistro			= 	GETDATE()		
		WHERE idCliente	= @idCliente;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE Cliente SET idEstado = 0 
		WHERE idCliente = @idCliente;
	END
END

---------- GESTION SERVICIOS ADICIONALES AGREGADOS ----------
IF OBJECT_ID('SP_GestionServAdicionalesAdded') IS NOT NULL
	DROP PROCEDURE SP_GestionServAdicionalesAdded;
GO
CREATE PROCEDURE SP_GestionServAdicionalesAdded
	@idHotel_ServAdicionales INT,
	@idHotel INT,
	@idServAdicionales INT,
	@opcion CHAR(1),
	@rowsAffected INT OUTPUT
AS
BEGIN
SET NOCOUNT OFF;
	IF @opcion = 'I'
	BEGIN 
		IF NOT EXISTS (
			SELECT *
			FROM Hotel_ServicioAdicional
			WHERE idHotel = @idHotel
			AND idServicioAdicional = @idServAdicionales
			AND idEstado = 1
		)
		BEGIN
			INSERT INTO Hotel_ServicioAdicional(idHotel,idServicioAdicional, idEstado)
			VALUES (@idHotel,@idServAdicionales,1);
			SET @rowsAffected = @@ROWCOUNT;;
		END
	END

	IF @opcion='S'
	BEGIN
		SELECT HSA.idHotel_Servicio 'ID',nombre 'Nombre', costo 'Costo' FROM Hotel_ServicioAdicional HSA
			INNER JOIN ServicioAdicional SA
			ON HSA.idServicioAdicional=SA.idServicioAdicional
		WHERE idHotel = @idHotel AND HSA.idEstado = 1;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE Hotel_ServicioAdicional SET idEstado = 0 
		WHERE idHotel_Servicio = @idHotel_ServAdicionales;
	END
END

---------- GESTION SERVICIOS ADICIONALES ----------
IF OBJECT_ID('SP_GestionServAdicionales') IS NOT NULL
	DROP PROCEDURE SP_GestionServAdicionales;
GO
CREATE PROCEDURE SP_GestionServAdicionales
	@idServicioAdicional	INT,
	@nombre					VARCHAR(40) ,
	@descripcion			VARCHAR(144),
	@costo					MONEY,
	@idAdministrador		INT,
	@opcion					CHAR(1)
AS
BEGIN
	IF @opcion = 'I'
	BEGIN 
		INSERT INTO ServicioAdicional(nombre, descripcion, costo, registradoPor, fechaRegistro, idEstado)
		VALUES (@nombre,@descripcion,@costo,@idAdministrador,GETDATE(),1);
	END

	IF @opcion='S'
	BEGIN
		SELECT SA.idServicioAdicional 'ID', SA.nombre 'Nombre', SA.descripcion 'Descripcion', SA.costo 'Costo', P.nombre 'Registrado por', SA.fechaRegistro 'Fecha de registro' 
		FROM ServicioAdicional SA
		INNER JOIN Usuario U
		ON SA.registradoPor = U.idUsuario
		INNER JOIN Persona P
		ON U.idPersona = P.idPersona
		WHERE SA.idEstado=1;
	END

	IF @opcion = 'U'
	BEGIN 
		UPDATE ServicioAdicional SET 
			nombre				=	@nombre					,
			descripcion			=	@descripcion			,
			costo				=	@costo					,
			registradoPor		=	@idAdministrador		,
			fechaRegistro		=	GETDATE()				
		WHERE idServicioAdicional	=	@idServicioAdicional;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE ServicioAdicional SET idEstado = 0 
		WHERE idServicioAdicional = @idServicioAdicional;
	END
END

---------- GESTION CARACTERISTICAS DE HABITACION AGREGADAS ----------
IF OBJECT_ID('SP_GestionCaractHabAdded') IS NOT NULL
	DROP PROCEDURE SP_GestionCaractHabAdded;
GO
CREATE PROCEDURE SP_GestionCaractHabAdded
	@idHab_CaractHab INT,
	@idTipoHabitacion INT,
	@idCaracteristicaHabitacion INT,
	@opcion CHAR(1),
	@rowsAffected INT OUTPUT
AS
BEGIN
SET NOCOUNT OFF;
	IF @opcion = 'I'
	BEGIN 
		IF NOT EXISTS (
			SELECT *
			FROM TipoHabitacion_CaracteristicaHabitacion
			WHERE idTipoHabitacion = @idTipoHabitacion
			AND idCaractHab = @idCaracteristicaHabitacion
			AND idEstado = 1
		)
		BEGIN
			INSERT INTO TipoHabitacion_CaracteristicaHabitacion (idTipoHabitacion,idCaractHab, idEstado)
			VALUES (@idTipoHabitacion,@idCaracteristicaHabitacion,1);
			SET @rowsAffected = @@ROWCOUNT;;
		END
	END

	IF @opcion='S'
	BEGIN
		SELECT THCH.idTipoHab_CaractHab,nombre FROM TipoHabitacion_CaracteristicaHabitacion THCH
			INNER JOIN CaracteristicaHabitacion CH
			ON THCH.idCaractHab=CH.idCaractHab
		WHERE idTipoHabitacion = @idTipoHabitacion AND THCH.idEstado = 1;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE TipoHabitacion_CaracteristicaHabitacion SET idEstado = 0 
		WHERE idTipoHab_CaractHab = @idHab_CaractHab;
	END
END

---------- GESTION AMENIDADES DE HABITACION AGREGADAS ----------
IF OBJECT_ID('SP_GestionAmHabAdded') IS NOT NULL
	DROP PROCEDURE SP_GestionAmHabAdded;
GO
CREATE PROCEDURE SP_GestionAmHabAdded
	@idHab_AmHab INT,
	@idTipoHabitacion INT,
	@idAmenidadHabitacion INT,
	@opcion CHAR(1),
	@rowsAffected INT OUTPUT
AS
BEGIN
SET NOCOUNT OFF;
	IF @opcion = 'I'
	BEGIN 
		IF NOT EXISTS (
			SELECT *
			FROM TipoHabitacion_AmenidadHabitacion
			WHERE idTipoHabitacion = @idTipoHabitacion
			AND idAmenidadHab = @idAmenidadHabitacion
			AND idEstado = 1
		)
		BEGIN
			INSERT INTO TipoHabitacion_AmenidadHabitacion (idTipoHabitacion,idAmenidadHab, idEstado)
			VALUES (@idTipoHabitacion,@idAmenidadHabitacion,1);
			SET @rowsAffected = @@ROWCOUNT;;
		END
	END
	 
	IF @opcion='S'
	BEGIN
		SELECT THAH.idTipoHab_AmenHab,nombre FROM TipoHabitacion_AmenidadHabitacion THAH
			INNER JOIN AmenidadHabitacion AH
			ON THAH.idAmenidadHab=AH.idAmenidadHab
		WHERE idTipoHabitacion = @idTipoHabitacion AND THAH.idEstado = 1;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE TipoHabitacion_AmenidadHabitacion SET idEstado = 0 
		WHERE idTipoHab_AmenHab = @idHab_AmHab;
	END
END

---------- GESTION TIPOS DE HABITACION AGREGADAS ----------
IF OBJECT_ID('SP_GestionTiposHabAdded') IS NOT NULL
	DROP PROCEDURE SP_GestionTiposHabAdded;
GO
CREATE PROCEDURE SP_GestionTiposHabAdded
	@idHotel_TipoHab INT,
	@idHotel INT,
	@idTipoHabitacion INT,
	@cantHabs INT,
	@opcion CHAR(1),
	@rowsAffected INT OUTPUT,
	@fechaAReservar DATE,
	@fechaAReservar2 DATE
AS
BEGIN
SET NOCOUNT OFF;
	IF @opcion = 'I'
	BEGIN 
		IF NOT EXISTS (
			SELECT *
			FROM Hotel_TipoHabitacion
			WHERE idHotel = @idHotel
			AND idTipoHabitacion = @idTipoHabitacion
			AND idEstatus = 1
		)
		BEGIN
			INSERT INTO Hotel_TipoHabitacion(idHotel,idTipoHabitacion, cantHabitaciones, idEstatus)
			VALUES (@idHotel,@idTipoHabitacion, @cantHabs, 1);
			SET @rowsAffected = @@ROWCOUNT;
			UPDATE Hotel SET tiposHabitacion =
			(SELECT COUNT(DISTINCT idTipoHabitacion) AS cantidad_tipos_habitacion
			FROM Hotel_TipoHabitacion WHERE idHotel = @idHotel AND idEstatus=1)
			WHERE idHotel = @idHotel;
		END
	END

	IF @opcion='S'
	BEGIN
		SELECT HTH.idHotel_TipoHab,nombre, cantHabitaciones
		FROM Hotel_TipoHabitacion HTH
		INNER JOIN TipoHabitacion TH
		ON HTH.idTipoHabitacion=TH.idTipoHabitacion
		WHERE idHotel = @idHotel AND HTH.idEstatus = 1;
	END

	IF @opcion = 'R'
	BEGIN
		SELECT DISTINCT
		TH.idTipoHabitacion AS 'ID',
		TH.nombre AS 'Nombre',
		TH.cantCamas AS 'Cantidad de camas',
		TC.nombre AS 'Tipo de cama',
		TH.costoPersona AS 'Costo por persona', 
		TH.capacidadPersonas AS 'Capacidad de personas',
		NH.nombre AS 'Nivel de habitación',
		(
			SELECT COUNT(H2.idHabitacion)
			FROM Habitacion H2
			WHERE H2.idTipoHabitacion = H.idTipoHabitacion
				AND NOT EXISTS (
					SELECT 1
					FROM Reservacion_Habitacion RH
					INNER JOIN Reservacion R ON RH.cdoReservacion = R.cdoReservacion
					WHERE RH.idHabitacion = H2.idHabitacion
						AND (
							(R.fechaLlegada <= @fechaAReservar2 AND R.fechaSalida >= @fechaAReservar) OR
							(R.fechaLlegada <= @fechaAReservar AND R.fechaSalida >= @fechaAReservar2)
						)
				)
		) AS 'Habitaciones disponibles'
		FROM
		Habitacion H
		INNER JOIN TipoHabitacion TH ON H.idTipoHabitacion = TH.idTipoHabitacion
		INNER JOIN TipoCama TC ON TH.idTipoCama = TC.idTipoCama
		INNER JOIN NivelHabitacion NH ON TH.idNivelHabitacion = NH.idNivelHabitacion
		WHERE
		H.idHotel = @idHotel;
	END

	IF @opcion='C'
	BEGIN
		SELECT cantHabitaciones
		FROM Hotel_TipoHabitacion HTH
		WHERE idHotel_TipoHab = @idHotel_TipoHab AND HTH.idEstatus = 1;
	END

	IF @opcion = 'U'
	BEGIN
		UPDATE Hotel_TipoHabitacion SET cantHabitaciones = @cantHabs 
		WHERE idHotel_TipoHab = @idHotel_TipoHab;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE Hotel_TipoHabitacion SET idEstatus = 0 
		WHERE idHotel_TipoHab = @idHotel_TipoHab;
		UPDATE Hotel SET tiposHabitacion=
		(SELECT COUNT(DISTINCT idTipoHabitacion) AS cantidad_tipos_habitacion
		FROM Hotel_TipoHabitacion WHERE idHotel=@idHotel AND idEstatus=1)
		WHERE idHotel = @idHotel;
	END
END

----------GESTION HOTEL----------
IF OBJECT_ID('SP_GestionHotel') IS NOT NULL
	DROP PROCEDURE SP_GestionHotel;
GO
CREATE PROCEDURE SP_GestionHotel
	@idHotel			INT			,
	@nombre				VARCHAR(40)	,
	@calle				VARCHAR(20) ,
	@colonia			VARCHAR(20) ,
	@cveCiudad			VARCHAR(5) 	,
	@cvePais			VARCHAR(5) 	,
	@cantPisos			INT 		,
	@cantHabitaciones	INT			,
	@tiposHabitacion	INT 		,
	@zonaTuristica		INT 		,
	@fechaApertura		DATE		,
	@idUsuario			INT			,
	@opcion				CHAR(1)
AS
BEGIN 
	IF @opcion  = 'I'
	BEGIN
		INSERT INTO Hotel (	
			nombre			,	
			calle			,	
			colonia			,
			cveCiudad		,	
			cvePais			,
			cantPisos		,	
			cantHabitaciones,	
			tiposHabitacion	,
			zonaTuristica	,	
			fechaApertura	,	
			registradoPor	,
			idEstado)
		VALUES (
			@nombre			,	
			@calle			,	
			@colonia		,
			@cveCiudad		,	
			@cvePais		,
			@cantPisos		,	
			@cantHabitaciones,	
			@tiposHabitacion,
			@zonaTuristica	,	
			@fechaApertura	,	
			@idUsuario,
			1 
		);
	END

	IF @opcion = 'S'
	BEGIN
		SELECT
			H.idHotel 'ID',
			H.nombre 'Nombre',
			H.calle 'Calle',
			H.colonia 'Colonia',
			CD.nombre 'Ciudad',
			PA.nombre 'Pais',
			H.cantPisos 'Cantidad de pisos',
			H.cantHabitaciones 'Cantidad de habitaciones',
			H.tiposHabitacion 'Cantidad de tipos de habitacion',
			ZT.nombre 'Zona turistica',
			H.fechaApertura 'Fecha de apertura',
			CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
			H.fechaRegistro 'Fecha de registro'
			FROM Hotel H
			INNER JOIN Ciudad CD
			ON H.cveCiudad=CD.cveCiudad
			INNER JOIN Pais PA
			ON H.cvePais=PA.cvePais
			INNER JOIN ZonaTuristica ZT
			ON H.zonaTuristica=ZT.idZonaTuristica
			INNER JOIN Usuario U
			ON H.registradoPor = U.idUsuario
			INNER JOIN Persona P
			ON U.idPersona = P.idPersona
			WHERE H.idEstado = 1;
	END

	IF @opcion = 'U'
	BEGIN
		UPDATE Hotel SET
			nombre				= 	@nombre				,			
			calle				= 	@calle			   ,
			colonia				= 	@colonia			,
			cveCiudad			= 	@cveCiudad		   ,
			cvePais				= 	@cvePais			,
			cantPisos			= 	@cantPisos		   ,
			cantHabitaciones	= 	@cantHabitaciones  ,
			tiposHabitacion		= 	@tiposHabitacion	,
			zonaTuristica		= 	@zonaTuristica	   ,
			fechaApertura		= 	@fechaApertura	   ,
			registradoPor		= 	@idUsuario	,
			fechaRegistro		=	GETDATE()
		WHERE idHotel = @idHotel;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE Hotel SET idEstado = 0 WHERE idHotel = @idHotel;
	END
END

---------- GESTION HABITACION ----------
IF OBJECT_ID('SP_GestionHab') IS NOT NULL
	DROP PROCEDURE SP_GestionHab;
GO
CREATE PROCEDURE SP_GestionHab
	 @opcion					VARCHAR(3)
	,@idHabitacion				INT
	,@noHabitacion				INT	
	,@noPiso					INT
	,@idHotel					INT
	,@idTipoHabitacion			INT
	,@registradoPor				INT	
AS
BEGIN
	IF @opcion = 'I'
	BEGIN
		INSERT INTO Habitacion(
			 noHabitacion		
			,noPiso				
			,idHotel				
			,idTipoHabitacion	
			,idDisponibilidad	
			,registradoPor		
			,fechaRegistro		
			,idEstado			
		) VALUES (
			 @noHabitacion		
			,@noPiso				
			,@idHotel				
			,@idTipoHabitacion	
			,1
			,@registradoPor		
			,GETDATE()
			,1
		);
	END	

	IF @opcion = 'S'
	BEGIN 
		SELECT
		H.idHabitacion 'ID',
		TH.nombre 'Tipo de habitación',
		H.noHabitacion 'Número de habitación',
		H.noPiso 'Número de piso',
		CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
		H.fechaRegistro 'Fecha de registro',
		DH.nombre 'Disponibilidad'
		FROM Habitacion H
		INNER JOIN TipoHabitacion TH
		ON H.idTipoHabitacion = TH.idTipoHabitacion
		INNER JOIN Usuario U
		ON TH.registradoPor = U.idUsuario
		INNER JOIN Persona P
		ON U.idPersona = P.idPersona
		INNER JOIN DisponibilidadHabitacion DH
		ON H.idDisponibilidad = DH.idDisponibilidad
		WHERE H.idEstado = 1 AND H.idHotel = @idHotel
	END

	IF @opcion = 'U'
	BEGIN
		UPDATE Habitacion SET
			 noHabitacion		= 	@noHabitacion		
			,noPiso				= 	@noPiso			
			,idTipoHabitacion	= 	@idTipoHabitacion
		WHERE idHabitacion = @idHabitacion
	END

	IF @opcion = 'D'
	BEGIN
		DELETE Habitacion WHERE idHabitacion = @idHabitacion
	END
END

select * from Habitacion

---------- GESTION TIPO DE HABITACION ----------
IF OBJECT_ID('SP_GestionTipoHab') IS NOT NULL
	DROP PROCEDURE SP_GestionTipoHab;
GO
CREATE PROCEDURE SP_GestionTipoHab
	@idTipoHabitacion	INT,
	@nombre				VARCHAR(40),
	@cantCamas			INT, 
	@idTipoCama			INT, 
	@costoPersona		MONEY,
	@capacidadPersonas	INT,
	@idNivelHabitacion	INT,
	@idUsuario			INT, 
	@opcion				CHAR(1)
AS
BEGIN 
	IF @opcion = 'I'
	BEGIN
		INSERT INTO TipoHabitacion (	
			nombre,
			cantCamas,
			idTipoCama,
			costoPersona,
			capacidadPersonas,
			idNivelHabitacion,
			registradoPor,
			fechaRegistro,
			idEstado)
		VALUES (
			@nombre,
			@cantCamas,
			@idTipoCama,
			@costoPersona,
			@capacidadPersonas,
			@idNivelHabitacion,
			@idUsuario,
			GETDATE(),
			1);
	END

	IF @opcion = 'S'
	BEGIN
		SELECT
		TH.idTipoHabitacion 'ID',
		TH.nombre 'Nombre',
		TH.cantCamas 'Cantidad de camas',
		TC.nombre 'Tipo de cama',
		TH.costoPersona 'Costo por persona',
		TH.capacidadPersonas 'Capacidad de personas',
		NH.nombre 'Nivel de habitacion',
		CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
		TH.fechaRegistro 'Fecha de registro'
		FROM TipoHabitacion TH
		INNER JOIN TipoCama TC
		ON TH.idTipoCama=TC.idTipoCama
		INNER JOIN NivelHabitacion NH
		ON TH.idNivelHabitacion=NH.idNivelHabitacion
		INNER JOIN Usuario U
		ON TH.registradoPor = U.idUsuario
		INNER JOIN Persona P
		ON U.idPersona = P.idPersona
		WHERE TH.idEstado = 1;
	END

	IF @opcion = 'U'
	BEGIN
		UPDATE TipoHabitacion SET
			nombre				=	@nombre			  ,				
			cantCamas			=	@cantCamas		  ,
			idTipoCama			=	@idTipoCama		  ,
			costoPersona		=	@costoPersona	  ,
			capacidadPersonas	=	@capacidadPersonas,
			idNivelHabitacion	=	@idNivelHabitacion,
			registradoPor		=	@idUsuario		  ,	
			fechaRegistro		=	GETDATE()		
		WHERE idTipoHabitacion = @idTipoHabitacion;
	END

	IF @opcion = 'D'
	BEGIN
		UPDATE TipoHabitacion SET idEstado = 0 WHERE idTipoHabitacion = @idTipoHabitacion;
	END
END

---------- GESTION CARACTERISTICA DE HABITACION ---------
IF OBJECT_ID('SP_GestionCaracteristicasHab') IS NOT NULL
	DROP PROCEDURE SP_GestionCaracteristicasHab;
GO
CREATE PROCEDURE SP_GestionCaracteristicasHab
	@opcion					CHAR(1),	
	@idCaractdHab			INT,
	@nombre					VARCHAR(40),
	@descripcion			VARCHAR(144),
	@idAdministrador		INT
AS
BEGIN
	IF @opcion = 'I' 
	BEGIN
		INSERT INTO CaracteristicaHabitacion(
			nombre,
			descripcion,
			registradoPor,
			fechaRegistro,
			idEstado)
		VALUES (
			@nombre,				
			@descripcion,		
			@idAdministrador,
			GETDATE(),
			1);
	END	
	IF @opcion = 'S'
	BEGIN
		SELECT 
			CH.idCaractHab 'ID',
			CH.nombre 'Nombre',
			CH.descripcion 'Descripcion',
			CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
			CH.fechaRegistro 'Fecha de registro'
		FROM CaracteristicaHabitacion CH
		INNER JOIN Usuario U
		ON CH.registradoPor = U.idUsuario
		INNER JOIN Persona P
		ON U.idPersona = P.idPersona
		WHERE CH.idEstado = 1;
	END
	IF @opcion = 'U'
	BEGIN
		UPDATE CaracteristicaHabitacion SET
			nombre				= @nombre,
			descripcion			= @descripcion,
			registradoPor		= @idAdministrador,
			fechaRegistro			= GETDATE()
		WHERE idCaractHab = @idCaractdHab;
	END
	IF @opcion = 'D'
	BEGIN
		UPDATE CaracteristicaHabitacion SET idEstado = 0
		WHERE idCaractHab = @idCaractdHab;
	END
END

---------- GESTION AMENIDADES DE HABITACION ---------
IF OBJECT_ID('SP_GestionAmenidadesHab') IS NOT NULL
	DROP PROCEDURE SP_GestionAmenidadesHab;
GO
CREATE PROCEDURE SP_GestionAmenidadesHab
	@opcion				CHAR(1),	
	@idAmenidadHab		INT,
	@nombre				VARCHAR(40),
	@descripcion		VARCHAR(144),
	@idAdministrador	INT
AS
BEGIN
	IF @opcion = 'I' 
	BEGIN
		INSERT INTO AmenidadHabitacion (
			nombre,
			descripcion,
			registradoPor,
			fechaRegistro,
			idEstado)
		VALUES (
			@nombre,				
			@descripcion,		
			@idAdministrador,
			GETDATE(),
			1);
	END	
	IF @opcion = 'S'
	BEGIN
		SELECT 
			AH.idAmenidadHab 'ID',
			AH.nombre 'Nombre',
			AH.descripcion 'Descripcion',
			CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno) 'Registrado por',
			AH.fechaRegistro 'Fecha de registro'
		FROM AmenidadHabitacion AH
		INNER JOIN Usuario U
		ON AH.registradoPor = U.idUsuario
		INNER JOIN Persona P
		ON U.idPersona = P.idPersona
		WHERE AH.idEstado = 1;
	END
	IF @opcion = 'U'
	BEGIN
		UPDATE AmenidadHabitacion SET
			nombre				= @nombre,
			descripcion			= @descripcion,
			registradoPor		= @idAdministrador,
			fechaRegistro			= GETDATE()
		WHERE idAmenidadHab = @idAmenidadHab;
	END
	IF @opcion = 'D'
	BEGIN
		UPDATE AmenidadHabitacion SET 
			idEstado = 0
		WHERE idAmenidadHab = @idAmenidadHab;
	END
END

---------- LOGIN ----------
IF OBJECT_ID('SP_Login') IS NOT NULL
	DROP PROCEDURE SP_Login;
GO
CREATE PROCEDURE SP_Login 
	@correo					VARCHAR(40),
	@contrasena				VARCHAR(20),
	@opcion					CHAR(1)
AS
BEGIN 
	IF @opcion = 'A'
	BEGIN
		SELECT idUsuario
		FROM Usuario 
		WHERE 
		correo=@correo AND contrasena=@contrasena AND tipoUsuario = 1 AND idEstado = 1;
	END	
	IF @opcion = 'O'
	BEGIN
		SELECT idUsuario
		FROM Usuario 
		WHERE 
		correo=@correo AND contrasena=@contrasena AND tipoUsuario = 2 AND idEstado = 1;
	END	
END

---------- GESTION USUARIO ----------
IF OBJECT_ID('SP_GestionUsuario') IS NOT NULL
	DROP PROCEDURE SP_GestionUsuario;
GO
CREATE PROCEDURE SP_GestionUsuario 
	@opcion					CHAR(3),
	@correo					VARCHAR(40),
	@contrasena				VARCHAR(20),
	@nombre					VARCHAR(20),
	@apellidoPaterno 		VARCHAR(20),
	@apellidoMaterno 		VARCHAR(20),
	@noNomina				VARCHAR(6), 
	@fechaNacimiento		DATE,
	@calle					VARCHAR(20),
	@colonia				VARCHAR(20),
	@cveCiudad				VARCHAR(5),
	@cvePais				VARCHAR(5),
	@telefonoCasa			VARCHAR(8),
	@celular				VARCHAR(10),
	@idEstado				BIT,
	@idUsuario				INT,
	@registradoPor			INT,		
	@idPersonaRegistrada	INT,
	@tipoUsuario			TINYINT
AS
BEGIN
	IF @opcion = 'I'
	BEGIN
		INSERT INTO Persona(	
			 nombre			
			,apellidoPaterno 
			,apellidoMaterno 
			,fechaNacimiento	
			,calle			
			,colonia			
			,cveCiudad		
			,cvePais			
			,telefonoCasa	
			,celular			
			,idEstado		
		)VALUES (
			 @nombre			
			,@apellidoPaterno 
			,@apellidoMaterno 
			,@fechaNacimiento
			,@calle			
			,@colonia		
			,@cveCiudad		
			,@cvePais		
			,@telefonoCasa	
			,@celular		
			,1					
		);

		SET @idPersonaRegistrada = SCOPE_IDENTITY();
		INSERT INTO Usuario (
			correo			
			,contrasena		
			,noNomina		
			,tipoUsuario	
			,idPersona
			,registradoPor	
			,idEstado		
		) VALUES (
			 @correo			
			,@contrasena		
			,@noNomina		
			,@tipoUsuario	
			,@idPersonaRegistrada
			,@registradoPor	
			,1
		);
	END

	ELSE IF @opcion = 'S' 
	BEGIN
		SELECT * FROM VW_Usuarios
	END

	ELSE IF @opcion = 'U'
	BEGIN
		UPDATE Persona SET						
			nombre			=	@nombre,			
			apellidoPaterno	=	@apellidoPaterno,
			apellidoMaterno	=	@apellidoMaterno,
			fechaNacimiento	=	@fechaNacimiento,
			calle			=	@calle,			
			colonia			=	@colonia,		
			cveCiudad		=	@cveCiudad,		
			cvePais			=	@cvePais,		
			telefonoCasa	=	@telefonoCasa,	
			celular			=	@celular
		WHERE idPersona = (SELECT idPersona FROM Usuario WHERE idUsuario = @idUsuario);
		UPDATE Usuario SET 
			correo = @correo,
			contrasena = @contrasena,
			noNomina = @noNomina
		WHERE idUsuario = @idUsuario;
	END

	ELSE IF @opcion = 'IH'
	BEGIN
		UPDATE Usuario SET
			idEstado = 0
		WHERE idUsuario = @idUsuario
	END
	
	ELSE IF @opcion = 'H'
	BEGIN
		UPDATE Usuario SET
			idEstado = 1
		WHERE idUsuario = @idUsuario
	END

	ELSE IF @opcion = 'D' 
	BEGIN
		DELETE Persona WHERE idPersona = (SELECT idPersona FROM idUsuario WHERE idUsuario = @idUsuario);
		DELETE Usuario WHERE idUsuario = @idUsuario;
	END
END

exec SP_GestionUsuario
 'I',
 'carlos@hotmail.com',
 '123',
 'Carlos Adrian',
 'Ruiz',
 'Hernandez',
 '1903184',
 '080902',
 'Afluente #816',
 'Villa de las Puentes',
 'MTY',
 'MEX',
 '18726840',
 '8121129313',
 1,
 0,NULL,0,1

 delete persona

 Select * from Persona
 Select * from Usuario


---------- BUSQUEDAS ----------
---------- BUSQUEDA DE CLIENTES ----------
IF OBJECT_ID('SP_BusquedaClientes') IS NOT NULL
	DROP PROCEDURE SP_BusquedaClientes;
GO
CREATE PROCEDURE SP_BusquedaClientes
	@opcion			CHAR(1),
	@correo			VARCHAR(40),
	@apellidos		VARCHAR(40),
	@RFC			VARCHAR(13)
AS
BEGIN
	IF @opcion = 'C'
	BEGIN
		SELECT idCliente 'ID', correo 'Correo' 
		FROM Cliente
		WHERE correo LIKE CONCAT('%',@correo,'%');
	END
	IF @opcion = 'A'
	BEGIN
		SELECT idCliente 'ID', CONCAT(apellidoPaterno,' ',apellidoMaterno,' ',nombre) 'Nombre' 
		FROM Cliente
		WHERE CONCAT(apellidoPaterno,' ',apellidoMaterno) LIKE CONCAT('%',@apellidos,'%');
	END
	IF @opcion = 'R'
	BEGIN
		SELECT idCliente 'ID', RFC 'RFC' 
		FROM Cliente
		WHERE RFC LIKE CONCAT('%',@RFC,'%');
	END
END

---------- POBLAR COMBOBOXES/LISTBOXES ----------
---------- MOSTRAR HOTELES POR CIUDAD ----------
IF OBJECT_ID('SP_MostrarHotelesCiudad') IS NOT NULL
	DROP PROCEDURE SP_MostrarHotelesCiudad;
GO
CREATE PROCEDURE SP_MostrarHotelesCiudad
	@ciudad		VARCHAR(5)
AS
BEGIN
	SELECT idHotel 'ID', nombre FROM Hotel WHERE cveCiudad=@ciudad;
END
---------- MOSTRAR HOTELES ----------
IF OBJECT_ID('SP_MostrarHoteles') IS NOT NULL
	DROP PROCEDURE SP_MostrarHoteles;
GO
CREATE PROCEDURE SP_MostrarHoteles
AS
BEGIN
	SELECT idHotel 'ID', nombre FROM Hotel;
END
---------- MOSTRAR TIPOS DE CAMA ----------
IF OBJECT_ID('SP_MostrarTiposCama') IS NOT NULL
	DROP PROCEDURE SP_MostrarTiposCama;
GO
CREATE PROCEDURE SP_MostrarTiposCama
AS
BEGIN
	SELECT idTipoCama,nombre 'nombreTipoCama' FROM TipoCama;
END

IF OBJECT_ID('SP_GetHotelReserv') IS NOT NULL
	DROP PROCEDURE SP_GetHotelReserv;
GO
CREATE PROCEDURE SP_GetHotelReserv
	@cdoReservacion		INT
AS
BEGIN
	SELECT idHotel FROM Reservacion WHERE cdoReservacion=@cdoReservacion;
END

---------- MOSTRAR NIVELES DE HABITACION ----------
IF OBJECT_ID('SP_MostrarNivelesHab') IS NOT NULL
	DROP PROCEDURE SP_MostrarNivelesHab;
GO
CREATE PROCEDURE SP_MostrarNivelesHab
AS
BEGIN
	SELECT idNivelHabitacion,nombre 'nombreNivelHab' FROM NivelHabitacion;
END

---------- MOSTRAR PAISES ----------
IF OBJECT_ID('SP_MostrarPaises') IS NOT NULL
	DROP PROCEDURE SP_MostrarPaises;
GO
CREATE PROCEDURE SP_MostrarPaises
AS
BEGIN
	SELECT cvePais,nombre FROM Pais;
END

---------- MOSTRAR TIPOS HAB ----------
IF OBJECT_ID('SP_MostrarTiposHab') IS NOT NULL
	DROP PROCEDURE SP_MostrarTiposHab;
GO
CREATE PROCEDURE SP_MostrarTiposHab
AS
BEGIN
	SELECT idTipoHabitacion 'ID', nombre FROM TipoHabitacion;
END


---------- MOSTRAR CIUDADES ----------
IF OBJECT_ID('SP_MostrarCiudades') IS NOT NULL
	DROP PROCEDURE SP_MostrarCiudades;
GO
CREATE PROCEDURE SP_MostrarCiudades
AS
BEGIN
	SELECT cveCiudad,nombre FROM Ciudad;
END

---------- MOSTRAR ZONAS TURISTICAS ----------
IF OBJECT_ID('SP_MostrarZonasTuristicas') IS NOT NULL
	DROP PROCEDURE SP_MostrarZonasTuristicas;
GO
CREATE PROCEDURE SP_MostrarZonasTuristicas
AS
BEGIN
	SELECT idZonaTuristica,nombre FROM ZonaTuristica;
END

---------- MOSTRAR REFERENCIAS ----------
IF OBJECT_ID('SP_MostrarReferencias') IS NOT NULL
	DROP PROCEDURE SP_MostrarReferencias;
GO
CREATE PROCEDURE SP_MostrarReferencias
AS
BEGIN
	SELECT idReferencia 'ID',nombre FROM Referencia;
END
---------- MOSTRAR ESTADOS CIVILES ----------
IF OBJECT_ID('SP_MostrarEstadoCivil') IS NOT NULL
	DROP PROCEDURE SP_MostrarEstadoCivil;
GO
CREATE PROCEDURE SP_MostrarEstadoCivil
AS
BEGIN
	SELECT idEstadoCivil 'ID',nombre FROM EstadoCivil;
END

