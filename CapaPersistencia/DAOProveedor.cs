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
    public class DAOProveedor
    {
        public List<Proveedor> listarTodosProveedores(out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from proveedor";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Proveedor> listaDeProveedores = new List<Proveedor>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Proveedor N_proveedor = new Proveedor();
                        N_proveedor._nombreProveedor = miTabla.Rows[i]["nombre_proveedor"].ToString();
                        N_proveedor._telefonoContacto = int.Parse(miTabla.Rows[i]["telefono_contacto"].ToString());
                        N_proveedor._correoContacto = miTabla.Rows[i]["correo_contacto"].ToString();
                       
                        listaDeProveedores.Add(N_proveedor);
                    }
                    return listaDeProveedores;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public Proveedor datosProv(Proveedor proveedor, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from proveedor where nombre_proveedor='" + proveedor._nombreProveedor + "';";
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
                   Proveedor ProvAutenticado = new Proveedor();
                    ProvAutenticado._nombreProveedor = miTabla.Rows[0]["nombre_proveedor"].ToString();
                    ProvAutenticado._telefonoContacto = int.Parse(miTabla.Rows[0]["telefono_contacto"].ToString());
                    ProvAutenticado._correoContacto = miTabla.Rows[0]["correo_contacto"].ToString();                    
                    ProvAutenticado._estado = bool.Parse(miTabla.Rows[0]["estado"].ToString());

                    return ProvAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool actualizaProv(Proveedor proveedor, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                int intExito = 0;
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter("actualizaProveedores", conexion.getConexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlAdaptador.SelectCommand.Parameters.Add("@nombre_proveedor", SqlDbType.VarChar).Value = proveedor._nombreProveedor;
                sqlAdaptador.SelectCommand.Parameters.Add("@telefono_contacto", SqlDbType.Int).Value = proveedor._telefonoContacto;
                sqlAdaptador.SelectCommand.Parameters.Add("@correo_contacto", SqlDbType.VarChar).Value = proveedor._correoContacto;
                sqlAdaptador.SelectCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = proveedor._estado;

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
        public bool insertaPROVEnBD(Proveedor Proveedor, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros1 = new SqlParameter[4];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.VarChar;
                parametro.ParameterName = "@nombre_proveedor";
                parametro.Value = Proveedor._nombreProveedor;

                listaParametros1[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@telefono_contacto";
                parametro2.Value = Proveedor._telefonoContacto;

                listaParametros1[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@correo_contacto";
                parametro3.Value = Proveedor._correoContacto;

                listaParametros1[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.Bit;
                parametro4.ParameterName = "@estado";
                parametro4.Value = Proveedor._estado;

                listaParametros1[3] = parametro4;


                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros1, "Nuevo_Proveedor", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
