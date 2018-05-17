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
    public class DAOOperacion
    {
        public List<Operaciones> listarOperaciones(out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from Operacion";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Operaciones> listaDeOperaciones= new List<Operaciones>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Operaciones op= new Operaciones();
                        op._Id_numero_operacion= int.Parse(miTabla.Rows[i]["numero_operacion"].ToString());
                        op._id_usuario = int.Parse(miTabla.Rows[i]["usuario"].ToString());
                        op._id_tipo_operacion = int.Parse(miTabla.Rows[i]["tipo_operacion"].ToString());                        
                        op._descripcion= miTabla.Rows[i]["descripcion"].ToString();                       
                        op._fechaOperacion = DateTime.Parse(miTabla.Rows[i]["fechaOperacion"].ToString());
                        listaDeOperaciones.Add(op);
                    }
                    return listaDeOperaciones;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public Operaciones datosOperacion(Operaciones operacion, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from operacion where tipo_operacion='" + operacion._id_tipo_operacion + "';";
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
                    Operaciones op = new Operaciones();
                    op._Id_numero_operacion = int.Parse(miTabla.Rows[0]["numero_operacion"].ToString());
                    op._id_usuario = int.Parse(miTabla.Rows[0]["usuario"].ToString());
                    op._id_tipo_operacion = int.Parse(miTabla.Rows[0]["tipo_operacion"].ToString());                    
                    op._descripcion = miTabla.Rows[0]["descripcion"].ToString();
                    
                    op._fechaOperacion = DateTime.Parse(miTabla.Rows[0]["fechaOperacion"].ToString());

                    return op;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ultimaOperacion( out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select MAX (numero_operacion)as num from operacion";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return 0;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    Operaciones op = new Operaciones();
                    op._Id_numero_operacion = int.Parse(miTabla.Rows[0]["num"].ToString());    
                    return op._Id_numero_operacion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool insertaOperacionEnBD(Operaciones operacion, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.Int;
                parametro.ParameterName = "@usuario";
                parametro.Value = operacion._id_usuario;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@tipo_operacion";
                parametro2.Value = operacion._id_tipo_operacion;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = operacion._descripcion;

                listaParametros[2] = parametro3;

                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "Nueva_Operacion", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
