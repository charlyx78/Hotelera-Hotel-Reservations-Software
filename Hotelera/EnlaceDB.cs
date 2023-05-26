/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;


/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace Hotelera
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["z"].ToString();
            // Cambiar Grupo01 por el que ustedes hayan definido en el App.Confif
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public int Autentificar(string us, string ps, string tu)
        {
            int idUsuario = 0;
            try
            {
                conectar();
                string qry = "SP_Login";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 20);
                parametro2.Value = ps;
                var parametro3 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro3.Value = tu;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    idUsuario = Convert.ToInt32(_tabla.Rows[0][0]);
                }
            }
            catch (SqlException e)
            {
                idUsuario = 0;
            }
            finally
            {
                desconectar();
            }

            return idUsuario;
        }
        public DataTable get_Users()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                // Ejemplo de cómo ejecutar un query, 
                // PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
                string qry = "Select Nombre, email, Fecha_modif from Usuarios where Activo = 0;";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
                _comandosql.CommandTimeout = 1200;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //POBLAR DATA GRID VIEWS
        public DataTable get_Clientes()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionClientes";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = "S";
                var parametro1 = _comandosql.Parameters.Add("@idCliente", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar, 20);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar, 20);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro5.Value = DBNull.Value;
                var parametro6 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro6.Value = DBNull.Value;
                var parametro7 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro7.Value = DBNull.Value;
                var parametro71 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro71.Value = DBNull.Value;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 13);
                parametro8.Value = DBNull.Value;
                var parametro9 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro9.Value = DBNull.Value;
                var parametro10 = _comandosql.Parameters.Add("@telefonoCasa", SqlDbType.VarChar, 8);
                parametro10.Value = DBNull.Value;
                var parametro11 = _comandosql.Parameters.Add("@celular", SqlDbType.VarChar, 10);
                parametro11.Value = DBNull.Value;
                var parametro12 = _comandosql.Parameters.Add("@idReferencia", SqlDbType.Int);
                parametro12.Value = DBNull.Value;
                var parametro13 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro13.Value = DBNull.Value;
                var parametro14 = _comandosql.Parameters.Add("@idEstadoCivil", SqlDbType.Int);
                parametro14.Value = DBNull.Value;
                var parametro15 = _comandosql.Parameters.Add("@idOperativo", SqlDbType.Int);
                parametro15.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_DatosFactura(int cdoReserv, string opc) { 
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GetDatosFactura";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cdoReserv;
                var parametro2 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 3);
                parametro2.Value = opc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_Hoteles()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionHotel";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = "S";
                var parametro1 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro5.Value = DBNull.Value;
                var parametro6 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro6.Value = DBNull.Value;
                var parametro7 = _comandosql.Parameters.Add("@cantPisos", SqlDbType.Int);
                parametro7.Value = DBNull.Value;
                var parametro8 = _comandosql.Parameters.Add("@cantHabitaciones", SqlDbType.Int);
                parametro8.Value = DBNull.Value;
                var parametro9 = _comandosql.Parameters.Add("@tiposHabitacion", SqlDbType.Int);
                parametro9.Value = DBNull.Value;
                var parametro10 = _comandosql.Parameters.Add("@zonaTuristica", SqlDbType.Int);
                parametro10.Value = DBNull.Value;
                var parametro11 = _comandosql.Parameters.Add("@fechaApertura", SqlDbType.Date);
                parametro11.Value = DBNull.Value;
                var parametro12 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro12.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_ServAdicionales()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionales";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = "S";
                var parametro1 = _comandosql.Parameters.Add("@idServicioAdicional", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@costo", SqlDbType.VarChar, 20);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_ServAdicionalesAdded(string opc, int idHotel)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionalesAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idHotel_ServAdicionales", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro2.Value = idHotel;
                var parametro3 = _comandosql.Parameters.Add("@idServAdicionales", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_Usuarios(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 20);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar, 20);
                parametro5.Value = DBNull.Value;
                var parametro6 = _comandosql.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar, 20);
                parametro6.Value = DBNull.Value;
                var parametro7 = _comandosql.Parameters.Add("@noNomina", SqlDbType.VarChar, 6);
                parametro7.Value = DBNull.Value;
                var parametro8 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro8.Value = DBNull.Value;
                var parametro9 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro9.Value = DBNull.Value;
                var parametro10 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro10.Value = DBNull.Value;
                var parametro11 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro11.Value = DBNull.Value;
                var parametro12 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro12.Value = DBNull.Value;
                var parametro13 = _comandosql.Parameters.Add("@telefonoCasa", SqlDbType.VarChar, 8);
                parametro13.Value = DBNull.Value;
                var parametro14 = _comandosql.Parameters.Add("@celular", SqlDbType.VarChar, 10);
                parametro14.Value = DBNull.Value;
                var parametro15 = _comandosql.Parameters.Add("@idEstado", SqlDbType.TinyInt);
                parametro15.Value = DBNull.Value;
                var parametro16 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro16.Value = DBNull.Value;
                var parametro17 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro17.Value = DBNull.Value;
                var parametro18 = _comandosql.Parameters.Add("@idPersonaRegistrada", SqlDbType.Int);
                parametro18.Value = DBNull.Value;
                var parametro19 = _comandosql.Parameters.Add("@tipoUsuario", SqlDbType.Int);
                parametro19.Value = DBNull.Value;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_HabitacionesReservaciones(string opc, int idReservHab, int cdoReserv, int idHotel, int idHab, int idTipoHab, int cantHabs, int cantPersonas)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionHabitacionesReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cdoReserv;
                var parametro12 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro12.Value = idHotel;
                var parametro13 = _comandosql.Parameters.Add("@idHabitacion", SqlDbType.Int);
                parametro13.Value = idHab;
                var parametro14 = _comandosql.Parameters.Add("@cantHabitaciones", SqlDbType.Int);
                parametro14.Value = cantHabs;
                var parametro15 = _comandosql.Parameters.Add("@cantPersonas", SqlDbType.Int);
                parametro15.Value = cantPersonas;
                var parametro16 = _comandosql.Parameters.Add("@idReservHab", SqlDbType.Int);
                parametro16.Value = idReservHab;
                var parametro17 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro17.Value = idReservHab;
                var parametro18 = _comandosql.Parameters.Add("@fechaAReservar", SqlDbType.Date);
                parametro18.Value = DBNull.Value;
                var parametro19 = _comandosql.Parameters.Add("@fechaAReservar2", SqlDbType.Date);
                parametro19.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable get_ServiciosReservaciones(string opc, int idReservServ, int cdoReserv, int idServAd, int idHotel)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionalesReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idReserv_Servicio", SqlDbType.Int);
                parametro1.Value = idReservServ;
                var parametro12 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro12.Value = cdoReserv;
                var parametro13 = _comandosql.Parameters.Add("@idServAdicional", SqlDbType.Int);
                parametro13.Value = idServAd;
                var parametro14 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro14.Value = idHotel;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable get_Hab(string opc, int idHotel)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@idHabitacion", SqlDbType.Int);
                parametro2.Value = 0;
                var parametro3 = _comandosql.Parameters.Add("@noHabitacion", SqlDbType.Int);
                parametro3.Value = 0;
                var parametro4 = _comandosql.Parameters.Add("@noPiso", SqlDbType.Int);
                parametro4.Value = 0;
                var parametro5 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro5.Value = idHotel;
                var parametro6 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro6.Value = 0;
                var parametro7 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro7.Value = 0;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_TiposHab(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionTipoHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@cantCamas", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@idTipoCama", SqlDbType.Int);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@costoPersona", SqlDbType.Money);
                parametro5.Value = DBNull.Value;
                var parametro6 = _comandosql.Parameters.Add("@capacidadPersonas", SqlDbType.Int);
                parametro6.Value = DBNull.Value;
                var parametro7 = _comandosql.Parameters.Add("@idNivelHabitacion", SqlDbType.Int);
                parametro7.Value = DBNull.Value;
                var parametro8 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro8.Value = DBNull.Value;
                var parametro9 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro9.Value = opc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_TiposHabAdded(string opcion, int idHotelTipoHab, int idHotel)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionTiposHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHotel_TipoHab", SqlDbType.Int);
                parametro1.Value = idHotelTipoHab;
                var parametro2 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro2.Value = idHotel;
                var parametro3 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@cantHabs", SqlDbType.Int);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro5.Value = opcion;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_AmHab()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionAmenidadesHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = "S";
                var parametro2 = _comandosql.Parameters.Add("@idAmenidadHab", SqlDbType.Int);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;

                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_AmHabAdded(int idHab)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionAmHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHab_AmHab", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro2.Value = idHab;
                var parametro3 = _comandosql.Parameters.Add("@idAmenidadHabitacion", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro4.Value = "S";
                var rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_CaractHab()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionCaracteristicasHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = "S";
                var parametro2 = _comandosql.Parameters.Add("@idCaractdHab", SqlDbType.Int);
                parametro2.Value = DBNull.Value;
                var parametro3 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = DBNull.Value;

                _adaptador.SelectCommand = _comandosql;

                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_CaractHabAdded(int idHab)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionCaractHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHab_CaractHab", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro2.Value = idHab;
                var parametro3 = _comandosql.Parameters.Add("@idCaracteristicaHabitacion", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro4.Value = "S";
                var rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_ReporteVentas(string opc, string cvePais, int año, string cveCd, int idHotel)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_ReporteVentas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro1.Value = cvePais;
                var parametro2 = _comandosql.Parameters.Add("@año", SqlDbType.Int);
                parametro2.Value = año;
                var parametro3 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro3.Value = cveCd;
                var parametro4 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro4.Value = idHotel;
                var parametro5 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 3);
                parametro5.Value = opc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_ReporteHistorialCliente(string opc, int idCliente, int año)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_ReporteHistorialCliente";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idCliente", SqlDbType.Int);
                parametro1.Value = idCliente;
                var parametro2 = _comandosql.Parameters.Add("@año", SqlDbType.Int);
                parametro2.Value = año;
                var parametro3 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 3);
                parametro3.Value = opc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }


        //POBLAR COMBOBOX/LSITBOX
        public DataTable get_BusqClientes(string opc, string correo, string apellidos, string rfc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_BusquedaClientes";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro2.Value = correo;
                var parametro3 = _comandosql.Parameters.Add("@apellidos", SqlDbType.VarChar, 40);
                parametro3.Value = apellidos;
                var parametro4 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 13);
                parametro4.Value = rfc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_BusqHoteles(string cd)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_MostrarHotelesCiudad";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@ciudad", SqlDbType.VarChar, 5);
                parametro1.Value = cd;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        public DataTable get_HotelReserv(int cr)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GetHotelReserv";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cr;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_BusqTiposHab(string opcion, int idHotel, string fechaAReservar, string fechaAReservar2)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionTiposHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHotel_TipoHab", SqlDbType.Int);
                parametro1.Value = DBNull.Value;
                var parametro2 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro2.Value = idHotel;
                var parametro3 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro3.Value = DBNull.Value;
                var parametro4 = _comandosql.Parameters.Add("@cantHabs", SqlDbType.Int);
                parametro4.Value = DBNull.Value;
                var parametro5 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro5.Value = opcion;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;
                var parametro6 = _comandosql.Parameters.Add("@fechaAReservar", SqlDbType.Date);
                parametro6.Value = fechaAReservar;
                var parametro7 = _comandosql.Parameters.Add("@fechaAReservar2", SqlDbType.Date);
                parametro7.Value = fechaAReservar2;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }
        public DataTable get_Combobox(string spName)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = spName;
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        //GESTION
        public DataTable Crear_Reservaciones(string opc, int cdoReserv, string cveCd, string fech1, string fech2, int estadoReserv, float anticipo, int metodoPago, int idCliente, int idOperativo, int idHotel, string fechaRegistro, string fechaOps)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_GestionReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cdoReserv;
                var parametro2 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.Char, 5);
                parametro2.Value = cveCd;
                var parametro5 = _comandosql.Parameters.Add("@fechaLlegada", SqlDbType.Date);
                parametro5.Value = fech1;
                var parametro6 = _comandosql.Parameters.Add("@fechaSalida", SqlDbType.Date);
                parametro6.Value = fech2;
                var parametro7 = _comandosql.Parameters.Add("@idEstadoReserv", SqlDbType.Int);
                parametro7.Value = estadoReserv;
                var parametro8 = _comandosql.Parameters.Add("@montoAnticipo", SqlDbType.Money);
                parametro8.Value = anticipo;
                var parametro9 = _comandosql.Parameters.Add("@cdoCheckIn", SqlDbType.UniqueIdentifier);
                parametro9.Value = DBNull.Value;
                var parametro10 = _comandosql.Parameters.Add("@fechaCheckIn", SqlDbType.Date);
                parametro10.Value = DBNull.Value;
                var parametro11 = _comandosql.Parameters.Add("@cdoCheckOut", SqlDbType.UniqueIdentifier);
                parametro11.Value = DBNull.Value;
                var parametro12 = _comandosql.Parameters.Add("@fechaCheckOut", SqlDbType.DateTime);
                parametro12.Value = DBNull.Value;
                var parametro13 = _comandosql.Parameters.Add("@extEstancia", SqlDbType.Int);
                parametro13.Value = DBNull.Value;
                var parametro14 = _comandosql.Parameters.Add("@montoServ", SqlDbType.Money);
                parametro14.Value = DBNull.Value;
                var parametro15 = _comandosql.Parameters.Add("@montoPendiente", SqlDbType.Money);
                parametro15.Value = DBNull.Value;
                var parametro16 = _comandosql.Parameters.Add("@montoSubtotal", SqlDbType.Money);
                parametro16.Value = 0;
                var parametro17 = _comandosql.Parameters.Add("@montoTotal", SqlDbType.Money);
                parametro17.Value = 0;
                var parametro18 = _comandosql.Parameters.Add("@idMetodoPago", SqlDbType.Int);
                parametro18.Value = metodoPago;
                var parametro19 = _comandosql.Parameters.Add("@idCliente", SqlDbType.Int);
                parametro19.Value = idCliente;
                var parametro20 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro20.Value = idOperativo;
                var parametro21 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro21.Value = idHotel;
                var parametro22 = _comandosql.Parameters.Add("@fechaRegistro", SqlDbType.DateTime);
                parametro22.Value = fechaRegistro;
                var parametro23 = _comandosql.Parameters.Add("@fechaOps", SqlDbType.Date);
                parametro23.Value = fechaOps;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public bool Gestion_Reservaciones(string opc, int cdoReserv, string cveCd, string fech1, string fech2, int estadoReserv, float anticipo, int metodoPago, int idCliente, int idOperativo, int idHotel, string fechaRegistro, string fechaOps)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cdoReserv;
                var parametro2 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.Char, 5);
                parametro2.Value = cveCd;
                var parametro5 = _comandosql.Parameters.Add("@fechaLlegada", SqlDbType.Date);
                parametro5.Value = fech1;
                var parametro6 = _comandosql.Parameters.Add("@fechaSalida", SqlDbType.Date);
                parametro6.Value = fech2;
                var parametro7 = _comandosql.Parameters.Add("@idEstadoReserv", SqlDbType.Int);
                parametro7.Value = estadoReserv;
                var parametro8 = _comandosql.Parameters.Add("@montoAnticipo", SqlDbType.Money);
                parametro8.Value = anticipo;
                var parametro9 = _comandosql.Parameters.Add("@cdoCheckIn", SqlDbType.UniqueIdentifier);
                parametro9.Value = DBNull.Value;
                var parametro10 = _comandosql.Parameters.Add("@fechaCheckIn", SqlDbType.Date);
                parametro10.Value = DBNull.Value;
                var parametro11 = _comandosql.Parameters.Add("@cdoCheckOut", SqlDbType.UniqueIdentifier);
                parametro11.Value = DBNull.Value;
                var parametro12 = _comandosql.Parameters.Add("@fechaCheckOut", SqlDbType.DateTime);
                parametro12.Value = DBNull.Value;
                var parametro13 = _comandosql.Parameters.Add("@extEstancia", SqlDbType.Int);
                parametro13.Value = DBNull.Value;
                var parametro14 = _comandosql.Parameters.Add("@montoServ", SqlDbType.Money);
                parametro14.Value = DBNull.Value;
                var parametro15 = _comandosql.Parameters.Add("@montoPendiente", SqlDbType.Money);
                parametro15.Value = DBNull.Value;
                var parametro16 = _comandosql.Parameters.Add("@montoSubtotal", SqlDbType.Money);
                parametro16.Value = 0;
                var parametro17 = _comandosql.Parameters.Add("@montoTotal", SqlDbType.Money);
                parametro17.Value = 0;
                var parametro18 = _comandosql.Parameters.Add("@idMetodoPago", SqlDbType.Int);
                parametro18.Value = metodoPago;
                var parametro19 = _comandosql.Parameters.Add("@idCliente", SqlDbType.Int);
                parametro19.Value = idCliente;
                var parametro20 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro20.Value = idOperativo;
                var parametro21 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro21.Value = idHotel;
                var parametro22 = _comandosql.Parameters.Add("@fechaRegistro", SqlDbType.DateTime);
                parametro22.Value = fechaRegistro;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;
                var parametro23 = _comandosql.Parameters.Add("@fechaOps", SqlDbType.Date);
                parametro23.Value = fechaOps;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

                if (opc == "CHI")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Ya se realizó el Check In de esta reservación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        add = false;
                    }
                }
                if (opc == "CHO")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Ya se realizó el Check Out de esta reservación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        add = false;
                    }
                }
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_ServAdicionalesReservaciones(string opc, int idReservServ, int cdoReserv, int idServAd, int idHotel)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionalesReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idReserv_Servicio", SqlDbType.Int);
                parametro1.Value = idReservServ;
                var parametro12 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro12.Value = cdoReserv;
                var parametro13 = _comandosql.Parameters.Add("@idServAdicional", SqlDbType.Int);
                parametro13.Value = idServAd;
                var parametro14 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro14.Value = idServAd;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
                if (opc == "I")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Este servicio adicional ya está agregado en la reservación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        add = false;
                    }
                }
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_HabitacionesReservaciones(string opc, int idReservHab, int cdoReserv, int idHotel, int idHab, int idTipoHab, int cantHabs, int cantPersonas, string f1, string f2)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionHabitacionesReservaciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@cdoReservacion", SqlDbType.Int);
                parametro1.Value = cdoReserv;
                var parametro12 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro12.Value = idHotel;
                var parametro13 = _comandosql.Parameters.Add("@idHabitacion", SqlDbType.Int);
                parametro13.Value = idHab;
                var parametro14 = _comandosql.Parameters.Add("@cantHabitaciones", SqlDbType.Int);
                parametro14.Value = cantHabs;
                var parametro15 = _comandosql.Parameters.Add("@cantPersonas", SqlDbType.Int);
                parametro15.Value = cantPersonas;
                var parametro16 = _comandosql.Parameters.Add("@idReservHab", SqlDbType.Int);
                parametro16.Value = idReservHab;
                var parametro17 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro17.Value = idTipoHab;
                var parametro18 = _comandosql.Parameters.Add("@fechaAReservar", SqlDbType.Date);
                parametro18.Value = f1;
                var parametro19 = _comandosql.Parameters.Add("@fechaAReservar2", SqlDbType.Date);
                parametro19.Value = f2;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_Cliente(string opc, int idCliente, string nombre, string apPat, string apMat, string calle, string col, string cveCd, string cvePais, string RFC, string correo, string tel, string cel, int idRef, string fechNac, int idEstadoCivil, int idOperativo)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionClientes";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idCliente", SqlDbType.Int);
                parametro1.Value = idCliente;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro2.Value = nombre;
                var parametro3 = _comandosql.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar, 20);
                parametro3.Value = apPat;
                var parametro4 = _comandosql.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar, 20);
                parametro4.Value = apMat;
                var parametro5 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro5.Value = calle;
                var parametro6 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro6.Value = col;
                var parametro7 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro7.Value = cveCd;
                var parametro71 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro71.Value = cvePais;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 13);
                parametro8.Value = RFC;
                var parametro9 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro9.Value = correo;
                var parametro10 = _comandosql.Parameters.Add("@telefonoCasa", SqlDbType.VarChar, 8);
                parametro10.Value = tel;
                var parametro11 = _comandosql.Parameters.Add("@celular", SqlDbType.VarChar, 10);
                parametro11.Value = cel;
                var parametro12 = _comandosql.Parameters.Add("@idReferencia", SqlDbType.Int);
                parametro12.Value = idRef;
                var parametro13 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro13.Value = fechNac;
                var parametro14 = _comandosql.Parameters.Add("@idEstadoCivil", SqlDbType.Int);
                parametro14.Value = idEstadoCivil;
                var parametro15 = _comandosql.Parameters.Add("@idOperativo", SqlDbType.Int);
                parametro15.Value = idOperativo;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_Hotel(string opc, int idHotel, string nombre, string calle, string col, string cveCd, string cvePais, int cantPisos, int cantHab, int cantTipHab, int zonaTuristica, string fechaAp, int idAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionHotel";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro1.Value = idHotel;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro2.Value = nombre;
                var parametro3 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro3.Value = calle;
                var parametro4 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro4.Value = col;
                var parametro5 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro5.Value = cveCd;
                var parametro6 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro6.Value = cvePais;
                var parametro7 = _comandosql.Parameters.Add("@cantPisos", SqlDbType.Int);
                parametro7.Value = cantPisos;
                var parametro8 = _comandosql.Parameters.Add("@cantHabitaciones", SqlDbType.Int);
                parametro8.Value = cantHab;
                var parametro9 = _comandosql.Parameters.Add("@tiposHabitacion", SqlDbType.Int);
                parametro9.Value = cantTipHab;
                var parametro10 = _comandosql.Parameters.Add("@zonaTuristica", SqlDbType.Int);
                parametro10.Value = zonaTuristica;
                var parametro11 = _comandosql.Parameters.Add("@fechaApertura", SqlDbType.Date);
                parametro11.Value = fechaAp;
                var parametro12 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro12.Value = idAdmin;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_ServAdicionales(string opc, int idServAdicional, string nombre, string desc, float costo, int idAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionales";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idServicioAdicional", SqlDbType.Int);
                parametro1.Value = idServAdicional;
                var parametro2 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro2.Value = nombre;
                var parametro3 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro3.Value = desc;
                var parametro4 = _comandosql.Parameters.Add("@costo", SqlDbType.VarChar, 20);
                parametro4.Value = costo;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = idAdmin;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_ServAdicionalesAdded(string opc, int idHotelServAdicional, int idHotel, int idServAdicional)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionServAdicionalesAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro0 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro0.Value = opc;
                var parametro1 = _comandosql.Parameters.Add("@idHotel_ServAdicionales", SqlDbType.Int);
                parametro1.Value = idHotelServAdicional;
                var parametro2 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro2.Value = idHotel;
                var parametro3 = _comandosql.Parameters.Add("@idServAdicionales", SqlDbType.Int);
                parametro3.Value = idServAdicional;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_Hab(string opc, int idHab, int noHab, int noPiso, int idHotel, int idTipoHab, int idDisp, int idUsuario)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@idHabitacion", SqlDbType.Int);
                parametro2.Value = idHab;
                var parametro3 = _comandosql.Parameters.Add("@noHabitacion", SqlDbType.Int);
                parametro3.Value = noHab;
                var parametro4 = _comandosql.Parameters.Add("@noPiso", SqlDbType.Int);
                parametro4.Value = noPiso;
                var parametro5 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro5.Value = idHotel;
                var parametro6 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro6.Value = idTipoHab;
                var parametro7 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro7.Value = idUsuario;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_TipoHab(string opc, int idTipoHab, string nombre, int cantCamas, int idTipoCama, float costoPersona, int capPersonas, int idNivelHab, int idAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionTipoHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro2.Value = idTipoHab;
                var parametro3 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro3.Value = nombre;
                var parametro4 = _comandosql.Parameters.Add("@cantCamas", SqlDbType.Int);
                parametro4.Value = cantCamas;
                var parametro5 = _comandosql.Parameters.Add("@idTipoCama", SqlDbType.Int);
                parametro5.Value = idTipoCama;
                var parametro6 = _comandosql.Parameters.Add("@costoPersona", SqlDbType.Money);
                parametro6.Value = costoPersona;
                var parametro7 = _comandosql.Parameters.Add("@capacidadPersonas", SqlDbType.Int);
                parametro7.Value = capPersonas;
                var parametro8 = _comandosql.Parameters.Add("@idNivelHabitacion", SqlDbType.Int);
                parametro8.Value = idNivelHab;
                var parametro9 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro9.Value = idAdmin;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_TipoHabAdded(int idHotel_TipoHab, int idHotel, int idTipoHab, int cantHabs, string opc)
        {
            var msg = "";
            var added = true;
            try
            {
                conectar();
                string qry = "SP_GestionTiposHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHotel_TipoHab", SqlDbType.Int);
                parametro1.Value = idHotel_TipoHab;
                var parametro2 = _comandosql.Parameters.Add("@idHotel", SqlDbType.Int);
                parametro2.Value = idHotel;
                var parametro3 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro3.Value = idTipoHab;
                var parametro4 = _comandosql.Parameters.Add("@cantHabs", SqlDbType.Int);
                parametro4.Value = cantHabs;
                var parametro5 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro5.Value = opc;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
                if (opc == "I")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Este tipo de habitación ya está agregado en el hotel", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        added = false;
                    }
                }
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return added;
        }
        public bool Gestion_AmenidadesHab(string opc, int idAmHabm, string nombre, string desc, int idAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionAmenidadesHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@idAmenidadHab", SqlDbType.Int);
                parametro2.Value = idAmHabm;
                var parametro3 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro3.Value = nombre;
                var parametro4 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro4.Value = desc;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = idAdmin;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_AmHabAdded(int idHab_AmHab, int idHab, int idAmHab, string opc)
        {
            var msg = "";
            var added = true;
            try
            {
                conectar();
                string qry = "SP_GestionAmHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHab_AmHab", SqlDbType.Int);
                parametro1.Value = idHab_AmHab;
                var parametro2 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro2.Value = idHab;
                var parametro3 = _comandosql.Parameters.Add("@idAmenidadHabitacion", SqlDbType.Int);
                parametro3.Value = idAmHab;
                var parametro4 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro4.Value = opc;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
                if (opc == "I")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Esta amenidad ya está agregada en la habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        added = false;
                    }
                }
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return added;
        }
        public bool Gestion_CaracteristicasHab(string opc, int idAmHabm, string nombre, string desc, int idAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionCaracteristicasHab";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@idCaractdHab", SqlDbType.Int);
                parametro2.Value = idAmHabm;
                var parametro3 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
                parametro3.Value = nombre;
                var parametro4 = _comandosql.Parameters.Add("@descripcion", SqlDbType.VarChar, 144);
                parametro4.Value = desc;
                var parametro5 = _comandosql.Parameters.Add("@idAdministrador", SqlDbType.Int);
                parametro5.Value = idAdmin;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Gestion_CaractHabAdded(int idHab_AmHab, int idHab, int idCaractHab, string opc)
        {
            var msg = "";
            var added = true;
            try
            {
                conectar();
                string qry = "SP_GestionCaractHabAdded";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idHab_CaractHab", SqlDbType.Int);
                parametro1.Value = idHab_AmHab;
                var parametro2 = _comandosql.Parameters.Add("@idTipoHabitacion", SqlDbType.Int);
                parametro2.Value = idHab;
                var parametro3 = _comandosql.Parameters.Add("@idCaracteristicaHabitacion", SqlDbType.Int);
                parametro3.Value = idCaractHab;
                var parametro4 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro4.Value = opc;
                SqlParameter rowsAffectedParam = _comandosql.Parameters.Add("@rowsAffected", SqlDbType.Int);
                rowsAffectedParam.Direction = ParameterDirection.Output;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
                if (opc == "I")
                {
                    if (Convert.IsDBNull(rowsAffectedParam.Value))
                    {
                        MessageBox.Show("Esta característica ya está agregada en la habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        added = false;
                    }
                }
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return added;
        }
        public bool Gestion_Usuario(string opc, int idUsuario, string correo, string contra, string nombre, string apPat, string apMat, string noNom, string fechNac, string calle, string col, string cd, string pais, string tel, string cel, int estatus, int registradoPor)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_GestionUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 40);
                parametro2.Value = correo;
                var parametro3 = _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 20);
                parametro3.Value = contra;
                var parametro4 = _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 20);
                parametro4.Value = nombre;
                var parametro5 = _comandosql.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar, 20);
                parametro5.Value = apPat;
                var parametro6 = _comandosql.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar, 20);
                parametro6.Value = apMat;
                var parametro7 = _comandosql.Parameters.Add("@noNomina", SqlDbType.VarChar, 6);
                parametro7.Value = noNom;
                var parametro8 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro8.Value = fechNac;
                var parametro9 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20);
                parametro9.Value = calle;
                var parametro10 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 20);
                parametro10.Value = col;
                var parametro11 = _comandosql.Parameters.Add("@cveCiudad", SqlDbType.VarChar, 5);
                parametro11.Value = cd;
                var parametro12 = _comandosql.Parameters.Add("@cvePais", SqlDbType.VarChar, 5);
                parametro12.Value = pais;
                var parametro13 = _comandosql.Parameters.Add("@telefonoCasa", SqlDbType.VarChar, 8);
                parametro13.Value = tel;
                var parametro14 = _comandosql.Parameters.Add("@celular", SqlDbType.VarChar, 10);
                parametro14.Value = cel;
                var parametro15 = _comandosql.Parameters.Add("@idEstado", SqlDbType.TinyInt);
                parametro15.Value = estatus;
                var parametro16 = _comandosql.Parameters.Add("@idUsuario", SqlDbType.Int);
                parametro16.Value = idUsuario;
                var parametro17 = _comandosql.Parameters.Add("@registradoPor", SqlDbType.Int);
                parametro17.Value = registradoPor;
                var parametro18 = _comandosql.Parameters.Add("@idPersonaRegistrada", SqlDbType.Int);
                parametro18.Value = DBNull.Value;
                var parametro19 = _comandosql.Parameters.Add("@tipoUsuario", SqlDbType.Int);
                parametro19.Value = 2;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public static System.Drawing.Font printFont;
        public static StreamReader streamToPrint;
        public class CreaTicket
        {
            public static StringBuilder line = new StringBuilder();
            string ticket = "";
            string parte1, parte2;

            public static int max = 45;
            int cort;
            private string[] cadenaserver;

            public byte[] Serverbyte { get; private set; }

            public static string LineasGuion()
            {
                string LineaGuion = "--------------------------------------------------";   // agrega lineas separadoras -

                return line.AppendLine(LineaGuion).ToString();
            }


            public static void EncabezadoVenta()
            {
                string LineEncavesado = "Articulo       Cant   Precio    Subtotal     Desc.";   // 40 caracteres agrega lineas de  encabezados
                line.AppendLine(LineEncavesado);
            }
            public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > 50)                                 // **********
                {
                    cort = max - 50;
                    parte1 = par1.Remove(50, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                line.AppendLine(ticket = parte1);

            }
            public void TextoDerecha(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = 45 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
                for (int i = 0; i < max; i++)
                {
                    ticket += " ";                          // agrega espacios para alinear a la derecha
                }
                line.AppendLine(ticket += parte1 + "\n");                //Agrega el texto

            }
            public void TextoCentro(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 50)                                 // **********
                {
                    cort = max - 50;
                    parte1 = par1.Remove(50, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(50 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********
                line.AppendLine(ticket += parte1 + "\n");

            }
            public void TextoExtremos(string par1, string par2)
            {
                max = par1.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega el primer parametro
                max = par2.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
                }
                else { parte2 = par2; }
                max = 40 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                 // **********
                {
                    ticket += " ";                            // Agrega espacios para poner par2 al final
                }                                             // **********
                line.AppendLine(ticket += parte2 + "\n");                   // agrega el segundo parametro al final

            }
            public void AgregaTotales(string par1, double total)
            {
                max = par1.Length;
                if (max > 25)                                 // **********
                {
                    cort = max - 25;
                    parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;
                parte2 = total.ToString() + "$";
                max = 50 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
                }                                            // **********
                line.AppendLine(ticket += parte2 + "\n");

            }

            // se le pasan los Aticulos  con sus detalles
            public void AgregaArticulo(string Articulo, double precio, double cant, double subtotal, int desc)
            {
                if (cant.ToString().Length <= 5 && precio.ToString("c").Length <= 15 && subtotal.ToString("c").Length <= 16 && desc.ToString().Length <= 8) // valida que cant precio y total esten dentro de rango
                {
                    string elementos = "", espacios = "";
                    bool bandera = false;
                    int nroEspacios = 0;

                    if (Articulo.Length > 45)                                 // **********
                    {
                        //cort = max - 16;
                        //parte1 = Articulo.Remove(16, cort);          // corta a 16 la descripcion del articulo
                        nroEspacios = (3 - cant.ToString().Length);
                        espacios = "";
                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = (10 - precio.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString() + "$";

                        //colocar el subtotal a la dercha
                        nroEspacios = (10 - subtotal.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString() + "$";

                        //colocar el descuento a la dercha
                        nroEspacios = (8 - desc.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + desc.ToString() + "%";

                        int CaracterActual = 0;// indica en que caracter se quedo
                        for (int Longtext = Articulo.Length; Longtext > 16; Longtext++)
                        {
                            if (bandera == false)
                            {
                                line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
                                bandera = true;
                            }
                            else
                            {
                                line.AppendLine(Articulo.Substring(CaracterActual, 16));

                            }
                            CaracterActual += 16;
                        }
                        line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


                    }
                    else
                    {
                        for (int i = 0; i < (16 - Articulo.Length); i++)
                        {
                            espacios += " ";

                        }
                        elementos = Articulo + espacios;

                        nroEspacios = (3 - cant.ToString().Length);
                        espacios = "";
                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = (10 - precio.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString() + "$";

                        //colocar el subtotal a la dercha
                        nroEspacios = (10 - subtotal.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString() + "$";

                        //colocar el descuento a la dercha
                        nroEspacios = (8 - desc.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + desc.ToString() + "%";

                        line.AppendLine(elementos);

                    }
                }
                else
                {
                    MessageBox.Show("Valores fuera de rango");

                }
            }

            public void ImprimirTiket(string Impresora)
            {
                File.WriteAllText("Factura.txt", line.ToString());


                line = new StringBuilder();

                try
                {
                    streamToPrint = new StreamReader
                       ("Factura.txt");
                    try
                    {
                        printFont = new System.Drawing.Font("Consolas", 10);
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler
                           (this.pd_PrintPage);
                        //  pd.PrinterSettings.PrinterName = "EPSON L3110 SERIES";// Nombre de la impresora
                        //pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";// Nombre de la impresora
                        pd.PrinterSettings.PrinterName = Impresora;// Nombre de la impresora

                        //pd.DefaultPageSettings.PaperSize = new PaperSize("", 10, 800);
                        pd.DocumentName = "Factura" + DateTime.Now.ToString();

                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Elija impresora valida");
                }


            }
            public void pd_PrintPage(object sender, PrintPageEventArgs ev)
            {
                float linesPerPage = 0;
                float yPos = 0;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;
                float topMargin = ev.MarginBounds.Top;
                string line = null;



                // Calculate the number of lines per page.
                linesPerPage = ev.MarginBounds.Height /
                   printFont.GetHeight(ev.Graphics);

                // Print each line of the file.
                while (count < linesPerPage &&
                   ((line = streamToPrint.ReadLine()) != null))
                {
                    yPos = topMargin + (count *
                       printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black,
                       leftMargin, yPos, new StringFormat());
                    count++;

                }

                // If more lines exist, print another page.
                if (line != null)
                    ev.HasMorePages = true;
                else
                    ev.HasMorePages = false;
            }
        }
    }
}
