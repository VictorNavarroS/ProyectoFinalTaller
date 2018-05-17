using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaPersistencia
{
    public class DAOCargo
    {
        public List<Cargo> listarTodosCargos(out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from cargo";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Cargo> listaDecargos = new List<Cargo>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Cargo NombreCargo = new Cargo();
                        NombreCargo._id = int.Parse(miTabla.Rows[i]["id_cargo"].ToString());
                        NombreCargo._nombre_cargo = miTabla.Rows[i]["nombre_cargo"].ToString();
                        NombreCargo._permisos = int.Parse(miTabla.Rows[i]["permisos"].ToString());
                        listaDecargos.Add(NombreCargo);
                    }
                    return listaDecargos;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public Cargo datosCargo(Cargo cargo, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from cargo where nombre_cargo='" + cargo._nombre_cargo + "';";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Cargo cargoAutenticado = new Cargo();
                    cargoAutenticado._id = int.Parse(miTabla.Rows[0]["id_cargo"].ToString());
                    cargoAutenticado._nombre_cargo = miTabla.Rows[0]["nombre_cargo"].ToString();
                    cargoAutenticado._permisos = int.Parse(miTabla.Rows[0]["permisos"].ToString());
                    cargoAutenticado._estado = bool.Parse(miTabla.Rows[0]["estado"].ToString());

                    return cargoAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string nombreCargo(int cargo, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select nombre_cargo from cargo where id_cargo=" + cargo + ";";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Cargo cargo2 = new Cargo();
                    cargo2._nombre_cargo = miTabla.Rows[0]["nombre_cargo"].ToString();
                    return cargo2._nombre_cargo;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool actualizaCargo(Cargo cargo, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                int intExito = 0;
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter("actualizaCargo", conexion.getConexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlAdaptador.SelectCommand.Parameters.Add("@nombre_cargo", SqlDbType.VarChar).Value = cargo._nombre_cargo;
                sqlAdaptador.SelectCommand.Parameters.Add("@Permisos", SqlDbType.VarChar).Value = cargo._permisos;
                sqlAdaptador.SelectCommand.Parameters.Add("@estado", SqlDbType.VarChar).Value = cargo._estado;

                conexion.getConexion.Open();
                intExito = sqlAdaptador.SelectCommand.ExecuteNonQuery();
                conexion.getConexion.Close();

                if (intExito > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool insertaCargoEnBD(Cargo cargo, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.VarChar;
                parametro.ParameterName = "@nombre_cargo";
                parametro.Value = cargo._nombre_cargo;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@Permisos";
                parametro2.Value = cargo._permisos;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.Bit;
                parametro3.ParameterName = "@estado";
                parametro3.Value = cargo._estado;

                listaParametros[2] = parametro3;


                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "Nuevo_cargo", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
    }
