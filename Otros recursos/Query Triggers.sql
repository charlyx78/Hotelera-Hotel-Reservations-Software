IF OBJECT_ID('TR_IdReservacion') IS NOT NULL
	DROP TRIGGER TR_IdReservacion;
GO
create trigger TR_IdReservacion on Reservacion
after insert
as 
begin
	select i.cdoReservacion from Reservacion r
	join inserted i
	on i.cdoReservacion=r.cdoReservacion;
end

IF OBJECT_ID('TR_IdTipoHab') IS NOT NULL
	DROP TRIGGER TR_IdTipoHab;
GO
create trigger TR_IdTipoHab on TipoHabitacion
after insert
as 
begin
	select i.idTipoHabitacion from TipoHabitacion th
	join inserted i
	on i.idTipoHabitacion=th.idTipoHabitacion;
end


IF OBJECT_ID('TR_ActualizarCostoReservacionHabitacion') IS NOT NULL
	DROP TRIGGER TR_ActualizarCostoReservacionHabitacion;
GO
CREATE TRIGGER TR_ActualizarCostoReservacionHabitacion ON Reservacion_Habitacion
AFTER INSERT 
AS
	UPDATE Reservacion 
	SET montoTotal += ((I.cantPersonas * TH.costoPersona) * (DATEDIFF(DAY,R.fechaLlegada,R.fechaSalida)))
	FROM Reservacion R
	INNER JOIN inserted I
	ON R.cdoReservacion = I.cdoReservacion
	INNER JOIN Habitacion H
	ON I.idHabitacion = H.idHabitacion
	INNER JOIN TipoHabitacion TH
	ON H.idTipoHabitacion = TH.idTipoHabitacion
	WHERE R.cdoReservacion = I.cdoReservacion


IF OBJECT_ID('TR_ActualizarCostoReservacionHabitacionDelete') IS NOT NULL
DROP TRIGGER TR_ActualizarCostoReservacionHabitacionDelete;
GO
CREATE TRIGGER TR_ActualizarCostoReservacionHabitacionDelete ON Reservacion_Habitacion
AFTER DELETE 
AS
	UPDATE Reservacion 
	SET montoTotal -= ((d.cantPersonas * TH.costoPersona) * (DATEDIFF(DAY,R.fechaLlegada,R.fechaSalida)))
	FROM Reservacion R
	INNER JOIN deleted d
	ON R.cdoReservacion = d.cdoReservacion
	INNER JOIN Habitacion H
	ON d.idHabitacion = H.idHabitacion
	INNER JOIN TipoHabitacion TH
	ON H.idTipoHabitacion = TH.idTipoHabitacion
	WHERE R.cdoReservacion = d.cdoReservacion


IF OBJECT_ID('TR_ActualizarCostoReservacionServicio') IS NOT NULL
	DROP TRIGGER TR_ActualizarCostoReservacionServicio;
GO
CREATE TRIGGER TR_ActualizarCostoReservacionServicio ON Reservacion_ServicioAdicional
AFTER INSERT 
AS
	UPDATE Reservacion 
	SET montoServ += (SA.costo)
	FROM Reservacion R
	INNER JOIN inserted I
	ON R.cdoReservacion = I.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON I.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = I.cdoReservacion;

	UPDATE Reservacion
	SET montoTotal += (SA.costo)
	FROM Reservacion R
	INNER JOIN inserted I
	ON R.cdoReservacion = I.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON I.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = I.cdoReservacion;

	UPDATE Reservacion
	SET montoPendiente = montoTotal-montoAnticipo
	FROM Reservacion R
	INNER JOIN inserted I
	ON R.cdoReservacion = I.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON I.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = I.cdoReservacion;

IF OBJECT_ID('TR_ActualizarCostoReservacionServicioDelete') IS NOT NULL
DROP TRIGGER TR_ActualizarCostoReservacionServicioDelete;
GO
CREATE TRIGGER TR_ActualizarCostoReservacionServicioDelete ON Reservacion_ServicioAdicional
AFTER DELETE 
AS
	UPDATE Reservacion
	SET montoTotal -= (SA.costo)
	FROM Reservacion R
	INNER JOIN deleted D
	ON R.cdoReservacion = D.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON D.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = D.cdoReservacion;

	UPDATE Reservacion 
	SET montoServ -= (SA.costo)
	FROM Reservacion R
	INNER JOIN deleted D
	ON R.cdoReservacion = D.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON D.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = D.cdoReservacion;
	
	UPDATE Reservacion 
	SET montoPendiente = montoTotal-montoAnticipo
	FROM Reservacion R
	INNER JOIN deleted D
	ON R.cdoReservacion = D.cdoReservacion
	INNER JOIN ServicioAdicional SA
	ON D.idServicioAdicional = SA.idServicioAdicional
	WHERE R.cdoReservacion = D.cdoReservacion;



--IF OBJECT_ID('TR_ActualizarCantHabitaciones') IS NOT NULL
--DROP TRIGGER TR_ActualizarCantHabitaciones;
--GO
--CREATE TRIGGER TR_ActualizarCantHabitaciones ON Habitacion
--AFTER INSERT, DELETE 
--AS
--	UPDATE Hotel
--    SET 
--	cantHabitaciones = (SELECT COUNT(idHabitacion) FROM Habitacion WHERE idHotel = I.idHotel),
--	tiposHabitacion = (SELECT COUNT(DISTINCT(idTipoHabitacion)) FROM Habitacion WHERE idHotel = I.idHotel)
--    FROM Hotel H
--    INNER JOIN (SELECT idHotel FROM inserted UNION SELECT idHotel FROM deleted) I 
--    ON H.idHotel = I.idHotel
--    WHERE H.idHotel = I.idHotel

--IF OBJECT_ID('TR_ActualizarDispHabitaciones') IS NOT NULL
--DROP TRIGGER TR_ActualizarDispHabitaciones;
--GO
--CREATE TRIGGER TR_ActualizarDispHabitaciones ON Reservacion
--AFTER UPDATE
--AS
--	IF (SELECT TOP 1 cdoCheckIn FROM inserted) IS NOT NULL
--	BEGIN
--		UPDATE Habitacion
--		SET
--		idDisponibilidad = 0 
--		FROM Habitacion H
--		INNER JOIN Reservacion_Habitacion RH
--		ON RH.idHabitacion = H.idHabitacion
--		INNER JOIN inserted I 
--		ON RH.cdoReservacion = I.cdoReservacion
--		WHERE H.idHabitacion = RH.idHabitacion
--	END


	
--IF OBJECT_ID('TR_ActualizarDispHabitacionesD') IS NOT NULL
--DROP TRIGGER TR_ActualizarDispHabitacionesD;
--GO
--CREATE TRIGGER TR_ActualizarDispHabitacionesD ON Reservacion
--AFTER UPDATE
--AS
--	IF(SELECT TOP 1 cdoCheckOut FROM inserted) IS NOT NULL
--	BEGIN		
--		UPDATE Habitacion
--		SET
--		idDisponibilidad = 1
--		FROM Habitacion H
--		INNER JOIN Reservacion_Habitacion RH
--		ON RH.idHabitacion = H.idHabitacion
--		INNER JOIN inserted I 
--		ON RH.cdoReservacion = I.cdoReservacion
--		WHERE H.idHabitacion = RH.idHabitacion
--	END
